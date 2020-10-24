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
    public partial class QueingForm : Form
    {
        public QueingForm()
        {
            InitializeComponent();
        }

        private CashierClass cashier = new CashierClass();
        private void btnCashier_Click(object sender, EventArgs e)
        {
            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getNumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getNumberInQueue);
        }

        private void btnWindow_Click(object sender, EventArgs e)
        {
            CashierWindowQueueForm cwq = new CashierWindowQueueForm();
            cwq.ShowDialog();
        }
    }
}
