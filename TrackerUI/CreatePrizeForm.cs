using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess;

namespace TrackerUI
{
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        private bool ValidateForm()
        {
            bool output = true;
            int placeNumber = 0;

            bool placeNumberValidNumber = int.TryParse(textBoxPlaceNumberValue.Text, out placeNumber);
            if (!placeNumberValidNumber)
            {
                output = false;
            }
            if (placeNumber < 1)
            {
                output = false;
            }
            if (textBoxPlaceNumberValue.Text.Length == 0)
            {
                output = false;
            }

            decimal prizeAmount = 0;
            double prizePercentage = 0;

            bool prizeAmountValid = decimal.TryParse(textBoxPrizeAmountValue.Text, out prizeAmount);
            bool prizePercentageValid = double.TryParse(textBoxPrizeAmountValue.Text, out prizePercentage);

            if (!prizeAmountValid || !prizePercentageValid)
            {
                output = false;
            }

            if (prizeAmount <= 0 && prizePercentage <= 0)
            {
                output = false;
            }

            if (prizePercentage < 0 || prizePercentage > 100)
            {
                output = false;
            }

            return output;
        }

        private void buttonCreatePrize_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                PrizeModel model = new PrizeModel(
                    textBoxPlaceNameValue.Text,
                    textBoxPlaceNumberValue.Text,
                    textBoxPrizeAmountValue.Text,
                    textBoxPrizePercentageValue.Text);
                foreach (IDataConnection db in GlobalConfig.Connections)
                {
                    db.CreatePrize(model);
                }
                textBoxPlaceNameValue.Text = "";
                textBoxPlaceNumberValue.Text = "";
                textBoxPrizeAmountValue.Text = "0";
                textBoxPrizePercentageValue.Text = "0";
            }
            else
            {
                MessageBox.Show("This form has invalid information.");
            }
        }
    }
}
