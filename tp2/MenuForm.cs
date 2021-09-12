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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void btnEj1_Click(object sender, EventArgs e)
        {
            Form ej01Form = new Ej01Form();
            ej01Form.ShowDialog();
        }

        private void btnEj2_Click(object sender, EventArgs e)
        {
            Form ej02Form = new Ej02Form();
            ej02Form.ShowDialog();
        }

        private void btnEj3_Click(object sender, EventArgs e)
        {
            Form ej03Form = new Ej03Form();
            ej03Form.ShowDialog();
        }

        private void btnEj4_Click(object sender, EventArgs e)
        {
            Form ej04Form = new Ej04Form();
            ej04Form.ShowDialog();
        }
    }
}
