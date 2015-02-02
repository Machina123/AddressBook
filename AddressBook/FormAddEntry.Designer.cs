namespace AddressBook
{
    partial class FormAddEntry
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TbName = new System.Windows.Forms.TextBox();
            this.TbSurname = new System.Windows.Forms.TextBox();
            this.BtnAddData = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Imię";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nazwisko";
            // 
            // TbName
            // 
            this.TbName.Location = new System.Drawing.Point(71, 12);
            this.TbName.Name = "TbName";
            this.TbName.Size = new System.Drawing.Size(177, 20);
            this.TbName.TabIndex = 2;
            // 
            // TbSurname
            // 
            this.TbSurname.Location = new System.Drawing.Point(71, 38);
            this.TbSurname.Name = "TbSurname";
            this.TbSurname.Size = new System.Drawing.Size(177, 20);
            this.TbSurname.TabIndex = 3;
            // 
            // BtnAddData
            // 
            this.BtnAddData.Location = new System.Drawing.Point(12, 64);
            this.BtnAddData.Name = "BtnAddData";
            this.BtnAddData.Size = new System.Drawing.Size(236, 23);
            this.BtnAddData.TabIndex = 4;
            this.BtnAddData.Text = "Dodaj wpis";
            this.BtnAddData.UseVisualStyleBackColor = true;
            this.BtnAddData.Click += new System.EventHandler(this.BtnAddData_Click);
            // 
            // FormAddEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 99);
            this.Controls.Add(this.BtnAddData);
            this.Controls.Add(this.TbSurname);
            this.Controls.Add(this.TbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAddEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dodawanie wpisu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbName;
        private System.Windows.Forms.TextBox TbSurname;
        private System.Windows.Forms.Button BtnAddData;
    }
}