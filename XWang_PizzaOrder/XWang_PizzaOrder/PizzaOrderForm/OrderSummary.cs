using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaOrderForm
{
    public partial class OrderSummary : Form
    {
        public OrderSummary()
        {
            InitializeComponent();
        }

        /// <summary>
        /// generate the order summary when the form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderSummary_Load(object sender, EventArgs e)
        {
            OrderingForm orderingForm = (OrderingForm)Owner;
            txtOrderSummary.Text = orderingForm.GetPizzaSummary();
        }

        /// <summary>
        /// to reset the ordering form to get ready for a new order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnStartNewOrder_Click(object sender, EventArgs e)
        {
            OrderingForm orderingForm = (OrderingForm)Owner;
            this.Close();
            orderingForm.ResetOrderingForm();
        }

        /// <summary>
        /// to exit the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// to close the order summary form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEditCurrentOrder_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
