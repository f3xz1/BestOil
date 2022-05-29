using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestOil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer = 0;
            day_price = 0;
            timer1.Interval = 1000;
            timer1.Start();
        }
        const double oil1 = 1.5;
        const double oil2 = 2;

        const double hotdog = 1;
        const double humburger = 2;
        const double cocacola = 0.5;
        const double frice = 1;

        public double day_price { get; set; }
        public double timer{ get; set; }

        int timeout = 10;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
           textBox_in_L.Enabled = true;
            textBox_in_AZN.Enabled = false;
            textBox_in_AZN.Text = 0.ToString();
        }

        private void radioButton_in_money_CheckedChanged(object sender, EventArgs e)
        {
            textBox_in_AZN.Enabled = true;
            textBox_in_L.Enabled = false;
            textBox_in_L.Text = 0.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_hotdog.Checked == true)
            {
                textBox_dogcount.Enabled = true;
                textBox_dogprice.Enabled = true;
            }
            else
            {
                textBox_dogcount.Enabled = false;
                textBox_dogprice.Enabled = false;
            }
            Cofe_full_price.Text = count_full_cofe_price().ToString();
            lable_full_price.Text = count_full_price().ToString();
        }

        private void checkBox_hamburger_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_hamburger.Checked == true)
            {
                textBox_burgercount.Enabled = true;
                textBox_burgerprice.Enabled = true;
            }
            else
            {
                textBox_burgercount.Enabled = false;
                textBox_burgerprice.Enabled = false;
            }
            Cofe_full_price.Text = count_full_cofe_price().ToString();
            lable_full_price.Text = count_full_price().ToString();
        }

        private void checkBox_frice_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_frice.Checked == true)
            {
                textBox_fricecount.Enabled = true;
                textBox_friceprice.Enabled = true;
            }
            else
            {
                textBox_fricecount.Enabled = false;
                textBox_friceprice.Enabled = false;
            }
            Cofe_full_price.Text = count_full_cofe_price().ToString();
            lable_full_price.Text = count_full_price().ToString();
        }

        private void checkBox_cola_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_cola.Checked == true)
            {
                textBox_colacount.Enabled = true;
                textBox_colaprice.Enabled = true;
            }
            else
            {
                textBox_colacount.Enabled = false;
                textBox_colaprice.Enabled = false;
            }
            Cofe_full_price.Text = count_full_cofe_price().ToString();
            lable_full_price.Text = count_full_price().ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem.ToString() == "oil 1")
                textBox_oil_price.Text = oil1.ToString();
            else if(comboBox1.SelectedItem.ToString()=="oil 2")
                textBox_oil_price.Text = oil2.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer++;
            if (timer == timeout)
            {
                DialogResult msg = MessageBox.Show("Очистить форму?", "msg", MessageBoxButtons.YesNo);
                if (msg == DialogResult.Yes)
                {
                    textBox_in_AZN.Text = string.Empty;
                    textBox_in_L.Text = string.Empty;


                    textBox_dogcount.Text = 0.ToString();
                    textBox_dogprice.Text = 0.ToString();
                    checkBox_hotdog.Checked = false;

                    textBox_fricecount.Text = 0.ToString();
                    textBox_friceprice.Text = 0.ToString();
                    checkBox_frice.Checked = false;

                    textBox_burgercount.Text = 0.ToString();
                    textBox_burgerprice.Text = 0.ToString();
                    checkBox_hamburger.Checked = false;

                    textBox_colaprice.Text = 0.ToString();
                    textBox_colacount.Text = 0.ToString();
                    checkBox_cola.Checked = false;
                    timer = 0;
                    timeout = 10;
                }
                else
                {
                    timer = 0;
                    timeout += 10;
                }
            }
            
        }


        private void textBox_dogcount_TextChanged(object sender, EventArgs e)
        {
            textBox_dogprice.Text = (Convert.ToDouble(textBox_dogcount.Text) * hotdog).ToString();
            Cofe_full_price.Text = count_full_price().ToString();
            lable_full_price.Text = count_full_price().ToString();
        }

        private void textBox_burgercount_TextChanged(object sender, EventArgs e)
        {
            textBox_burgerprice.Text = (Convert.ToDouble(textBox_burgercount.Text) * humburger).ToString();
            Cofe_full_price.Text = count_full_price().ToString();
            lable_full_price.Text = count_full_price().ToString();
        }

        private void textBox_fricecount_TextChanged(object sender, EventArgs e)
        { 
            textBox_friceprice.Text = (Convert.ToDouble(textBox_fricecount.Text) * frice).ToString();
            Cofe_full_price.Text = count_full_price().ToString();
            lable_full_price.Text = count_full_price().ToString();
        }

        private void textBox_colacount_TextChanged(object sender, EventArgs e)
        {
            textBox_colaprice.Text = (Convert.ToDouble(textBox_colacount.Text) * cocacola).ToString();
            Cofe_full_price.Text = count_full_price().ToString();

            lable_full_price.Text = count_full_price().ToString();
            
        }
        private double count_full_price()
        {
            return double.Parse(Oil_full_price.Text) + count_full_cofe_price();
        }
        private double count_full_cofe_price()
        {
            double price = 0;
            if (checkBox_hotdog.Checked)
                price += Convert.ToDouble(textBox_dogprice.Text);
            if (checkBox_hamburger.Checked)
                price += Convert.ToDouble(textBox_burgerprice.Text);
            if (checkBox_frice.Checked)
                price += Convert.ToDouble(textBox_friceprice.Text);
            if (checkBox_cola.Checked)
                price += Convert.ToDouble(textBox_colaprice.Text);
            return price;
        }



        private void textBox_in_L_TextChanged(object sender, EventArgs e)
        {
            if (textBox_in_L.Text[textBox_in_L.Text.Length - 1] == '.' || textBox_in_L.Text[textBox_in_L.Text.Length - 1] == ',')
                return;
            try
            {
                if (comboBox1.SelectedItem.ToString() == "oil 1")
                    Oil_full_price.Text = (double.Parse(textBox_in_L.Text.Replace(',', '.')) * oil1).ToString();
                else if (comboBox1.SelectedItem.ToString() == "oil 2")
                    Oil_full_price.Text = (double.Parse(textBox_in_L.Text.Replace(',', '.')) * oil2).ToString();
            }
            catch (Exception)
            {
                textBox_in_L.Text = 0.ToString();
            }
            lable_full_price.Text = count_full_price().ToString();
        }

        private void textBox_in_AZN_TextChanged(object sender, EventArgs e)
        {
            if (textBox_in_AZN.Text[textBox_in_AZN.Text.Length - 1]  == '.' || textBox_in_AZN.Text[textBox_in_AZN.Text.Length - 1] == '.')
                return;
            try
            {
                if (comboBox1.SelectedItem.ToString() == "oil 1")
                    Oil_full_price.Text = (double.Parse(textBox_in_AZN.Text.Replace(',', '.')) / oil1).ToString();
                else if (comboBox1.SelectedItem.ToString() == "oil 2")
                    Oil_full_price.Text = (double.Parse(textBox_in_AZN.Text.Replace(',', '.')) / oil2).ToString();
            }
            catch (Exception)
            {
                textBox_in_L.Text = 0.ToString();
            }
            lable_full_price.Text = count_full_price().ToString();
        }
    }
}
