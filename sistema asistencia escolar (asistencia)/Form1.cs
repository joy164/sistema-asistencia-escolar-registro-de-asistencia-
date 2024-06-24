using sistema_asistencia_escolar__asistencia_.includes.entidades;
using sistema_asistencia_escolar__asistencia_.includes.utils;
using sistema_asistencia_escolar__asistencia_.Properties;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using System;

using Timer = System.Windows.Forms.Timer;

namespace sistema_asistencia_escolar__asistencia_
{
    public partial class Form1 : Form
    {
        private readonly TimeSpan horaToleranciaEntrada = Settings.Default.horaEntrada.AddMinutes(Settings.Default.tolerancia).TimeOfDay;

        private readonly int tiempoMax = Settings.Default.msgEsperaDelay;

        private bool limpiar_campos = false;
        private Timer timer;

        private int IDInfante = 0, IDTutor = 0;
        public Form1()
        {
            InitializeComponent();
            SetTimer();
        }

        private void OnTimeEvent(object source, EventArgs e)
        {
            pb_icono.Image = Resources.codigo_qr;
            pn_mensaje.BackColor = Color.DarkSlateGray;
            lb_mensaje.Text = "Presente tarjeta en el escaner";
            tb_entrada.Enabled = true;

            if (limpiar_campos)
            {
                pb_infante.Image = null;
                pb_tutor.Image = null;

                lb_nomTutor.Text = "Parentesco";
                lb_nomInfante.Text = "Nombre de infante";
                lb_nomTutor.Text = "Nombre de tutor";
                lb_nomInfante.Text = "Grupo";

                limpiar_campos = false;
            }

            timer.Stop();
            timer.Enabled = false;
            tb_entrada.Focus();
        }

        public void SetTimer()
        {
            timer = new Timer
            {
                Interval = tiempoMax,
                Enabled = false
            };
            timer.Tick += new EventHandler(OnTimeEvent);
        }

        private void tb_busqueda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;

            string noCredencial = tb_entrada.Text;

            tb_entrada.Text = string.Empty;
            tb_entrada.Enabled = false;

            //valido si la credencial tiene un formato valido
            if (!DividirCadena(noCredencial))
            {
                lb_mensaje.Text = "Formato de credencial invalido";
                pb_icono.Image = Resources.pregunta;
                pn_mensaje.BackColor = Color.DarkOrange;

                timer.Enabled = true;
                timer.Start();
                ActiveControl = tb_entrada;
                return;
            }

