using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp2
{
    public partial class Ej01Form : Form
    {
        public Ej01Form()
        {
            InitializeComponent();
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                Operation operation = new Operation((float)numericEj01.Value);
                operation.DivideByZero();
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show($"Se ha producido un excepcion de tipo {ex.GetType()} : {ex.Message}");
            }
            finally
            {
                MessageBox.Show("La operacion a finalizado");
            }
        }
    }
}
