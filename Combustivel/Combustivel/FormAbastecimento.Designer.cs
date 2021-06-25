
namespace Combustivel
{
    partial class FormAbastecimento
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
            this.components = new System.ComponentModel.Container();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.HodometroBD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ddIdVeiculo = new System.Windows.Forms.ComboBox();
            this.txtQtDeLitros = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvAbastecimento = new System.Windows.Forms.DataGridView();
            this.dB_COMBUSTIVELDataSet = new Combustivel.DB_COMBUSTIVELDataSet();
            this.veiculoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.veiculoTableAdapter = new Combustivel.DB_COMBUSTIVELDataSetTableAdapters.VeiculoTableAdapter();
            this.txbIdAbastecimento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbastecimento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_COMBUSTIVELDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veiculoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(219, 123);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(126, 26);
            this.button5.TabIndex = 28;
            this.button5.Text = "CONSULTAR";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(550, 123);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(126, 26);
            this.button4.TabIndex = 27;
            this.button4.Text = "EXCLUIR";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(388, 123);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 26);
            this.button3.TabIndex = 26;
            this.button3.Text = "ALTERAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // HodometroBD
            // 
            this.HodometroBD.Location = new System.Drawing.Point(445, 64);
            this.HodometroBD.Name = "HodometroBD";
            this.HodometroBD.ReadOnly = true;
            this.HodometroBD.Size = new System.Drawing.Size(126, 20);
            this.HodometroBD.TabIndex = 25;
            this.HodometroBD.TextChanged += new System.EventHandler(this.HodometroBD_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(462, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "HODOMETRO";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 26);
            this.button1.TabIndex = 23;
            this.button1.Text = "CONFIRMAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(313, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(126, 20);
            this.textBox2.TabIndex = 22;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "ID DO VEICULO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(353, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "DATA";
            // 
            // ddIdVeiculo
            // 
            this.ddIdVeiculo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.veiculoBindingSource, "Id", true));
            this.ddIdVeiculo.DataSource = this.dB_COMBUSTIVELDataSet;
            this.ddIdVeiculo.DisplayMember = "Veiculo.Id";
            this.ddIdVeiculo.FormattingEnabled = true;
            this.ddIdVeiculo.Location = new System.Drawing.Point(30, 62);
            this.ddIdVeiculo.Name = "ddIdVeiculo";
            this.ddIdVeiculo.Size = new System.Drawing.Size(126, 21);
            this.ddIdVeiculo.TabIndex = 29;
            this.ddIdVeiculo.SelectedIndexChanged += new System.EventHandler(this.ddIdVeiculo_SelectedIndexChanged);
            // 
            // txtQtDeLitros
            // 
            this.txtQtDeLitros.Location = new System.Drawing.Point(577, 64);
            this.txtQtDeLitros.Name = "txtQtDeLitros";
            this.txtQtDeLitros.Size = new System.Drawing.Size(136, 20);
            this.txtQtDeLitros.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(584, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "QUANTIDADE LITROS";
            // 
            // dgvAbastecimento
            // 
            this.dgvAbastecimento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbastecimento.Location = new System.Drawing.Point(67, 192);
            this.dgvAbastecimento.Name = "dgvAbastecimento";
            this.dgvAbastecimento.Size = new System.Drawing.Size(609, 229);
            this.dgvAbastecimento.TabIndex = 32;
            // 
            // dB_COMBUSTIVELDataSet
            // 
            this.dB_COMBUSTIVELDataSet.DataSetName = "DB_COMBUSTIVELDataSet";
            this.dB_COMBUSTIVELDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // veiculoBindingSource
            // 
            this.veiculoBindingSource.DataMember = "Veiculo";
            this.veiculoBindingSource.DataSource = this.dB_COMBUSTIVELDataSet;
            // 
            // veiculoTableAdapter
            // 
            this.veiculoTableAdapter.ClearBeforeFill = true;
            // 
            // txbIdAbastecimento
            // 
            this.txbIdAbastecimento.Location = new System.Drawing.Point(171, 64);
            this.txbIdAbastecimento.Name = "txbIdAbastecimento";
            this.txbIdAbastecimento.Size = new System.Drawing.Size(126, 20);
            this.txbIdAbastecimento.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(185, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "ID ABASTECIMENTO";
            // 
            // FormAbastecimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbIdAbastecimento);
            this.Controls.Add(this.dgvAbastecimento);
            this.Controls.Add(this.txtQtDeLitros);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ddIdVeiculo);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.HodometroBD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormAbastecimento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABASTECIMENTO";
            this.Load += new System.EventHandler(this.FormAbastecimento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbastecimento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_COMBUSTIVELDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veiculoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox HodometroBD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ddIdVeiculo;
        private System.Windows.Forms.TextBox txtQtDeLitros;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvAbastecimento;
        private DB_COMBUSTIVELDataSet dB_COMBUSTIVELDataSet;
        private System.Windows.Forms.BindingSource veiculoBindingSource;
        private DB_COMBUSTIVELDataSetTableAdapters.VeiculoTableAdapter veiculoTableAdapter;
        private System.Windows.Forms.TextBox txbIdAbastecimento;
        private System.Windows.Forms.Label label5;
    }
}