namespace Distribuidora
{
    partial class form_inicio
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excluirProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarProdutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "DISTRIBUIDORA";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtoToolStripMenuItem,
            this.pesquisaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(503, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarProdutoToolStripMenuItem,
            this.excluirProdutoToolStripMenuItem});
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.produtoToolStripMenuItem.Text = "Produto";
            // 
            // cadastrarProdutoToolStripMenuItem
            // 
            this.cadastrarProdutoToolStripMenuItem.Name = "cadastrarProdutoToolStripMenuItem";
            this.cadastrarProdutoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastrarProdutoToolStripMenuItem.Text = "Cadastrar Produto";
            this.cadastrarProdutoToolStripMenuItem.Click += new System.EventHandler(this.cadastrarProdutoToolStripMenuItem_Click);
            // 
            // excluirProdutoToolStripMenuItem
            // 
            this.excluirProdutoToolStripMenuItem.Name = "excluirProdutoToolStripMenuItem";
            this.excluirProdutoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.excluirProdutoToolStripMenuItem.Text = "Excluir Produto";
            // 
            // pesquisaToolStripMenuItem
            // 
            this.pesquisaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pesquisarProdutoToolStripMenuItem});
            this.pesquisaToolStripMenuItem.Name = "pesquisaToolStripMenuItem";
            this.pesquisaToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.pesquisaToolStripMenuItem.Text = "Pesquisa";
            // 
            // pesquisarProdutoToolStripMenuItem
            // 
            this.pesquisarProdutoToolStripMenuItem.Name = "pesquisarProdutoToolStripMenuItem";
            this.pesquisarProdutoToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.pesquisarProdutoToolStripMenuItem.Text = "Pesquisar Produto";
            // 
            // form_inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(503, 304);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "form_inicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excluirProdutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarProdutoToolStripMenuItem;
    }
}

