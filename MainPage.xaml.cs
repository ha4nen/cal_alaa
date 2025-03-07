﻿namespace cal
{

    public partial class MainPage : ContentPage
    {
        float x, y;
        string operation = "";
        int clickOnce = 0;
        float result;
        int minusClick = 0;
        int clickPoint = 0;
        Boolean xPressed = false;
        Boolean yPressed = false;


        public MainPage()
        {
            InitializeComponent();
        }

        private void But_9_Clicked(object sender, EventArgs e)
        {
            if (minusClick != 0)
            {
                if (operation != "")
                {
                    if (x == 0)
                    {
                        x = 9;
                        Display.Text = Display.Text + x.ToString();
                    }
                    else
                    {
                        Display.Text = Display.Text + "9";
                        x = float.Parse(Display.Text);
                    }
                }
                else
                {
                    if (y == 0)
                    {

                        y = 9;
                        Display.Text = Display.Text + y.ToString();
                    }
                    else
                    {
                        Display.Text = Display.Text + "9";
                        y = float.Parse(Display.Text);
                    }
                }
            }
            else
            {
                if (operation != "")
                {
                    if (x == 0)
                    {
                        xPressed = true;
                        Display.Text = "";
                        x = 9;
                        Display.Text = x.ToString();
                        x = float.Parse(Display.Text);
                    }
                    else
                    {
                        xPressed = true;
                        Display.Text = Display.Text + "9";
                        x = float.Parse(Display.Text);
                    }
                }
                else
                {
                    if (y == 0)
                    {
                        yPressed = true;
                        y = 9;
                        Display.Text = y.ToString();
                    }
                    else
                    {
                        yPressed = true;
                        Display.Text = Display.Text + "9";
                        y = float.Parse(Display.Text);
                    }
                }
            }
        }

        private void But_C_Clicked(object sender, EventArgs e)
        {
            x = 0;
            y = 0;
            operation = "";
            Display.Text = "0";
            clickOnce = 0;
            minusClick = 0;
            clickPoint = 0;
            xPressed = false;
            yPressed = false;


        }

        private void But_add_minus_Clicked(object sender, EventArgs e)
        {
            minusClick = 1;
            Display.Text = "-";

        }

        private void But_mod_Clicked(object sender, EventArgs e)
        {
            checkOperation();
            if (clickOnce == 0)
            {
                operation = "%";
                clickOnce = 1;
                minusClick = 0;
                y = float.Parse(Display.Text);
            }

        }

        private void But_div_Clicked(object sender, EventArgs e)
        {
            checkOperation();
            if (clickOnce == 0)
            {
                operation = "/";
                clickOnce = 1;
                minusClick = 0;
            }

            if (xPressed && yPressed)
            {
                result = y / x;
                Display.Text = result.ToString();
                y = float.Parse(Display.Text);
                x = 0;
                clickOnce = 0;
                result = 0;
                xPressed = false;
            }

        }

        private void But_7_Clicked(object sender, EventArgs e)
        {
            if (minusClick != 0)
            {
                if (operation != "")
                {
                    if (x == 0)
                    {
                        x = 7;
                        Display.Text = Display.Text + x.ToString();
                    }
                    else
                    {
                        Display.Text = Display.Text + "9";
                        x = float.Parse(Display.Text);
                    }
                }
                else
                {
                    if (y == 0)
                    {
                        y = 7;
                        Display.Text = Display.Text + y.ToString();
                    }
                    else
                    {
                        Display.Text = Display.Text + "7";
                        y = float.Parse(Display.Text);
                    }
                }
            }
            else
            {
                if (operation != "")
                {
                    if (x == 0)
                    {
                        xPressed = true;
                        Display.Text = "";
                        x = 7;
                        Display.Text = x.ToString();
                        x = float.Parse(Display.Text);
                    }
                    else
                    {
                        xPressed = true;
                        Display.Text = Display.Text + "7";
                        x = float.Parse(Display.Text);
                    }
                }
                else
                {
                    if (y == 0)
                    {
                        yPressed = true;
                        y = 7;
                        Display.Text = y.ToString();
                    }
                    else
                    {
                        yPressed = true;
                        Display.Text = Display.Text + "7";
                        y = float.Parse(Display.Text);
                    }
                }
            }
        }

        private void But_8_Clicked(object sender, EventArgs e)
        {
            if (minusClick != 0)
            {
                if (operation != "")
                {
                    if (x == 0)
                    {
                        x = 8;
                        Display.Text = Display.Text + x.ToString();
                    }
                    else
                    {
                        Display.Text = Display.Text + "8";
                        x = float.Parse(Display.Text);
                    }
                }
                else
                {
                    if (y == 0)
                    {
                        y = 8;
                        Display.Text = Display.Text + y.ToString();
                    }
                    else
                    {
                        Display.Text = Display.Text + "8";
                        y = float.Parse(Display.Text);
                    }
                }
            }
            else
            {
                if (operation != "")
                {
                    if (x == 0)
                    {
                        xPressed = true;
                        Display.Text = "";
                        x = 8;
                        Display.Text = x.ToString();
                        x = float.Parse(Display.Text);
                    }
                    else
                    {
                        xPressed = true;
                        Display.Text = Display.Text + "8";
                        x = float.Parse(Display.Text);
                    }
                }
                else
                {
                    if (y == 0)
                    {
                        yPressed = true;
                        y = 8;
                        Display.Text = y.ToString();
                    }
                    else
                    {
                        yPressed = true;
                        Display.Text = Display.Text + "8";
                        y = float.Parse(Display.Text);
                    }
                }
            }
        }

        private void But_multiply_Clicked(object sender, EventArgs e)
        {
            checkOperation();

            if (clickOnce == 0)
            {
                operation = "*";
                clickOnce = 1;
                minusClick = 0;
            }

            if (xPressed && yPressed)
            {
                result = x * y;
                Display.Text = result.ToString();
                y = float.Parse(Display.Text);
                x = 0;
                clickOnce = 0;
                result = 0;
                xPressed = false;
            }


        }

        private void But_minus_Clicked(object sender, EventArgs e)
        {
            checkOperation();

            if (clickOnce == 0)
            {
                operation = "-";
                clickOnce = 1;
            }
            if (xPressed && yPressed)
            {
                result = y - x;
                Display.Text = result.ToString();
                y = float.Parse(Display.Text);
                x = 0;
                clickOnce = 0;
                result = 0;
                xPressed = false;
            }

        }

        private void But_4_Clicked(object sender, EventArgs e)
        {
            if (minusClick != 0)
            {
                if (operation != "")
                {
                    if (x == 0)
                    {
                        x = 4;
                        Display.Text = Display.Text + x.ToString();
                    }
                    else
                    {
                        Display.Text = Display.Text + "4";
                        x = float.Parse(Display.Text);
                    }
                }
                else
                {
                    if (y == 0)
                    {
                        y = 4;
                        Display.Text = Display.Text + y.ToString();
                    }
                    else
                    {
                        Display.Text = Display.Text + "4";
                        y = float.Parse(Display.Text);
                    }
                }
            }
            else
            {
                if (operation != "")
                {
                    if (x == 0)
                    {
                        xPressed = true;
                        Display.Text = "";
                        x = 4;
                        Display.Text = x.ToString();
                        x = float.Parse(Display.Text);
                    }
                    else
                    {
                        xPressed = true;
                        Display.Text = Display.Text + "4";
                        x = float.Parse(Display.Text);
                    }
                }
                else
                {
                    if (y == 0)
                    {
                        yPressed = true;
                        y = 4;
                        Display.Text = y.ToString();
                    }
                    else
                    {
                        yPressed = true;
                        Display.Text = Display.Text + "4";
                        y = float.Parse(Display.Text);
                    }
                }
            }
        }

        private void But_5_Clicked(object sender, EventArgs e)
        {
            if (minusClick != 0)
            {
                if (operation != "")
                {
                    if (x == 0)
                    {
                        x = 5;
                        Display.Text = Display.Text + x.ToString();
                    }
                    else
                    {
                        Display.Text = Display.Text + "5";
                        x = float.Parse(Display.Text);
                    }
                }
                else
                {
                    if (y == 0)
                    {
                        y = 5;
                        Display.Text = Display.Text + y.ToString();
                    }
                    else
                    {
                        Display.Text = Display.Text + "5";
                        y = float.Parse(Display.Text);
                    }
                }
            }
            else
            {
                if (operation != "")
                {
                    if (x == 0)
                    {
                        xPressed = true;
                        Display.Text = "";
                        x = 5;
                        Display.Text = x.ToString();
                        x = float.Parse(Display.Text);
                    }
                    else
                    {
                        xPressed = true;
                        Display.Text = Display.Text + "5";
                        x = float.Parse(Display.Text);
                    }
                }
                else
                {
                    if (y == 0)
                    {
                        yPressed = true;
                        y = 5;
                        Display.Text = y.ToString();
                    }
                    else
                    {
                        yPressed = true;
                        Display.Text = Display.Text + "5";
                        y = float.Parse(Display.Text);
                    }
                }
            }
        }

        private void But_6_Clicked(object sender, EventArgs e)
        {
            if (minusClick != 0)
            {
                if (operation != "")
                {
                    if (x == 0)
                    {
                        x = 6;
                        Display.Text = Display.Text + x.ToString();
                    }
                    else
                    {
                        Display.Text = Display.Text + "6";
                        x = float.Parse(Display.Text);
                    }
                }
                else
                {
                    if (y == 0)
                    {
                        y = 6;
                        Display.Text = Display.Text + y.ToString();
                    }
                    else
                    {
                        Display.Text = Display.Text + "6";
                        y = float.Parse(Display.Text);
                    }
                }
            }
            else
            {
                if (operation != "")
                {
                    if (x == 0)
                    {
                        xPressed = true;
                        Display.Text = "";
                        x = 6;
                        Display.Text = x.ToString();
                        x = float.Parse(Display.Text);
                    }
                    else
                    {
                        xPressed = true;
                        Display.Text = Display.Text + "6";
                        x = float.Parse(Display.Text);
                    }
                }
                else
                {
                    if (y == 0)
                    {
                        yPressed = true;
                        y = 6;
                        Display.Text = y.ToString();
                    }
                    else
                    {
                        yPressed = true;
                        Display.Text = Display.Text + "6";
                        y = float.Parse(Display.Text);
                    }
                }
            }
        }
        private void But_plus_Clicked(object sender, EventArgs e)
        {
            checkOperation();
            if (clickOnce == 0)
            {
                operation = "+";
                clickOnce = 1;
                minusClick = 0;
            }

            if (xPressed && yPressed)
            {
                result = x + y;
                Display.Text = result.ToString();
                y = float.Parse(Display.Text);
                x = 0;
                clickOnce = 0;
                result = 0;
                xPressed = false;
            }

        }

        private void But_1_Clicked(object sender, EventArgs e)
        {
            if (minusClick != 0)
            {
                if (operation != "")
                {
                    if (x == 0)
                    {
                        Display.Text = "";
                        x = 1;
                        Display.Text = Display.Text + x.ToString();
                    }
                    else
                    {
                        Display.Text = Display.Text + "1";
                        x = float.Parse(Display.Text);
                    }
                }
                else
                {
                    if (y == 0)
                    {
                        y = 1;
                        Display.Text = Display.Text + y.ToString();
                    }
                    else
                    {
                        Display.Text = Display.Text + "1";
                        y = float.Parse(Display.Text);
                    }
                }
            }
            else
            {
                if (operation != "")
                {
                    if (x == 0)
                    {
                        xPressed = true;
                        Display.Text = "";
                        x = 1;
                        Display.Text = x.ToString();
                        x = float.Parse(Display.Text);
                    }
                    else
                    {
                        xPressed = true;
                        Display.Text = Display.Text + "1";
                        x = float.Parse(Display.Text);
                    }
                }
                else
                {
                    if (y == 0)
                    {
                        yPressed = true;
                        y = 1;
                        Display.Text = y.ToString();
                    }
                    else
                    {
                        yPressed = true;
                        Display.Text = Display.Text + "1";
                        y = float.Parse(Display.Text);
                    }
                }
            }
        }

        private void But_2_Clicked(object sender, EventArgs e)
        {
            if (minusClick != 0)
            {
                if (operation != "")
                {
                    if (x == 0)
                    {
                        x = 2;
                        Display.Text = Display.Text + x.ToString();
                    }
                    else
                    {
                        Display.Text = Display.Text + "2";
                        x = float.Parse(Display.Text);
                    }
                }
                else
                {
                    if (y == 0)
                    {
                        y = 2;
                        Display.Text = Display.Text + y.ToString();
                    }
                    else
                    {
                        Display.Text = Display.Text + "2";
                        y = float.Parse(Display.Text);
                    }
                }
            }
            else
            {
                if (operation != "")
                {
                    if (x == 0)
                    {
                        xPressed = true;
                        Display.Text = "";
                        x = 2;
                        Display.Text = x.ToString();
                        x = float.Parse(Display.Text);
                    }
                    else
                    {
                        xPressed = true;
                        Display.Text = Display.Text + "2";
                        x = float.Parse(Display.Text);
                    }
                }
                else
                {
                    if (y == 0)
                    {
                        yPressed = true;
                        y = 2;
                        Display.Text = y.ToString();
                    }
                    else
                    {
                        yPressed = true;
                        Display.Text = Display.Text + "2";
                        y = float.Parse(Display.Text);
                    }
                }
            }
        }

        private void But_3_Clicked(object sender, EventArgs e)
        {
            if (minusClick != 0)
            {
                if (operation != "")
                {
                    if (x == 0)
                    {
                        x = 3;
                        Display.Text = Display.Text + x.ToString();
                    }
                    else
                    {
                        Display.Text = Display.Text + "3";
                        x = float.Parse(Display.Text);
                    }
                }
                else
                {
                    if (y == 0)
                    {
                        y = 3;
                        Display.Text = Display.Text + y.ToString();
                    }
                    else
                    {
                        Display.Text = Display.Text + "3";
                        y = float.Parse(Display.Text);
                    }
                }
            }
            else
            {
                if (operation != "")
                {
                    if (x == 0)
                    {
                        xPressed = true;
                        Display.Text = "";
                        x = 3;
                        Display.Text = x.ToString();
                        x = float.Parse(Display.Text);
                    }
                    else
                    {
                        xPressed = true;
                        Display.Text = Display.Text + "3";
                        x = float.Parse(Display.Text);
                    }
                }
                else
                {
                    if (y == 0)
                    {
                        yPressed = true;
                        y = 3;
                        Display.Text = y.ToString();
                    }
                    else
                    {
                        yPressed = true;
                        Display.Text = Display.Text + "3";
                        y = float.Parse(Display.Text);
                    }
                }
            }
        }

        private void But_0_Clicked(object sender, EventArgs e)
        {
            if (minusClick != 0)
            {
                if (operation != "")
                {
                    if (x == 0)
                    {
                        x = 0;
                        Display.Text = Display.Text + x.ToString();
                    }
                    else
                    {
                        Display.Text = Display.Text + "0";
                        x = float.Parse(Display.Text);
                    }
                }
                else
                {
                    if (y == 0)
                    {
                        y = 0;
                        Display.Text = Display.Text + y.ToString();
                    }
                    else
                    {
                        Display.Text = Display.Text + "0";
                        y = float.Parse(Display.Text);
                    }
                }
            }
            else
            {
                if (operation != "")
                {
                    if (x == 0)
                    {
                        xPressed = true;
                        Display.Text = "";
                        x = 0;
                        Display.Text = x.ToString();
                        x = float.Parse(Display.Text);
                    }
                    else
                    {
                        xPressed = true;
                        Display.Text = Display.Text + "0";
                        x = float.Parse(Display.Text);
                    }
                }
                else
                {
                    if (y == 0)
                    {
                        yPressed = true;
                        y = 0;
                        Display.Text = y.ToString();
                    }
                    else
                    {
                        yPressed = true;
                        Display.Text = Display.Text + "0";
                        y = float.Parse(Display.Text);
                    }
                }
            }
        }
        private void But_point_Clicked(object sender, EventArgs e)
        {
            if (clickPoint == 0)
            {
                Display.Text = Display.Text + ".";
                clickPoint++;
            }
        }

        private void But_equal_Clicked(object sender, EventArgs e)
        {
            clickOnce = 0;

            if (operation == "+")
            {
                result = x + y;
                Display.Text = result.ToString();
                y = float.Parse(Display.Text);
                operation = "";
                x = 0;
            }

            else if (operation == "-")
            {
                result = y - x;
                Display.Text = result.ToString();
                y = float.Parse(Display.Text);
                operation = "";
                x = 0;
            }

            else if (operation == "*")
            {
                result = x * y;
                Display.Text = result.ToString();
                y = float.Parse(Display.Text);
                operation = "";
                x = 0;
            }

            else if (operation == "/")
            {
                result = y / x;
                Display.Text = result.ToString();
                y = float.Parse(Display.Text);
                operation = "";
                x = 0;
            }

            else if (operation == "%")
            {
                if (Display.Text != null)
                {
                    result = float.Parse(Display.Text) / 100;
                    Display.Text = result.ToString();
                    y = float.Parse(Display.Text);
                    operation = "";
                    x = 0;

                }

            }

        }

        public void checkOperation()
        {
            clickOnce = 0;

            if (operation == "+")
            {
                result = x + y;
                Display.Text = result.ToString();
                y = float.Parse(Display.Text);
                operation = "";
                x = 0;
                xPressed = false;
            }

            else if (operation == "-")
            {
                result = y - x;
                Display.Text = result.ToString();
                y = float.Parse(Display.Text);
                operation = "";
                x = 0;
                xPressed = false;
            }

            else if (operation == "*")
            {
                result = x * y;
                Display.Text = result.ToString();
                y = float.Parse(Display.Text);
                operation = "";
                x = 0;
                xPressed = false;
            }

            else if (operation == "/")
            {
                result = y / x;
                Display.Text = result.ToString();
                y = float.Parse(Display.Text);
                operation = "";
                x = 0;
                xPressed = false;
            }

            else if (operation == "%")
            {
                if (Display.Text != null)
                {
                    result = float.Parse(Display.Text) / 100;
                    Display.Text = result.ToString();
                    y = float.Parse(Display.Text);
                    operation = "";
                    x = 0;
                    xPressed = false;

                }

            }
        }


    }
}