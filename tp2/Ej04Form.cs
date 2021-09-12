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
using Entity.Exceptions;

namespace tp2
{
    public partial class Ej04Form : Form
    {
        public Ej04Form()
        {
            InitializeComponent();
        }

        private void btnException_Click(object sender, EventArgs e)
        {
            try
            {
                Logic.ThrowCustomException();
            }
            catch (CustomException ex)
            {
                MessageBox.Show($"Exception: {ex.GetType()}.\nMensaje: {ex.Message}");
            }
            finally
            {
                MessageBox.Show("La operacion a finalizado");
            }
        }
    }
}
