using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const string LowercaseChars = "abcdefghijklmnopqrstuvwxyz";
        const string UppercaseChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string DigitChars = "0123456789";
        const string SymbolChars = "!@#$%^&*()-=_+[]{}|;:'\",.<>?/";
        private void bunifuToggleSwitch1_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
            if (bunifuToggleSwitch1.Value == true)
            {
                this.BackColor = Color.FromArgb(15, 15, 15);
                bunifuLabel1.ForeColor = Color.WhiteSmoke;
                bunifuLabel2.ForeColor = Color.WhiteSmoke;
                bunifuLabel3.ForeColor = Color.WhiteSmoke;
                bunifuLabel4.ForeColor = Color.WhiteSmoke;
                bunifuLabel5.ForeColor = Color.WhiteSmoke;
                bunifuLabel6.ForeColor = Color.WhiteSmoke;

                bunifuPanel1.BackgroundColor = Color.FromArgb(20, 20, 20);
                bunifuPanel2.BackgroundColor = Color.FromArgb(20, 20, 20);

                //bunifuTextBox1.FillColor = Color.FromArgb(22, 22, 22);
                bunifuTextBox1.ForeColor = Color.WhiteSmoke;

                bunifuImageButton1.BackColor = Color.FromArgb(20, 20, 20);
                bunifuPanel3.BackgroundColor = Color.FromArgb(20, 20, 20);
                bunifuImageButton2.BackColor = Color.FromArgb(20, 20, 20);
                pictureBox4.BackColor = Color.FromArgb(20, 20, 20);
                bunifuLabel11.ForeColor = Color.WhiteSmoke;

            }
            else
            {
                this.BackColor = Color.White;
                bunifuLabel1.ForeColor = Color.Black;
                bunifuLabel2.ForeColor = Color.Black;
                bunifuLabel3.ForeColor = Color.Black;
                bunifuLabel4.ForeColor = Color.Black;
                bunifuLabel5.ForeColor = Color.Black;
                bunifuLabel6.ForeColor = Color.Black;

                bunifuPanel1.BackgroundColor = Color.FromArgb(231, 231, 231);
                bunifuPanel2.BackgroundColor = Color.FromArgb(231, 231, 231);

                //bunifuTextBox1.FillColor = Color.FromArgb(231, 231, 231);
                bunifuTextBox1.ForeColor = Color.Black;

                bunifuImageButton1.BackColor = Color.FromArgb(231, 231, 231);
                bunifuPanel3.BackgroundColor = Color.FromArgb(231, 231, 231);
                bunifuImageButton2.BackColor = Color.FromArgb(231, 231, 231);
                pictureBox4.BackColor = Color.FromArgb(231, 231, 231);
                bunifuLabel11.ForeColor = Color.Black;

            }
        }

        public string PasswordGenerator(bool lowerCase, bool upperCase, bool numberic, bool specialCharacter, int length)
        {
            char[] password = new char[length];
            string charSet = "";
            System.Random random = new System.Random();

            if (lowerCase)
                charSet += LowercaseChars;
            if (upperCase)
                charSet += UppercaseChars;
            if (numberic)
                charSet += DigitChars;
            if(specialCharacter)
                charSet += SymbolChars;
            for (int i = 0; i < length; i++)
                password[i] = charSet[random.Next(charSet.Length - 1)];
            return string.Join(null, password);
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            try
            {
                bunifuTextBox1.Text = PasswordGenerator(bunifuCheckBox1.Checked, bunifuCheckBox2.Checked, bunifuCheckBox3.Checked, bunifuCheckBox4.Checked, int.Parse(bunifuLabel10.Text));
            }
            catch (Exception ex)
            {

            }


            // Messages //

            if(bunifuCheckBox1.Checked &&  bunifuCheckBox2.Checked && bunifuCheckBox3.Checked && bunifuCheckBox4.Checked)
            {
                bunifuLabel8.Text = "Strong";
                bunifuLabel8.ForeColor = Color.Green;
            }

            // Compare 3
            //1, 2, 3
            else if(bunifuCheckBox1.Checked && bunifuCheckBox2.Checked && bunifuCheckBox3.Checked)
            {
                bunifuLabel8.Text = "Good";
                bunifuLabel8.ForeColor = Color.Blue;
            }
            //1, 2, 4
            else if (bunifuCheckBox1.Checked && bunifuCheckBox2.Checked && bunifuCheckBox4.Checked)
            {
                bunifuLabel8.Text = "Good";
                bunifuLabel8.ForeColor = Color.Blue;
            }
            //1, 3, 4
            else if (bunifuCheckBox1.Checked && bunifuCheckBox3.Checked && bunifuCheckBox4.Checked)
            {
                bunifuLabel8.Text = "Good";
                bunifuLabel8.ForeColor = Color.Blue;
            }
            //2, 3, 4
            else if (bunifuCheckBox2.Checked && bunifuCheckBox3.Checked && bunifuCheckBox4.Checked)
            {
                bunifuLabel8.Text = "Good";
                bunifuLabel8.ForeColor = Color.Blue;
            }


            //Compare 2
            //1,2
            else if (bunifuCheckBox1.Checked && bunifuCheckBox2.Checked)
            {
                bunifuLabel8.Text = "Medium";
                bunifuLabel8.ForeColor = Color.Yellow;
            }
            //1,3
            else if (bunifuCheckBox1.Checked && bunifuCheckBox3.Checked)
            {
                bunifuLabel8.Text = "Medium";
                bunifuLabel8.ForeColor = Color.Yellow;
            }
            //1,4
            else if (bunifuCheckBox1.Checked && bunifuCheckBox4.Checked)
            {
                bunifuLabel8.Text = "Medium";
                bunifuLabel8.ForeColor = Color.Yellow;
            }
            //2,3
            else if (bunifuCheckBox2.Checked && bunifuCheckBox3.Checked)
            {
                bunifuLabel8.Text = "Medium";
                bunifuLabel8.ForeColor = Color.Yellow;
            }
            //2,4
            else if (bunifuCheckBox2.Checked && bunifuCheckBox4.Checked)
            {
                bunifuLabel8.Text = "Medium";
                bunifuLabel8.ForeColor = Color.Yellow;
            }
            //3,4
            else if (bunifuCheckBox3.Checked && bunifuCheckBox4.Checked)
            {
                bunifuLabel8.Text = "Medium";
                bunifuLabel8.ForeColor = Color.Yellow;
            }




            //Compare 1
            //1
            else if (bunifuCheckBox1.Checked)
            {
                bunifuLabel8.Text = "Weak";
                bunifuLabel8.ForeColor = Color.Red;
            }
            //2
            else if (bunifuCheckBox2.Checked)
            {
                bunifuLabel8.Text = "Weak";
                bunifuLabel8.ForeColor = Color.Red;
            }
            //3
            else if (bunifuCheckBox3.Checked)
            {
                bunifuLabel8.Text = "Weak";
                bunifuLabel8.ForeColor = Color.Red;
            }
            //4
            else if (bunifuCheckBox4.Checked)
            {
                bunifuLabel8.Text = "Weak";
                bunifuLabel8.ForeColor = Color.Red;
            }
            else
            {
                bunifuLabel8.Text = "Weak";
                bunifuLabel8.ForeColor = Color.Red;
            }



        }





        private void bunifuLabel7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://ruchiralk.000webhostapp.com/");
        }

        private void bunifuHSlider1_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
            bunifuLabel10.Text = bunifuHSlider1.Value.ToString();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(bunifuTextBox1.Text);
        }

        private void bunifuPanel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
