using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex3
{
    public partial class Calculator : Form
    {

        CalcEngine calc = new CalcEngine();
        public Calculator()
        {
            InitializeComponent();

            addition.Text = "+";
            multiplikation.Text = "*";
            Subtraktion.Text = "-";
            Division.Text = "/";

            addition.Click += new EventHandler(ButtonHandler);
            multiplikation.Click += new EventHandler(ButtonHandler);
            Subtraktion.Click += new EventHandler(ButtonHandler);
            Division.Click += new EventHandler(ButtonHandler);
            textBox1.KeyPress += new KeyPressEventHandler(KeyPressControl);



        }

        private void KeyPressControl(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9')
            {
                
                if (((short)e.KeyChar) != 8)
                {
                    e.Handled = true;
                }
            }
        }

        private void ButtonHandler(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int i = int.Parse(textBox1.Text);
            int j = int.Parse(textBox2.Text);
            int answer = 0;



            try
            {


                switch (btn.Text)
                {
                    case "+":
                        answer = calc.Add(i, j);
                        break;
                    case "*":
                        answer = calc.Mult(i, j);
                        break;
                    case "/":
                        answer = calc.Div(i, j);
                        break;
                    case "-":
                        answer = calc.Dif(i, j);
                        break;



                }

                PresentResult(i, j, answer, (sender as Button).Text);

            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("You can not divide a number with zero");
            }
            }

        private static void PresentResult(int i, int j, int answer, string operation)
        {
            MessageBox.Show($"{i} {operation} {j} = {answer}");
        }
         

}
}
