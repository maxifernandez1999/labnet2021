
namespace tp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnTrasport = new System.Windows.Forms.Button();
            this.numericPassagers = new System.Windows.Forms.NumericUpDown();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.lblDriverName = new System.Windows.Forms.Label();
            this.lblPassagers = new System.Windows.Forms.Label();
            this.rbTaxi = new System.Windows.Forms.RadioButton();
            this.rbOmnibus = new System.Windows.Forms.RadioButton();
            this.lbAlert = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericPassagers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTrasport
            // 
            this.btnTrasport.Location = new System.Drawing.Point(22, 149);
            this.btnTrasport.Name = "btnTrasport";
            this.btnTrasport.Size = new System.Drawing.Size(144, 48);
            this.btnTrasport.TabIndex = 0;
            this.btnTrasport.Text = "Agregar Transporte";
            this.btnTrasport.UseVisualStyleBackColor = true;
            this.btnTrasport.Click += new System.EventHandler(this.btnTrasport_Click);
            // 
            // numericPassagers
            // 
            this.numericPassagers.Location = new System.Drawing.Point(135, 73);
            this.numericPassagers.Name = "numericPassagers";
            this.numericPassagers.Size = new System.Drawing.Size(190, 20);
            this.numericPassagers.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(135, 35);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(190, 20);
            this.txtName.TabIndex = 2;
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(350, 21);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(343, 176);
            this.dataGrid.TabIndex = 3;
            // 
            // lblDriverName
            // 
            this.lblDriverName.AutoSize = true;
            this.lblDriverName.Location = new System.Drawing.Point(19, 38);
            this.lblDriverName.Name = "lblDriverName";
            this.lblDriverName.Size = new System.Drawing.Size(110, 13);
            this.lblDriverName.TabIndex = 4;
            this.lblDriverName.Text = "nombre del conductor";
            // 
            // lblPassagers
            // 
            this.lblPassagers.AutoSize = true;
            this.lblPassagers.Location = new System.Drawing.Point(18, 80);
            this.lblPassagers.Name = "lblPassagers";
            this.lblPassagers.Size = new System.Drawing.Size(111, 13);
            this.lblPassagers.TabIndex = 5;
            this.lblPassagers.Text = "cantidad de pasajeros";
            // 
            // rbTaxi
            // 
            this.rbTaxi.AutoSize = true;
            this.rbTaxi.Location = new System.Drawing.Point(121, 111);
            this.rbTaxi.Name = "rbTaxi";
            this.rbTaxi.Size = new System.Drawing.Size(45, 17);
            this.rbTaxi.TabIndex = 6;
            this.rbTaxi.TabStop = true;
            this.rbTaxi.Text = "Taxi";
            this.rbTaxi.UseVisualStyleBackColor = true;
            // 
            // rbOmnibus
            // 
            this.rbOmnibus.AutoSize = true;
            this.rbOmnibus.Location = new System.Drawing.Point(22, 111);
            this.rbOmnibus.Name = "rbOmnibus";
            this.rbOmnibus.Size = new System.Drawing.Size(66, 17);
            this.rbOmnibus.TabIndex = 7;
            this.rbOmnibus.TabStop = true;
            this.rbOmnibus.Text = "Omnibus";
            this.rbOmnibus.UseVisualStyleBackColor = true;
            // 
            // lbAlert
            // 
            this.lbAlert.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbAlert.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAlert.Location = new System.Drawing.Point(18, 220);
            this.lbAlert.Name = "lbAlert";
            this.lbAlert.Size = new System.Drawing.Size(681, 48);
            this.lbAlert.TabIndex = 8;
            this.lbAlert.Text = "Ingrese un transporte";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(181, 149);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(144, 48);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Eliminar Todos";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 281);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lbAlert);
            this.Controls.Add(this.rbOmnibus);
            this.Controls.Add(this.rbTaxi);
            this.Controls.Add(this.lblPassagers);
            this.Controls.Add(this.lblDriverName);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.numericPassagers);
            this.Controls.Add(this.btnTrasport);
            this.Name = "Form1";
            this.Text = "Transporte Publico";
            ((System.ComponentModel.ISupportInitialize)(this.numericPassagers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTrasport;
        private System.Windows.Forms.NumericUpDown numericPassagers;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Label lblDriverName;
        private System.Windows.Forms.Label lblPassagers;
        private System.Windows.Forms.RadioButton rbTaxi;
        private System.Windows.Forms.RadioButton rbOmnibus;
        private System.Windows.Forms.Label lbAlert;
        private System.Windows.Forms.Button btnDelete;
    }
}

