using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumbersListApp
{
    public partial class AddNumberUI : Form
    {
        public AddNumberUI()
        {
            InitializeComponent();
        }

        List<double> numbers = new List<double>();
        private void addButton_Click(object sender, EventArgs e)
        {
            if (numberTextBox.Text != "")
            {
            double aNumber = Convert.ToDouble(numberTextBox.Text);
            numbers.Add(aNumber);
            MessageBox.Show("Number added");
            numberTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Enter your number!");
            }
        }

       

        private void showAllNumberButton_Click(object sender, EventArgs e)
        {
            numbersListBox.DataSource = null;
            numbersListBox.DataSource = numbers;
            totalTextBox.Text = numbers.Count().ToString();
        }
    }
}
