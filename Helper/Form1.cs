using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Helper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtBinaryN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txtAplha.Text))
                {
                    double aplha = Convert.ToDouble(txtAplha.Text);

                    if (!string.IsNullOrEmpty(txtBinaryN.Text))
                    {
                        int numBinary = Convert.ToInt32(txtBinaryN.Text);

                        double schvnNDouble = Math.Log(2, Math.E) * numBinary / Math.Log(aplha, Math.E);
                        //int schvnNInt = (int)Math.Ceiling(schvnNDouble);

                        txtScvhN.Text = schvnNDouble.ToString();

                    }
                    else
                    {
                        MessageBox.Show("Неправильно введені параметри");
                    }
                }
                else
                {
                    MessageBox.Show("Неправильно введені параметри");
                }
            }
        }

        private void txtScvhN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter)
            {
                if (!string.IsNullOrEmpty(txtAplha.Text))
                {
                    double aplha = Convert.ToDouble(txtAplha.Text);

                    if (!string.IsNullOrEmpty(txtScvhN.Text))
                    {
                        int numSchvn = Convert.ToInt32(txtScvhN.Text);

                        double binaryNDouble = Math.Log(aplha, Math.E) * numSchvn / Math.Log(2, Math.E);
                        //int binaryNInt = (int)Math.Ceiling(binaryNDouble);

                        txtBinaryN.Text = binaryNDouble.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Неправильно введені параметри");
                    }
                }
                else
                {
                    MessageBox.Show("Неправильно введені параметри");
                }
            }
        }
    }
}
