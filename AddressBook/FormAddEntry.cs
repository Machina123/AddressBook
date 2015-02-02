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
        FormDisplay main;

        private FormRole role;
        private int editedEntryID;

        public enum FormRole : int
        {
            ROLE_ADD = 1,
            ROLE_EDIT = 2
        };

        public FormAddEntry()
        {
            role = FormRole.ROLE_ADD;
            InitializeComponent();
        }

        public FormAddEntry(FormDisplay main, FormRole role)
        {
            this.main = main;
            this.role = role;
            InitializeComponent();
        }

        public FormAddEntry(FormDisplay main, FormRole role, int EditedID)
        {
            this.main = main;
            this.role = role;
            this.editedEntryID = EditedID;
            InitializeComponent();

        }

        private void BtnAddData_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            switch (role)
            {
                case FormRole.ROLE_ADD:
                    sb.Append("INSERT INTO person(name,surname,phone,email,age,gender) VALUES(");
                    sb.Append("'" + TbName.Text.ToString() + "',");
                    sb.Append("'" + TbSurname.Text.ToString() + "',");
                    sb.Append("'" + tbPhone.Text.ToString() + "',");
                    sb.Append("'" + tbEmail.Text.ToString() + "',");
                    sb.Append("'" + tbAge.Text.ToString() + "',");
                    sb.Append("'" + comboGender.Text.ToString() + "')");
                    break;
                case FormRole.ROLE_EDIT:
                    sb.Append("UPDATE person SET ");
                    sb.Append("name='" + TbName.Text.ToString() + "', ");
                    sb.Append("surname='" + TbSurname.Text.ToString() + "', ");
                    sb.Append("phone='" + tbPhone.Text.ToString() + "', ");
                    sb.Append("email='" + tbEmail.Text.ToString() + "', ");
                    sb.Append("age='" + tbAge.Text.ToString() + "', ");
                    sb.Append("gender='" + comboGender.Text.ToString() + "' ");
                    sb.Append("WHERE id=").Append(editedEntryID).Append(";");
                    break;
                default:
                    break;
            }


            SqlCeCommand query = new SqlCeCommand(sb.ToString(), main.SQLconn);
            try
            {
                query.ExecuteNonQuery();
                switch (role)
                {
                    case FormRole.ROLE_ADD:
                        MessageBox.Show(this, "Dodano!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case FormRole.ROLE_EDIT:
                        MessageBox.Show(this, "Zapisano zmiany!", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }
                main.CallRefresh();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Błąd: " + ex.Message.ToString(), "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


            }

        }

        private void FormAddEntry_Load(object sender, EventArgs e)
        {
            switch (role)
            {
                case FormRole.ROLE_ADD:
                    this.Text = "Dodawanie wpisu";
                    this.BtnAddData.Text = "Dodaj wpis";
                    break;

                case FormRole.ROLE_EDIT:
                    string cmd = "SELECT * FROM person WHERE id=" + editedEntryID;
                    SqlCeCommand command = new SqlCeCommand(cmd, main.SQLconn);
                    command.ExecuteNonQuery();

                    using (var row = command.ExecuteReader()) 
                    {
                        while (row.Read())
                        {
                            this.TbName.Text = row["name"].ToString();
                            this.TbSurname.Text = row["surname"].ToString();
                            this.tbPhone.Text = row["phone"].ToString();
                            this.tbEmail.Text = row["email"].ToString();
                            this.comboGender.Text = row["gender"].ToString();
                            this.tbAge.Text = row["age"].ToString();
                        }
                    }

                    this.Text = "Edycja wpisu ID:" + editedEntryID;
                    this.BtnAddData.Text = "Zapisz zmiany";
                    break;
                default:
                    break;
            }
        }



    }
}
