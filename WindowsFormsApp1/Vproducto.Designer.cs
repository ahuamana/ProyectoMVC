namespace WindowsFormsApp1
{
    partial class Vproducto
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtProd_Codigo = new System.Windows.Forms.TextBox();
            this.tblProductos = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnProd_Nuevo = new System.Windows.Forms.Button();
            this.btnProd_Eliminar = new System.Windows.Forms.Button();
            this.btnProd_Actualizar = new System.Windows.Forms.Button();
            this.btnProd_Agregar = new System.Windows.Forms.Button();
            this.cmbProd_Proveedor = new System.Windows.Forms.ComboBox();
            this.cmbProd_Presentacion = new System.Windows.Forms.ComboBox();
            this.txtProd_Pventa = new System.Windows.Forms.TextBox();
            this.txtProd_Pcompra = new System.Windows.Forms.TextBox();
            this.txtProd_Descripcion = new System.Windows.Forms.TextBox();
            this.txtProd_Nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tblStock = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtStock_Cantidad = new System.Windows.Forms.TextBox();
            this.txtStock_Actual = new System.Windows.Forms.TextBox();
            this.txtStock_Nom = new System.Windows.Forms.TextBox();
            this.txtStock_Cod = new System.Windows.Forms.TextBox();
            this.btnStock_Agregar = new System.Windows.Forms.Button();
            this.btnStock_Disminuir = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductos)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblStock)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(717, 408);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtProd_Codigo);
            this.tabPage1.Controls.Add(this.tblProductos);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.btnProd_Nuevo);
            this.tabPage1.Controls.Add(this.btnProd_Eliminar);
            this.tabPage1.Controls.Add(this.btnProd_Actualizar);
            this.tabPage1.Controls.Add(this.btnProd_Agregar);
            this.tabPage1.Controls.Add(this.cmbProd_Proveedor);
            this.tabPage1.Controls.Add(this.cmbProd_Presentacion);
            this.tabPage1.Controls.Add(this.txtProd_Pventa);
            this.tabPage1.Controls.Add(this.txtProd_Pcompra);
            this.tabPage1.Controls.Add(this.txtProd_Descripcion);
            this.tabPage1.Controls.Add(this.txtProd_Nombre);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(709, 382);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Producto";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtProd_Codigo
            // 
            this.txtProd_Codigo.Location = new System.Drawing.Point(89, 16);
            this.txtProd_Codigo.Name = "txtProd_Codigo";
            this.txtProd_Codigo.ReadOnly = true;
            this.txtProd_Codigo.Size = new System.Drawing.Size(100, 20);
            this.txtProd_Codigo.TabIndex = 18;
            // 
            // tblProductos
            // 
            this.tblProductos.AllowUserToAddRows = false;
            this.tblProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblProductos.Location = new System.Drawing.Point(14, 181);
            this.tblProductos.Name = "tblProductos";
            this.tblProductos.ReadOnly = true;
            this.tblProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblProductos.Size = new System.Drawing.Size(676, 179);
            this.tblProductos.TabIndex = 17;
            this.tblProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblProductos_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(264, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Presentacion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(277, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Proveedor";
            // 
            // btnProd_Nuevo
            // 
            this.btnProd_Nuevo.Location = new System.Drawing.Point(586, 133);
            this.btnProd_Nuevo.Name = "btnProd_Nuevo";
            this.btnProd_Nuevo.Size = new System.Drawing.Size(75, 23);
            this.btnProd_Nuevo.TabIndex = 14;
            this.btnProd_Nuevo.Text = "Nuevo";
            this.btnProd_Nuevo.UseVisualStyleBackColor = true;
            this.btnProd_Nuevo.Click += new System.EventHandler(this.btnProd_Nuevo_Click);
            // 
            // btnProd_Eliminar
            // 
            this.btnProd_Eliminar.Location = new System.Drawing.Point(586, 104);
            this.btnProd_Eliminar.Name = "btnProd_Eliminar";
            this.btnProd_Eliminar.Size = new System.Drawing.Size(75, 23);
            this.btnProd_Eliminar.TabIndex = 13;
            this.btnProd_Eliminar.Text = "Eliminar";
            this.btnProd_Eliminar.UseVisualStyleBackColor = true;
            this.btnProd_Eliminar.Click += new System.EventHandler(this.btnProd_Eliminar_Click);
            // 
            // btnProd_Actualizar
            // 
            this.btnProd_Actualizar.Location = new System.Drawing.Point(586, 72);
            this.btnProd_Actualizar.Name = "btnProd_Actualizar";
            this.btnProd_Actualizar.Size = new System.Drawing.Size(75, 23);
            this.btnProd_Actualizar.TabIndex = 12;
            this.btnProd_Actualizar.Text = "Actualizar";
            this.btnProd_Actualizar.UseVisualStyleBackColor = true;
            this.btnProd_Actualizar.Click += new System.EventHandler(this.btnProd_Actualizar_Click);
            // 
            // btnProd_Agregar
            // 
            this.btnProd_Agregar.Location = new System.Drawing.Point(586, 38);
            this.btnProd_Agregar.Name = "btnProd_Agregar";
            this.btnProd_Agregar.Size = new System.Drawing.Size(75, 23);
            this.btnProd_Agregar.TabIndex = 11;
            this.btnProd_Agregar.Text = "Agregar";
            this.btnProd_Agregar.UseVisualStyleBackColor = true;
            this.btnProd_Agregar.Click += new System.EventHandler(this.btnProd_Agregar_Click);
            // 
            // cmbProd_Proveedor
            // 
            this.cmbProd_Proveedor.FormattingEnabled = true;
            this.cmbProd_Proveedor.Location = new System.Drawing.Point(339, 51);
            this.cmbProd_Proveedor.Name = "cmbProd_Proveedor";
            this.cmbProd_Proveedor.Size = new System.Drawing.Size(121, 21);
            this.cmbProd_Proveedor.TabIndex = 10;
            // 
            // cmbProd_Presentacion
            // 
            this.cmbProd_Presentacion.FormattingEnabled = true;
            this.cmbProd_Presentacion.Location = new System.Drawing.Point(339, 87);
            this.cmbProd_Presentacion.Name = "cmbProd_Presentacion";
            this.cmbProd_Presentacion.Size = new System.Drawing.Size(121, 21);
            this.cmbProd_Presentacion.TabIndex = 9;
            // 
            // txtProd_Pventa
            // 
            this.txtProd_Pventa.Location = new System.Drawing.Point(89, 145);
            this.txtProd_Pventa.Name = "txtProd_Pventa";
            this.txtProd_Pventa.Size = new System.Drawing.Size(100, 20);
            this.txtProd_Pventa.TabIndex = 8;
            // 
            // txtProd_Pcompra
            // 
            this.txtProd_Pcompra.Location = new System.Drawing.Point(89, 115);
            this.txtProd_Pcompra.Name = "txtProd_Pcompra";
            this.txtProd_Pcompra.Size = new System.Drawing.Size(100, 20);
            this.txtProd_Pcompra.TabIndex = 7;
            // 
            // txtProd_Descripcion
            // 
            this.txtProd_Descripcion.Location = new System.Drawing.Point(89, 84);
            this.txtProd_Descripcion.Name = "txtProd_Descripcion";
            this.txtProd_Descripcion.Size = new System.Drawing.Size(100, 20);
            this.txtProd_Descripcion.TabIndex = 6;
            // 
            // txtProd_Nombre
            // 
            this.txtProd_Nombre.Location = new System.Drawing.Point(89, 51);
            this.txtProd_Nombre.Name = "txtProd_Nombre";
            this.txtProd_Nombre.Size = new System.Drawing.Size(100, 20);
            this.txtProd_Nombre.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Precio Compra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Precio Venta";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnStock_Disminuir);
            this.tabPage2.Controls.Add(this.btnStock_Agregar);
            this.tabPage2.Controls.Add(this.txtStock_Cod);
            this.tabPage2.Controls.Add(this.txtStock_Nom);
            this.tabPage2.Controls.Add(this.txtStock_Actual);
            this.tabPage2.Controls.Add(this.txtStock_Cantidad);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.tblStock);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(709, 382);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Stock";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tblStock
            // 
            this.tblStock.AllowUserToAddRows = false;
            this.tblStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblStock.Location = new System.Drawing.Point(6, 192);
            this.tblStock.Name = "tblStock";
            this.tblStock.ReadOnly = true;
            this.tblStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblStock.Size = new System.Drawing.Size(697, 184);
            this.tblStock.TabIndex = 0;
            this.tblStock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblStock_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Codigo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Nombre";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Cantidad";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(233, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Stock Actual";
            // 
            // txtStock_Cantidad
            // 
            this.txtStock_Cantidad.Location = new System.Drawing.Point(104, 132);
            this.txtStock_Cantidad.Name = "txtStock_Cantidad";
            this.txtStock_Cantidad.Size = new System.Drawing.Size(100, 20);
            this.txtStock_Cantidad.TabIndex = 5;
            // 
            // txtStock_Actual
            // 
            this.txtStock_Actual.Location = new System.Drawing.Point(307, 77);
            this.txtStock_Actual.Name = "txtStock_Actual";
            this.txtStock_Actual.Size = new System.Drawing.Size(100, 20);
            this.txtStock_Actual.TabIndex = 6;
            // 
            // txtStock_Nom
            // 
            this.txtStock_Nom.Location = new System.Drawing.Point(104, 77);
            this.txtStock_Nom.Name = "txtStock_Nom";
            this.txtStock_Nom.Size = new System.Drawing.Size(100, 20);
            this.txtStock_Nom.TabIndex = 7;
            // 
            // txtStock_Cod
            // 
            this.txtStock_Cod.Location = new System.Drawing.Point(104, 51);
            this.txtStock_Cod.Name = "txtStock_Cod";
            this.txtStock_Cod.Size = new System.Drawing.Size(100, 20);
            this.txtStock_Cod.TabIndex = 8;
            // 
            // btnStock_Agregar
            // 
            this.btnStock_Agregar.Location = new System.Drawing.Point(502, 163);
            this.btnStock_Agregar.Name = "btnStock_Agregar";
            this.btnStock_Agregar.Size = new System.Drawing.Size(75, 23);
            this.btnStock_Agregar.TabIndex = 9;
            this.btnStock_Agregar.Text = "Agregar";
            this.btnStock_Agregar.UseVisualStyleBackColor = true;
            this.btnStock_Agregar.Click += new System.EventHandler(this.btnStock_Agregar_Click);
            // 
            // btnStock_Disminuir
            // 
            this.btnStock_Disminuir.Location = new System.Drawing.Point(583, 163);
            this.btnStock_Disminuir.Name = "btnStock_Disminuir";
            this.btnStock_Disminuir.Size = new System.Drawing.Size(75, 23);
            this.btnStock_Disminuir.TabIndex = 10;
            this.btnStock_Disminuir.Text = "Disminuir";
            this.btnStock_Disminuir.UseVisualStyleBackColor = true;
            this.btnStock_Disminuir.Click += new System.EventHandler(this.btnStock_Disminuir_Click);
            // 
            // Vproducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 432);
            this.Controls.Add(this.tabControl1);
            this.Name = "Vproducto";
            this.Text = "Vproducto";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblProductos)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnProd_Nuevo;
        private System.Windows.Forms.Button btnProd_Eliminar;
        private System.Windows.Forms.Button btnProd_Actualizar;
        private System.Windows.Forms.Button btnProd_Agregar;
        private System.Windows.Forms.ComboBox cmbProd_Proveedor;
        private System.Windows.Forms.ComboBox cmbProd_Presentacion;
        private System.Windows.Forms.TextBox txtProd_Pcompra;
        private System.Windows.Forms.TextBox txtProd_Descripcion;
        private System.Windows.Forms.TextBox txtProd_Nombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProd_Pventa;
        private System.Windows.Forms.DataGridView tblProductos;
        private System.Windows.Forms.DataGridView tblStock;
        private System.Windows.Forms.TextBox txtProd_Codigo;
        private System.Windows.Forms.Button btnStock_Disminuir;
        private System.Windows.Forms.Button btnStock_Agregar;
        private System.Windows.Forms.TextBox txtStock_Cod;
        private System.Windows.Forms.TextBox txtStock_Nom;
        private System.Windows.Forms.TextBox txtStock_Actual;
        private System.Windows.Forms.TextBox txtStock_Cantidad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}