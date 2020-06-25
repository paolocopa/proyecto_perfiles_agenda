namespace CapaPresentacion
{
    partial class FrmNuevoLicenciado
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
            this.cmb_Institucion = new System.Windows.Forms.ComboBox();
            this.cmb_carrera = new System.Windows.Forms.ComboBox();
            this.btn_Agregar_Institucion = new System.Windows.Forms.Button();
            this.btn_agregar_Carrera = new System.Windows.Forms.Button();
            this.pnlBarraTitulo = new System.Windows.Forms.Panel();
            this.btnMinimizar = new FontAwesome.Sharp.IconButton();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.pnlBarraTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_Institucion
            // 
            this.cmb_Institucion.FormattingEnabled = true;
            this.cmb_Institucion.Location = new System.Drawing.Point(47, 119);
            this.cmb_Institucion.Name = "cmb_Institucion";
            this.cmb_Institucion.Size = new System.Drawing.Size(154, 21);
            this.cmb_Institucion.TabIndex = 0;
            // 
            // cmb_carrera
            // 
            this.cmb_carrera.FormattingEnabled = true;
            this.cmb_carrera.Location = new System.Drawing.Point(47, 193);
            this.cmb_carrera.Name = "cmb_carrera";
            this.cmb_carrera.Size = new System.Drawing.Size(154, 21);
            this.cmb_carrera.TabIndex = 1;
            // 
            // btn_Agregar_Institucion
            // 
            this.btn_Agregar_Institucion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btn_Agregar_Institucion.FlatAppearance.BorderSize = 0;
            this.btn_Agregar_Institucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Agregar_Institucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Agregar_Institucion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Agregar_Institucion.Location = new System.Drawing.Point(263, 116);
            this.btn_Agregar_Institucion.Name = "btn_Agregar_Institucion";
            this.btn_Agregar_Institucion.Size = new System.Drawing.Size(134, 25);
            this.btn_Agregar_Institucion.TabIndex = 26;
            this.btn_Agregar_Institucion.Text = "Nuevo agenda";
            this.btn_Agregar_Institucion.UseVisualStyleBackColor = false;
            // 
            // btn_agregar_Carrera
            // 
            this.btn_agregar_Carrera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.btn_agregar_Carrera.FlatAppearance.BorderSize = 0;
            this.btn_agregar_Carrera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar_Carrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar_Carrera.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_agregar_Carrera.Location = new System.Drawing.Point(263, 193);
            this.btn_agregar_Carrera.Name = "btn_agregar_Carrera";
            this.btn_agregar_Carrera.Size = new System.Drawing.Size(134, 25);
            this.btn_agregar_Carrera.TabIndex = 27;
            this.btn_agregar_Carrera.Text = "Nuevo agenda";
            this.btn_agregar_Carrera.UseVisualStyleBackColor = false;
            // 
            // pnlBarraTitulo
            // 
            this.pnlBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.pnlBarraTitulo.Controls.Add(this.btnMinimizar);
            this.pnlBarraTitulo.Controls.Add(this.btnCerrar);
            this.pnlBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraTitulo.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBarraTitulo.Name = "pnlBarraTitulo";
            this.pnlBarraTitulo.Size = new System.Drawing.Size(720, 29);
            this.pnlBarraTitulo.TabIndex = 28;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(9)))), ((int)(((byte)(71)))));
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnMinimizar.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimizar.IconColor = System.Drawing.Color.Black;
            this.btnMinimizar.IconSize = 16;
            this.btnMinimizar.Location = new System.Drawing.Point(652, 0);
            this.btnMinimizar.Margin = new System.Windows.Forms.Padding(0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Rotation = 0D;
            this.btnMinimizar.Size = new System.Drawing.Size(34, 29);
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(9)))), ((int)(((byte)(71)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnCerrar.IconColor = System.Drawing.Color.Black;
            this.btnCerrar.IconSize = 16;
            this.btnCerrar.Location = new System.Drawing.Point(686, 2);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(0);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Rotation = 0D;
            this.btnCerrar.Size = new System.Drawing.Size(34, 29);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FrmNuevoLicenciado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(720, 395);
            this.Controls.Add(this.pnlBarraTitulo);
            this.Controls.Add(this.btn_agregar_Carrera);
            this.Controls.Add(this.btn_Agregar_Institucion);
            this.Controls.Add(this.cmb_carrera);
            this.Controls.Add(this.cmb_Institucion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNuevoLicenciado";
            this.Text = "FrmNuevoLicenciado";
            this.pnlBarraTitulo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Institucion;
        private System.Windows.Forms.ComboBox cmb_carrera;
        private System.Windows.Forms.Button btn_Agregar_Institucion;
        private System.Windows.Forms.Button btn_agregar_Carrera;
        private System.Windows.Forms.Panel pnlBarraTitulo;
        private FontAwesome.Sharp.IconButton btnMinimizar;
        private FontAwesome.Sharp.IconButton btnCerrar;
    }
}