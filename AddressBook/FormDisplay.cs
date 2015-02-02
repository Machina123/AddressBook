using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook
{
    public partial class FormDisplay : Form
    {
        MainWindow main;

        public FormDisplay()
        {
            InitializeComponent();
        }

        public FormDisplay(MainWindow arg0)
        {
            this.main = arg0;
            InitializeComponent();
        }


        private void menuAdd_Click(object sender, EventArgs e)
        {

        }

        private void menuEdit_Click(object sender, EventArgs e)
        {

        }

        private void menuDelete_Click(object sender, EventArgs e)
        {

        }

        private void menuFind_Click(object sender, EventArgs e)
        {

        }

        private void menuRefresh_Click(object sender, EventArgs e)
        {

        }

    }
}
