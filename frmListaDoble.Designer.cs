namespace pryProyecto
{
    partial class frmListaDoble
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListaDoble));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtT = new System.Windows.Forms.TextBox();
            this.txtN = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstListaDoble = new System.Windows.Forms.ListBox();
            this.dgvListaDoble = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rDes = new System.Windows.Forms.RadioButton();
            this.rAs = new System.Windows.Forms.RadioButton();
            this.cboxListaDoble = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDoble)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.groupBox1.Location = new System.Drawing.Point(253, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 218);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nuevo Elemento";
            // 
            // txtT
            // 
            this.txtT.Location = new System.Drawing.Point(114, 139);
            this.txtT.Name = "txtT";
            this.txtT.Size = new System.Drawing.Size(142, 20);
            this.txtT.TabIndex = 6;
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(114, 87);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(142, 20);
            this.txtN.TabIndex = 5;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(114, 33);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(142, 20);
            this.txtC.TabIndex = 4;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(6, 175);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(250, 37);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstListaDoble);
            this.groupBox3.Controls.Add(this.dgvListaDoble);
            this.groupBox3.Location = new System.Drawing.Point(4, 227);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(792, 221);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Listado en una Lista y una Grilla";
            // 
            // lstListaDoble
            // 
            this.lstListaDoble.FormattingEnabled = true;
            this.lstListaDoble.Location = new System.Drawing.Point(9, 20);
            this.lstListaDoble.Name = "lstListaDoble";
            this.lstListaDoble.Size = new System.Drawing.Size(293, 199);
            this.lstListaDoble.TabIndex = 2;
            // 
            // dgvListaDoble
            // 
            this.dgvListaDoble.AllowUserToAddRows = false;
            this.dgvListaDoble.AllowUserToDeleteRows = false;
            this.dgvListaDoble.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaDoble.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Tramite});
            this.dgvListaDoble.Location = new System.Drawing.Point(308, 20);
            this.dgvListaDoble.Name = "dgvListaDoble";
            this.dgvListaDoble.ReadOnly = true;
            this.dgvListaDoble.Size = new System.Drawing.Size(478, 201);
            this.dgvListaDoble.TabIndex = 1;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Tramite
            // 
            this.Tramite.HeaderText = "Tramite";
            this.Tramite.Name = "Tramite";
            this.Tramite.ReadOnly = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(9, 66);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(268, 37);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Código";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rDes);
            this.groupBox2.Controls.Add(this.rAs);
            this.groupBox2.Controls.Add(this.cboxListaDoble);
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(515, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 218);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Elemento Eliminado";
            // 
            // rDes
            // 
            this.rDes.AutoSize = true;
            this.rDes.Location = new System.Drawing.Point(9, 160);
            this.rDes.Name = "rDes";
            this.rDes.Size = new System.Drawing.Size(89, 17);
            this.rDes.TabIndex = 13;
            this.rDes.TabStop = true;
            this.rDes.Text = "Descendente";
            this.rDes.UseVisualStyleBackColor = true;
            // 
            // rAs
            // 
            this.rAs.AutoSize = true;
            this.rAs.Location = new System.Drawing.Point(9, 137);
            this.rAs.Name = "rAs";
            this.rAs.Size = new System.Drawing.Size(82, 17);
            this.rAs.TabIndex = 12;
            this.rAs.TabStop = true;
            this.rAs.Text = "Ascendente";
            this.rAs.UseVisualStyleBackColor = true;
            // 
            // cboxListaDoble
            // 
            this.cboxListaDoble.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxListaDoble.FormattingEnabled = true;
            this.cboxListaDoble.Location = new System.Drawing.Point(85, 19);
            this.cboxListaDoble.Name = "cboxListaDoble";
            this.cboxListaDoble.Size = new System.Drawing.Size(196, 21);
            this.cboxListaDoble.TabIndex = 11;
            this.cboxListaDoble.SelectedIndexChanged += new System.EventHandler(this.cboxListaDoble_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // frmListaDoble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmListaDoble";
            this.Text = "Estructura de Datos - Lista Doble";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaDoble)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtT;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvListaDoble;
        private System.Windows.Forms.ListBox lstListaDoble;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tramite;
        private System.Windows.Forms.ComboBox cboxListaDoble;
        private System.Windows.Forms.RadioButton rDes;
        private System.Windows.Forms.RadioButton rAs;
    }
}