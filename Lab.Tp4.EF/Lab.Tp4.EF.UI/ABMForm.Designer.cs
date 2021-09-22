
namespace Lab.Tp4.EF.UI
{
    partial class ABMForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnGetTerritories = new System.Windows.Forms.Button();
            this.dgDatos = new System.Windows.Forms.DataGridView();
            this.btnGetShippers = new System.Windows.Forms.Button();
            this.btnGetCategories = new System.Windows.Forms.Button();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnAddShipper = new System.Windows.Forms.Button();
            this.btnUpdateShipper = new System.Windows.Forms.Button();
            this.gbDatosShipper = new System.Windows.Forms.GroupBox();
            this.lblAdd = new System.Windows.Forms.Label();
            this.btnShowTerritoryEmployee = new System.Windows.Forms.Button();
            this.btnDeleteTerritoryEmployee = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos)).BeginInit();
            this.gbDatosShipper.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetTerritories
            // 
            this.btnGetTerritories.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGetTerritories.Location = new System.Drawing.Point(1045, 63);
            this.btnGetTerritories.Name = "btnGetTerritories";
            this.btnGetTerritories.Size = new System.Drawing.Size(358, 43);
            this.btnGetTerritories.TabIndex = 0;
            this.btnGetTerritories.Text = "ShowTerritories";
            this.btnGetTerritories.UseVisualStyleBackColor = true;
            this.btnGetTerritories.Click += new System.EventHandler(this.btnGetTerritories_Click);
            // 
            // dgDatos
            // 
            this.dgDatos.AllowUserToAddRows = false;
            this.dgDatos.AllowUserToDeleteRows = false;
            this.dgDatos.AllowUserToResizeColumns = false;
            this.dgDatos.AllowUserToResizeRows = false;
            this.dgDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDatos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgDatos.Location = new System.Drawing.Point(344, 12);
            this.dgDatos.MultiSelect = false;
            this.dgDatos.Name = "dgDatos";
            this.dgDatos.Size = new System.Drawing.Size(691, 632);
            this.dgDatos.TabIndex = 1;
            // 
            // btnGetShippers
            // 
            this.btnGetShippers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGetShippers.Location = new System.Drawing.Point(1045, 12);
            this.btnGetShippers.Name = "btnGetShippers";
            this.btnGetShippers.Size = new System.Drawing.Size(359, 45);
            this.btnGetShippers.TabIndex = 2;
            this.btnGetShippers.Text = "Show Shippers";
            this.btnGetShippers.UseVisualStyleBackColor = true;
            this.btnGetShippers.Click += new System.EventHandler(this.btnGetShippers_Click);
            // 
            // btnGetCategories
            // 
            this.btnGetCategories.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGetCategories.Location = new System.Drawing.Point(1045, 116);
            this.btnGetCategories.Name = "btnGetCategories";
            this.btnGetCategories.Size = new System.Drawing.Size(358, 45);
            this.btnGetCategories.TabIndex = 5;
            this.btnGetCategories.Text = "Show Categories";
            this.btnGetCategories.UseVisualStyleBackColor = true;
            this.btnGetCategories.Click += new System.EventHandler(this.btnGetCategories_Click);
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(20, 39);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(82, 13);
            this.lblCompanyName.TabIndex = 8;
            this.lblCompanyName.Text = "Company Name";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(20, 116);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(38, 13);
            this.lblPhone.TabIndex = 10;
            this.lblPhone.Text = "Phone";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyName.Location = new System.Drawing.Point(23, 73);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(241, 22);
            this.txtCompanyName.TabIndex = 11;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(23, 152);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(241, 22);
            this.txtPhone.TabIndex = 12;
            // 
            // btnAddShipper
            // 
            this.btnAddShipper.AllowDrop = true;
            this.btnAddShipper.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnAddShipper.Location = new System.Drawing.Point(53, 203);
            this.btnAddShipper.Name = "btnAddShipper";
            this.btnAddShipper.Size = new System.Drawing.Size(178, 43);
            this.btnAddShipper.TabIndex = 13;
            this.btnAddShipper.Text = "Add Shipper";
            this.btnAddShipper.UseVisualStyleBackColor = true;
            this.btnAddShipper.Click += new System.EventHandler(this.btnAddShipper_Click);
            // 
            // btnUpdateShipper
            // 
            this.btnUpdateShipper.AllowDrop = true;
            this.btnUpdateShipper.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnUpdateShipper.Location = new System.Drawing.Point(53, 261);
            this.btnUpdateShipper.Name = "btnUpdateShipper";
            this.btnUpdateShipper.Size = new System.Drawing.Size(178, 43);
            this.btnUpdateShipper.TabIndex = 14;
            this.btnUpdateShipper.Text = "Update Shipper";
            this.btnUpdateShipper.UseVisualStyleBackColor = true;
            this.btnUpdateShipper.Click += new System.EventHandler(this.btnUpdateShipper_Click);
            // 
            // gbDatosShipper
            // 
            this.gbDatosShipper.Controls.Add(this.txtCompanyName);
            this.gbDatosShipper.Controls.Add(this.txtPhone);
            this.gbDatosShipper.Controls.Add(this.lblCompanyName);
            this.gbDatosShipper.Controls.Add(this.btnAddShipper);
            this.gbDatosShipper.Controls.Add(this.lblPhone);
            this.gbDatosShipper.Controls.Add(this.btnUpdateShipper);
            this.gbDatosShipper.Enabled = false;
            this.gbDatosShipper.Location = new System.Drawing.Point(22, 193);
            this.gbDatosShipper.Name = "gbDatosShipper";
            this.gbDatosShipper.Size = new System.Drawing.Size(283, 322);
            this.gbDatosShipper.TabIndex = 15;
            this.gbDatosShipper.TabStop = false;
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd.Location = new System.Drawing.Point(18, 57);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(301, 21);
            this.lblAdd.TabIndex = 13;
            this.lblAdd.Text = "parentesis, los guiones, los espaciados";
            // 
            // btnShowTerritoryEmployee
            // 
            this.btnShowTerritoryEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnShowTerritoryEmployee.Location = new System.Drawing.Point(1045, 169);
            this.btnShowTerritoryEmployee.Name = "btnShowTerritoryEmployee";
            this.btnShowTerritoryEmployee.Size = new System.Drawing.Size(358, 45);
            this.btnShowTerritoryEmployee.TabIndex = 16;
            this.btnShowTerritoryEmployee.Text = "Show Employee Territory";
            this.btnShowTerritoryEmployee.UseVisualStyleBackColor = true;
            this.btnShowTerritoryEmployee.Click += new System.EventHandler(this.btnGetTerritoryEmployee_Click);
            // 
            // btnDeleteTerritoryEmployee
            // 
            this.btnDeleteTerritoryEmployee.Enabled = false;
            this.btnDeleteTerritoryEmployee.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTerritoryEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnDeleteTerritoryEmployee.Location = new System.Drawing.Point(1045, 599);
            this.btnDeleteTerritoryEmployee.Name = "btnDeleteTerritoryEmployee";
            this.btnDeleteTerritoryEmployee.Size = new System.Drawing.Size(359, 45);
            this.btnDeleteTerritoryEmployee.TabIndex = 17;
            this.btnDeleteTerritoryEmployee.Text = "Delete Employee Territory";
            this.btnDeleteTerritoryEmployee.UseVisualStyleBackColor = true;
            this.btnDeleteTerritoryEmployee.Click += new System.EventHandler(this.btnDeleteTerritoryEmployee_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "El telefono del shipper tiene que tener el ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "siguiente formato respetando los ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(94, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 21);
            this.label3.TabIndex = 20;
            this.label3.Text = "ej: (555) 234-4566";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 21);
            this.label4.TabIndex = 21;
            this.label4.Text = "y la cantidad de numeros";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 628);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(293, 21);
            this.label5.TabIndex = 22;
            this.label5.Text = " presionar el boton \"Update Shipper\"";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 560);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(324, 21);
            this.label6.TabIndex = 23;
            this.label6.Text = "Para realizar una actualizacion tiene que ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 595);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(325, 21);
            this.label7.TabIndex = 24;
            this.label7.Text = "cambiar los valores sobre la tabla y luego";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(112, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 21);
            this.label8.TabIndex = 25;
            this.label8.Text = "Add Shipper";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1070, 465);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(313, 21);
            this.label9.TabIndex = 26;
            this.label9.Text = "Para realizar una eliminacion tiene que ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1061, 494);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(342, 21);
            this.label10.TabIndex = 27;
            this.label10.Text = "seleccionar en la tabla el registro que desea";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1041, 560);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(363, 21);
            this.label11.TabIndex = 28;
            this.label11.Text = "y luego presionar \"Delete Employee Territory\"";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1132, 525);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(211, 21);
            this.label12.TabIndex = 29;
            this.label12.Text = "eliminar y luego presionar";
            // 
            // ABMForm
            // 
            this.ClientSize = new System.Drawing.Size(1415, 658);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDeleteTerritoryEmployee);
            this.Controls.Add(this.btnShowTerritoryEmployee);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.gbDatosShipper);
            this.Controls.Add(this.btnGetCategories);
            this.Controls.Add(this.btnGetShippers);
            this.Controls.Add(this.dgDatos);
            this.Controls.Add(this.btnGetTerritories);
            this.Name = "ABMForm";
            this.Text = "ABM Maximiliano Fernandez";
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos)).EndInit();
            this.gbDatosShipper.ResumeLayout(false);
            this.gbDatosShipper.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnGetTerritories;
        private System.Windows.Forms.DataGridView dgDatos;
        private System.Windows.Forms.Button btnGetShippers;
        private System.Windows.Forms.Button btnGetCategories;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnAddShipper;
        private System.Windows.Forms.Button btnUpdateShipper;
        private System.Windows.Forms.GroupBox gbDatosShipper;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Button btnShowTerritoryEmployee;
        private System.Windows.Forms.Button btnDeleteTerritoryEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

