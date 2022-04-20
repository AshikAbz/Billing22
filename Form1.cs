using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Billing22
{
    public partial class Form1 : Form
    {
        double bread = 30;
        double rice = 36;
        double beans = 26;
        double milk = 25;
        double wine = 20;

        double[] items = new double[7];
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            double i = Convert.ToDouble(numbread.Value);
            lblbread.Text = String.Format("{0:c2}", i * bread);
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            double i = Convert.ToDouble(numrice.Value);
            lblrice.Text = String.Format("{0:c2}", i*rice);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            try
            {
                iExit = MessageBox.Show("confirm if you want to exit", "Billing Manage System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (iExit == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            numbread.Value = 0;
            numbeans.Value = 0;
            numrice.Value = 0;
            numwine.Value = 0;
            nummilk.Value = 0;
            numtot.Value = 0;
            raseet.Clear();

            lblbread.Text = "0";
            lblrice.Text = "0";
            lblwine.Text = "0";
            lblmilk.Text = "0";
            lblbeans.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    printPreviewDialog1.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Billing Manage System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            {
                try
                {
                    System.Drawing.Font fntString = new System.Drawing.Font("Arial", 18, FontStyle.Regular);
                    e.Graphics.DrawString(raseet.Text, fntString, Brushes.Black, 120, 120);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Billing Manage Systems", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void numbeans_ValueChanged(object sender, EventArgs e)
        {
            double i = Convert.ToDouble(numbeans.Value);
            lblbeans.Text = String.Format("{0:c2}", i * beans);
        }

        private void numwine_ValueChanged(object sender, EventArgs e)
        {
            double i = Convert.ToDouble(numwine.Value);
            lblwine.Text = String.Format("{0:c2}", i * wine);
        }

        private void nummilk_ValueChanged(object sender, EventArgs e)
        {
            double i = Convert.ToDouble(nummilk.Value);
            lblmilk.Text = String.Format("{0:c2}", i * milk);
        }

        private void Btn_Tot(object sender, EventArgs e)
        {
            double[] a = new double[7];
            a[0] = Convert.ToDouble(numbread.Value);
            a[1] = Convert.ToDouble(numrice.Value); 
            a[2] = Convert.ToDouble(numbeans.Value);
            a[3] = Convert.ToDouble(numwine.Value);
            a[4] = Convert.ToDouble(nummilk.Value);
            a[5] = a[0] + a[1] + a[2] + a[3] + a[4];
            numtot.Text = Convert.ToString(a[5]);

            items[0] = a[0] * bread;
            items[1] = a[1] * rice; 
            items[2] = a[2] * beans;
            items[3] = a[3] * wine;
            items[4] = a[4] * milk;
            items[5] = items[0] + items[1] + items[2] + items[3] + items[4];
            lbltot.Text =Convert.ToString(items[5]);
        }

        private void reciept(object sender, EventArgs e)
        {
            raseet.Clear();
            raseet.AppendText(label13.Text +  "\t"  + "\t"  + label2.Text + "\t"  + "\t" + label3.Text + "\t"  + "\t" + "\n" );
            raseet.AppendText(label1.Text + "\t" + "\t" + "\t" + numbread.Text + "\t" + "\t" + "\t" + lblbread.Text + "\t" + "\t" + "\t" + "\n" );
            raseet.AppendText(label6.Text + "\t" + "\t" + "\t" + "\t" + numrice.Text + "\t" + "\t" + "\t"  + lblrice.Text+ "\n" + "\n"   );
            raseet.AppendText(label4.Text + "\t" + "\t" + "\t" + numbeans.Text + "\t" + "\t" + "\t"  + lblbeans.Text + "\t" + "\t" + "\n");
            raseet.AppendText(label8.Text + "\t" + "\t" + "\t" + numwine.Text + "\t" + "\t" + "\t" + lblwine.Text + "\t" + "\t" + "\n");
            raseet.AppendText(label10.Text + "\t" + "\t" + "\t" + "\t" + nummilk.Text + "\t" + "\t" + "\t" + lblmilk.Text+ "\n" + "\n" + "\n");
            raseet.AppendText(label12.Text + "\t" + "\t" + "\t" + numtot.Text + "\t" + "\t" + "\t" + lbltot.Text+"\n" + "\n" + "\n");
        }

        private void lblbread_Click(object sender, EventArgs e)
        {

        }

        private void lblrice_Click(object sender, EventArgs e)
        {

        }
    }
}
