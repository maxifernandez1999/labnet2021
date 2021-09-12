
namespace tp2
{
    partial class Ej03Form
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
            this.btnException = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnException
            // 
            this.btnException.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnException.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnException.Location = new System.Drawing.Point(40, 31);
            this.btnException.Name = "btnException";
            this.btnException.Size = new System.Drawing.Size(274, 54);
            this.btnException.TabIndex = 0;
            this.btnException.Text = "Lanzar Excepcion";
            this.btnException.UseVisualStyleBackColor = false;
            this.btnException.Click += new System.EventHandler(this.btnException_Click);
            // 
            // Ej03Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 116);
            this.Controls.Add(this.btnException);
            this.Name = "Ej03Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio 3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnException;
    }
}