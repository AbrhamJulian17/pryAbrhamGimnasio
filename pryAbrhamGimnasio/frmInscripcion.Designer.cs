namespace pryAbrhamGimnasio
{
    partial class frmIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIn));
            rbEfectivo = new RadioButton();
            rbTarjeta = new RadioButton();
            cbxPlan = new ComboBox();
            cboTurno = new ComboBox();
            grpDatosP = new GroupBox();
            txtEdad = new TextBox();
            txtNom = new TextBox();
            chkEstudiante = new CheckBox();
            lblEdad = new Label();
            lblNom = new Label();
            grpFormaPago = new GroupBox();
            lblCuotas = new Label();
            cboCuotas = new ComboBox();
            grpPlan = new GroupBox();
            txtMeses = new TextBox();
            lblPlan = new Label();
            chkCasillero = new CheckBox();
            lblTurno = new Label();
            lblMeses = new Label();
            btnLimpiar = new Button();
            btnCalcular = new Button();
            btnConsultar = new Button();
            grpDatosP.SuspendLayout();
            grpFormaPago.SuspendLayout();
            grpPlan.SuspendLayout();
            SuspendLayout();
            // 
            // rbEfectivo
            // 
            rbEfectivo.AutoSize = true;
            rbEfectivo.Location = new Point(14, 43);
            rbEfectivo.Name = "rbEfectivo";
            rbEfectivo.Size = new Size(67, 19);
            rbEfectivo.TabIndex = 0;
            rbEfectivo.TabStop = true;
            rbEfectivo.Text = "Efectivo";
            rbEfectivo.UseVisualStyleBackColor = true;
            // 
            // rbTarjeta
            // 
            rbTarjeta.AutoSize = true;
            rbTarjeta.Location = new Point(133, 43);
            rbTarjeta.Name = "rbTarjeta";
            rbTarjeta.Size = new Size(60, 19);
            rbTarjeta.TabIndex = 1;
            rbTarjeta.TabStop = true;
            rbTarjeta.Text = "Tarjeta";
            rbTarjeta.UseVisualStyleBackColor = true;
            // 
            // cbxPlan
            // 
            cbxPlan.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPlan.FormattingEnabled = true;
            cbxPlan.Items.AddRange(new object[] { "Musculacion", "Funcional", "Natacion" });
            cbxPlan.Location = new Point(122, 26);
            cbxPlan.Name = "cbxPlan";
            cbxPlan.Size = new Size(150, 23);
            cbxPlan.TabIndex = 1;
            // 
            // cboTurno
            // 
            cboTurno.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTurno.FormattingEnabled = true;
            cboTurno.Items.AddRange(new object[] { "Mañana", "Tarde", "Noche" });
            cboTurno.Location = new Point(122, 59);
            cboTurno.Name = "cboTurno";
            cboTurno.Size = new Size(150, 23);
            cboTurno.TabIndex = 2;
            // 
            // grpDatosP
            // 
            grpDatosP.BackColor = SystemColors.InactiveCaption;
            grpDatosP.Controls.Add(txtEdad);
            grpDatosP.Controls.Add(txtNom);
            grpDatosP.Controls.Add(chkEstudiante);
            grpDatosP.Controls.Add(lblEdad);
            grpDatosP.Controls.Add(lblNom);
            grpDatosP.Location = new Point(12, 28);
            grpDatosP.Name = "grpDatosP";
            grpDatosP.Size = new Size(420, 120);
            grpDatosP.TabIndex = 4;
            grpDatosP.TabStop = false;
            grpDatosP.Text = "Datos Personales";
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(77, 78);
            txtEdad.MaxLength = 2;
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(91, 23);
            txtEdad.TabIndex = 1;
            txtEdad.Click += frm_Load;
            txtEdad.KeyPress += txtEdad_KeyPress;
            // 
            // txtNom
            // 
            txtNom.Location = new Point(77, 28);
            txtNom.MaxLength = 30;
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(275, 23);
            txtNom.TabIndex = 0;
            // 
            // chkEstudiante
            // 
            chkEstudiante.AutoSize = true;
            chkEstudiante.Location = new Point(191, 82);
            chkEstudiante.Name = "chkEstudiante";
            chkEstudiante.Size = new Size(81, 19);
            chkEstudiante.TabIndex = 2;
            chkEstudiante.Text = "Estudiante";
            chkEstudiante.UseVisualStyleBackColor = true;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(14, 81);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(36, 15);
            lblEdad.TabIndex = 8;
            lblEdad.Text = "Edad:";
            // 
            // lblNom
            // 
            lblNom.AutoSize = true;
            lblNom.Location = new Point(12, 36);
            lblNom.Name = "lblNom";
            lblNom.Size = new Size(54, 15);
            lblNom.TabIndex = 7;
            lblNom.Text = "Nombre:";
            // 
            // grpFormaPago
            // 
            grpFormaPago.BackColor = SystemColors.InactiveCaption;
            grpFormaPago.Controls.Add(lblCuotas);
            grpFormaPago.Controls.Add(cboCuotas);
            grpFormaPago.Controls.Add(rbEfectivo);
            grpFormaPago.Controls.Add(rbTarjeta);
            grpFormaPago.Location = new Point(12, 338);
            grpFormaPago.Name = "grpFormaPago";
            grpFormaPago.Size = new Size(420, 100);
            grpFormaPago.TabIndex = 5;
            grpFormaPago.TabStop = false;
            grpFormaPago.Text = "Forma de pago";
            // 
            // lblCuotas
            // 
            lblCuotas.AutoSize = true;
            lblCuotas.Location = new Point(262, 45);
            lblCuotas.Name = "lblCuotas";
            lblCuotas.Size = new Size(44, 15);
            lblCuotas.TabIndex = 18;
            lblCuotas.Text = "Cuotas";
            // 
            // cboCuotas
            // 
            cboCuotas.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCuotas.FormattingEnabled = true;
            cboCuotas.Items.AddRange(new object[] { "1 ", "3", "6", "" });
            cboCuotas.Location = new Point(312, 42);
            cboCuotas.Name = "cboCuotas";
            cboCuotas.Size = new Size(58, 23);
            cboCuotas.TabIndex = 2;
            // 
            // grpPlan
            // 
            grpPlan.BackColor = SystemColors.InactiveCaption;
            grpPlan.Controls.Add(txtMeses);
            grpPlan.Controls.Add(lblPlan);
            grpPlan.Controls.Add(chkCasillero);
            grpPlan.Controls.Add(lblTurno);
            grpPlan.Controls.Add(cbxPlan);
            grpPlan.Controls.Add(cboTurno);
            grpPlan.Controls.Add(lblMeses);
            grpPlan.Location = new Point(12, 154);
            grpPlan.Name = "grpPlan";
            grpPlan.Size = new Size(420, 178);
            grpPlan.TabIndex = 1;
            grpPlan.TabStop = false;
            grpPlan.Text = "Plan";
            // 
            // txtMeses
            // 
            txtMeses.Location = new Point(122, 106);
            txtMeses.MaxLength = 2;
            txtMeses.Name = "txtMeses";
            txtMeses.Size = new Size(76, 23);
            txtMeses.TabIndex = 3;
            txtMeses.KeyPress += txtMeses_KeyPress;
            // 
            // lblPlan
            // 
            lblPlan.AutoSize = true;
            lblPlan.Location = new Point(14, 34);
            lblPlan.Name = "lblPlan";
            lblPlan.Size = new Size(33, 15);
            lblPlan.TabIndex = 10;
            lblPlan.Text = "Plan:";
            // 
            // chkCasillero
            // 
            chkCasillero.AutoSize = true;
            chkCasillero.Location = new Point(225, 110);
            chkCasillero.Name = "chkCasillero";
            chkCasillero.Size = new Size(145, 19);
            chkCasillero.TabIndex = 4;
            chkCasillero.Text = "Casillero ($ 3.000/mes)";
            chkCasillero.UseVisualStyleBackColor = true;
            // 
            // lblTurno
            // 
            lblTurno.AutoSize = true;
            lblTurno.Location = new Point(14, 62);
            lblTurno.Name = "lblTurno";
            lblTurno.Size = new Size(42, 15);
            lblTurno.TabIndex = 11;
            lblTurno.Text = "Turno:";
            // 
            // lblMeses
            // 
            lblMeses.AutoSize = true;
            lblMeses.Location = new Point(14, 114);
            lblMeses.Name = "lblMeses";
            lblMeses.Size = new Size(81, 15);
            lblMeses.TabIndex = 12;
            lblMeses.Text = "Meses (1 a 12)";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(340, 468);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(92, 38);
            btnLimpiar.TabIndex = 14;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(237, 468);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(92, 38);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(15, 468);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(92, 38);
            btnConsultar.TabIndex = 16;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            // 
            // frmIn
            // 
            AcceptButton = btnCalcular;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(444, 524);
            Controls.Add(btnConsultar);
            Controls.Add(btnCalcular);
            Controls.Add(btnLimpiar);
            Controls.Add(grpPlan);
            Controls.Add(grpFormaPago);
            Controls.Add(grpDatosP);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "frmIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gimnasio Siglo - Inscripcion";
            Load += frm_Load;
            grpDatosP.ResumeLayout(false);
            grpDatosP.PerformLayout();
            grpFormaPago.ResumeLayout(false);
            grpFormaPago.PerformLayout();
            grpPlan.ResumeLayout(false);
            grpPlan.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RadioButton rbEfectivo;
        private RadioButton rbTarjeta;
        private ComboBox cbxPlan;
        private ComboBox cboTurno;
        private GroupBox grpDatosP;
        private GroupBox grpFormaPago;
        private GroupBox grpPlan;
        private Label lblNom;
        private Label lblEdad;
        private Label lblPlan;
        private Label lblTurno;
        private Label lblMeses;
        private TextBox txtNom;
        private CheckBox chkEstudiante;
        private CheckBox chkCasillero;
        private Button btnLimpiar;
        private Button btnCalcular;
        private TextBox txtMeses;
        private Label lblCuotas;
        private ComboBox cboCuotas;
        private TextBox txtEdad;
        private Button btnConsultar;
    }
}
