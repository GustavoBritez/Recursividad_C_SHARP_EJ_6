using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTN_INGRESAR_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TX_1.Text))
            {
                if (Int32.TryParse(TX_1.Text, out int num))
                {
                    int resultado = Suma_Postivos(num);
                    LT_1.Items.Add(resultado);
                }
                else
                {
                    MessageBox.Show(" ERROR: Numero invalido");
                }
            }
            else
            {
                MessageBox.Show(" ERROR: Vacio");
            }
        }

        public int Suma_Postivos( int n )
        {
            if( n % 2 != 0)
            {
                MessageBox.Show(" ERROR: Numero Impar");
                return 0;
            }

            if ( n % 2 == 0  && n > 2)
            {
                return n + Suma_Postivos( n-2);
            }
            else
            {
                return n;
            }
        }
    }
}
