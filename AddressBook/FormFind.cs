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
    public partial class FormFind : Form
    {
        FormDisplay main;

        public FormFind()
        {
            InitializeComponent();
        }

        public FormFind(FormDisplay main)
        {
            this.main = main;
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count == 1)
            {
                try
                {
                    StringBuilder cmd = new StringBuilder();

                    cmd.Append("SELECT * FROM person WHERE ");
                    switch (listBox1.SelectedIndex)
                    {
                        case 0:
                            cmd.Append("UPPER(name) LIKE UPPER('");
                            break;
                        case 1:
                            cmd.Append("UPPER(surname) LIKE UPPER('");
                            break;
                        case 2:
                            cmd.Append("UPPER(phone) LIKE UPPER('");
                            break;
                        case 3:
                            cmd.Append("UPPER(email) LIKE UPPER('");
                            break;
                    }
                    cmd.Append("%").Append(tbParam.Text).Append("%');");

                    SqlCeCommand command = new SqlCeCommand(cmd.ToString(), main.SQLconn);

                    command.ExecuteNonQuery();
                    main.lblStatus1.Text = "Wyniki wyszukiwania";
                    main.listContacts.Items.Clear();

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

                            main.listContacts.Items.Add(item);
                        }
                    }
                }
                catch(Exception ex) {
                    MessageBox.Show(this, "Błąd: " + ex.Message.ToString(), "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            
        }

    }
}
