namespace WindowsFormsApp1
{
    partial class MainPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mANTENIMIENTOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.fACTURASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cONSULTASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mANTENIMIENTOToolStripMenuItem,
            this.fACTURASToolStripMenuItem,
            this.cONSULTASToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mANTENIMIENTOToolStripMenuItem
            // 
            this.mANTENIMIENTOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuClientes,
            this.menuProductos,
            this.menuProveedores});
            this.mANTENIMIENTOToolStripMenuItem.Name = "mANTENIMIENTOToolStripMenuItem";
            this.mANTENIMIENTOToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.mANTENIMIENTOToolStripMenuItem.Text = "MANTENIMIENTO";
            // 
            // menuClientes
            // 
            this.menuClientes.Name = "menuClientes";
            this.menuClientes.Size = new System.Drawing.Size(180, 22);
            this.menuClientes.Text = "CLIENTES";
            this.menuClientes.Click += new System.EventHandler(this.menuClientes_Click);
            // 
            // menuProductos
            // 
            this.menuProductos.Name = "menuProductos";
            this.menuProductos.Size = new System.Drawing.Size(180, 22);
            this.menuProductos.Text = "PRODUCTOS";
            // 
            // menuProveedores
            // 
            this.menuProveedores.Name = "menuProveedores";
            this.menuProveedores.Size = new System.Drawing.Size(180, 22);
            this.menuProveedores.Text = "PROVEEDORES";
            // 
            // fACTURASToolStripMenuItem
            // 
            this.fACTURASToolStripMenuItem.Name = "fACTURASToolStripMenuItem";
            this.fACTURASToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.fACTURASToolStripMenuItem.Text = "FACTURAS";
            // 
            // cONSULTASToolStripMenuItem
            // 
            this.cONSULTASToolStripMenuItem.Name = "cONSULTASToolStripMenuItem";
            this.cONSULTASToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.cONSULTASToolStripMenuItem.Text = "CONSULTAS";
            // 
            // MainPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainPrincipal";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mANTENIMIENTOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuClientes;
        private System.Windows.Forms.ToolStripMenuItem menuProductos;
        private System.Windows.Forms.ToolStripMenuItem menuProveedores;
        private System.Windows.Forms.ToolStripMenuItem fACTURASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cONSULTASToolStripMenuItem;
    }
}

