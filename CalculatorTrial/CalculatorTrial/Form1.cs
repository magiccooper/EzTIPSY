using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorTrial
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (isOperationPerformed))
                textBox1.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;
            if(button.Text == ".")
            {
                if(!textBox1.Text.Contains("."))
                    textBox1.Text = textBox1.Text + button.Text;
            }
            else

            textBox1.Text = textBox1.Text + button.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultValue != 0)
            {
                button18.PerformClick();
                operationPerformed = button.Text;
                resultValue = Double.Parse(textBox1.Text);
                label1.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;

            }
            else
            {
                operationPerformed = button.Text;
                resultValue = Double.Parse(textBox1.Text);
                label1.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            resultValue = 0;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    textBox1.Text=(resultValue + Double.Parse(textBox1.Text)).ToString();
                    break;

                case "-":
                    textBox1.Text = (resultValue - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (resultValue * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (resultValue / Double.Parse(textBox1.Text)).ToString();
                    break;
                default:
                    break;

            }

            resultValue = Double.Parse(textBox1.Text);
            label1.Text = "";
        }

        private void button19_Click(object sender, EventArgs e)
        {
          //define variables
          double height, length, width;
          double area, permiter, volume;

          //get the input
          if(LengthBox.Text =="")
          {
            MessageBox.Show("Value is missing.", "Input Length"); return;
          }

          if(WidthBox.Text =="")
          {
            MessageBox.Show("Value is missing.", "Input Width"); return;
          }

          if(HeightBox.Text =="")
          {
            MessageBox.Show( "Input Height or Input '0'"); return;

          }

          height = Convert.ToDouble(HeightBox.Text);
          length = Convert.ToDouble(LengthBox.Text);
          width = Convert.ToDouble(LengthBox.Text);

          //Calculation 
          area = width * length;
          AreaBox.Text = area.ToString("");
          permiter = length + width;
          PermiterBox.Text = permiter.ToString("");
          volume = height * length * width;
          VolumeBox.Text = volume.ToString("");

         
        }

        private void button20_Click(object sender, EventArgs e)
        {
          HeightBox.Clear();
          LengthBox.Clear();
          WidthBox.Clear();
          AreaBox.Clear();
          PermiterBox.Clear();
          VolumeBox.Clear();



        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
          //define variables
          double BatteryCapacity, Load;
          double batterylast;

          if (BatteryCapacitytxtBox.Text == "")
          {
            MessageBox.Show("Value is missing.", "Input Battery Capacity"); return;
          }
          if (Loadtxtbox.Text == "")
          {
            MessageBox.Show("Value is missing.", "Input Load data"); return;
          }
          
          // Calculation
          BatteryCapacity = Convert.ToDouble(BatteryCapacitytxtBox.Text);
          Load = Convert.ToDouble(Loadtxtbox.Text);
          batterylast = (BatteryCapacity/Load) *3600 ;

          //Display output
          TimeSpan test = TimeSpan.FromSeconds(batterylast);
          Batterylasttxtbox.Text = test.ToString();
                             
        }

        private void button22_Click(object sender, EventArgs e)
        {
          BatteryCapacitytxtBox.Clear();
          Loadtxtbox.Clear();
          Batterylasttxtbox.Clear();
        }

        private void button23_Click(object sender, EventArgs e)
        {
          MahaDevaFountain sec= new MahaDevaFountain ();
          sec.ShowDialog();
        }
    }
}
