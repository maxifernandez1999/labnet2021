using Lab.Tp4.EF.Entities;
using Lab.Tp4.EF.Logic;
using Lab.Tp4.EF.Logic.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab.Tp4.EF.UI
{
    public partial class ABMForm : Form
    {
        private DataTable _tableTerritories;
        private DataTable _tableShippers;
        private DataTable _tableCategories;
        private DataTable _tableEmployeeTerritories;

        public ABMForm()
        {
            InitializeComponent();
            this._tableTerritories = new DataTable();
            this._tableShippers = new DataTable();
            this._tableCategories = new DataTable();
            this._tableEmployeeTerritories = new DataTable();
            this.CreateDataTable("shipper");
            this.CreateDataTable("territory");
            this.CreateDataTable("category");
            this.CreateDataTable("ETerritory");


        }
        private void CreateDataTable(string table)
        {
            switch (table)
            {
                case "shipper":
                    this._tableShippers.Columns.Add("ShipperID").ReadOnly = true;
                    this._tableShippers.Columns.Add("CompanyName");
                    this._tableShippers.Columns.Add("Phone");
                    break;
                case "territory":
                    this._tableTerritories.Columns.Add("TerritoryID");
                    this._tableTerritories.Columns.Add("TerritoryDescription");
                    this._tableTerritories.Columns.Add("RegionID");
                    break;
                case "category":
                    this._tableCategories.Columns.Add("CategoryID");
                    this._tableCategories.Columns.Add("CategoryName");
                    this._tableCategories.Columns.Add("Description");
                    this._tableCategories.Columns.Add("Picture");
                    break;
                case "ETerritory":
                    this._tableEmployeeTerritories.Columns.Add("EmployeeID");
                    this._tableEmployeeTerritories.Columns.Add("TerritoryID");
                    
                    break;

                default:
                    break;
            }
            
        }
        private void ClearDataTable()
        {
            this._tableShippers.Rows.Clear();
            this._tableTerritories.Rows.Clear();
            this._tableCategories.Rows.Clear();
            this._tableEmployeeTerritories.Rows.Clear();
        }
        private void btnGetTerritories_Click(object sender, EventArgs e)
        {
            this.btnDeleteTerritoryEmployee.Enabled = false;
            this.gbDatosShipper.Enabled = false;
            this.ClearDataTable();
            TerritoryLogic territories = new TerritoryLogic();

            try
            {
                foreach (var territory in territories.GetAll())
                {
                    this._tableTerritories.Rows.Add(territory.TerritoryID,
                                                    territory.TerritoryDescription,
                                                    territory.RegionID);
                }
                this.dgDatos.DataSource = this._tableTerritories;
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error al cargar la lista, intente de nuevo!");
            }

            
        }

        private void btnGetShippers_Click(object sender, EventArgs e)
        {
            this.btnDeleteTerritoryEmployee.Enabled = false;
            this.gbDatosShipper.Enabled = true;
            this.ClearDataTable();
            this.ShowShippers();
        }

       

        private void ShowShippers()
        {
            try
            {
                ShipperLogic shippers = new ShipperLogic();

                foreach (var shipper in shippers.GetAll())
                {
                    this._tableShippers.Rows.Add(shipper.ShipperID,
                                    shipper.CompanyName,
                                    shipper.Phone);

                }
                this.dgDatos.DataSource = this._tableShippers;

                }
            catch (Exception)
            {

                MessageBox.Show("Ocurrio un error al cargar la lista, intente de nuevo!");
            }
        }

        private void ShowEmployeeTerritories()
        {
            try
            {
                EmployeeTerritoryLogic employeeTerritory = new EmployeeTerritoryLogic();

                foreach (var territory in employeeTerritory.GetAll())
                {
                    this._tableEmployeeTerritories.Rows.Add(territory.EmployeeID,
                                                    territory.TerritoryID);
                }
                this.dgDatos.DataSource = this._tableEmployeeTerritories;

            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error al cargar la lista, intente de nuevo!");
            }
        }

     

        private void btnGetCategories_Click(object sender, EventArgs e)
        {
            this.btnDeleteTerritoryEmployee.Enabled = false;
            this.gbDatosShipper.Enabled = false;
            this.ClearDataTable();
            try
            {
                CategoryLogic categories = new CategoryLogic();

                foreach (var category in categories.GetAll())
                {
                    this._tableCategories.Rows.Add( category.CategoryID,
                                                    category.CategoryName,
                                                    category.Description,
                                                    category.Picture );
                }
                this.dgDatos.DataSource = this._tableCategories;

            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error al cargar la lista, intente de nuevo!");
            }
        }


        private void btnAddShipper_Click(object sender, EventArgs e)
        {
            ShipperLogic shipper = new ShipperLogic();

            if (MessageBox.Show("Esta seguro que desea agregar nuevo Shipper?", "Cerrar sin Guardar?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (txtPhone.Text.IsValidPhoneExtension())
                {
                    try
                    {
                        shipper.Add(new Shipper
                        {
                            CompanyName = txtCompanyName.Text,
                            Phone = txtPhone.Text

                        });
                        this.ClearDataTable();

                        MessageBox.Show("Shipper Agregado!");

                        this.ShowShippers();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ha ocurrido un error con el agregado, porfavor intente de nuevo");
                    }
                    
                }
                else
                {
                    MessageBox.Show("El formato del numero de telefono no es el correcto!\nEj: (555) 345-5678");
                }
            }
            else
            {
                
                MessageBox.Show("Operacion Cancelada!");
            }
            
        }

        private void btnUpdateShipper_Click(object sender, EventArgs e)
        {
            ShipperLogic shipper = new ShipperLogic();
            var id = this.dgDatos.CurrentRow.Cells[0].Value;
            try
            {
                shipper.Update(new Shipper
                {
                    ShipperID = int.Parse((string)id),
                    CompanyName = this.dgDatos.CurrentRow.Cells[1].Value.ToString(),
                    Phone = this.dgDatos.CurrentRow.Cells[2].Value.ToString()

                });
                MessageBox.Show("Update realizado con exito!");
                this.ClearDataTable();
                this.ShowShippers();

            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error la actualizacion del registro, intente de nuevo!");
            }
            

        }

        private void btnGetTerritoryEmployee_Click(object sender, EventArgs e)
        {
            this.btnDeleteTerritoryEmployee.Enabled = true;
            this.gbDatosShipper.Enabled = false;
            this.ClearDataTable();
            this.ShowEmployeeTerritories();
        }

        private void btnDeleteTerritoryEmployee_Click(object sender, EventArgs e)
        {
            
            EmployeeTerritoryLogic territoryEmployee = new EmployeeTerritoryLogic();
            var id = this.dgDatos.CurrentRow.Cells[1].Value;
            try
            {
                territoryEmployee.Delete(Convert.ToInt32(id));
                MessageBox.Show("Eliminacion realizado con exito realizado con exito!");
                this.ClearDataTable();
                this.ShowEmployeeTerritories();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error con la eliminacion del elemento, intente de nuevo!");
            }
            
        }

        private void btnDeleteShipper_Click(object sender, EventArgs e)
        {
            ShipperLogic shipper = new ShipperLogic();
            var id = this.dgDatos.CurrentRow.Cells[0].Value;
            try
            {
                shipper.Delete(Convert.ToInt32(id));
                MessageBox.Show("Eliminacion realizado con exito realizado con exito!");
                this.ClearDataTable();
                this.ShowShippers();
            }
            catch (Exception)
            {
                MessageBox.Show("El elemento no pudo ser borrado! Contiene relaciones con otras tablas");
            }
}
    }
}
