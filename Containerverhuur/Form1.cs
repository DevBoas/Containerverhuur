using System;
using System.Windows.Forms;

namespace Containerverhuur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Bereken_Click(object sender, EventArgs e)
        {
            DateTime van = dateTimePicker1.Value;
            DateTime tot = dateTimePicker2.Value;

            int days = (tot - van).Days;
            int m3 = 0;
            Decimal price = 0;
            Int32.TryParse(TextBoxM3.Text, out m3);

            price = (m3 * 40) * days;

            if (m3 <= 2)
                price += 60;
            else
                price += 125;

            if (CheckBoxVasteKlant.Checked)
                price = price * 0.85m;
            ///MessageBox.Show("Price = " + price.ToString());
            Output.Text = "Tarief: €" + price.ToString();
        }
    }
}
