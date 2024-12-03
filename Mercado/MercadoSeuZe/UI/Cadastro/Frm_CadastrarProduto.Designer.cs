namespace MercadoSeuZe.UI.Produto
{
    partial class Frm_CadastrarProduto
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
            this.Txt_Nome = new System.Windows.Forms.TextBox();
            this.Txt_Preco = new System.Windows.Forms.TextBox();
            this.Btn_SalvarProduto = new System.Windows.Forms.Button();
            this.Lbl_Nome = new System.Windows.Forms.Label();
            this.Lbl_Preco = new System.Windows.Forms.Label();

            // 
            // Txt_Nome
            // 
            this.Txt_Nome.Font = new System.Drawing.Font("Arial", 12F);
            this.Txt_Nome.Location = new System.Drawing.Point(120, 50);
            this.Txt_Nome.Name = "Txt_Nome";
            this.Txt_Nome.Size = new System.Drawing.Size(300, 26);
            this.Txt_Nome.TabIndex = 0;

            // 
            // Txt_Preco
            // 
            this.Txt_Preco.Font = new System.Drawing.Font("Arial", 12F);
            this.Txt_Preco.Location = new System.Drawing.Point(120, 100);
            this.Txt_Preco.Name = "Txt_Preco";
            this.Txt_Preco.Size = new System.Drawing.Size(100, 26);
            this.Txt_Preco.TabIndex = 1;

            // 
            // Btn_SalvarProduto
            // 
            this.Btn_SalvarProduto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Btn_SalvarProduto.Location = new System.Drawing.Point(120, 150);
            this.Btn_SalvarProduto.Name = "Btn_SalvarProduto";
            this.Btn_SalvarProduto.Size = new System.Drawing.Size(120, 40);
            this.Btn_SalvarProduto.TabIndex = 2;
            this.Btn_SalvarProduto.Text = "Salvar";
            this.Btn_SalvarProduto.UseVisualStyleBackColor = true;
            this.Btn_SalvarProduto.Click += new System.EventHandler(this.Btn_SalvarProduto_Click);

            // 
            // Lbl_Nome
            // 
            this.Lbl_Nome.AutoSize = true;
            this.Lbl_Nome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Lbl_Nome.Location = new System.Drawing.Point(50, 50);
            this.Lbl_Nome.Name = "Lbl_Nome";
            this.Lbl_Nome.Size = new System.Drawing.Size(64, 19);
            this.Lbl_Nome.TabIndex = 3;
            this.Lbl_Nome.Text = "Nome:";

            // 
            // Lbl_Preco
            // 
            this.Lbl_Preco.AutoSize = true;
            this.Lbl_Preco.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Lbl_Preco.Location = new System.Drawing.Point(50, 100);
            this.Lbl_Preco.Name = "Lbl_Preco";
            this.Lbl_Preco.Size = new System.Drawing.Size(58, 19);
            this.Lbl_Preco.TabIndex = 4;
            this.Lbl_Preco.Text = "Preço:";

            // 
            // Frm_CadastrarProduto
            // 
            this.ClientSize = new System.Drawing.Size(450, 250);
            this.Controls.Add(this.Lbl_Nome);
            this.Controls.Add(this.Txt_Nome);
            this.Controls.Add(this.Lbl_Preco);
            this.Controls.Add(this.Txt_Preco);
            this.Controls.Add(this.Btn_SalvarProduto);
            this.Name = "Frm_CadastrarProduto";
            this.Text = "Cadastro de Produto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Nome;
        private System.Windows.Forms.TextBox Txt_Preco;
        private System.Windows.Forms.Button Btn_SalvarProduto;
        private System.Windows.Forms.Label Lbl_Nome;
        private System.Windows.Forms.Label Lbl_Preco;
    }
}
