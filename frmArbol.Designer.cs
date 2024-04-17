namespace pryProyecto
{
    partial class frmArbol
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
            this.tView = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEquilibrar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvTree = new System.Windows.Forms.DataGridView();
            this.inOrden = new System.Windows.Forms.RadioButton();
            this.preOrden = new System.Windows.Forms.RadioButton();
            this.postOrden = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtN = new System.Windows.Forms.TextBox();
            this.txtT = new System.Windows.Forms.TextBox();
            this.cboxT = new System.Windows.Forms.ComboBox();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tramite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTree)).BeginInit();
            this.SuspendLayout();
            // 
            // tView
            // 
            this.tView.Location = new System.Drawing.Point(13, 13);
            this.tView.Name = "tView";
            this.tView.Size = new System.Drawing.Size(212, 195);
            this.tView.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtT);
            this.groupBox1.Controls.Add(this.txtN);
            this.groupBox1.Controls.Add(this.txtC);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Location = new System.Drawing.Point(232, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 202);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboxT);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Location = new System.Drawing.Point(516, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(278, 128);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // btnEquilibrar
            // 
            this.btnEquilibrar.Location = new System.Drawing.Point(516, 170);
            this.btnEquilibrar.Name = "btnEquilibrar";
            this.btnEquilibrar.Size = new System.Drawing.Size(278, 37);
            this.btnEquilibrar.TabIndex = 3;
            this.btnEquilibrar.Text = "&Equilibrar";
            this.btnEquilibrar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(6, 85);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(266, 37);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "&Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(6, 157);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(266, 37);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "&Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.postOrden);
            this.groupBox3.Controls.Add(this.preOrden);
            this.groupBox3.Controls.Add(this.inOrden);
            this.groupBox3.Controls.Add(this.dgvTree);
            this.groupBox3.Location = new System.Drawing.Point(13, 215);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(781, 223);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox3";
            // 
            // dgvTree
            // 
            this.dgvTree.AllowUserToAddRows = false;
            this.dgvTree.AllowUserToDeleteRows = false;
            this.dgvTree.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTree.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Tramite});
            this.dgvTree.Location = new System.Drawing.Point(219, 6);
            this.dgvTree.Name = "dgvTree";
            this.dgvTree.ReadOnly = true;
            this.dgvTree.Size = new System.Drawing.Size(556, 211);
            this.dgvTree.TabIndex = 0;
            // 
            // inOrden
            // 
            this.inOrden.AutoSize = true;
            this.inOrden.Location = new System.Drawing.Point(7, 38);
            this.inOrden.Name = "inOrden";
            this.inOrden.Size = new System.Drawing.Size(66, 17);
            this.inOrden.TabIndex = 1;
            this.inOrden.TabStop = true;
            this.inOrden.Text = "In-Orden";
            this.inOrden.UseVisualStyleBackColor = true;
            // 
            // preOrden
            // 
            this.preOrden.AutoSize = true;
            this.preOrden.Location = new System.Drawing.Point(7, 79);
            this.preOrden.Name = "preOrden";
            this.preOrden.Size = new System.Drawing.Size(73, 17);
            this.preOrden.TabIndex = 2;
            this.preOrden.TabStop = true;
            this.preOrden.Text = "Pre-Orden";
            this.preOrden.UseVisualStyleBackColor = true;
            // 
            // postOrden
            // 
            this.postOrden.AutoSize = true;
            this.postOrden.Location = new System.Drawing.Point(7, 117);
            this.postOrden.Name = "postOrden";
            this.postOrden.Size = new System.Drawing.Size(78, 17);
            this.postOrden.TabIndex = 3;
            this.postOrden.TabStop = true;
            this.postOrden.Text = "Post-Orden";
            this.postOrden.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Trámite";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Código";
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(88, 20);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(184, 20);
            this.txtC.TabIndex = 9;
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(88, 67);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(184, 20);
            this.txtN.TabIndex = 10;
            // 
            // txtT
            // 
            this.txtT.Location = new System.Drawing.Point(88, 115);
            this.txtT.Name = "txtT";
            this.txtT.Size = new System.Drawing.Size(184, 20);
            this.txtT.TabIndex = 11;
            // 
            // cboxT
            // 
            this.cboxT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxT.FormattingEnabled = true;
            this.cboxT.Location = new System.Drawing.Point(109, 33);
            this.cboxT.Name = "cboxT";
            this.cboxT.Size = new System.Drawing.Size(151, 21);
            this.cboxT.TabIndex = 10;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
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
            this.Tramite.HeaderText = "Trámite";
            this.Tramite.Name = "Tramite";
            this.Tramite.ReadOnly = true;
            // 
            // frmArbol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnEquilibrar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tView);
            this.Name = "frmArbol";
            this.Text = "frmArbol";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTree)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEquilibrar;
        private System.Windows.Forms.TextBox txtT;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxT;
        private System.Windows.Forms.Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton postOrden;
        private System.Windows.Forms.RadioButton preOrden;
        private System.Windows.Forms.RadioButton inOrden;
        private System.Windows.Forms.DataGridView dgvTree;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tramite;
    }
}