            try
            {

                DataTable permisosInfanteTutor = InfanteTutor.GetInfanteTutor(IDTutor, IDInfante);

                TimeSpan vigencia = DateTime.Parse((string)permisosInfanteTutor.Rows[0]["vigencia"]).TimeOfDay;

                //verifica si la credencial es valida
                if (TimeSpan.Compare(vigencia, DateTime.Today.TimeOfDay) == 1)
                {
                    lb_mensaje.Text = "Credencial vencida";
                    pb_icono.Image = Resources.cruz;
                    pn_mensaje.BackColor = Color.DarkRed;

                    timer.Enabled = true;
                    timer.Start();
                    ActiveControl = tb_entrada;
                    return;
                }

                //valido si hay autorizacion para entregar o recoger infante
                if (permisosInfanteTutor == null)
                {
                    lb_mensaje.Text = "Tutor no autorizado";
                    pb_icono.Image = Resources.cruz;
                    pn_mensaje.BackColor = Color.DarkRed;

                    timer.Enabled = true;
                    timer.Start();
                    ActiveControl = tb_entrada;
                    return;
                }

                Nombre nomInfante = new Nombre((string)permisosInfanteTutor.Rows[0]["NOM_INFANTE"], (string)permisosInfanteTutor.Rows[0]["AP_INFANTE"], (string)permisosInfanteTutor.Rows[0]["AM_INFANTE"]);
                Nombre nomTutor = new Nombre((string)permisosInfanteTutor.Rows[0]["NOM_TUTOR"], (string)permisosInfanteTutor.Rows[0]["AP_TUTOR"], (string)permisosInfanteTutor.Rows[0]["AM_TUTOR"]);

                string salon = (string)permisosInfanteTutor.Rows[0]["GRADO_GRUPO_SALON"];
                string parentesco = (string)permisosInfanteTutor.Rows[0]["PARENTESCO_TUTOR"];

                Image fotoInfante = Imagenes.ByteArrayToImagen((byte[])permisosInfanteTutor.Rows[0]["IMG_INFANTE"]);
                Image fotoTutor = Imagenes.ByteArrayToImagen((byte[])permisosInfanteTutor.Rows[0]["IMG_TUTOR"]);

                //reviso si es hora de entrada
                TimeSpan horaActual = DateTime.Now.TimeOfDay;

                //hora de entrada
                if (TimeSpan.Compare(horaActual, horaToleranciaEntrada) <= 0)
                {
                    Asistencia.NewAsistenica((int)Asistencia.Tipo.entrada, IDInfante, IDTutor, DateTime.Today, horaActual, "Sin observaciones");

                    pb_infante.Image = fotoInfante;
                    pb_tutor.Image = fotoTutor;

                    lb_grupo.Text = salon;
                    lb_parentesco.Text = parentesco;

                    lb_nomInfante.Text = nomInfante.ToString();
                    lb_nomTutor.Text = nomTutor.ToString();

                    lb_mensaje.Text = "Entrada registrada";
                    pb_icono.Image = Resources.ok;
                    pn_mensaje.BackColor = Color.DarkGreen;
                    limpiar_campos = true;

                    timer.Enabled = true;
                    timer.Start();
                    ActiveControl = tb_entrada;
                    return;
                }
                //hora de entrada despues de la hora de tolerancia
                else if (TimeSpan.Compare(horaActual, horaToleranciaEntrada) >= 0)
                {
                    //si el infante se retiro antes de la hora de salida
                    if (Asistencia.ExisteRegAsistencia((int)Asistencia.Tipo.entrada, IDInfante, IDTutor, DateTime.Today))
                    {
                        Asistencia.NewAsistenica((int)Asistencia.Tipo.salida, IDInfante, IDTutor, DateTime.Today, horaActual, "Salida registrada antes de la hora de salida");

                        pb_infante.Image = fotoInfante;
                        pb_tutor.Image = fotoTutor;

                        lb_grupo.Text = salon;
                        lb_parentesco.Text = parentesco;

                        lb_nomInfante.Text = nomInfante.ToString();
                        lb_nomTutor.Text = nomTutor.ToString();


                        lb_mensaje.Text = "Salida registrada con exito (Se retiro antes de la hora de salida)";
                        pb_icono.Image = Resources.exclamacion;
                        pn_mensaje.BackColor = Color.MidnightBlue;
                        limpiar_campos = true;

                        timer.Enabled = true;
                        timer.Start();
                        ActiveControl = tb_entrada;
                        return;
                    }
                    else
                    {
                        Asistencia.NewAsistenica((int)Asistencia.Tipo.entrada, IDInfante, IDTutor, DateTime.Today, horaActual, "Entrada con retardo");

                        pb_infante.Image = fotoInfante;
                        pb_tutor.Image = fotoTutor;

                        lb_grupo.Text = salon;
                        lb_parentesco.Text = parentesco;

                        lb_nomInfante.Text = nomInfante.ToString();
                        lb_nomTutor.Text = nomTutor.ToString();

                        lb_mensaje.Text = "Entrada registrada";
                        pb_icono.Image = Resources.exclamacion;
                        pn_mensaje.BackColor = Color.MidnightBlue;
                        limpiar_campos = true;

                        timer.Enabled = true;
                        timer.Start();
                        ActiveControl = tb_entrada;
                        return;
                    }

                }
                //hora de salida
                else if (TimeSpan.Compare(horaActual, Settings.Default.horaSalida.TimeOfDay) >= 0)
                {
                    if (!Asistencia.ExisteRegAsistencia((int)Asistencia.Tipo.entrada, IDInfante, IDTutor, DateTime.Today))
                    {
                        //si no presento tarjeta en la entrada se registrara la hora de entrada con la tolerencia maxima de entrada y con la nota de que no se presento la tarjeta a la hora de entrada, junto con el reg de salida
                        Asistencia.NewAsistenica((int)Asistencia.Tipo.entrada, IDInfante, IDTutor, DateTime.Today, horaToleranciaEntrada + new TimeSpan(0, 1, 0), "No presento tarjeta en la entrada");
                        Asistencia.NewAsistenica((int)Asistencia.Tipo.salida, IDInfante, IDTutor, DateTime.Today, horaActual, "Sin observaciones");

                        pb_infante.Image = fotoInfante;
                        pb_tutor.Image = fotoTutor;

                        lb_grupo.Text = salon;
                        lb_parentesco.Text = parentesco;

                        lb_nomInfante.Text = nomInfante.ToString();
                        lb_nomTutor.Text = nomTutor.ToString();


                        lb_mensaje.Text = "Entrada y salida registrada (No se presento tarjeta en la entrada)";
                        pb_icono.Image = Resources.exclamacion;
                        pn_mensaje.BackColor = Color.MidnightBlue;
                        limpiar_campos = true;

                        timer.Enabled = true;
                        timer.Start();
                        ActiveControl = tb_entrada;
                        return;
                    }
                    else
                    {
                        Asistencia.NewAsistenica((int)Asistencia.Tipo.salida, IDInfante, IDTutor, DateTime.Today, horaActual, "Sin observaciones");

                        pb_infante.Image = fotoInfante;
                        pb_tutor.Image = fotoTutor;

                        lb_grupo.Text = salon;
                        lb_parentesco.Text = parentesco;

                        lb_nomInfante.Text = nomInfante.ToString();
                        lb_nomTutor.Text = nomTutor.ToString();


                        lb_mensaje.Text = "Salida registrada";
                        pb_icono.Image = Resources.ok;
                        pn_mensaje.BackColor = Color.DarkGreen;
                        limpiar_campos = true;

                        timer.Enabled = true;
                        timer.Start();
                        ActiveControl = tb_entrada;
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                lb_mensaje.Text = ex.Message;
                pb_icono.Image = Resources.cruz;
                pn_mensaje.BackColor = Color.DarkRed;
                limpiar_campos = true;

                timer.Enabled = true;
                timer.Start();
                ActiveControl = tb_entrada;
                return;
            }
        }

        private bool DividirCadena(string entrada)
        {
            if (entrada.Length != 8) return false;
            string IDInfante = string.Empty, IDTutor = string.Empty;

            for (int i = 0; i < 4; i++) IDInfante += entrada[i];
            for (int i = 4; i < 8; i++) IDTutor += entrada[i];

            if (!int.TryParse(IDInfante, out this.IDInfante)) return false;
            if (!int.TryParse(IDTutor, out this.IDTutor)) return false;

            return true;
        }
    }
}
