using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Microfinance
{
    public partial class frm_Initial_Deposit : Form
    {
        public frm_Initial_Deposit()
        {
            InitializeComponent();
        }

        private void btnSave_InitialDeposit_Click(object sender, EventArgs e)
        {

        }

        private void frm_Initial_Deposit_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmHome homepg = new frmHome();
            this.Hide();
            homepg.Show();
            
           

        }
    }
}
