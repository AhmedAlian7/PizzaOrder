using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PizzaOrder
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        int GetSizePrice()
        {
            if (rdbSmall_Size.Checked)
            {
                return 3; 
            }
            else if (rdbMeduim_Size.Checked)
            {
                return 5;
            }
            else if (rdbLarg_Size.Checked)
            {
                return 7;
            }
            return 0;
        }

        int GetCrustPrice()
        {
            if (rdbThink_Crust.Checked)
            {
                return 1;
            }
            else
                return 0;
        }

        int GetToppingsPrice()
        {
            int Price = 0;
            if(chkChees.Checked)
            {
                Price += 1;
            }
            if (chkMushrooms.Checked)
            {
                Price += 1;
            }
            if (chkOlive.Checked)
            {
                Price += 1;
            }
            if (chkOnion.Checked)
            {
                Price += 1;
            }
            if (chkPeppers.Checked)
            {
                Price += 1;
            }
            if (chkTomatoes.Checked)
            {
                Price += 1;
            }
            return Price;
        }

        int CalcTotalPrice()
        {
            byte num = ((byte)numericUpDown1.Value);
            return num*(GetSizePrice() + GetCrustPrice() + GetToppingsPrice());
        }

        void UpdatePrice()
        {
            lbPrice.Text = CalcTotalPrice().ToString () + "$";
        }
        void UpdateSize()
        {
            UpdatePrice();

            if (rdbSmall_Size.Checked)
            {
                lbSize.Text = "Small";
            }
            else if (rdbMeduim_Size.Checked)
            {
                lbSize.Text = "Meduim";
            }
            else if (rdbLarg_Size.Checked)
            {
                lbSize.Text = "Larg";
            }
        }
        void UpdateCrust()
        {
            UpdatePrice();

            if ( rdbThin_Crust.Checked)
                 lbCrustType.Text = "Thin Crust";
          else if (rdbThink_Crust.Checked)
                lbCrustType.Text = "Think Crust";
        }

        void UpdateToppings()
        {
            UpdatePrice();

            string T = "";
            if (chkChees.Checked)
            {
                T += "Chees, ";
            }
            if (chkMushrooms.Checked)
            {
                T += "Mushroom, ";
            }
            if (chkOlive.Checked)
            {
                T += "Olive, ";
            }
            if (chkOnion.Checked)
            {
                T += "Onion, ";
            }
            if (chkPeppers.Checked)
            {
                T += "Pepper, ";
            }
            if (chkTomatoes.Checked)
            {
                T += "Tomato, ";
            }

            lbToppings.Text = T;
        }

        void UpdateEatingPlace()
        {
            if (rdbEatIn.Checked)
                lbEatingPlace.Text = "Eat In";
            if (rdbTakeAway.Checked)
                lbEatingPlace.Text = "Take Away";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();


        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

            UpdateSize();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lbEatingPlace_Click(object sender, EventArgs e)
        {

        }

        private void btnConferm_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Order","Confirm",
                MessageBoxButtons.OKCancel,MessageBoxIcon.Question)
                == DialogResult.OK)
            {
                MessageBox.Show("Order Placed Successfully, Thanks", "success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnConferm.Enabled = false;
                groupBox1.Enabled  = false;
                groupBox2.Enabled  = false;
                groupBox3.Enabled  = false;
                groupBox4.Enabled  = false;



            }
        }

        private void rdbThin_Crust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rdbThink_Crust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void chkChees_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();

        }

        private void chkPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();

        }

        private void rdbTakeAway_CheckedChanged(object sender, EventArgs e)
        {
            UpdateEatingPlace();
        }

        private void rdbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateEatingPlace();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox2.Enabled = true;
            groupBox3.Enabled = true;
            groupBox4.Enabled = true;

            rdbMeduim_Size.Checked = true;
            rdbThin_Crust.Checked  = true;

            chkChees.Checked = false;
            chkOlive.Checked = false;
            chkOnion.Checked = false;
            chkMushrooms.Checked = false;
            chkPeppers.Checked = false;
            chkTomatoes.Checked = false;

            rdbTakeAway.Checked = false;

            lbToppings.Text = "No Toppings";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            UpdatePrice();
        }
    }
}
