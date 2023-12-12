using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Generator
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuToggleSwitch5_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
            if (bunifuToggleSwitch5.Value==true)
            {
                this.BackColor = Color.FromArgb(15,15,15);
                bunifuLabel5.ForeColor = Color.White;
                bunifuLabel6.ForeColor = Color.White;
                bunifuLabel7.ForeColor = Color.LightGreen;
                bunifuPanel1.BackgroundColor = Color.FromArgb(20,20,20);
                bunifuPanel2.BackgroundColor = Color.FromArgb(20, 20, 20);

                bunifuLabel1.ForeColor = Color.WhiteSmoke;
                bunifuLabel2.ForeColor = Color.WhiteSmoke;
                bunifuLabel3.ForeColor = Color.WhiteSmoke;
                bunifuLabel4.ForeColor = Color.WhiteSmoke;
            }
            else
            {
                this.BackColor = Color.White;
                bunifuLabel5.ForeColor = Color.Black;
                bunifuLabel6.ForeColor = Color.Black;
                bunifuLabel7.ForeColor = Color.Black;
                bunifuPanel1.BackgroundColor = Color.FromArgb(231, 231, 231);
                bunifuPanel2.BackgroundColor = Color.FromArgb(231, 231, 231);

                bunifuLabel1.ForeColor = Color.Black;
                bunifuLabel2.ForeColor = Color.Black;
                bunifuLabel3.ForeColor = Color.Black;
                bunifuLabel4.ForeColor = Color.Black;
            }
        }
