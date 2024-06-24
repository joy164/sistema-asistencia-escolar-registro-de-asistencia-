using sistema_asistencia_escolar__asistencia_.includes.BD;
using MySql.Data.MySqlClient;
using System.Data;
using System;

namespace sistema_asistencia_escolar__asistencia_.includes.entidades
{
    internal class Asistencia
    {
        
        /// <summary>
        /// Enumera el tipo de asistencia que queremos trabajar con la clase
        /// </summary>
        [Flags]
        public enum Tipo : int
        {
            entrada = 1,
            salida = 2
        }

        public static bool ExisteRegAsistencia(int modo, int noInfante, int noTutor, DateTime fechaConsulta)
        {
            string cmdText = modo == (int)Tipo.entrada ? "SELECT * FROM V_PERMISO_ENTRADA WHERE FECHA = @fechaConsulta AND ID_INFANTE = @noInfante AND ID_TUTOR = @noTutor" : "SELECT * FROM V_PERMISO_SALIDA WHERE FECHA = @fechaConsulta AND ID_INFANTE = @noInfante AND ID_TUTOR = @noTutor";
            MySqlConnection conn;
            DataSet dataSet = new DataSet();

            try
            {
                //establecemos si se hay una conexion exitosa con la base de datos
                using (conn = ConectorMySQL.InitConexion())
                {

                    if (conn == null || conn.State != ConnectionState.Open)
                        throw new Exception("No se pudo establecer la conexion con la base de datos, revise el estado de conexion de su internet o del servidor");

                    //realizamos la consulta en la base de datos con el parametro de tipo entero
                    using (MySqlCommand cmdDB = new MySqlCommand(cmdText, conn))
                    {
                        cmdDB.Parameters.AddWithValue("@fechaConsulta", fechaConsulta);
                        cmdDB.Parameters.AddWithValue("@noInfante", noInfante);
                        cmdDB.Parameters.AddWithValue("@noTutor", noTutor);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmdDB);

                        //si no hay ningun grupo se retorna un valor nulo
                        if (da.Fill(dataSet) == 0)
                            return false;
                    }
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            ConectorMySQL.TermConexion(conn);
            return true;
        }

        public static void NewAsistenica(int modo, int noInfante, int noTutor, DateTime fecha, TimeSpan hora, string notas)
        {
            string cmdText = modo == (int)Tipo.entrada ? "CALL P_REGISTRO_ENTRADA_NUEVO (@noTutor, @noInfante, @fecha, @hora, @notas)" : "CALL P_REGISTRO_SALIDA_NUEVO (@noTutor, @noInfante, @fecha, @hora, @notas)";
            MySqlConnection conn;

            try
            {
                //establecemos si se hay una conexion exitosa con la base de datos
                using (conn = ConectorMySQL.InitConexion())
                {
                    if (conn == null || conn.State != ConnectionState.Open)
                        throw new Exception("No se pudo establecer la conexion con la base de datos, revise el estado de conexion de su internet o del servidor");

                    //realizamos la consulta en la base de datos con el parametro de tipo entero
                    using (MySqlCommand cmdDB = new MySqlCommand(cmdText, conn))
                    {
                        cmdDB.Parameters.AddWithValue("@noTutor", noTutor);
                        cmdDB.Parameters.AddWithValue("@noInfante", noInfante);
                        cmdDB.Parameters.AddWithValue("@fecha", fecha.Date);
                        cmdDB.Parameters.AddWithValue("@hora", hora);
                        cmdDB.Parameters.AddWithValue("@notas", notas);
                            
                        cmdDB.ExecuteNonQuery();
                    }

                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            ConectorMySQL.TermConexion(conn);
        }
    }
}
