namespace pryProyecto
{
    partial class frmBaseDatosOperaciones
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
            this.dgvOperaciones = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSelect3 = new System.Windows.Forms.Button();
            this.btnSelect2 = new System.Windows.Forms.Button();
            this.btnSelect1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnWhere3 = new System.Windows.Forms.Button();
            this.btnWhere2 = new System.Windows.Forms.Button();
            this.btnWhere1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAlgebra3 = new System.Windows.Forms.Button();
            this.btnAlgebra2 = new System.Windows.Forms.Button();
            this.btnAlgebra1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperaciones)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOperaciones
            // 
            this.dgvOperaciones.AllowUserToAddRows = false;
            this.dgvOperaciones.AllowUserToDeleteRows = false;
            this.dgvOperaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOperaciones.Location = new System.Drawing.Point(3, 3);
            this.dgvOperaciones.Name = "dgvOperaciones";
            this.dgvOperaciones.ReadOnly = true;
            this.dgvOperaciones.Size = new System.Drawing.Size(794, 306);
            this.dgvOperaciones.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSelect3);
            this.groupBox1.Controls.Add(this.btnSelect2);
            this.groupBox1.Controls.Add(this.btnSelect1);
            this.groupBox1.Location = new System.Drawing.Point(3, 316);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 122);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operaciones de Proyección - SELECT";
            // 
            // btnSelect3
            // 
            this.btnSelect3.Location = new System.Drawing.Point(10, 79);
            this.btnSelect3.Name = "btnSelect3";
            this.btnSelect3.Size = new System.Drawing.Size(249, 23);
            this.btnSelect3.TabIndex = 2;
            this.btnSelect3.Text = "Juntar";
            this.btnSelect3.UseVisualStyleBackColor = true;
            this.btnSelect3.Click += new System.EventHandler(this.btnSelect3_Click);
            // 
            // btnSelect2
            // 
            this.btnSelect2.Location = new System.Drawing.Point(8, 50);
            this.btnSelect2.Name = "btnSelect2";
            this.btnSelect2.Size = new System.Drawing.Size(249, 23);
            this.btnSelect2.TabIndex = 1;
            this.btnSelect2.Text = "Proyección multiatributo";
            this.btnSelect2.UseVisualStyleBackColor = true;
            this.btnSelect2.Click += new System.EventHandler(this.btnSelect2_Click);
            // 
            // btnSelect1
            // 
            this.btnSelect1.Location = new System.Drawing.Point(10, 20);
            this.btnSelect1.Name = "btnSelect1";
            this.btnSelect1.Size = new System.Drawing.Size(249, 23);
            this.btnSelect1.TabIndex = 0;
            this.btnSelect1.Text = "Proyección Simple";
            this.btnSelect1.UseVisualStyleBackColor = true;
            this.btnSelect1.Click += new System.EventHandler(this.btnSelect1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnWhere3);
            this.groupBox2.Controls.Add(this.btnWhere2);
            this.groupBox2.Controls.Add(this.btnWhere1);
            this.groupBox2.Location = new System.Drawing.Point(274, 316);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 122);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opraciones de Selección - WHERE";
            // 
            // btnWhere3
            // 
            this.btnWhere3.Location = new System.Drawing.Point(6, 79);
            this.btnWhere3.Name = "btnWhere3";
            this.btnWhere3.Size = new System.Drawing.Size(249, 23);
            this.btnWhere3.TabIndex = 5;
            this.btnWhere3.Text = "Selección por convolución";
            this.btnWhere3.UseVisualStyleBackColor = true;
            this.btnWhere3.Click += new System.EventHandler(this.btnWhere3_Click);
            // 
            // btnWhere2
            // 
            this.btnWhere2.Location = new System.Drawing.Point(8, 50);
            this.btnWhere2.Name = "btnWhere2";
            this.btnWhere2.Size = new System.Drawing.Size(249, 23);
            this.btnWhere2.TabIndex = 4;
            this.btnWhere2.Text = "Selección multiatributo";
            this.btnWhere2.UseVisualStyleBackColor = true;
            this.btnWhere2.Click += new System.EventHandler(this.btnWhere2_Click);
            // 
            // btnWhere1
            // 
            this.btnWhere1.Location = new System.Drawing.Point(6, 20);
            this.btnWhere1.Name = "btnWhere1";
            this.btnWhere1.Size = new System.Drawing.Size(249, 23);
            this.btnWhere1.TabIndex = 3;
            this.btnWhere1.Text = "Selección Simple";
            this.btnWhere1.UseVisualStyleBackColor = true;
            this.btnWhere1.Click += new System.EventHandler(this.btnWhere1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnAlgebra3);
            this.groupBox3.Controls.Add(this.btnAlgebra2);
            this.groupBox3.Controls.Add(this.btnAlgebra1);
            this.groupBox3.Location = new System.Drawing.Point(545, 316);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(252, 122);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Operaciones Algebraicas";
            // 
            // btnAlgebra3
            // 
            this.btnAlgebra3.Location = new System.Drawing.Point(3, 79);
            this.btnAlgebra3.Name = "btnAlgebra3";
            this.btnAlgebra3.Size = new System.Drawing.Size(243, 23);
            this.btnAlgebra3.TabIndex = 8;
            this.btnAlgebra3.Text = "Diferencia";
            this.btnAlgebra3.UseVisualStyleBackColor = true;
            this.btnAlgebra3.Click += new System.EventHandler(this.btnAlgebra3_Click);
            // 
            // btnAlgebra2
            // 
            this.btnAlgebra2.Location = new System.Drawing.Point(3, 50);
            this.btnAlgebra2.Name = "btnAlgebra2";
            this.btnAlgebra2.Size = new System.Drawing.Size(243, 23);
            this.btnAlgebra2.TabIndex = 7;
            this.btnAlgebra2.Text = "Intersección";
            this.btnAlgebra2.UseVisualStyleBackColor = true;
            this.btnAlgebra2.Click += new System.EventHandler(this.btnAlgebra2_Click);
            // 
            // btnAlgebra1
            // 
            this.btnAlgebra1.Location = new System.Drawing.Point(3, 20);
            this.btnAlgebra1.Name = "btnAlgebra1";
            this.btnAlgebra1.Size = new System.Drawing.Size(243, 23);
            this.btnAlgebra1.TabIndex = 6;
            this.btnAlgebra1.Text = "Unión";
            this.btnAlgebra1.UseVisualStyleBackColor = true;
            this.btnAlgebra1.Click += new System.EventHandler(this.btnAlgebra1_Click);
            // 
            // frmBaseDatosOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvOperaciones);
            this.Name = "frmBaseDatosOperaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBaseDatosOperaciones";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperaciones)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOperaciones;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSelect3;
        private System.Windows.Forms.Button btnSelect2;
        private System.Windows.Forms.Button btnSelect1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnWhere3;
        private System.Windows.Forms.Button btnWhere2;
        private System.Windows.Forms.Button btnWhere1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnAlgebra3;
        private System.Windows.Forms.Button btnAlgebra2;
        private System.Windows.Forms.Button btnAlgebra1;
    }
}