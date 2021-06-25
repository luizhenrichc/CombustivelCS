
namespace Combustivel
{
    partial class FormVeiculo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdVeiculo = new System.Windows.Forms.TextBox();
            this.txtTipoCombustivel = new System.Windows.Forms.TextBox();
            this.btnCadastrarVeiculo = new System.Windows.Forms.Button();
            this.txtHodometro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAlterarVeiculo = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dvgCadastro = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCadastro)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TIPO DE COMBUSTIVEL";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID DO VEICULO";
            // 
            // txtIdVeiculo
            // 
            this.txtIdVeiculo.Location = new System.Drawing.Point(178, 15);
            this.txtIdVeiculo.Name = "txtIdVeiculo";
            this.txtIdVeiculo.Size = new System.Drawing.Size(126, 20);
            this.txtIdVeiculo.TabIndex = 2;
            this.txtIdVeiculo.TextChanged += new System.EventHandler(this.txtIdVeiculo_TextChanged);
            // 
            // txtTipoCombustivel
            // 
            this.txtTipoCombustivel.Location = new System.Drawing.Point(178, 59);
            this.txtTipoCombustivel.Name = "txtTipoCombustivel";
            this.txtTipoCombustivel.Size = new System.Drawing.Size(126, 20);
            this.txtTipoCombustivel.TabIndex = 3;
            // 
            // btnCadastrarVeiculo
            // 
            this.btnCadastrarVeiculo.Location = new System.Drawing.Point(33, 152);
            this.btnCadastrarVeiculo.Name = "btnCadastrarVeiculo";
            this.btnCadastrarVeiculo.Size = new System.Drawing.Size(126, 26);
            this.btnCadastrarVeiculo.TabIndex = 4;
            this.btnCadastrarVeiculo.Text = "CADASTRAR";
            this.btnCadastrarVeiculo.UseVisualStyleBackColor = true;
            this.btnCadastrarVeiculo.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtHodometro
            // 
            this.txtHodometro.Location = new System.Drawing.Point(178, 104);
            this.txtHodometro.Name = "txtHodometro";
            this.txtHodometro.Size = new System.Drawing.Size(126, 20);
            this.txtHodometro.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "HODOMETRO ATUAL";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnAlterarVeiculo
            // 
            this.btnAlterarVeiculo.Location = new System.Drawing.Point(336, 152);
            this.btnAlterarVeiculo.Name = "btnAlterarVeiculo";
            this.btnAlterarVeiculo.Size = new System.Drawing.Size(126, 26);
            this.btnAlterarVeiculo.TabIndex = 16;
            this.btnAlterarVeiculo.Text = "ALTERAR";
            this.btnAlterarVeiculo.UseVisualStyleBackColor = true;
            this.btnAlterarVeiculo.Click += new System.EventHandler(this.btnAlterarVeiculo_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(493, 152);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(126, 26);
            this.button4.TabIndex = 17;
            this.button4.Text = "EXCLUIR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(178, 152);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(126, 26);
            this.button5.TabIndex = 18;
            this.button5.Text = "CONSULTAR";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(652, 152);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 26);
            this.button2.TabIndex = 19;
            this.button2.Text = "ABASTECER";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "(G) (D) OU (E)";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dvgCadastro
            // 
            this.dvgCadastro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCadastro.Location = new System.Drawing.Point(99, 216);
            this.dvgCadastro.Name = "dvgCadastro";
            this.dvgCadastro.Size = new System.Drawing.Size(585, 222);
            this.dvgCadastro.TabIndex = 21;
            this.dvgCadastro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgCadastro_CellContentClick);
            // 
            // FormVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dvgCadastro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnAlterarVeiculo);
            this.Controls.Add(this.txtHodometro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCadastrarVeiculo);
            this.Controls.Add(this.txtTipoCombustivel);
            this.Controls.Add(this.txtIdVeiculo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormVeiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRO";
            ((System.ComponentModel.ISupportInitialize)(this.dvgCadastro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdVeiculo;
        private System.Windows.Forms.TextBox txtTipoCombustivel;
        private System.Windows.Forms.Button btnCadastrarVeiculo;
        private System.Windows.Forms.TextBox txtHodometro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAlterarVeiculo;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dvgCadastro;
    }
}

