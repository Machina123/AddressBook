using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AddressBook
{
    public partial class FormDisplay : Form
    {

        string ConnStringCI = @"Data Source=database1.sdf; Password='123'; LCID=1033";
        string ConnStringCS = @"Data Source=database1.sdf; Password='123'; LCID=1033; Case Sensitive=true";

        public SqlCeConnection SQLconn = null;

        public void UpgradeWithCaseSens()
        {
            SqlCeEngine Engine = new SqlCeEngine(ConnStringCI);
            Engine.Upgrade(ConnStringCS);
            SQLconn = new SqlCeConnection(ConnStringCI);
            SQLconn.Open();

        }

        private void FormDisplay_Load(object sender, EventArgs e)
        {
            try
            {
                SQLconn = new SqlCeConnection(ConnStringCI);
                SQLconn.Open();
                CallRefresh();
            }
            catch (SqlCeInvalidDatabaseFormatException)
            {
                this.UpgradeWithCaseSens();
            }

            switch (SQLconn.State.ToString())
            {
                case "Open":
                    lblStatus.Text = "Połączenie nawiązane";
                    break;
                case "Closed":
                    lblStatus.Text = "Połączenie zamknięte";
                    break;
                default:
                    lblStatus.Text = SQLconn.State.ToString();
                    break;
            }

        }

        public FormDisplay()
        {
            InitializeComponent();
        }

        private void menuAdd_Click(object sender, EventArgs e)
        {
            FormAddEntry f = new FormAddEntry(this, FormAddEntry.FormRole.ROLE_ADD);
            f.Owner = this;
            f.Show();
            f.Focus();
        }

        private void menuEdit_Click(object sender, EventArgs e)
        {
            CallEdit();
        }

        private void menuDelete_Click(object sender, EventArgs e)
        {
            CallDelete();
        }

        private void menuFind_Click(object sender, EventArgs e)
        {
            FormFind f = new FormFind(this);
            f.Owner = this;
            f.Show();
            f.Focus();
        }

        private void menuRefresh_Click(object sender, EventArgs e)
        {
            CallRefresh();
        }

        public void CallRefresh()
        {
            listContacts.Items.Clear();
            lblStatus1.Text = "Gotowy do pracy";
            string cmd = "SELECT * FROM person ORDER BY id ASC;";
            SqlCeCommand command = new SqlCeCommand(cmd, SQLconn);
            command.ExecuteNonQuery();

            using (var row = command.ExecuteReader())
            {
                while (row.Read())
                {
                    string[] i = new string[7];
                    i[0] = row["id"].ToString();
                    i[1] = row["name"].ToString();
                    i[2] = row["surname"].ToString();
                    i[3] = row["phone"].ToString();
                    i[4] = row["email"].ToString();
                    i[5] = row["gender"].ToString();
                    i[6] = row["age"].ToString();

                    ListViewItem item = new ListViewItem(i);

                    listContacts.Items.Add(item);
                }
            }
        }

        private void listContacts_DoubleClick(object sender, EventArgs e)
        {
            CallEdit();
        }

        private void edytujToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CallEdit();
        }

        private void CallEdit()
        {
            if (listContacts.SelectedItems.Count == 1)
            {
                try
                {
                    int id = int.Parse(listContacts.SelectedItems[0].Text);
                    FormAddEntry f = new FormAddEntry(this, FormAddEntry.FormRole.ROLE_EDIT, id);
                    f.Owner = this;
                    f.Show();
                    f.Focus();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Wystąpił błąd: " + ex.Message.ToString(), "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CallDelete()
        {
            if (listContacts.SelectedItems.Count == 1)
            {
                DialogResult toDelete = MessageBox.Show(this, "Czy na pewno chcesz usunąć ten wpis?", "Pytanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (toDelete == DialogResult.Yes)
                {
                    try
                    {
                        int id = int.Parse(listContacts.SelectedItems[0].Text);
                        SqlCeCommand query = new SqlCeCommand("DELETE FROM person WHERE id=" + id, SQLconn);
                        query.ExecuteNonQuery();
                        MessageBox.Show(this, "Wpis został usunięty!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CallRefresh();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Wystąpił błąd: " + ex.Message.ToString(), "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
            }
        }

        private void cntxDelete_Click(object sender, EventArgs e)
        {
            CallDelete();
        }
    }
}
