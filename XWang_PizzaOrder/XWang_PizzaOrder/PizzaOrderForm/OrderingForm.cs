/***
 * Author: Xiaoyang Wang
 * Create Date: 
 * Discription: Assignment 1. 
 *              This is a comprehensive exercise to practice Windows Forms, especially the use of Tag property,
 *              and to familiar with creating class, inheritance and object concept.
 */
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
    public partial class OrderingForm : Form
    {
        Pizza activePizza;

        public OrderingForm()
        {
            InitializeComponent();
        }

        private void ResetRadioButtons(GroupBox grb)
        {
            foreach(RadioButton rdb in grb.Controls)
            {
                rdb.Checked = false;
            }
        }


        /// <summary>
        /// This is an event handler method for btnStartOrder,
        /// to limit the pizza number and create dynamic pizza instance
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnStartOrder_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtPizzaNumber.Text, out int pizzaNumber)
                            && pizzaNumber >= 1 && pizzaNumber <=9)
            {
                ClearPnlPizzaPiesAndPnlSelections();
                pnlPizzaPies.Enabled = true;

                for (int i = 0; i < pizzaNumber; i++)
                {
                    Pizza pizza = new Pizza(i);
                    pizza.CheckedChanged += Pizza_CheckedChanged;
                    pnlPizzaPies.Controls.Add(pizza);

                    //to initialise the activePizza, in case user forget to choose the first pizza
                    if (i == 0)
                    {
                        activePizza = pizza;
                    }
                    pnlSelections.Enabled = true;
                }
            }
            else
            {
                txtPizzaNumber.Clear();

                MessageBox.Show("You can only order 1-9 pizzas, please enter a number between 1 and 9.", "Reminding",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPizzaNumber.Focus();
            }
        }

        /// <summary>
        /// an event handler method for each radPizzaPie created, 
        /// to set the clicked pizza as activePizza and load the pizza's info on pnlSelections
        /// and call the LoadToppingInfo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Pizza_CheckedChanged(object sender, EventArgs e)
        {
            activePizza = (Pizza)sender;
            LoadPizzaInfo();
        }

        /// <summary>
        /// to load the pizza info on the pnlSelections
        /// </summary>
        private void LoadPizzaInfo()
        {
            LoadActiveSauceOrCheeseInfo(grbCheese);
            LoadActiveSauceOrCheeseInfo(grbSauce);
            LoadToppingInfo();
            txtSpecialInstructions.Text = activePizza.SpecialInfo;
        }

        /// <summary>
        /// to interate all check boxes in grbToppings and check the ones which in activePizza's topping
        /// </summary>
        private void LoadToppingInfo()
        {
            foreach(CheckBox chk in grbToppings.Controls)
            {
                if ((activePizza.Topping & (Topping)chk.Tag) == (Topping)chk.Tag)
                {
                    chk.Checked = true;
                }
                else
                {
                    chk.Checked = false;
                }
            }
        }

        /// <summary>
        /// to iterate all radio buttons in grbSauce or grbCheese to check the activePizza's sauce or cheese
        /// </summary>
        /// <param name="grb"></param>
        private void LoadActiveSauceOrCheeseInfo(GroupBox grb)
        {
            int checkedIndex;
            if (grb == grbCheese)
                checkedIndex = (int)activePizza.Cheese;
            else
                checkedIndex = (int)activePizza.Sauce;

            foreach(RadioButton rdb in grb.Controls)
            {
                if (checkedIndex != 0 && (int)rdb.Tag == checkedIndex)
                {
                    rdb.Checked = true;
                }
                else
                {
                    rdb.Checked = false;
                }
            }
        }

        /// <summary>
        /// this is an event handler method for btnCheckOut
        /// to show all pizzas summary in a new form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCheckOut_Click(object sender, EventArgs e)
        {
            txtPizzaNumber.Focus();
            OrderSummary orderSummary = new OrderSummary();
            orderSummary.ShowDialog(this);
        }

        /// <summary>
        /// this is an event handler method for form loading
        /// to set the tag of the checkboxes and radio buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrderingForm_Load(object sender, EventArgs e)
        {
            foreach(RadioButton rb in grbSauce.Controls)
            {
                rb.Tag = (Sauce)rb.TabIndex;
            }

            foreach(RadioButton rb in grbCheese.Controls)
            {
                rb.Tag = (Cheese)rb.TabIndex;
            }

            foreach(CheckBox cb in grbToppings.Controls)
            {
                cb.Tag = (Topping)cb.TabIndex;
            }
        }

        /// <summary>
        /// the event handler method for all the radio buttons in grbSauce
        /// to change the activePizza's sause according to the selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadSauce_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked)
            {
                activePizza.SetPizzaSauce((Sauce)rb.Tag);
            }
        }

        /// <summary>
        /// the event handler method for all the radio buttons in grbCheese
        /// to change the activePizza's cheese according to the selection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RadCheese_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked)
            {
                activePizza.SetPizzaCheese((Cheese)rb.Tag);
            }
        }

        /// <summary>
        /// the event handler method for all the check boxes in grbTopping
        /// to change the activePizza's topping according to the selection 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChkTopping_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            if (cb.Checked && (activePizza.Topping & (Topping)cb.Tag) != (Topping)cb.Tag)
            {
                activePizza.Topping ^= (Topping)cb.Tag;
            }
            else if (!cb.Checked && (activePizza.Topping & (Topping)cb.Tag) == (Topping)cb.Tag)
            {
                activePizza.Topping &= ~(Topping)cb.Tag;
            }
        }

        /// <summary>
        /// the event handler method when txtSpecialInstructions leave
        /// to change the activePizza's special instructions according to the input in the textbox 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtSpecialInstructions_Leave(object sender, EventArgs e)
        {
            activePizza.SetSpecialInstructions(txtSpecialInstructions.Text);
        }

        /// <summary>
        /// to build the order summary of all pizzas
        /// </summary>
        /// <returns></returns>
        internal string GetPizzaSummary()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("Order Summary:");
            foreach(Pizza pizza in pnlPizzaPies.Controls)
            {
                stringBuilder.AppendLine(pizza.ToString());
            }

            return stringBuilder.ToString();
        }

        /// <summary>
        /// to reset the ordering form to get ready for new order
        /// </summary>
        internal void ResetOrderingForm()
        {
            txtPizzaNumber.Clear();
            ClearPnlPizzaPiesAndPnlSelections();
            pnlPizzaPies.Enabled = false;
            pnlSelections.Enabled = false;
        }

        /// <summary>
        /// to clear all pizza and releted info
        /// </summary>
        private void ClearPnlPizzaPiesAndPnlSelections()
        {
            pnlPizzaPies.Controls.Clear();

            ResetRadioButtons(grbCheese);
            ResetRadioButtons(grbSauce);
            foreach (CheckBox chk in grbToppings.Controls)
            {
                chk.Checked = false;
            }
            txtSpecialInstructions.Clear();
        }
    }
}

