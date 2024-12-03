namespace MercadoSeuZe.UI.Pesquisa
{
    partial class Frm_PesquisaProduto
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView DGrid_GridView;
        private System.Windows.Forms.Button Btn_Primeiro;
        private System.Windows.Forms.Button Btn_Anterior;
        private System.Windows.Forms.Button Btn_Proximo;
        private System.Windows.Forms.Button Btn_Ultimo;
        private System.Windows.Forms.Label Lbl_PaginaAtual;
        private System.Windows.Forms.Label Lbl_TotalLinhas;
        private System.Windows.Forms.Label Lbl_TituloTotalLinhas;
        private System.Windows.Forms.Label Lbl_TituloPagina;
        private System.Windows.Forms.Label Lbl_TituloDe;
        private System.Windows.Forms.Label Lbl_TotalPaginas;
        private System.Windows.Forms.Label Lbl_TituloPesquisa;
        private System.Windows.Forms.TextBox Txt_Pesquisa;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.DGrid_GridView = new System.Windows.Forms.DataGridView();
            this.Btn_Primeiro = new System.Windows.Forms.Button();
            this.Btn_Anterior = new System.Windows.Forms.Button();
            this.Btn_Proximo = new System.Windows.Forms.Button();
            this.Btn_Ultimo = new System.Windows.Forms.Button();
            this.Lbl_PaginaAtual = new System.Windows.Forms.Label();
            this.Lbl_TotalLinhas = new System.Windows.Forms.Label();
            this.Lbl_TituloTotalLinhas = new System.Windows.Forms.Label();
            this.Lbl_TituloPagina = new System.Windows.Forms.Label();
            this.Lbl_TituloDe = new System.Windows.Forms.Label();
            this.Lbl_TotalPaginas = new System.Windows.Forms.Label();
            this.Lbl_TituloPesquisa = new System.Windows.Forms.Label();
            this.Txt_Pesquisa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGrid_GridView)).BeginInit();
            this.SuspendLayout();

            // DGrid_GridView
            this.DGrid_GridView.AllowUserToAddRows = false;
            this.DGrid_GridView.AllowUserToResizeColumns = false;
            this.DGrid_GridView.AllowUserToResizeRows = false;
            this.DGrid_GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGrid_GridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DGrid_GridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DGrid_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGrid_GridView.Location = new System.Drawing.Point(12, 123);
            this.DGrid_GridView.MultiSelect = false;
            this.DGrid_GridView.Name = "DGrid_GridView";
            this.DGrid_GridView.RowHeadersVisible = false;
            this.DGrid_GridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.DGrid_GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGrid_GridView.Size = new System.Drawing.Size(1073, 346);
            this.DGrid_GridView.TabIndex = 1;
            this.DGrid_GridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGrid_GridView_CellContentClick);

            // Botões e Labels
            this.Btn_Primeiro.Location = new System.Drawing.Point(682, 484);
            this.Btn_Primeiro.Name = "Btn_Primeiro";
            this.Btn_Primeiro.Size = new System.Drawing.Size(100, 35);
            this.Btn_Primeiro.TabIndex = 2;
            this.Btn_Primeiro.Text = "<<";
            this.Btn_Primeiro.UseVisualStyleBackColor = true;
            this.Btn_Primeiro.Click += new System.EventHandler(this.Btn_Primeiro_Click);

            this.Btn_Anterior.Location = new System.Drawing.Point(783, 484);
            this.Btn_Anterior.Name = "Btn_Anterior";
            this.Btn_Anterior.Size = new System.Drawing.Size(100, 35);
            this.Btn_Anterior.TabIndex = 3;
            this.Btn_Anterior.Text = "<";
            this.Btn_Anterior.UseVisualStyleBackColor = true;
            this.Btn_Anterior.Click += new System.EventHandler(this.Btn_Anterior_Click);

            this.Btn_Proximo.Location = new System.Drawing.Point(884, 484);
            this.Btn_Proximo.Name = "Btn_Proximo";
            this.Btn_Proximo.Size = new System.Drawing.Size(100, 35);
            this.Btn_Proximo.TabIndex = 4;
            this.Btn_Proximo.Text = ">";
            this.Btn_Proximo.UseVisualStyleBackColor = true;
            this.Btn_Proximo.Click += new System.EventHandler(this.Btn_Proximo_Click);

            this.Btn_Ultimo.Location = new System.Drawing.Point(985, 484);
            this.Btn_Ultimo.Name = "Btn_Ultimo";
            this.Btn_Ultimo.Size = new System.Drawing.Size(100, 35);
            this.Btn_Ultimo.TabIndex = 5;
            this.Btn_Ultimo.Text = ">>";
            this.Btn_Ultimo.UseVisualStyleBackColor = true;
            this.Btn_Ultimo.Click += new System.EventHandler(this.Btn_Ultimo_Click);

            // Labels de navegação e pesquisa
            this.Lbl_PaginaAtual.AutoSize = true;
            this.Lbl_PaginaAtual.Location = new System.Drawing.Point(427, 484);
            this.Lbl_PaginaAtual.Name = "Lbl_PaginaAtual";
            this.Lbl_PaginaAtual.Size = new System.Drawing.Size(13, 13);
            this.Lbl_PaginaAtual.TabIndex = 6;
            this.Lbl_PaginaAtual.Text = "1";

            this.Lbl_TotalLinhas.AutoSize = true;
            this.Lbl_TotalLinhas.Location = new System.Drawing.Point(150, 484);
            this.Lbl_TotalLinhas.Name = "Lbl_TotalLinhas";
            this.Lbl_TotalLinhas.Size = new System.Drawing.Size(13, 13);
            this.Lbl_TotalLinhas.TabIndex = 7;
            this.Lbl_TotalLinhas.Text = "0";

            this.Lbl_TituloTotalLinhas.AutoSize = true;
            this.Lbl_TituloTotalLinhas.Location = new System.Drawing.Point(12, 484);
            this.Lbl_TituloTotalLinhas.Name = "Lbl_TituloTotalLinhas";
            this.Lbl_TituloTotalLinhas.Size = new System.Drawing.Size(72, 13);
            this.Lbl_TituloTotalLinhas.TabIndex = 8;
            this.Lbl_TituloTotalLinhas.Text = "Total de linhas";

            this.Lbl_TituloPagina.AutoSize = true;
            this.Lbl_TituloPagina.Location = new System.Drawing.Point(361, 484);
            this.Lbl_TituloPagina.Name = "Lbl_TituloPagina";
            this.Lbl_TituloPagina.Size = new System.Drawing.Size(40, 13);
            this.Lbl_TituloPagina.TabIndex = 9;
            this.Lbl_TituloPagina.Text = "Página";

            this.Lbl_TituloDe.AutoSize = true;
            this.Lbl_TituloDe.Location = new System.Drawing.Point(452, 484);
            this.Lbl_TituloDe.Name = "Lbl_TituloDe";
            this.Lbl_TituloDe.Size = new System.Drawing.Size(16, 13);
            this.Lbl_TituloDe.TabIndex = 10;
            this.Lbl_TituloDe.Text = "de";

            this.Lbl_TotalPaginas.AutoSize = true;
            this.Lbl_TotalPaginas.Location = new System.Drawing.Point(484, 484);
            this.Lbl_TotalPaginas.Name = "Lbl_TotalPaginas";
            this.Lbl_TotalPaginas.Size = new System.Drawing.Size(13, 13);
            this.Lbl_TotalPaginas.TabIndex = 11;
            this.Lbl_TotalPaginas.Text = "0";

            this.Lbl_TituloPesquisa.AutoSize = true;
            this.Lbl_TituloPesquisa.Location = new System.Drawing.Point(13, 77);
            this.Lbl_TituloPesquisa.Name = "Lbl_TituloPesquisa";
            this.Lbl_TituloPesquisa.Size = new System.Drawing.Size(50, 13);
            this.Lbl_TituloPesquisa.TabIndex = 12;
            this.Lbl_TituloPesquisa.Text = "Pesquisa";

            this.Txt_Pesquisa.Location = new System.Drawing.Point(113, 71);
            this.Txt_Pesquisa.Name = "Txt_Pesquisa";
            this.Txt_Pesquisa.Size = new System.Drawing.Size(441, 20);
            this.Txt_Pesquisa.TabIndex = 13;
            this.Txt_Pesquisa.TextChanged += new System.EventHandler(this.Txt_Pesquisa_TextChanged);

            // Finaliza a configuração do formulário
            this.ClientSize = new System.Drawing.Size(1097, 531);
            this.Controls.Add(this.Txt_Pesquisa);
            this.Controls.Add(this.Lbl_TituloPesquisa);
            this.Controls.Add(this.Lbl_TotalPaginas);
            this.Controls.Add(this.Lbl_TituloDe);
            this.Controls.Add(this.Lbl_TituloPagina);
            this.Controls.Add(this.Lbl_TituloTotalLinhas);
            this.Controls.Add(this.Lbl_TotalLinhas);
            this.Controls.Add(this.Lbl_PaginaAtual);
            this.Controls.Add(this.Btn_Ultimo);
            this.Controls.Add(this.Btn_Proximo);
            this.Controls.Add(this.Btn_Anterior);
            this.Controls.Add(this.Btn_Primeiro);
            this.Controls.Add(this.DGrid_GridView);
            this.Name = "Frm_PesquisaProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Produtos";
            this.Load += new System.EventHandler(this.Frm_PesquisaProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGrid_GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
