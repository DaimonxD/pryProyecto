namespace pryProyecto
{
    partial class frmPila
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
            this.lstPila = new System.Windows.Forms.ListBox();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPila = new System.Windows.Forms.DataGridView();
            this.Tramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblT = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblN = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtT = new System.Windows.Forms.TextBox();
            this.txtN = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPila)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstPila
            // 
            this.lstPila.FormattingEnabled = true;
            this.lstPila.Location = new System.Drawing.Point(7, 20);
            this.lstPila.Name = "lstPila";
            this.lstPila.Size = new System.Drawing.Size(294, 199);
            this.lstPila.TabIndex = 0;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // dgvPila
            // 
            this.dgvPila.AllowUserToAddRows = false;
            this.dgvPila.AllowUserToDeleteRows = false;
            this.dgvPila.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPila.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Tramite});
            this.dgvPila.Location = new System.Drawing.Point(314, 19);
            this.dgvPila.Name = "dgvPila";
            this.dgvPila.ReadOnly = true;
            this.dgvPila.Size = new System.Drawing.Size(478, 199);
            this.dgvPila.TabIndex = 1;
            // 
            // Tramite
            // 
            this.Tramite.HeaderText = "Trámite";
            this.Tramite.Name = "Tramite";
            this.Tramite.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvPila);
            this.groupBox3.Controls.Add(this.lstPila);
            this.groupBox3.Location = new System.Drawing.Point(4, 227);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(792, 221);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Listado en una Lista y una Grilla";
            // 
            // lblT
            // 
            this.lblT.Location = new System.Drawing.Point(113, 139);
            this.lblT.Name = "lblT";
            this.lblT.Size = new System.Drawing.Size(161, 20);
            this.lblT.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblT);
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.lblN);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblC);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(515, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 218);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Elemento Eliminado";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(162, 175);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(112, 37);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblN
            // 
            this.lblN.Location = new System.Drawing.Point(113, 87);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(161, 20);
            this.lblN.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Código";
            // 
            // lblC
            // 
            this.lblC.Location = new System.Drawing.Point(113, 33);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(161, 20);
            this.lblC.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Trámite";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(163, 175);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(112, 37);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Trámite";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // txtT
            // 
            this.txtT.Location = new System.Drawing.Point(114, 139);
            this.txtT.Name = "txtT";
            this.txtT.Size = new System.Drawing.Size(161, 20);
            this.txtT.TabIndex = 6;
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(114, 87);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(161, 20);
            this.txtN.TabIndex = 5;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(114, 33);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(161, 20);
            this.txtC.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtT);
            this.groupBox1.Controls.Add(this.txtN);
            this.groupBox1.Controls.Add(this.txtC);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(228, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 218);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nuevo Elemento";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::pryProyecto.Properties.Resources._640px_Pila_svg;
            this.pictureBox1.Location = new System.Drawing.Point(4, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 218);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // frmPila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPila";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructura de Datos - Pila";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPila)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstPila;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridView dgvPila;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tramite;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox lblT;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox lblN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox lblC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtT;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}