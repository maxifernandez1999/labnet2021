using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp1
{
    public partial class Form1 : Form
    {
        DataTable table;
        List<TransportePublico> publicTransport = new List<TransportePublico>();
        public Form1()
        {
            InitializeComponent();
            Init();

        }

        
        private void Init()
        {
            table = new DataTable();
            table.Columns.Add("Tipo de Vehiculo");
            table.Columns.Add("Nombre Conductor");
            table.Columns.Add("Cantidad Pasajeros");
            dataGrid.DataSource = table;

            rbTaxi.Checked = true;
        }

        private void SetData()
        {
            string driverName = txtName.Text;
            int passengers = (int)numericPassagers.Value;
            
            if (rbOmnibus.Checked)
            {
                Omnibus omnibus = new Omnibus(passengers, driverName, 30);

                if (omnibus.DriverName != "error")
                {
                    if (omnibus.Pasajeros <= omnibus.MaxCapacity)
                    {
                        if (publicTransport.Count >=10)
                        {
                            lbAlert.Text = "No se puede registrar mas transportes (maximo: 10)";
                        }
                        else
                        {

                            publicTransport.Add(omnibus);
                        }

                    }
                    else
                    {
                        lbAlert.Text = $"Un Omnibus solo puede llevar un maximo de {omnibus.MaxCapacity} pasajeros";
                    }

                }
                else
                {
                    lbAlert.Text = "El nombre del conductor solo puede contener letras";
                }
               
                
                
            }
            if (rbTaxi.Checked)
            {
                Taxi taxi = new Taxi(passengers, driverName, 5);
                if (taxi.DriverName != "error")
                {
                    if (taxi.Pasajeros <= taxi.MaxCapacity)
                    {
                        if (publicTransport.Count >= 10)
                        {
                            lbAlert.Text = "No se puede registrar mas transportes (maximo: 10)";
                        }
                        else
                        {

                            publicTransport.Add(taxi);
                        }

                    }
                    else
                    {
                        lbAlert.Text = $"Un Omnibus solo puede llevar un maximo de {taxi.MaxCapacity} pasajeros";
                    }
                }
                else
                {
                    lbAlert.Text = "El nombre del conductor solo puede contener letras";
                }
            }
                
                    
        }
        private void GetData()
        {
            
            foreach (var transport in publicTransport)
            {
                DataRow row = table.NewRow();
                if (transport.GetType() == typeof(Omnibus))
                {
                    row["Tipo de Vehiculo"] = "Omnibus";
                    row["Nombre Conductor"] = transport.DriverName;
                    row["Cantidad Pasajeros"] = transport.Pasajeros;
                    
                }
                if (transport.GetType() == typeof(Taxi))
                {
                    row["Tipo de Vehiculo"] = "Taxi";
                    row["Nombre Conductor"] = transport.DriverName;
                    row["Cantidad Pasajeros"] = transport.Pasajeros;
                    
                }
                table.Rows.Add(row);
            }
        }

        private void ClearDataGrid()
        {
            table.Rows.Clear();
        }
        private void Clear()
        {
            publicTransport.RemoveRange(0, publicTransport.Count);
        }

        private void btnTrasport_Click(object sender, EventArgs e)
        {
            ClearDataGrid();
            SetData();
            GetData();
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Clear();
            ClearDataGrid();
        }
    }
}
