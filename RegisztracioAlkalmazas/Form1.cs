using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RegisztracioAlkalmazas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonMentes_Click(object sender, EventArgs e)
        {
            TextWriter txt = new StreamWriter("regisztracio.txt");
            txt.WriteLine(textBoxNev.Text);
            txt.WriteLine(textBoxSzulDatum.Text);
            if (radioButtonFerfi.Checked)
            {
                txt.WriteLine("Férfi");
            }
            else {
                txt.WriteLine("Nő");
            }
            txt.WriteLine(listBoxHobbik.SelectedItem);
            
            txt.Close();
        }
    }
}
