using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaOrderForm
{
    enum Sauce
    {
        NotChosen,
        None,
        Light,
        Normal,
        Heavy
    }

    [Flags]
    enum Topping
    {
        None = 0,
        Pepperoni = 2,
        Bacon = 4,
        Ham = 8, 
        Mushroom = 16,
        Pinapple = 32,
        Tomato = 64,
        GreenPeppers = 128,
        Onion = 256,
        Spinach = 512,
        OliveBlack = 1024,
        OliveGreen = 2048
    }

    enum Cheese
    {
        NotChosen,
        None,
        Light,
        Normal,
        Heavy
    }

    /// <summary>
    /// this class is for storing pizza's info and generate the pizza info in string form
    /// </summary>
    class Pizza : RadioButton
    {
        //const values for pizza pie size and initial position
        const int PIZZA_SIDE_LENGTH = 140;
        const int PIZZA_OFFSET = 20;

        readonly int pizzaIndex;

        #region PizzaSelectionsFieldsAndProperties
        private Sauce _sauce;
        internal Sauce Sauce { get => _sauce; }

        private Topping _topping;
        internal Topping Topping { get => _topping; set => _topping = value; }

        private Cheese _cheese;
        internal Cheese Cheese { get => _cheese; }

        string specialInstructions;
        public string SpecialInfo { get => specialInstructions; } 
        #endregion

        public Pizza(int pizzaIndex)
        {
            //initialize the pizza selections
            _sauce = Sauce.NotChosen;
            _topping = Topping.None;
            _cheese = Cheese.NotChosen;
            specialInstructions = "";

            this.pizzaIndex = pizzaIndex;
            this.Size = new Size(PIZZA_SIDE_LENGTH, PIZZA_SIDE_LENGTH);
            this.Location = new Point(PIZZA_OFFSET, 
                                      (PIZZA_OFFSET + PIZZA_SIDE_LENGTH) * pizzaIndex + PIZZA_OFFSET);
            this.Appearance = Appearance.Button;
            this.BackgroundImage = Properties.Resources.pizza;
            this.BackgroundImageLayout = ImageLayout.Zoom;
        }

        /// <summary>
        /// to set the pizza sauce
        /// </summary>
        /// <param name="sauce"></param>
        public void SetPizzaSauce(Sauce sauce)
        {
            _sauce = sauce;
        }

        /// <summary>
        /// to set the pizza cheese
        /// </summary>
        /// <param name="cheese"></param>
        public void SetPizzaCheese(Cheese cheese)
        {
            _cheese = cheese;
        }

        /// <summary>
        /// to set the pizza's special instructions
        /// </summary>
        /// <param name="specialInstructions"></param>
        public void SetSpecialInstructions(string specialInstructions)
        {
            this.specialInstructions = specialInstructions;
        }

        /// <summary>
        /// to generate the pizza's info
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"Pizza #{pizzaIndex + 1}:");
            stringBuilder.AppendLine($"\tSauce: {_sauce}");
            stringBuilder.AppendLine($"\tTopping: {_topping}");
            stringBuilder.AppendLine($"\tCheese: {_cheese}");
            stringBuilder.AppendLine($"\tSpecial Instructions: {specialInstructions}");

            return stringBuilder.ToString();
        }
    }
}
        