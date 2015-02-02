namespace AddressBook
{
    partial class FormDisplay
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFind = new System.Windows.Forms.ToolStripMenuItem();
            this.menuRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.listContacts = new System.Windows.Forms.ListView();
            this.colID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSurname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPhoneNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cntxEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.cntxDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAdd,
            this.menuEdit,
            this.menuDelete,
            this.menuFind,
            this.menuRefresh});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(793, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuAdd
            // 
            this.menuAdd.Name = "menuAdd";
            this.menuAdd.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.menuAdd.Size = new System.Drawing.Size(109, 20);
            this.menuAdd.Text = "Dodaj wpis... [F1]";
            this.menuAdd.Click += new System.EventHandler(this.menuAdd_Click);
            // 
            // menuEdit
            // 
            this.menuEdit.Name = "menuEdit";
            this.menuEdit.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.menuEdit.Size = new System.Drawing.Size(84, 20);
            this.menuEdit.Text = "Edytuj... [F2]";
            this.menuEdit.Click += new System.EventHandler(this.menuEdit_Click);
            // 
            // menuDelete
            // 
            this.menuDelete.Name = "menuDelete";
            this.menuDelete.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.menuDelete.Size = new System.Drawing.Size(78, 20);
            this.menuDelete.Text = "Usuń... [F3]";
            this.menuDelete.Click += new System.EventHandler(this.menuDelete_Click);
            // 
            // menuFind
            // 
            this.menuFind.Name = "menuFind";
            this.menuFind.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.menuFind.Size = new System.Drawing.Size(84, 20);
            this.menuFind.Text = "Szukaj... [F4]";
            this.menuFind.Click += new System.EventHandler(this.menuFind_Click);
            // 
            // menuRefresh
            // 
            this.menuRefresh.Name = "menuRefresh";
            this.menuRefresh.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.menuRefresh.Size = new System.Drawing.Size(95, 20);
            this.menuRefresh.Text = "Odśwież... [F5]";
            this.menuRefresh.Click += new System.EventHandler(this.menuRefresh_Click);
            // 
            // listContacts
            // 
            this.listContacts.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listContacts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colID,
            this.colName,
            this.colSurname,
            this.colPhoneNo,
            this.colEmail,
            this.colGender,
            this.colAge});
            this.listContacts.ContextMenuStrip = this.contextMenuStrip1;
            this.listContacts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listContacts.FullRowSelect = true;
            this.listContacts.Location = new System.Drawing.Point(0, 24);
            this.listContacts.MultiSelect = false;
            this.listContacts.Name = "listContacts";
            this.listContacts.Size = new System.Drawing.Size(793, 385);
            this.listContacts.TabIndex = 1;
            this.listContacts.UseCompatibleStateImageBehavior = false;
            this.listContacts.View = System.Windows.Forms.View.Details;
            this.listContacts.DoubleClick += new System.EventHandler(this.listContacts_DoubleClick);
            // 
            // colID
            // 
            this.colID.Tag = "ID";
            this.colID.Text = "ID";
            this.colID.Width = 40;
            // 
            // colName
            // 
            this.colName.Tag = "Name";
            this.colName.Text = "Imię";
            this.colName.Width = 100;
            // 
            // colSurname
            // 
            this.colSurname.Tag = "Surname";
            this.colSurname.Text = "Nazwisko";
            this.colSurname.Width = 150;
            // 
            // colPhoneNo
            // 
            this.colPhoneNo.Text = "Telefon";
            this.colPhoneNo.Width = 100;
            // 
            // colEmail
            // 
            this.colEmail.Text = "Adres e-mail";
            this.colEmail.Width = 200;
            // 
            // colGender
            // 
            this.colGender.Text = "Płeć";
            // 
            // colAge
            // 
            this.colAge.Text = "Wiek";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 387);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(793, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(140, 17);
            this.lblStatus.Text = "Połączenie z bazą danych";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cntxEdit,
            this.cntxDelete});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 70);
            this.contextMenuStrip1.Text = "Opcje...";
            // 
            // cntxEdit
            // 
            this.cntxEdit.Name = "cntxEdit";
            this.cntxEdit.Size = new System.Drawing.Size(152, 22);
            this.cntxEdit.Text = "Edytuj";
            this.cntxEdit.Click += new System.EventHandler(this.edytujToolStripMenuItem_Click);
            // 
            // cntxDelete
            // 
            this.cntxDelete.Name = "cntxDelete";
            this.cntxDelete.Size = new System.Drawing.Size(152, 22);
            this.cntxDelete.Text = "Usuń";
            this.cntxDelete.Click += new System.EventHandler(this.cntxDelete_Click);
            // 
            // FormDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 409);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.listContacts);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormDisplay";
            this.Text = "Moje kontakty";
            this.Load += new System.EventHandler(this.FormDisplay_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colSurname;
        private System.Windows.Forms.ListView listContacts;
        private System.Windows.Forms.ColumnHeader colPhoneNo;
        private System.Windows.Forms.ColumnHeader colEmail;
        private System.Windows.Forms.ToolStripMenuItem menuRefresh;
        private System.Windows.Forms.ToolStripMenuItem menuAdd;
        private System.Windows.Forms.ToolStripMenuItem menuEdit;
        private System.Windows.Forms.ToolStripMenuItem menuDelete;
        private System.Windows.Forms.ToolStripMenuItem menuFind;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ColumnHeader colGender;
        private System.Windows.Forms.ColumnHeader colAge;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cntxEdit;
        private System.Windows.Forms.ToolStripMenuItem cntxDelete;

    }
}