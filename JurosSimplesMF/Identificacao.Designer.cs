namespace JurosSimplesMF
{
    partial class Identificacao
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
            this.btnNome = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblRA = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNome
            // 
            this.btnNome.Location = new System.Drawing.Point(206, 123);
            this.btnNome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNome.Name = "btnNome";
            this.btnNome.Size = new System.Drawing.Size(112, 35);
            this.btnNome.TabIndex = 0;
            this.btnNome.Text = "Próximo";
            this.btnNome.UseVisualStyleBackColor = true;
            this.btnNome.Click += new System.EventHandler(this.btnNome_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(45, 69);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(464, 26);
            this.txtNome.TabIndex = 1;
            // 
            // lblRA
            // 
            this.lblRA.AutoSize = true;
            this.lblRA.Location = new System.Drawing.Point(41, 32);
            this.lblRA.Name = "lblRA";
            this.lblRA.Size = new System.Drawing.Size(97, 20);
            this.lblRA.TabIndex = 2;
            this.lblRA.Text = "RA do aluno";
            // 
            // Identificacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 186);
            this.Controls.Add(this.lblRA);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnNome);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Identificacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Identificacao";
            this.Load += new System.EventHandler(this.Identificacao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblRA;
    }
}