
namespace repeticao_07_3
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_calcular = new System.Windows.Forms.Button();
            this.ltx_imprimir = new System.Windows.Forms.ListBox();
            this.txt_num = new System.Windows.Forms.TextBox();
            this.lbl_num = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(15, 408);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(216, 30);
            this.btn_calcular.TabIndex = 0;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // ltx_imprimir
            // 
            this.ltx_imprimir.FormattingEnabled = true;
            this.ltx_imprimir.Location = new System.Drawing.Point(12, 38);
            this.ltx_imprimir.Name = "ltx_imprimir";
            this.ltx_imprimir.Size = new System.Drawing.Size(223, 355);
            this.ltx_imprimir.TabIndex = 1;
            // 
            // txt_num
            // 
            this.txt_num.Location = new System.Drawing.Point(119, 6);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(116, 20);
            this.txt_num.TabIndex = 2;
            // 
            // lbl_num
            // 
            this.lbl_num.AutoSize = true;
            this.lbl_num.Location = new System.Drawing.Point(9, 9);
            this.lbl_num.Name = "lbl_num";
            this.lbl_num.Size = new System.Drawing.Size(92, 13);
            this.lbl_num.TabIndex = 3;
            this.lbl_num.Text = "Digite um número:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 450);
            this.Controls.Add(this.lbl_num);
            this.Controls.Add(this.txt_num);
            this.Controls.Add(this.ltx_imprimir);
            this.Controls.Add(this.btn_calcular);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.ListBox ltx_imprimir;
        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.Label lbl_num;
    }
}

