using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SqlServerCe;

namespace AddressBook
{
    public partial class FormAddEntry : Form
    {
        MainWindow main;
        public FormAddEntry()
        {
            InitializeComponent();
        }

        public FormAddEntry(MainWindow main)
        {
            this.main = main;
            InitializeComponent();
        }

        private void BtnAddData_Click(object sender, EventArgs e)
        {

            SqlCeCommand query = new SqlCeCommand("INSERT INTO person(name,surname) VALUES('" + TbName.Text.ToString() + "', '" + TbSurname.Text.ToString() + "')", main.SQLconn);
            try
            {
                query.ExecuteNonQuery();
                MessageBox.Show(this, "Dodano!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Błąd: " + ex.Message.ToString(), "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            
        }
    }
}
