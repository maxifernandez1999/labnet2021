
namespace tp2
{
    partial class MenuForm
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
            this.btnEj1 = new System.Windows.Forms.Button();
            this.btnEj2 = new System.Windows.Forms.Button();
            this.btnEj3 = new System.Windows.Forms.Button();
            this.btnEj4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEj1
            // 
            this.btnEj1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEj1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEj1.Location = new System.Drawing.Point(44, 12);
            this.btnEj1.Name = "btnEj1";
            this.btnEj1.Size = new System.Drawing.Size(134, 66);
            this.btnEj1.TabIndex = 0;
            this.btnEj1.Text = "Ejercicio01";
            this.btnEj1.UseVisualStyleBackColor = false;
            this.btnEj1.Click += new System.EventHandler(this.btnEj1_Click);
            // 
            // btnEj2
            // 
            this.btnEj2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEj2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEj2.Location = new System.Drawing.Point(237, 12);
            this.btnEj2.Name = "btnEj2";
            this.btnEj2.Size = new System.Drawing.Size(134, 66);
            this.btnEj2.TabIndex = 1;
            this.btnEj2.Text = "Ejercicio02";
            this.btnEj2.UseVisualStyleBackColor = false;
            this.btnEj2.Click += new System.EventHandler(this.btnEj2_Click);
            // 
            // btnEj3
            // 
            this.btnEj3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEj3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEj3.Location = new System.Drawing.Point(44, 103);
            this.btnEj3.Name = "btnEj3";
            this.btnEj3.Size = new System.Drawing.Size(134, 59);
            this.btnEj3.TabIndex = 2;
            this.btnEj3.Text = "Ejercicio03";
            this.btnEj3.UseVisualStyleBackColor = false;
            this.btnEj3.Click += new System.EventHandler(this.btnEj3_Click);
            // 
            // btnEj4
            // 
            this.btnEj4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnEj4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEj4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEj4.Location = new System.Drawing.Point(237, 103);
            this.btnEj4.Name = "btnEj4";
            this.btnEj4.Size = new System.Drawing.Size(134, 59);
            this.btnEj4.TabIndex = 3;
            this.btnEj4.Text = "Ejercicio04";
            this.btnEj4.UseVisualStyleBackColor = false;
            this.btnEj4.Click += new System.EventHandler(this.btnEj4_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 178);
            this.Controls.Add(this.btnEj4);
            this.Controls.Add(this.btnEj3);
            this.Controls.Add(this.btnEj2);
            this.Controls.Add(this.btnEj1);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maximiliano Fernandez";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEj1;
        private System.Windows.Forms.Button btnEj2;
        private System.Windows.Forms.Button btnEj3;
        private System.Windows.Forms.Button btnEj4;
    }
}

