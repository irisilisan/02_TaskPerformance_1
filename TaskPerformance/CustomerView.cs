using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02TaskPerformance01
{
    public partial class CustomerView : Form
    {
        public CustomerView()
        {
            InitializeComponent();
        }

        private void lblDisplay_Click(object sender, EventArgs e)
        {

        }

        private void CustomerView_Load(object sender, EventArgs e)
        {
            try
            {
                lblDisplay.Text = CashierClass.CashierQueue.Peek();
            }
            catch (System.InvalidOperationException ex)
            {
                MessageBox.Show("No Tickets", "Message");
                this.Close();
            }
        }
    }
}
