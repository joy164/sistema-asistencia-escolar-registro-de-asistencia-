namespace sistema_asistencia_escolar__asistencia_
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pn_mensaje = new System.Windows.Forms.Panel();
            this.lb_mensaje = new System.Windows.Forms.Label();
            this.pb_icono = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_entrada = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_parentesco = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pb_tutor = new System.Windows.Forms.PictureBox();
            this.lb_nomTutor = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_grupo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pb_infante = new System.Windows.Forms.PictureBox();
            this.lb_nomInfante = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.pn_mensaje.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_icono)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tutor)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_infante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.Controls.Add(this.pn_mensaje, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1332, 831);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // pn_mensaje
            // 
            this.pn_mensaje.BackColor = System.Drawing.Color.Black;
            this.pn_mensaje.Controls.Add(this.lb_mensaje);
            this.pn_mensaje.Controls.Add(this.pb_icono);
            this.pn_mensaje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_mensaje.Location = new System.Drawing.Point(0, 0);
            this.pn_mensaje.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.pn_mensaje.Name = "pn_mensaje";
            this.pn_mensaje.Size = new System.Drawing.Size(330, 831);
            this.pn_mensaje.TabIndex = 0;
            // 
            // lb_mensaje
            // 
            this.lb_mensaje.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_mensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_mensaje.ForeColor = System.Drawing.Color.White;
            this.lb_mensaje.Location = new System.Drawing.Point(12, 658);
            this.lb_mensaje.Name = "lb_mensaje";
            this.lb_mensaje.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.lb_mensaje.Size = new System.Drawing.Size(304, 164);
            this.lb_mensaje.TabIndex = 2;
            this.lb_mensaje.Text = "Presente tarjeta en el escaner";
            this.lb_mensaje.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // pb_icono
            // 
            this.pb_icono.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pb_icono.Image = global::sistema_asistencia_escolar__asistencia_.Properties.Resources.codigo_qr;
            this.pb_icono.Location = new System.Drawing.Point(12, 12);
            this.pb_icono.Name = "pb_icono";
            this.pb_icono.Size = new System.Drawing.Size(304, 304);
            this.pb_icono.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_icono.TabIndex = 1;
            this.pb_icono.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tb_entrada, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.pictureBox4, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(336, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.15152F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.040404F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.80808F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(993, 825);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // tb_entrada
            // 
            this.tb_entrada.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tb_entrada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_entrada.ForeColor = System.Drawing.Color.White;
            this.tb_entrada.Location = new System.Drawing.Point(3, 131);
            this.tb_entrada.Name = "tb_entrada";
            this.tb_entrada.Size = new System.Drawing.Size(279, 13);
            this.tb_entrada.TabIndex = 0;
            this.tb_entrada.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_busqueda_KeyDown);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 161);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(987, 661);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.lb_parentesco, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.pb_tutor, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.lb_nomTutor, 0, 2);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(496, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 4;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(488, 655);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // lb_parentesco
            // 
            this.lb_parentesco.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_parentesco.AutoSize = true;
            this.lb_parentesco.Location = new System.Drawing.Point(178, 617);
            this.lb_parentesco.Name = "lb_parentesco";
            this.lb_parentesco.Size = new System.Drawing.Size(131, 25);
            this.lb_parentesco.TabIndex = 3;
            this.lb_parentesco.Text = "Parentesco";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(192, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 39);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tutor";
            // 
            // pb_tutor
            // 
            this.pb_tutor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_tutor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pb_tutor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb_tutor.Location = new System.Drawing.Point(69, 66);
            this.pb_tutor.Name = "pb_tutor";
            this.pb_tutor.Size = new System.Drawing.Size(350, 472);
            this.pb_tutor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_tutor.TabIndex = 1;
            this.pb_tutor.TabStop = false;
            // 
            // lb_nomTutor
            // 
            this.lb_nomTutor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_nomTutor.AutoSize = true;
            this.lb_nomTutor.Location = new System.Drawing.Point(153, 567);
            this.lb_nomTutor.Name = "lb_nomTutor";
            this.lb_nomTutor.Size = new System.Drawing.Size(181, 25);
            this.lb_nomTutor.TabIndex = 2;
            this.lb_nomTutor.Text = "Nombre de tutor";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.lb_grupo, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.pb_infante, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.lb_nomInfante, 0, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(487, 655);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // lb_grupo
            // 
            this.lb_grupo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_grupo.AutoSize = true;
            this.lb_grupo.Location = new System.Drawing.Point(205, 617);
            this.lb_grupo.Name = "lb_grupo";
            this.lb_grupo.Size = new System.Drawing.Size(76, 25);
            this.lb_grupo.TabIndex = 3;
            this.lb_grupo.Text = "Grupo";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(179, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "Infante";
            // 
            // pb_infante
            // 
            this.pb_infante.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_infante.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pb_infante.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pb_infante.Location = new System.Drawing.Point(68, 66);
            this.pb_infante.Name = "pb_infante";
            this.pb_infante.Size = new System.Drawing.Size(350, 472);
            this.pb_infante.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_infante.TabIndex = 1;
            this.pb_infante.TabStop = false;
            // 
            // lb_nomInfante
            // 
            this.lb_nomInfante.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb_nomInfante.AutoSize = true;
            this.lb_nomInfante.Location = new System.Drawing.Point(141, 567);
            this.lb_nomInfante.Name = "lb_nomInfante";
            this.lb_nomInfante.Size = new System.Drawing.Size(205, 25);
            this.lb_nomInfante.TabIndex = 2;
            this.lb_nomInfante.Text = "Nombre de infante";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.Location = new System.Drawing.Point(586, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(404, 119);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1332, 831);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pn_mensaje.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_icono)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_tutor)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_infante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pn_mensaje;
        private System.Windows.Forms.PictureBox pb_icono;
        private System.Windows.Forms.Label lb_mensaje;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox tb_entrada;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pb_tutor;
        private System.Windows.Forms.Label lb_nomTutor;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pb_infante;
        private System.Windows.Forms.Label lb_nomInfante;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lb_parentesco;
        private System.Windows.Forms.Label lb_grupo;
    }
}

