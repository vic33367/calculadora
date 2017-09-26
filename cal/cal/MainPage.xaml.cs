using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace cal
{
    public partial class MainPage : ContentPage
    {
        double n1 = 0;
        double n2 = 0;
        string op,cadena;
        public MainPage()
        {
            InitializeComponent();
        }

        private void operaciones()
        {
            try
            {
                n2 = Convert.ToDouble(lblResul.Text);

                switch (op)
                {
                    case "dividir":
                        lblResul.Text = Convert.ToString(n1 / n2);
                        lblop.Text = Convert.ToString(n1 / n2);
                        n1 = 0;
                        n2 = 0;

                        break;
                    case "multiplicar":
                        lblResul.Text = Convert.ToString(n1 * n2);
                        lblop.Text = Convert.ToString(n1 * n2);
                        n1 = 0;
                        n2 = 0;

                        break;
                    case "suma":
                        lblResul.Text = Convert.ToString(n1 + n2);
                        lblop.Text = Convert.ToString(n1 + n2);
                        n1 = 0;
                        n2 = 0;
                        break;
                    case "resta":
                        lblResul.Text = Convert.ToString(n1 - n2);
                        lblop.Text = Convert.ToString(n1 - n2);
                        n1 = 0;
                        n2 = 0;
                        break;

                }
            }
            catch
            {

            }
        }
        private void delete()
        {
            cadena = lblResul.Text;
            int Cadena = cadena.Length;
            if (Cadena == 1)
            {
                lblResul.Text = "0";
            }
            else
            {
                lblResul.Text = cadena.Substring(0, (Cadena - 1));
            }
            
        }

        private void btn1_Clicked(object sender, EventArgs e)
        {
            n1 = 0;
            n2 = 0;
            lblResul.Text = 0+"";
            lblop.Text = "";

        }

        private void btn2_Clicked(object sender, EventArgs e)
        {
            delete();
        }

        private void btn3_Clicked(object sender, EventArgs e)
        {
            try {
                n1 = Convert.ToDouble(lblResul.Text);
                op = "multiplicar";
                lblResul.Text = "";
                if (lblop.Text.Length == 0)
                {
                    lblop.Text = "";
                }
                else
                {
                    lblop.Text = lblop.Text+"*";
                }
                operaciones();

            }
            catch
            {

            }
        }

        private void btn4_Clicked(object sender, EventArgs e)
        {
            try
            {
                n1 = Convert.ToDouble(lblResul.Text);
                op = "dividir";
                lblResul.Text = "";
                if (lblop.Text.Length == 0)
                {
                    lblop.Text = "";
                }
                else
                {
                    lblop.Text = lblop.Text + "÷";
                }
               
                operaciones();
            }
            catch
            {

            }
        }

        private void btn5_Clicked(object sender, EventArgs e)
        {            
            cadena = lblResul.Text;           

            if (cadena=="0")
            {
                lblResul.Text = "7";
                lblop.Text = "7";

            }
            else if (cadena == "0.")
            {
                lblResul.Text = "";
                lblResul.Text = lblResul.Text + "0.7";
                lblop.Text = lblop.Text + "0.7";
            }
            else
            {
                lblResul.Text = lblResul.Text + "7";
                lblop.Text = lblop.Text + "7";
            }


        }

        private void btn6_Clicked(object sender, EventArgs e)
        {
            cadena = lblResul.Text;

            if (cadena == "0")
            {
                lblResul.Text = "8";

                lblop.Text = "8";
            }
            else if (cadena == "0.")
            {
                lblResul.Text = "";
                lblResul.Text = lblResul.Text + "0.8";
                lblop.Text = lblop.Text + "0.8";
            }
            else
            {
                lblResul.Text = lblResul.Text + "8";
                lblop.Text = lblop.Text + "8";
            }
        }

        private void btn7_Clicked(object sender, EventArgs e)
        {
            cadena = lblResul.Text;

            if (cadena == "0")
            {
                lblResul.Text = "9";
                lblop.Text = "9";
            }
            else if (cadena == "0.")
            {
                lblResul.Text = "";
                lblResul.Text = lblResul.Text + "0.9";
                lblop.Text = lblop.Text + "0.9";
            }
            else
            {
                lblResul.Text = lblResul.Text + "9";
                lblop.Text = lblop.Text + "9";
            }
        }

        private void btn8_Clicked(object sender, EventArgs e)
        {
            try
            {
                cadena = lblResul.Text;
                if (cadena == "0" ||cadena.Length==0)
                {
                    lblResul.Text = "-";
                    if (lblop.Text.Length == 0)
                    {
                        lblop.Text = "";
                    }
                    else
                    {
                        lblop.Text = lblop.Text + "-";
                    }
                }
                else
                {
                    n1 = Convert.ToDouble(lblResul.Text);
                    op = "resta";
                    lblResul.Text = "";
                    if (lblop.Text.Length == 0)
                    {
                        lblop.Text = "";
                    }
                    else
                    {
                        lblop.Text = lblop.Text + "-";
                    }
                    operaciones();
                }
            }
            catch
            {

            }

        }

        private void btn9_Clicked(object sender, EventArgs e)
        {
            cadena = lblResul.Text;

            if (cadena == "0")
            {
                lblResul.Text = "4";

                lblop.Text = "4";
            }
            else if (cadena == "0.")
            {
                lblResul.Text = "";
                lblResul.Text = lblResul.Text + "0.4";
                lblop.Text = lblop.Text + "0.4";
            }
            else
            {
                lblResul.Text = lblResul.Text + "4";
                lblop.Text = lblop.Text + "4";
            }
        }

        private void btn10_Clicked(object sender, EventArgs e)
        {
            cadena = lblResul.Text;

            if (cadena == "0")
            {
                lblResul.Text = "5";
                lblop.Text = "5";
            }
            else if (cadena == "0.")
            {
                lblResul.Text = "";
                lblResul.Text = lblResul.Text + "0.5";
                lblop.Text = lblop.Text + "0.5";
            }
            else
            {
                lblResul.Text = lblResul.Text + "5";
                lblop.Text = lblop.Text + "5";
            }
        }

        private void btn11_Clicked(object sender, EventArgs e)
        {
            cadena = lblResul.Text;

            if (cadena == "0")
            {
                lblResul.Text = "6";

                lblop.Text = "6";
            }
            else if (cadena == "0.")
            {
                lblResul.Text = "";
                lblResul.Text = lblResul.Text + "0.6";
                lblop.Text = lblop.Text + "0.6";
            }
            else
            {
                lblResul.Text = lblResul.Text + "6";
                lblop.Text = lblop.Text + "6";
            }
        }

        private void btn12_Clicked(object sender, EventArgs e)
        {
            operaciones();
            try
            {

                n1 = Convert.ToDouble(lblResul.Text);
                op = "suma";
                lblResul.Text = "";
                if (lblop.Text.Length == 0)
                {
                    lblop.Text = "";
                }
                else
                {
                    lblop.Text = lblop.Text + "+";
                }
                operaciones();
                
            }
            catch
            {

            }
        }

        private void btn13_Clicked(object sender, EventArgs e)
        {
            cadena = lblResul.Text;

            if (cadena == "0")
            {
                lblResul.Text = "1";

                lblop.Text = "1";
            }
            else if (cadena == "0.")
            {
                lblResul.Text = "";
                lblResul.Text = lblResul.Text + "0.1";
                lblop.Text = lblop.Text + "0.1";
            }
            else
            {
                lblResul.Text = lblResul.Text + "1";
                lblop.Text = lblop.Text + "1";
            }
        }

        private void btn14_Clicked(object sender, EventArgs e)
        {
            cadena = lblResul.Text;

            if (cadena == "0")
            {
                lblResul.Text = "2";
                lblop.Text = "2";
            }
            else if (cadena == "0.")
            {
                lblResul.Text = "";
                lblResul.Text = lblResul.Text + "0.2";
                lblop.Text = lblop.Text + "0.2";
            }
            else
            {
                lblResul.Text = lblResul.Text + "2";
                lblop.Text = lblop.Text + "2";
            }
        }

        private void btn15_Clicked(object sender, EventArgs e)
        {
            cadena = lblResul.Text;

            if (cadena == "0")
            {
                lblResul.Text = "3";

                lblop.Text = "3";
            }
            else if (cadena == "0.")
            {
                lblResul.Text = "";
                lblResul.Text = lblResul.Text + "0.3";
                lblop.Text = lblop.Text + "0.3";
            }
            else
            {
                lblResul.Text = lblResul.Text + "3";
                lblop.Text = lblop.Text + "3";
            }
        }

        private void btn16_Clicked(object sender, EventArgs e)
        {
            operaciones();
        }

        private void btn17_Clicked(object sender, EventArgs e)
        {
            cadena = lblResul.Text;

            if (cadena == "0")
            {
                lblResul.Text = "0";
                lblop.Text = "0";
            }
            else
            {
                lblResul.Text = lblResul.Text + "0";
                lblop.Text = lblop.Text + "0";
            }
        }

        private void btn18_Clicked(object sender, EventArgs e)
        {
             cadena = lblResul.Text;

            if (cadena.Contains("."))
            {

            }
            else                

                if (cadena == "0")
                {
                lblResul.Text = "0.";

                lblop.Text = "0.";
            }
                else
                {
                lblResul.Text = lblResul.Text + ".";
                lblop.Text = lblop.Text+".";
            }
            
            
            
        }
    }
}
