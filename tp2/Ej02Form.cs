using System;
using Entity;
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
    public partial class Ej02Form : Form
    {
        public Ej02Form()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                float dividend = float.Parse(txtDividend.Text);
                float divider = float.Parse(txtDivider.Text);
                Operation operation = new Operation(dividend, divider);
                float result = operation.Divide();
                MessageBox.Show($"El resultado de la division es: {result}");
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Seguro Ingreso una letra o no ingreso nada!.\nException: {ex.GetType()}. {ex.Message}");
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show($"Solo Marcelo Gallardo puede Dividir por Cero!.\nException: {ex.GetType()}. {ex.Message}");
            }
            finally
            {
                MessageBox.Show("La operacion a finalizado");
            }


        }
    }
}
