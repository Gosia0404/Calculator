using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator2
{
    public partial class Form1 : Form
    {
        private enum operation
        {
            NULL,
            ADD,
            SUBTRACT,
            MULTIPLY,
            DIVIDE
        }
        operation op;
        double? stored = null;
        bool negative = false;
        bool comma = false;
        bool error = false;
        bool newnumber = false;
        public Form1()
        {
            InitializeComponent();
            op = operation.NULL;
            textActive.Text = "0";
        }

        private void b_number_Click(object sender, EventArgs e)
        {
            Button? b = sender as Button;
            if (b != null)
            {
                if (error)
                {
                    textActive.Text = b.Text.ToString();
                    error = false;
                }
                if (newnumber)
                {
                    textActive.Text = b.Text.ToString();
                    newnumber = false;
                    if (negative) negative = false;
                    if (comma) comma = false;
                }
                else if (textActive.Text == "0")
                {
                    if (b.Text != "0")
                    {
                        textActive.Text = b.Text.ToString();
                        if (negative) negative = false;
                        if (comma) comma = false;
                    }
                }
                else textActive.Text += b.Text.ToString();
            }
        }

        private void b_operation_click(object sender, EventArgs e)
        {
            Button? b = sender as Button;
            if (b != null && !error)
            {
                // Tutaj dzia³ania jednoelementowe
                if (b.Name == "bReverse")
                {
                    if (Double.Parse(textActive.Text) != 0)
                    {
                        if (op == operation.NULL)
                        {
                            textPrev.Text = "(1 / " + textActive.Text + ") = ";
                        }
                        else textPrev.Text += "(1 / " + textActive.Text + ") = ";
                        textActive.Text = (1 / Double.Parse(textActive.Text)).ToString();
                    }
                    else
                    {
                        error = true;
                        textActive.Text = "Niepoprawne dane!";
                    }
                }
                if (b.Name == "bPower")
                {
                    if (op == operation.NULL)
                    {
                        textPrev.Text = "pow(" + textActive.Text + ") = ";
                    }
                    else textPrev.Text += "pow(" + textActive.Text + ") = ";
                    textActive.Text = (Math.Pow(Double.Parse(textActive.Text), 2)).ToString();
                }
                if (b.Name == "bRoot")
                {
                    if (Double.Parse(textActive.Text) >= 0)
                    {
                        if (op == operation.NULL)
                        {
                            textPrev.Text = "sqrt(" + textActive.Text + ") = ";
                        }
                        else textPrev.Text += "sqrt(" + textActive.Text + ") = ";
                        textActive.Text = (Math.Sqrt(Double.Parse(textActive.Text))).ToString();
                    }
                    else
                    {
                        error = true;
                        textActive.Text = "Niepoprawne dane!";
                    }
                }

                //Czy bylo ustawione wczesniej dzialanie?
                if (b.Name == "bEqual" && op != operation.NULL)
                {
                    textPrev.Text += textActive.Text + " = ";
                }
                if (op == operation.ADD)
                {
                    textActive.Text = (stored + Double.Parse(textActive.Text)).ToString();
                }
                if (op == operation.SUBTRACT)
                {
                    textActive.Text = (stored - Double.Parse(textActive.Text)).ToString();
                }
                if (op == operation.MULTIPLY)
                {
                    textActive.Text = (stored * Double.Parse(textActive.Text)).ToString();
                }
                if (op == operation.DIVIDE)
                {
                    if (Double.Parse(textActive.Text) == 0)
                    {
                        error = true;
                        textActive.Text = "Niepoprawne dane!";
                    }
                    else textActive.Text = (stored / Double.Parse(textActive.Text)).ToString();
                }
                
                //je¿eli jest to dzia³anie dwuelementowe
                if (!error) stored = Double.Parse(textActive.Text);
                if (b.Name == "bAdd")
                {
                    textPrev.Text = stored.ToString() + " + ";
                    op = operation.ADD;
                }
                if (b.Name == "bSub")
                {
                    textPrev.Text = stored.ToString() + " - ";
                    op = operation.SUBTRACT;
                }
                if (b.Name == "bMul")
                {
                    textPrev.Text = stored.ToString() + " * ";
                    op = operation.MULTIPLY;
                }
                if (b.Name == "bDiv")
                {
                    textPrev.Text = stored.ToString() + " / ";
                    op = operation.DIVIDE;
                }
                if ((b.Name == "bEqual" || b.Name == "bPower" || b.Name == "bRoot" || b.Name == "bReverse") && !error)
                {
                    textActive.Text = stored.ToString();
                    op = operation.NULL;
                    newnumber = true;
                }
                else if (!error) textActive.Text = "0";
            }
        }

        private void b_special_click(object sender, EventArgs e)
        {
            Button? b = sender as Button;
            if (b != null)
            {
                if (b.Name == "bPlusMinus" && textActive.Text != "0")
                {
                    if (negative)
                    {
                        textActive.Text = textActive.Text.Substring(1, textActive.TextLength - 1);
                        negative = false;
                    }
                    else
                    {
                        textActive.Text = "-" + textActive.Text;
                        negative = true;
                    }
                }
                if (b.Name == "bPoint")
                {
                    if (!comma)
                    {
                        textActive.Text += ",";
                        comma = true;
                    }
                }
            }
        }

        private void b_erase_click(object sender, EventArgs e)
        {
            Button? b = sender as Button;
            if (b != null)
            {
                if (b.Name == "bBackspace")
                {
                    if (textActive.TextLength > 0)
                    {
                        if (textActive.Text.EndsWith(","))
                        {
                            comma = false;
                        }
                        textActive.Text = textActive.Text.Substring(0, textActive.TextLength - 1);
                        if (textActive.Text.Length == 1 && textActive.Text.StartsWith("-"))
                        {
                            textActive.Text = "0";
                            textPrev.Text = "0";
                            negative = false;
                        }
                    }
                    if (textActive.TextLength == 0)
                    {
                        textActive.Text = "0";
                        textPrev.Text = "0";
                    }
                }
                if (b.Name == "bClearActive")
                {
                    textActive.Text = "0";
                    textPrev.Text = "0";
                    negative = false;
                    comma = false;
                    error = false;
                    stored = null;
                    op = operation.NULL;
                }
            }
        }
    }
}
