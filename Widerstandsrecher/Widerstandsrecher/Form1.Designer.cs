namespace Widerstandsrecher
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_R1 = new System.Windows.Forms.TextBox();
            this.tb_R2 = new System.Windows.Forms.TextBox();
            this.tb_Rg = new System.Windows.Forms.TextBox();
            this.lb_1 = new System.Windows.Forms.Label();
            this.lb_2 = new System.Windows.Forms.Label();
            this.lb_3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_R1
            // 
            this.tb_R1.Location = new System.Drawing.Point(105, 74);
            this.tb_R1.Name = "tb_R1";
            this.tb_R1.Size = new System.Drawing.Size(100, 20);
            this.tb_R1.TabIndex = 0;
            // 
            // tb_R2
            // 
            this.tb_R2.Location = new System.Drawing.Point(105, 100);
            this.tb_R2.Name = "tb_R2";
            this.tb_R2.Size = new System.Drawing.Size(100, 20);
            this.tb_R2.TabIndex = 1;
            // 
            // tb_Rg
            // 
            this.tb_Rg.Location = new System.Drawing.Point(105, 152);
            this.tb_Rg.Name = "tb_Rg";
            this.tb_Rg.Size = new System.Drawing.Size(100, 20);
            this.tb_Rg.TabIndex = 2;
            // 
            // lb_1
            // 
            this.lb_1.AutoSize = true;
            this.lb_1.Location = new System.Drawing.Point(78, 77);
            this.lb_1.Name = "lb_1";
            this.lb_1.Size = new System.Drawing.Size(21, 13);
            this.lb_1.TabIndex = 3;
            this.lb_1.Text = "R1";
            // 
            // lb_2
            // 
            this.lb_2.AutoSize = true;
            this.lb_2.Location = new System.Drawing.Point(78, 103);
            this.lb_2.Name = "lb_2";
            this.lb_2.Size = new System.Drawing.Size(21, 13);
            this.lb_2.TabIndex = 4;
            this.lb_2.Text = "R2";
            // 
            // lb_3
            // 
            this.lb_3.AutoSize = true;
            this.lb_3.Location = new System.Drawing.Point(78, 155);
            this.lb_3.Name = "lb_3";
            this.lb_3.Size = new System.Drawing.Size(21, 13);
            this.lb_3.TabIndex = 5;
            this.lb_3.Text = "Rg";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lb_3);
            this.Controls.Add(this.lb_2);
            this.Controls.Add(this.lb_1);
            this.Controls.Add(this.tb_Rg);
            this.Controls.Add(this.tb_R2);
            this.Controls.Add(this.tb_R1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_R1;
        private System.Windows.Forms.TextBox tb_R2;
        private System.Windows.Forms.TextBox tb_Rg;
        private System.Windows.Forms.Label lb_1;
        private System.Windows.Forms.Label lb_2;
        private System.Windows.Forms.Label lb_3;
    }
}

