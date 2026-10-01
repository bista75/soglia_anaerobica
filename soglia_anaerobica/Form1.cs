using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace soglia_anaerobica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_n1_Click(object sender, EventArgs e)
        {
            int eta;
            float risultato;
            if(txt_eta.Text.Length > 0)
            {
                eta = int.Parse(txt_eta.Text);
                if (eta>0 && eta<120)
                {
                    risultato = (220 - eta) * 0.935f;
                    lbl_n3.Text = risultato.ToString();
                }
                else
                {
                    MessageBox.Show("Età troppo alta");
                }
               

            }
            else
            {
                MessageBox.Show("l'età non è stata inserita");
            }

            
        }
    }
}
