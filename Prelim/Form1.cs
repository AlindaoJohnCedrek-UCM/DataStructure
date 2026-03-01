using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyConverter
{

    public partial class Form1 : Form
    {
        // The "Master List" of all your currencies
        private readonly string[] allCurrencies = { "PHP", "USD", "EUR", "CAD" };
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void convertCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }
        private void currentCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 1. Remember what was previously selected in the second box (if anything)
            string previousSelection = convertCurrency.Text;

            // 2. Clear the second box
            convertCurrency.Items.Clear();

            // 3. Loop through master list and add items that AREN'T selected in Box 1
            foreach (string currency in allCurrencies)
            {
                if (currency != currentCurrency.Text)
                {
                    convertCurrency.Items.Add(currency);
                }
            }

            // 4. Try to re-select what was there before, so it doesn't just go blank
            if (convertCurrency.Items.Contains(previousSelection))
            {
                convertCurrency.Text = previousSelection;
            }
            else if (convertCurrency.Items.Count > 0)
            {
                // If the old item is gone, just pick the first available one
                convertCurrency.SelectedIndex = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1. Define the dictionary ONCE with correct spelling
            Dictionary<string, double> exchangeRates = new Dictionary<string, double> {
        { "PHP", 1.0000 },
        { "CAD", 0.0236 },
        { "EUR", 0.0147 },
        { "USD", 0.0173 }
    };

            // 2. Get and clean inputs
            string amount = amountTextBox.Text;
            string fromCurrency = currentCurrency.Text.Trim().ToUpper();
            string toCurrency = convertCurrency.Text.Trim().ToUpper();
            double finalAmount = 0;

            // 3. Validation Check
            if (string.IsNullOrEmpty(amount) || string.IsNullOrEmpty(fromCurrency) || string.IsNullOrEmpty(toCurrency))
            {
                MessageBox.Show("Please fill in all fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 4. Number Parsing
            if (!double.TryParse(amount, out finalAmount))
            {
                MessageBox.Show("Only numbers are allowed!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 5. Safe Dictionary Access (This prevents the KeyNotFoundException)
            if (exchangeRates.ContainsKey(fromCurrency) && exchangeRates.ContainsKey(toCurrency))
            {
                double fromRate = exchangeRates[fromCurrency];
                double toRate = exchangeRates[toCurrency];

                // Calculation: (Amount / Source) * Target
                double convertedAmount = (finalAmount / fromRate) * toRate;

                // 6. Display Results
                showAmount.Text = finalAmount.ToString("N2"); // N2 adds commas and 2 decimals
                showCurrencyFrom.Text = fromCurrency;
                showConvertCurrency.Text = toCurrency;
                showConvert.Text = convertedAmount.ToString("N2");
            }
            else
            {
                MessageBox.Show("One of the selected currencies is not supported in the database.",
                                "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void showAmount_Click(object sender, EventArgs e)
        {

        }

    }
}
