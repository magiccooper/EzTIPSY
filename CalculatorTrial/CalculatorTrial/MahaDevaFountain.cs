using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace CalculatorTrial
{
  public partial class MahaDevaFountain : Form
  {
    WebClient wc = new WebClient();
    public MahaDevaFountain()
    {
      InitializeComponent();
    }

    private void button3_Click(object sender, EventArgs e)
    {
      Form1 fir = new Form1();
      fir.ShowDialog();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      System.Diagnostics.Process.Start("https://www.dropbox.com/s/79kp5tkaainvxiu/Final%20desing%20maha%20Drawing%20v1.pdf?dl=0");
    }

    private void button2_Click(object sender, EventArgs e)
    {
      System.Diagnostics.Process.Start("https://www.dropbox.com/s/jhn3sd4zfmbw05q/Final%20desing%20maha%20Drawing%20v1.dwg?dl=0");
    }
  }
}
