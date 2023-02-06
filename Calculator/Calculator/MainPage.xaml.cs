using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calculator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            lblOutput.Text = "0";
        }

        private void btn1_Clicked(object sender, EventArgs e)
        {
            StringBuilder thing = new StringBuilder();
            if(lblOutput.Text.ToString().Equals("0")){
                lblOutput.Text = "1";
            }
            else
            {
                thing.Append(lblOutput.Text);
                thing.Append("1");
                lblOutput.Text = thing.ToString();
            }
        }

        private void btn2_Clicked(object sender, EventArgs e)
        {
            StringBuilder thing = new StringBuilder();
            if (lblOutput.Text.ToString().Equals("0"))
            {
                lblOutput.Text = "2";
            }
            else
            {
                thing.Append(lblOutput.Text);
                thing.Append("2");
                lblOutput.Text = thing.ToString();
            }
        }

        private void btn3_Clicked(object sender, EventArgs e)
        {
            StringBuilder thing = new StringBuilder();
            if (lblOutput.Text.ToString().Equals("0"))
            {
                lblOutput.Text = "3";
            }
            else
            {
                thing.Append(lblOutput.Text);
                thing.Append("3");
                lblOutput.Text = thing.ToString();
            }
        }

        private void btnDivide_Clicked(object sender, EventArgs e)
        {
            StringBuilder thing = new StringBuilder();
            thing.Append(lblOutput.Text);
            thing.Append("/");
            lblOutput.Text = thing.ToString();
        }

        private void btn4_Clicked(object sender, EventArgs e)
        {
            StringBuilder thing = new StringBuilder();
            if (lblOutput.Text.ToString().Equals("0"))
            {
                lblOutput.Text = "4";
            }
            else
            {
                thing.Append(lblOutput.Text);
                thing.Append("4");
                lblOutput.Text = thing.ToString();
            }
        }

        private void btn5_Clicked(object sender, EventArgs e)
        {
            StringBuilder thing = new StringBuilder();
            if (lblOutput.Text.ToString().Equals("0"))
            {
                lblOutput.Text = "5";
            }
            else
            {
                thing.Append(lblOutput.Text);
                thing.Append("5");
                lblOutput.Text = thing.ToString();
            }
        }

        private void btn6_Clicked(object sender, EventArgs e)
        {
            StringBuilder thing = new StringBuilder();
            if (lblOutput.Text.ToString().Equals("0"))
            {
                lblOutput.Text = "6";
            }
            else
            {
                thing.Append(lblOutput.Text);
                thing.Append("6");
                lblOutput.Text = thing.ToString();
            }
        }

        private void btnMutiply_Clicked(object sender, EventArgs e)
        {
            StringBuilder thing = new StringBuilder();
            thing.Append(lblOutput.Text);
            thing.Append("*");
            lblOutput.Text = thing.ToString();
        }

        private void btn7_Clicked(object sender, EventArgs e)
        {
            StringBuilder thing = new StringBuilder();
            if (lblOutput.Text.ToString().Equals("0"))
            {
                lblOutput.Text = "7";
            }
            else
            {
                thing.Append(lblOutput.Text);
                thing.Append("7");
                lblOutput.Text = thing.ToString();
            }
        }

        private void btn8_Clicked(object sender, EventArgs e)
        {
            StringBuilder thing = new StringBuilder();
            if (lblOutput.Text.ToString().Equals("0"))
            {
                lblOutput.Text = "8";
            }
            else
            {
                thing.Append(lblOutput.Text);
                thing.Append("8");
                lblOutput.Text = thing.ToString();
            }
        }

        private void btn9_Clicked(object sender, EventArgs e)
        {
            StringBuilder thing = new StringBuilder();
            if (lblOutput.Text.ToString().Equals("0"))
            {
                lblOutput.Text = "9";
            }
            else
            {
                thing.Append(lblOutput.Text);
                thing.Append("9");
                lblOutput.Text = thing.ToString();
            }
        }

        private void btnSubtract_Clicked(object sender, EventArgs e)
        {
            StringBuilder thing = new StringBuilder();
            thing.Append(lblOutput.Text);
            thing.Append("-");
            lblOutput.Text = thing.ToString();
        }

        private void btn0_Clicked(object sender, EventArgs e)
        {
            StringBuilder thing = new StringBuilder();
            thing.Append(lblOutput.Text);
            thing.Append("0");
            lblOutput.Text = thing.ToString();
        }

        private void btnAdd_Clicked(object sender, EventArgs e)
        {
            StringBuilder thing = new StringBuilder();
            thing.Append(lblOutput.Text);
            thing.Append("+");
            lblOutput.Text = thing.ToString();
        }

        private void btnClear_Clicked(object sender, EventArgs e)
        {
            lblOutput.Text = "0";
        }

        private void btnEquals_Clicked(object sender, EventArgs e)
        {
            StringBuilder thing = new StringBuilder();
            thing.Append(lblOutput.Text);
            int calc = 0;

            // if subtraction is needed 
            if (thing.ToString().Contains("-"))
            {
                string[] parts = thing.ToString().Split('-');
                
                
                for (int i = 0; i < parts.Length; i++)
                {
                    if (i == 0)
                    {
                        calc =  int.Parse(parts[i]);
                    }
                    else
                    {
                        calc = calc - int.Parse(parts[i]);
                    }   
                }

                thing.Append("=");
                thing.Append(calc.ToString());
                lblOutput.Text = thing.ToString();
            }

            // if addition is needed 
            if (thing.ToString().Contains("+"))
            {
                string[] parts = thing.ToString().Split('+');


                for (int i = 0; i < parts.Length; i++)
                {
                    if (i == 0)
                    {
                        calc = int.Parse(parts[i]);
                    }
                    else
                    {
                        calc = calc + int.Parse(parts[i]);
                    }
                }

                thing.Append("=");
                thing.Append(calc.ToString());
                lblOutput.Text = thing.ToString();
            }

            // if mutliplication is needed 
            if (thing.ToString().Contains("*"))
            {
                string[] parts = thing.ToString().Split('*');


                for (int i = 0; i < parts.Length; i++)
                {
                    if (i == 0)
                    {
                        calc = int.Parse(parts[i]);
                    }
                    else
                    {
                        calc = calc * int.Parse(parts[i]);
                    }
                }

                thing.Append("=");
                thing.Append(calc.ToString());
                lblOutput.Text = thing.ToString();
            }

            // if division is needed 
            if (thing.ToString().Contains("/"))
            {
                string[] parts = thing.ToString().Split('/');


                for (int i = 0; i < parts.Length; i++)
                {
                    if (i == 0)
                    {
                        calc = int.Parse(parts[i]);
                    }
                    else
                    {
                        calc = calc / int.Parse(parts[i]);
                    }
                }

                thing.Append("=");
                thing.Append(calc.ToString());
                lblOutput.Text = thing.ToString();
            }

        }
    }
}
