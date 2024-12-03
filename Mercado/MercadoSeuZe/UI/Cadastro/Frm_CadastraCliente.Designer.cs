namespace MercadoSeuZe.UI
{
    partial class Frm_CadastraCliente
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
            this.Lbl_Titulo = new System.Windows.Forms.Label();
            this.Lbl_Nome = new System.Windows.Forms.Label();
            this.Txt_Nome = new System.Windows.Forms.TextBox();
            this.Cmb_EstadoCivil = new System.Windows.Forms.ComboBox();
            this.Lbl_EstadoCivil = new System.Windows.Forms.Label();
            this.Gbox_Sexo = new System.Windows.Forms.GroupBox();
            this.Rad_Feminino = new System.Windows.Forms.RadioButton();
            this.Rad_Masculino = new System.Windows.Forms.RadioButton();
            this.Btn_CadastrarCliente = new System.Windows.Forms.Button();
            this.Gbox_Sexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_Titulo
            // 
            this.Lbl_Titulo.AutoSize = true;
            this.Lbl_Titulo.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Titulo.Location = new System.Drawing.Point(124, 9);
            this.Lbl_Titulo.Name = "Lbl_Titulo";
            this.Lbl_Titulo.Size = new System.Drawing.Size(394, 57);
            this.Lbl_Titulo.TabIndex = 0;
            this.Lbl_Titulo.Text = "Cadastro de Cliente";
            this.Lbl_Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_Nome
            // 
            this.Lbl_Nome.AutoSize = true;
            this.Lbl_Nome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Nome.Location = new System.Drawing.Point(69, 96);
            this.Lbl_Nome.Name = "Lbl_Nome";
            this.Lbl_Nome.Size = new System.Drawing.Size(54, 19);
            this.Lbl_Nome.TabIndex = 1;
            this.Lbl_Nome.Text = "Nome";
            // 
            // Txt_Nome
            // 
            this.Txt_Nome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Nome.ForeColor = System.Drawing.Color.Red;
            this.Txt_Nome.Location = new System.Drawing.Point(134, 94);
            this.Txt_Nome.Name = "Txt_Nome";
            this.Txt_Nome.Size = new System.Drawing.Size(500, 26);
            this.Txt_Nome.TabIndex = 2;
            // 
            // Cmb_EstadoCivil
            // 
            this.Cmb_EstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cmb_EstadoCivil.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cmb_EstadoCivil.FormattingEnabled = true;
            this.Cmb_EstadoCivil.Items.AddRange(new object[] {
            "Casado",
            "Divorciado",
            "Separado",
            "Solteiro",
            "Viúvo"});
            this.Cmb_EstadoCivil.Location = new System.Drawing.Point(135, 146);
            this.Cmb_EstadoCivil.Name = "Cmb_EstadoCivil";
            this.Cmb_EstadoCivil.Size = new System.Drawing.Size(209, 28);
            this.Cmb_EstadoCivil.TabIndex = 3;
            // 
            // Lbl_EstadoCivil
            // 
            this.Lbl_EstadoCivil.AutoSize = true;
            this.Lbl_EstadoCivil.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_EstadoCivil.Location = new System.Drawing.Point(24, 154);
            this.Lbl_EstadoCivil.Name = "Lbl_EstadoCivil";
            this.Lbl_EstadoCivil.Size = new System.Drawing.Size(100, 19);
            this.Lbl_EstadoCivil.TabIndex = 4;
            this.Lbl_EstadoCivil.Text = "Estado Civil";
            // 
            // Gbox_Sexo
            // 
            this.Gbox_Sexo.Controls.Add(this.Rad_Feminino);
            this.Gbox_Sexo.Controls.Add(this.Rad_Masculino);
            this.Gbox_Sexo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gbox_Sexo.Location = new System.Drawing.Point(369, 126);
            this.Gbox_Sexo.Name = "Gbox_Sexo";
            this.Gbox_Sexo.Size = new System.Drawing.Size(265, 63);
            this.Gbox_Sexo.TabIndex = 5;
            this.Gbox_Sexo.TabStop = false;
            this.Gbox_Sexo.Text = "Sexo";
            // 
            // Rad_Feminino
            // 
            this.Rad_Feminino.AutoSize = true;
            this.Rad_Feminino.Location = new System.Drawing.Point(134, 25);
            this.Rad_Feminino.Name = "Rad_Feminino";
            this.Rad_Feminino.Size = new System.Drawing.Size(98, 23);
            this.Rad_Feminino.TabIndex = 1;
            this.Rad_Feminino.TabStop = true;
            this.Rad_Feminino.Text = "Feminino";
            this.Rad_Feminino.UseVisualStyleBackColor = true;
            // 
            // Rad_Masculino
            // 
            this.Rad_Masculino.AutoSize = true;
            this.Rad_Masculino.Location = new System.Drawing.Point(17, 24);
            this.Rad_Masculino.Name = "Rad_Masculino";
            this.Rad_Masculino.Size = new System.Drawing.Size(105, 23);
            this.Rad_Masculino.TabIndex = 0;
            this.Rad_Masculino.TabStop = true;
            this.Rad_Masculino.Text = "Masculino";
            this.Rad_Masculino.UseVisualStyleBackColor = true;
            // 
            // Btn_CadastrarCliente
            // 
            this.Btn_CadastrarCliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CadastrarCliente.Location = new System.Drawing.Point(28, 203);
            this.Btn_CadastrarCliente.Name = "Btn_CadastrarCliente";
            this.Btn_CadastrarCliente.Size = new System.Drawing.Size(606, 49);
            this.Btn_CadastrarCliente.TabIndex = 6;
            this.Btn_CadastrarCliente.Text = "Cadastrar Cliente";
            this.Btn_CadastrarCliente.UseVisualStyleBackColor = true;
            this.Btn_CadastrarCliente.Click += new System.EventHandler(this.Btn_CadastrarCliente_Click);
            // 
            // Frm_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 280);
            this.Controls.Add(this.Btn_CadastrarCliente);
            this.Controls.Add(this.Gbox_Sexo);
            this.Controls.Add(this.Lbl_EstadoCivil);
            this.Controls.Add(this.Cmb_EstadoCivil);
            this.Controls.Add(this.Txt_Nome);
            this.Controls.Add(this.Lbl_Nome);
            this.Controls.Add(this.Lbl_Titulo);
            this.Name = "Frm_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário de Cadastro de Cliente";
            this.Gbox_Sexo.ResumeLayout(false);
            this.Gbox_Sexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Titulo;
        private System.Windows.Forms.Label Lbl_Nome;
        private System.Windows.Forms.TextBox Txt_Nome;
        private System.Windows.Forms.ComboBox Cmb_EstadoCivil;
        private System.Windows.Forms.Label Lbl_EstadoCivil;
        private System.Windows.Forms.GroupBox Gbox_Sexo;
        private System.Windows.Forms.RadioButton Rad_Masculino;
        private System.Windows.Forms.RadioButton Rad_Feminino;
        private System.Windows.Forms.Button Btn_CadastrarCliente;
    }
}