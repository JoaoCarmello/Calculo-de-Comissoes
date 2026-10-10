namespace calculoComissao
{
    partial class frmCalcularComissao
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCalcular = new Button();
            dgvComissoes = new DataGridView();
            lblTitulo = new Label();
            lblSubTitulo = new Label();
            lblVendedores = new Label();
            lblVendas = new Label();
            gbVendedores = new GroupBox();
            gbVendas = new GroupBox();
            btnLimpar = new Button();
            btnSair = new Button();
            gbValorTotal = new GroupBox();
            lblValorTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvComissoes).BeginInit();
            gbVendedores.SuspendLayout();
            gbVendas.SuspendLayout();
            gbValorTotal.SuspendLayout();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(312, 171);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(84, 23);
            btnCalcular.TabIndex = 9;
            btnCalcular.Text = "&Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // dgvComissoes
            // 
            dgvComissoes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvComissoes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvComissoes.Location = new Point(12, 200);
            dgvComissoes.Name = "dgvComissoes";
            dgvComissoes.Size = new Size(474, 277);
            dgvComissoes.TabIndex = 11;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 18F);
            lblTitulo.Location = new Point(22, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(276, 37);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Controle de Comissões";
            // 
            // lblSubTitulo
            // 
            lblSubTitulo.Font = new Font("Segoe UI", 10F);
            lblSubTitulo.Location = new Point(26, 40);
            lblSubTitulo.Name = "lblSubTitulo";
            lblSubTitulo.Size = new Size(307, 26);
            lblSubTitulo.TabIndex = 1;
            lblSubTitulo.Text = "Gestão de vendas e desempenho comercial";
            // 
            // lblVendedores
            // 
            lblVendedores.Font = new Font("Segoe UI", 15F);
            lblVendedores.Location = new Point(10, 31);
            lblVendedores.Name = "lblVendedores";
            lblVendedores.Size = new Size(51, 26);
            lblVendedores.TabIndex = 3;
            // 
            // lblVendas
            // 
            lblVendas.Font = new Font("Segoe UI", 15F);
            lblVendas.Location = new Point(6, 29);
            lblVendas.Name = "lblVendas";
            lblVendas.Size = new Size(45, 26);
            lblVendas.TabIndex = 5;
            // 
            // gbVendedores
            // 
            gbVendedores.Controls.Add(lblVendedores);
            gbVendedores.Location = new Point(12, 67);
            gbVendedores.Name = "gbVendedores";
            gbVendedores.Size = new Size(137, 92);
            gbVendedores.TabIndex = 2;
            gbVendedores.TabStop = false;
            gbVendedores.Text = "Vendedores";
            // 
            // gbVendas
            // 
            gbVendas.Controls.Add(lblVendas);
            gbVendas.Location = new Point(182, 67);
            gbVendas.Name = "gbVendas";
            gbVendas.Size = new Size(137, 92);
            gbVendas.TabIndex = 4;
            gbVendas.TabStop = false;
            gbVendas.Text = "Vendas Calculadas";
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(222, 171);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(84, 23);
            btnLimpar.TabIndex = 8;
            btnLimpar.Text = "&Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(402, 171);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(84, 23);
            btnSair.TabIndex = 10;
            btnSair.Text = "&Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // gbValorTotal
            // 
            gbValorTotal.Controls.Add(lblValorTotal);
            gbValorTotal.Location = new Point(349, 67);
            gbValorTotal.Name = "gbValorTotal";
            gbValorTotal.Size = new Size(137, 92);
            gbValorTotal.TabIndex = 6;
            gbValorTotal.TabStop = false;
            gbValorTotal.Text = "Valor Total";
            // 
            // lblValorTotal
            // 
            lblValorTotal.Font = new Font("Segoe UI", 15F);
            lblValorTotal.Location = new Point(6, 29);
            lblValorTotal.Name = "lblValorTotal";
            lblValorTotal.Size = new Size(125, 26);
            lblValorTotal.TabIndex = 7;
            // 
            // frmCalcularComissao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 489);
            Controls.Add(gbValorTotal);
            Controls.Add(btnSair);
            Controls.Add(btnLimpar);
            Controls.Add(gbVendas);
            Controls.Add(gbVendedores);
            Controls.Add(lblSubTitulo);
            Controls.Add(lblTitulo);
            Controls.Add(dgvComissoes);
            Controls.Add(btnCalcular);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmCalcularComissao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cálculo de Comissões";
            Load += frmCalcularComissao_Load;
            ((System.ComponentModel.ISupportInitialize)dgvComissoes).EndInit();
            gbVendedores.ResumeLayout(false);
            gbVendas.ResumeLayout(false);
            gbValorTotal.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnCalcular;
        private DataGridView dgvComissoes;
        private Label lblTitulo;
        private Label lblSubTitulo;
        private Label lblVendedores;
        private Label lblVendas;
        private GroupBox gbVendedores;
        private GroupBox gbVendas;
        private Button btnLimpar;
        private Button btnSair;
        private GroupBox gbValorTotal;
        private Label lblValorTotal;
    }
}
