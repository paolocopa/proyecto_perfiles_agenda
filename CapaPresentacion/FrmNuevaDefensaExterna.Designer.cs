namespace CapaPresentacion
{
    partial class FrmNuevaDefensaExterna
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelarNuevaDefensaE = new System.Windows.Forms.Button();
            this.btnGuardarNuevaDefensaE = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTipoDefensa = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtFechaDefensa = new System.Windows.Forms.DateTimePicker();
            this.dtHora = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlBarraTitulo = new System.Windows.Forms.Panel();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlBarraTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnCancelarNuevaDefensaE);
            this.panel1.Controls.Add(this.btnGuardarNuevaDefensaE);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cmbTipoDefensa);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtAula);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtFechaDefensa);
            this.panel1.Controls.Add(this.dtHora);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pnlBarraTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1400, 1359);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnCancelarNuevaDefensaE
            // 
            this.btnCancelarNuevaDefensaE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnCancelarNuevaDefensaE.FlatAppearance.BorderSize = 0;
            this.btnCancelarNuevaDefensaE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarNuevaDefensaE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarNuevaDefensaE.ForeColor = System.Drawing.Color.White;
            this.btnCancelarNuevaDefensaE.Location = new System.Drawing.Point(751, 1124);
            this.btnCancelarNuevaDefensaE.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnCancelarNuevaDefensaE.Name = "btnCancelarNuevaDefensaE";
            this.btnCancelarNuevaDefensaE.Size = new System.Drawing.Size(191, 85);
            this.btnCancelarNuevaDefensaE.TabIndex = 35;
            this.btnCancelarNuevaDefensaE.Text = "Cancelar";
            this.btnCancelarNuevaDefensaE.UseVisualStyleBackColor = false;
            // 
            // btnGuardarNuevaDefensaE
            // 
            this.btnGuardarNuevaDefensaE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btnGuardarNuevaDefensaE.FlatAppearance.BorderSize = 0;
            this.btnGuardarNuevaDefensaE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarNuevaDefensaE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarNuevaDefensaE.ForeColor = System.Drawing.Color.White;
            this.btnGuardarNuevaDefensaE.Location = new System.Drawing.Point(957, 1124);
            this.btnGuardarNuevaDefensaE.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnGuardarNuevaDefensaE.Name = "btnGuardarNuevaDefensaE";
            this.btnGuardarNuevaDefensaE.Size = new System.Drawing.Size(191, 85);
            this.btnGuardarNuevaDefensaE.TabIndex = 34;
            this.btnGuardarNuevaDefensaE.Text = "Guardar";
            this.btnGuardarNuevaDefensaE.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(107, 228);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(223, 38);
            this.label4.TabIndex = 33;
            this.label4.Text = "Tipo Defensa";
            // 
            // cmbTipoDefensa
            // 
            this.cmbTipoDefensa.FormattingEnabled = true;
            this.cmbTipoDefensa.Items.AddRange(new object[] {
            "",
            "tesis",
            "examen de grado",
            "proyecto de grado"});
            this.cmbTipoDefensa.Location = new System.Drawing.Point(131, 301);
            this.cmbTipoDefensa.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cmbTipoDefensa.Name = "cmbTipoDefensa";
            this.cmbTipoDefensa.Size = new System.Drawing.Size(209, 37);
            this.cmbTipoDefensa.TabIndex = 32;
            this.cmbTipoDefensa.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(243, 895);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 38);
            this.label2.TabIndex = 31;
            this.label2.Text = "Aula";
            // 
            // txtAula
            // 
            this.txtAula.Location = new System.Drawing.Point(247, 961);
            this.txtAula.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtAula.Name = "txtAula";
            this.txtAula.Size = new System.Drawing.Size(172, 35);
            this.txtAula.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(527, 901);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 38);
            this.label1.TabIndex = 29;
            this.label1.Text = "Fecha Defensa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(856, 901);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 38);
            this.label3.TabIndex = 28;
            this.label3.Text = "Hora";
            // 
            // dtFechaDefensa
            // 
            this.dtFechaDefensa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaDefensa.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaDefensa.Location = new System.Drawing.Point(534, 950);
            this.dtFechaDefensa.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dtFechaDefensa.Name = "dtFechaDefensa";
            this.dtFechaDefensa.Size = new System.Drawing.Size(247, 44);
            this.dtFechaDefensa.TabIndex = 19;
            // 
            // dtHora
            // 
            this.dtHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtHora.Location = new System.Drawing.Point(863, 950);
            this.dtHora.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dtHora.Name = "dtHora";
            this.dtHora.Size = new System.Drawing.Size(247, 44);
            this.dtHora.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.lblTitulo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 60);
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1398, 134);
            this.panel2.TabIndex = 17;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTitulo.Location = new System.Drawing.Point(105, 38);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(415, 65);
            this.lblTitulo.TabIndex = 24;
            this.lblTitulo.Text = "Nueva Defensa Externa";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBarraTitulo
            // 
            this.pnlBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.pnlBarraTitulo.Controls.Add(this.btnCerrar);
            this.pnlBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraTitulo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pnlBarraTitulo.Name = "pnlBarraTitulo";
            this.pnlBarraTitulo.Size = new System.Drawing.Size(1398, 60);
            this.pnlBarraTitulo.TabIndex = 1;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCerrar.IconColor = System.Drawing.Color.Black;
            this.btnCerrar.IconSize = 16;
            this.btnCerrar.Location = new System.Drawing.Point(1319, 2);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Rotation = 0D;
            this.btnCerrar.Size = new System.Drawing.Size(79, 65);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FrmNuevaDefensaExterna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1400, 1359);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmNuevaDefensaExterna";
            this.Text = "FrmNuevaDefensaExterna";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.pnlBarraTitulo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlBarraTitulo;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DateTimePicker dtFechaDefensa;
        private System.Windows.Forms.DateTimePicker dtHora;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTipoDefensa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancelarNuevaDefensaE;
        private System.Windows.Forms.Button btnGuardarNuevaDefensaE;
    }
}