// Middle toggle 1
        private void bunifuToggleSwitch1_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
            if (bunifuToggleSwitch5.Value == true)
            {
                if (bunifuToggleSwitch1.Checked)
                {
                    bunifuLabel1.ForeColor = Color.WhiteSmoke;
                }
                else
                {
                    bunifuLabel1.ForeColor = Color.DimGray;
                }
                    
            }
            else
            {
                if (bunifuToggleSwitch1.Checked)
                {
                    bunifuLabel1.ForeColor = Color.Black;
                }
                else
                {
                    bunifuLabel1.ForeColor = Color.Gray;
                }
            }
        }
 // Middle toggle 2
        private void bunifuToggleSwitch2_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
            if (bunifuToggleSwitch5.Value == true)
            {
                if (bunifuToggleSwitch2.Checked)
                {
                    bunifuLabel2.ForeColor = Color.WhiteSmoke;
                }
                else
                {
                    bunifuLabel2.ForeColor = Color.DimGray;
                }

            }
            else
            {
                if (bunifuToggleSwitch2.Checked)
                {
                    bunifuLabel2.ForeColor = Color.Black;
                }
                else
                {
                    bunifuLabel2.ForeColor = Color.Gray;
                }
            }
        }
  // Middle toggle 3
        private void bunifuToggleSwitch3_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
            if (bunifuToggleSwitch5.Value == true)
            {
                if (bunifuToggleSwitch3.Checked)
                {
                    bunifuLabel3.ForeColor = Color.WhiteSmoke;
                }
                else
                {
                    bunifuLabel3.ForeColor = Color.DimGray;
                }

            }
            else
            {
                if (bunifuToggleSwitch3.Checked)
                {
                    bunifuLabel3.ForeColor = Color.Black;
                }
                else
                {
                    bunifuLabel3.ForeColor = Color.Gray;
                }
            }
        }
 // Middle toggle 4
        private void bunifuToggleSwitch4_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
            if (bunifuToggleSwitch5.Value == true)
            {
                if (bunifuToggleSwitch4.Checked)
                {
                    bunifuLabel4.ForeColor = Color.WhiteSmoke;
                }
                else
                {
                    bunifuLabel4.ForeColor = Color.DimGray;
                }

            }
            else
            {
                if (bunifuToggleSwitch4.Checked)
                {
                    bunifuLabel4.ForeColor = Color.Black;
                }
                else
                {
                    bunifuLabel4.ForeColor = Color.Gray;
                }
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            //////////////////////// Messages /////////////////////////////////////
            ///


            if (bunifuToggleSwitch1.Checked && bunifuToggleSwitch2.Checked && bunifuToggleSwitch3.Checked && bunifuToggleSwitch4.Checked)
            {
                bunifuLabel8.Text = "Strong";
                bunifuLabel8.ForeColor = Color.Green;
            }
            // Compare 3
            //1, 2, 3
            else if (bunifuToggleSwitch1.Checked && bunifuToggleSwitch2.Checked && bunifuToggleSwitch3.Checked)
            {
                bunifuLabel8.Text = "Good";
                bunifuLabel8.ForeColor = Color.Blue;
            }
            //1, 2, 4
            else if (bunifuToggleSwitch1.Checked && bunifuToggleSwitch2.Checked && bunifuToggleSwitch4.Checked)
            {
                bunifuLabel8.Text = "Good";
                bunifuLabel8.ForeColor = Color.Blue;
            }
            //1, 3, 4
            else if (bunifuToggleSwitch1.Checked && bunifuToggleSwitch3.Checked && bunifuToggleSwitch4.Checked)
            {
                bunifuLabel8.Text = "Good";
                bunifuLabel8.ForeColor = Color.Blue;
            }
            //2, 3, 4
            else if (bunifuToggleSwitch2.Checked && bunifuToggleSwitch3.Checked && bunifuToggleSwitch4.Checked)
            {
                bunifuLabel8.Text = "Good";
                bunifuLabel8.ForeColor = Color.Blue;
            }



            //Compare 2
            //1,2
            else if (bunifuToggleSwitch1.Checked && bunifuToggleSwitch2.Checked)
            {
                bunifuLabel8.Text = "Medium";
                bunifuLabel8.ForeColor = Color.Yellow;
            }
            //1,3
            else if (bunifuToggleSwitch1.Checked && bunifuToggleSwitch3.Checked)
            {
                bunifuLabel8.Text = "Medium";
                bunifuLabel8.ForeColor = Color.Yellow;
            }
            //1,4
            else if (bunifuToggleSwitch1.Checked && bunifuToggleSwitch4.Checked)
            {
                bunifuLabel8.Text = "Medium";
                bunifuLabel8.ForeColor = Color.Yellow;
            }
            //2,3
            else if (bunifuToggleSwitch2.Checked && bunifuToggleSwitch3.Checked)
            {
                bunifuLabel8.Text = "Medium";
                bunifuLabel8.ForeColor = Color.Yellow;
            }
            //2,4
            else if (bunifuToggleSwitch2.Checked && bunifuToggleSwitch4.Checked)
            {
                bunifuLabel8.Text = "Medium";
                bunifuLabel8.ForeColor = Color.Yellow;
            }
            //3,4
            else if (bunifuToggleSwitch3.Checked && bunifuToggleSwitch4.Checked)
            {
                bunifuLabel8.Text = "Medium";
                bunifuLabel8.ForeColor = Color.Yellow;
            }


            //Compare 1
            //1
            else if (bunifuToggleSwitch1.Checked)
            {
                bunifuLabel8.Text = "Weak";
                bunifuLabel8.ForeColor = Color.Red;
            }
            //2
            else if (bunifuToggleSwitch2.Checked)
            {
                bunifuLabel8.Text = "Weak";
                bunifuLabel8.ForeColor = Color.Red;
            }
            //3
            else if (bunifuToggleSwitch3.Checked)
            {
                bunifuLabel8.Text = "Weak";
                bunifuLabel8.ForeColor = Color.Red;
            }
            //4
            else if (bunifuToggleSwitch4.Checked)
            {
                bunifuLabel8.Text = "Weak";
                bunifuLabel8.ForeColor = Color.Red;
            }
            else
            {
                bunifuLabel8.Text = "Weak";
                bunifuLabel8.ForeColor = Color.Red;
            }


            ////////////////////////////// Commands //////////////////////////////
            ///

           

        }

  

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
