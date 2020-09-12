namespace WindowsFormsApp1
{
    partial class Vcliente
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
            this.tblCliente = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tblCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // tblCliente
            // 
            this.tblCliente.AllowUserToAddRows = false;
            this.tblCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblCliente.Location = new System.Drawing.Point(12, 232);
            this.tblCliente.Name = "tblCliente";
            this.tblCliente.ReadOnly = true;
            this.tblCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblCliente.Size = new System.Drawing.Size(697, 206);
            this.tblCliente.TabIndex = 0;
            // 
            // Vcliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 450);
            this.Controls.Add(this.tblCliente);
            this.Name = "Vcliente";
            this.Text = "Vcliente";
            ((System.ComponentModel.ISupportInitialize)(this.tblCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tblCliente;
    }
}