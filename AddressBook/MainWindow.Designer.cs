namespace AddressBook
{
    partial class MainWindow
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
            this.BtnConnect = new System.Windows.Forms.Button();
            this.BtnDisconnect = new System.Windows.Forms.Button();
            this.LblConnection = new System.Windows.Forms.Label();
            this.LBoxLog = new System.Windows.Forms.ListBox();
            this.BtnGetData = new System.Windows.Forms.Button();
            this.BtnAddData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnConnect
            // 
            this.BtnConnect.Location = new System.Drawing.Point(12, 12);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(126, 23);
            this.BtnConnect.TabIndex = 0;
            this.BtnConnect.Text = "Połącz";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // BtnDisconnect
            // 
            this.BtnDisconnect.Enabled = false;
            this.BtnDisconnect.Location = new System.Drawing.Point(149, 12);
            this.BtnDisconnect.Name = "BtnDisconnect";
            this.BtnDisconnect.Size = new System.Drawing.Size(123, 23);
            this.BtnDisconnect.TabIndex = 1;
            this.BtnDisconnect.Text = "Rozłącz";
            this.BtnDisconnect.UseVisualStyleBackColor = true;
            this.BtnDisconnect.Click += new System.EventHandler(this.BtnDisconnect_Click);
            // 
            // LblConnection
            // 
            this.LblConnection.AutoSize = true;
            this.LblConnection.Location = new System.Drawing.Point(9, 240);
            this.LblConnection.Name = "LblConnection";
            this.LblConnection.Size = new System.Drawing.Size(137, 13);
            this.LblConnection.TabIndex = 2;
            this.LblConnection.Text = "Rozłączono z bazą dancyh";
            // 
            // LBoxLog
            // 
            this.LBoxLog.FormattingEnabled = true;
            this.LBoxLog.Location = new System.Drawing.Point(12, 168);
            this.LBoxLog.Name = "LBoxLog";
            this.LBoxLog.Size = new System.Drawing.Size(260, 69);
            this.LBoxLog.TabIndex = 3;
            // 
            // BtnGetData
            // 
            this.BtnGetData.Enabled = false;
            this.BtnGetData.Location = new System.Drawing.Point(12, 41);
            this.BtnGetData.Name = "BtnGetData";
            this.BtnGetData.Size = new System.Drawing.Size(126, 23);
            this.BtnGetData.TabIndex = 4;
            this.BtnGetData.Text = "Pobierz dane";
            this.BtnGetData.UseVisualStyleBackColor = true;
            this.BtnGetData.Click += new System.EventHandler(this.BtnGetData_Click);
            // 
            // BtnAddData
            // 
            this.BtnAddData.Enabled = false;
            this.BtnAddData.Location = new System.Drawing.Point(149, 41);
            this.BtnAddData.Name = "BtnAddData";
            this.BtnAddData.Size = new System.Drawing.Size(123, 23);
            this.BtnAddData.TabIndex = 5;
            this.BtnAddData.Text = "Dodaj wpis";
            this.BtnAddData.UseVisualStyleBackColor = true;
            this.BtnAddData.Click += new System.EventHandler(this.BtnAddData_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.BtnAddData);
            this.Controls.Add(this.BtnGetData);
            this.Controls.Add(this.LBoxLog);
            this.Controls.Add(this.LblConnection);
            this.Controls.Add(this.BtnDisconnect);
            this.Controls.Add(this.BtnConnect);
            this.Name = "MainWindow";
            this.Text = "Książka adresowa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.Button BtnDisconnect;
        private System.Windows.Forms.Label LblConnection;
        private System.Windows.Forms.ListBox LBoxLog;
        private System.Windows.Forms.Button BtnGetData;
        private System.Windows.Forms.Button BtnAddData;
    }
}

