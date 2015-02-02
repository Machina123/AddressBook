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
    public partial class MainWindow : Form
    {

        string ConnStringCI = @"Data Source=database1.sdf; Password='123';LCID=1033";
        string ConnStringCS = @"Data Source=database1.sdf; Password='123'; LCID=1033; Case Sensitive=true";

        public SqlCeConnection SQLconn = null;

        public void UpgradeWithCaseSens()
        {
            SqlCeEngine Engine = new SqlCeEngine(ConnStringCI);
            Engine.Upgrade(ConnStringCS);
            SQLconn = new SqlCeConnection(ConnStringCI);
            SQLconn.Open();

            List<KeyValuePair<string, string>> DBInfo = SQLconn.GetDatabaseInfo();

            LBoxLog.Items.Add("\nGetDatabaseInfo() results:");

            foreach (KeyValuePair<string, string> kvp in DBInfo)
            {
                LBoxLog.Items.Add(kvp);
            }
        }

        public MainWindow()
        {
            InitializeComponent();
#if(DEBUG)
            FormDisplay fd = new FormDisplay(this);
            fd.Show();
#endif
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                SQLconn = new SqlCeConnection(ConnStringCI);
                SQLconn.Open();
                LBoxLog.Items.Clear();
            }
            catch (SqlCeInvalidDatabaseFormatException)
            {
                this.UpgradeWithCaseSens();
            }

            switch (SQLconn.State.ToString())
            {
                case "Open":
                    LblConnection.Text = "Połączenie nawiązane";
                    break;
                case "Closed":
                    LblConnection.Text = "Połączenie zamknięte";
                    break;
                default:
                    LblConnection.Text = SQLconn.State.ToString();
                    break;
            }
            BtnConnect.Enabled = false;
            BtnGetData.Enabled = true;
            BtnAddData.Enabled = true;
            BtnDisconnect.Enabled = true;

        }

        private void BtnDisconnect_Click(object sender, EventArgs e)
        {
            SQLconn.Close();
            switch (SQLconn.State.ToString()) {
                case "Open": 
                    LblConnection.Text = "Połączenie nawiązane";
                    break;
                case "Closed":
                    LblConnection.Text = "Połączenie zamknięte";
                    break;
                default:
                    LblConnection.Text = SQLconn.State.ToString();
                    break;
            }

            BtnConnect.Enabled = true;
            BtnDisconnect.Enabled = false;
            BtnGetData.Enabled = false;
            BtnAddData.Enabled = false;
        }

        private void BtnGetData_Click(object sender, EventArgs e)
        {
            SqlCeCommand query = new SqlCeCommand("SELECT * FROM person", SQLconn);
            LBoxLog.Items.Clear();
            query.ExecuteNonQuery();

            using (var lineText = query.ExecuteReader())
            {
                while (lineText.Read())
                {
                    LBoxLog.Items.Add(lineText["id"].ToString() + ". " + lineText["name"].ToString() + " " + lineText["surname"].ToString());
                }
            }
        }

        private void BtnAddData_Click(object sender, EventArgs e)
        {
            FormAddEntry f = new FormAddEntry(this);
            f.Owner = this;
            f.Show();
        }


    }
}