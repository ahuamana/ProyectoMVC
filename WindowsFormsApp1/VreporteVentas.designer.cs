namespace WindowsFormsApp1
{
    partial class formularioEnvio
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
            this.btnthisMonth = new System.Windows.Forms.Button();
            this.dateTimePickerToDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFromDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCustom = new System.Windows.Forms.Button();
            this.btnThisYear = new System.Windows.Forms.Button();
            this.btnLast30Days = new System.Windows.Forms.Button();
            this.btnLast7Days = new System.Windows.Forms.Button();
            this.btnToday = new System.Windows.Forms.Button();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.btnMininize = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMininize)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnthisMonth);
            this.panel1.Controls.Add(this.dateTimePickerToDate);
            this.panel1.Controls.Add(this.dateTimePickerFromDate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnApply);
            this.panel1.Controls.Add(this.btnCustom);
            this.panel1.Controls.Add(this.btnThisYear);
            this.panel1.Controls.Add(this.btnLast30Days);
            this.panel1.Controls.Add(this.btnLast7Days);
            this.panel1.Controls.Add(this.btnToday);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 506);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btnthisMonth
            // 
            this.btnthisMonth.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnthisMonth.FlatAppearance.BorderSize = 0;
            this.btnthisMonth.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnthisMonth.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnthisMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnthisMonth.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnthisMonth.Location = new System.Drawing.Point(22, 110);
            this.btnthisMonth.Name = "btnthisMonth";
            this.btnthisMonth.Size = new System.Drawing.Size(157, 43);
            this.btnthisMonth.TabIndex = 10;
            this.btnthisMonth.Text = "Este Mes";
            this.btnthisMonth.UseVisualStyleBackColor = false;
            this.btnthisMonth.Click += new System.EventHandler(this.btnthisMonth_Click);
            // 
            // dateTimePickerToDate
            // 
            this.dateTimePickerToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerToDate.Location = new System.Drawing.Point(73, 350);
            this.dateTimePickerToDate.Name = "dateTimePickerToDate";
            this.dateTimePickerToDate.Size = new System.Drawing.Size(106, 20);
            this.dateTimePickerToDate.TabIndex = 9;
            // 
            // dateTimePickerFromDate
            // 
            this.dateTimePickerFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFromDate.Location = new System.Drawing.Point(73, 313);
            this.dateTimePickerFromDate.Name = "dateTimePickerFromDate";
            this.dateTimePickerFromDate.Size = new System.Drawing.Size(106, 20);
            this.dateTimePickerFromDate.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hasta: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Desde:";
            // 
            // btnApply
            // 
            this.btnApply.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnApply.FlatAppearance.BorderSize = 0;
            this.btnApply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnApply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnApply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApply.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApply.Location = new System.Drawing.Point(22, 397);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(157, 43);
            this.btnApply.TabIndex = 5;
            this.btnApply.Text = "Aplicar";
            this.btnApply.UseVisualStyleBackColor = false;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCustom
            // 
            this.btnCustom.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCustom.Enabled = false;
            this.btnCustom.FlatAppearance.BorderSize = 0;
            this.btnCustom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustom.Location = new System.Drawing.Point(22, 257);
            this.btnCustom.Name = "btnCustom";
            this.btnCustom.Size = new System.Drawing.Size(157, 43);
            this.btnCustom.TabIndex = 4;
            this.btnCustom.Text = "Personalizado";
            this.btnCustom.UseVisualStyleBackColor = false;
            this.btnCustom.Click += new System.EventHandler(this.btnCustom_Click);
            // 
            // btnThisYear
            // 
            this.btnThisYear.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThisYear.FlatAppearance.BorderSize = 0;
            this.btnThisYear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnThisYear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnThisYear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThisYear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThisYear.Location = new System.Drawing.Point(22, 208);
            this.btnThisYear.Name = "btnThisYear";
            this.btnThisYear.Size = new System.Drawing.Size(157, 43);
            this.btnThisYear.TabIndex = 3;
            this.btnThisYear.Text = "Este Año";
            this.btnThisYear.UseVisualStyleBackColor = false;
            this.btnThisYear.Click += new System.EventHandler(this.btnThisYear_Click);
            // 
            // btnLast30Days
            // 
            this.btnLast30Days.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLast30Days.FlatAppearance.BorderSize = 0;
            this.btnLast30Days.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLast30Days.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnLast30Days.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast30Days.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLast30Days.Location = new System.Drawing.Point(22, 159);
            this.btnLast30Days.Name = "btnLast30Days";
            this.btnLast30Days.Size = new System.Drawing.Size(157, 43);
            this.btnLast30Days.TabIndex = 2;
            this.btnLast30Days.Text = "Ultimos 30 Dias";
            this.btnLast30Days.UseVisualStyleBackColor = false;
            this.btnLast30Days.Click += new System.EventHandler(this.btnLast30Days_Click);
            // 
            // btnLast7Days
            // 
            this.btnLast7Days.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLast7Days.FlatAppearance.BorderSize = 0;
            this.btnLast7Days.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnLast7Days.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnLast7Days.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLast7Days.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLast7Days.Location = new System.Drawing.Point(22, 61);
            this.btnLast7Days.Name = "btnLast7Days";
            this.btnLast7Days.Size = new System.Drawing.Size(157, 43);
            this.btnLast7Days.TabIndex = 1;
            this.btnLast7Days.Text = "Ultimos 7 Dias";
            this.btnLast7Days.UseVisualStyleBackColor = false;
            this.btnLast7Days.Click += new System.EventHandler(this.btnLast7Days_Click_1);
            // 
            // btnToday
            // 
            this.btnToday.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnToday.FlatAppearance.BorderSize = 0;
            this.btnToday.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnToday.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnToday.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToday.Location = new System.Drawing.Point(22, 12);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(157, 43);
            this.btnToday.TabIndex = 0;
            this.btnToday.Text = "Hoy";
            this.btnToday.UseVisualStyleBackColor = false;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click_1);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(200, 40);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(875, 506);
            this.reportViewer1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::WindowsFormsApp1.Properties.Resources.outline_highlight_off_white_18dp2;
            this.btnClose.Location = new System.Drawing.Point(1023, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 35);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 3;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMininize
            // 
            this.btnMininize.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMininize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMininize.Image = global::WindowsFormsApp1.Properties.Resources.outline_minimize_white_18dp1;
            this.btnMininize.Location = new System.Drawing.Point(982, -12);
            this.btnMininize.Name = "btnMininize";
            this.btnMininize.Size = new System.Drawing.Size(35, 45);
            this.btnMininize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMininize.TabIndex = 4;
            this.btnMininize.TabStop = false;
            this.btnMininize.Click += new System.EventHandler(this.btnMininize_Click);
            // 
            // formularioEnvio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(1075, 546);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnMininize);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formularioEnvio";
            this.Padding = new System.Windows.Forms.Padding(0, 40, 0, 0);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formularioEnvio";
            this.Load += new System.EventHandler(this.formularioEnvio_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.formularioEnvio_MouseDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMininize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLast7Days;
        private System.Windows.Forms.Button btnToday;
        private System.Windows.Forms.Button btnCustom;
        private System.Windows.Forms.Button btnThisYear;
        private System.Windows.Forms.Button btnLast30Days;
        private System.Windows.Forms.DateTimePicker dateTimePickerToDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerFromDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnthisMonth;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox btnMininize;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}