namespace CADASTRTO_DE_AUTOR
{
    partial class FrmCadastroAutor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroAutor));
            this.dadosGrid = new System.Windows.Forms.DataGridView();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtDescAutor = new System.Windows.Forms.TextBox();
            this.labelDescAutor = new System.Windows.Forms.Label();
            this.txtNomeAutor = new System.Windows.Forms.TextBox();
            this.txtcodAutor = new System.Windows.Forms.TextBox();
            this.labelCodAutor = new System.Windows.Forms.Label();
            this.labelNomeAutor = new System.Windows.Forms.Label();
            this.asteriscoAlert = new System.Windows.Forms.Label();
            this.colcodigoAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colnomeDoAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldecricaoAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dadosGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dadosGrid
            // 
            this.dadosGrid.AllowUserToAddRows = false;
            this.dadosGrid.AllowUserToDeleteRows = false;
            this.dadosGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dadosGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dadosGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dadosGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dadosGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colcodigoAutor,
            this.colnomeDoAutor,
            this.coldecricaoAutor});
            this.dadosGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dadosGrid.Location = new System.Drawing.Point(11, 118);
            this.dadosGrid.Name = "dadosGrid";
            this.dadosGrid.ReadOnly = true;
            this.dadosGrid.RowHeadersWidth = 51;
            this.dadosGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dadosGrid.Size = new System.Drawing.Size(553, 257);
            this.dadosGrid.TabIndex = 19;
            this.dadosGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dadosGrid_CellDoubleClick);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Excluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Excluir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Excluir.Location = new System.Drawing.Point(479, 88);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(85, 22);
            this.btn_Excluir.TabIndex = 18;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.Black;
            this.btnSalvar.Location = new System.Drawing.Point(479, 65);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(85, 22);
            this.btnSalvar.TabIndex = 17;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtDescAutor
            // 
            this.txtDescAutor.BackColor = System.Drawing.SystemColors.Info;
            this.txtDescAutor.Location = new System.Drawing.Point(122, 65);
            this.txtDescAutor.Multiline = true;
            this.txtDescAutor.Name = "txtDescAutor";
            this.txtDescAutor.Size = new System.Drawing.Size(351, 45);
            this.txtDescAutor.TabIndex = 16;
            // 
            // labelDescAutor
            // 
            this.labelDescAutor.AutoSize = true;
            this.labelDescAutor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescAutor.Location = new System.Drawing.Point(8, 65);
            this.labelDescAutor.Name = "labelDescAutor";
            this.labelDescAutor.Size = new System.Drawing.Size(135, 20);
            this.labelDescAutor.TabIndex = 15;
            this.labelDescAutor.Text = "Descrição do autor";
            // 
            // txtNomeAutor
            // 
            this.txtNomeAutor.BackColor = System.Drawing.SystemColors.Info;
            this.txtNomeAutor.Location = new System.Drawing.Point(122, 41);
            this.txtNomeAutor.Name = "txtNomeAutor";
            this.txtNomeAutor.Size = new System.Drawing.Size(351, 25);
            this.txtNomeAutor.TabIndex = 14;
            this.txtNomeAutor.TextChanged += new System.EventHandler(this.txtNomeAutor_TextChanged);
            // 
            // txtcodAutor
            // 
            this.txtcodAutor.BackColor = System.Drawing.SystemColors.Window;
            this.txtcodAutor.Enabled = false;
            this.txtcodAutor.Location = new System.Drawing.Point(122, 17);
            this.txtcodAutor.Name = "txtcodAutor";
            this.txtcodAutor.Size = new System.Drawing.Size(68, 25);
            this.txtcodAutor.TabIndex = 13;
            // 
            // labelCodAutor
            // 
            this.labelCodAutor.AutoSize = true;
            this.labelCodAutor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodAutor.Location = new System.Drawing.Point(8, 17);
            this.labelCodAutor.Name = "labelCodAutor";
            this.labelCodAutor.Size = new System.Drawing.Size(58, 20);
            this.labelCodAutor.TabIndex = 12;
            this.labelCodAutor.Text = "Código";
            // 
            // labelNomeAutor
            // 
            this.labelNomeAutor.AutoSize = true;
            this.labelNomeAutor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomeAutor.Location = new System.Drawing.Point(8, 41);
            this.labelNomeAutor.Name = "labelNomeAutor";
            this.labelNomeAutor.Size = new System.Drawing.Size(111, 20);
            this.labelNomeAutor.TabIndex = 11;
            this.labelNomeAutor.Text = "Nome do autor";
            // 
            // asteriscoAlert
            // 
            this.asteriscoAlert.AutoSize = true;
            this.asteriscoAlert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.asteriscoAlert.ForeColor = System.Drawing.Color.Red;
            this.asteriscoAlert.Location = new System.Drawing.Point(475, 41);
            this.asteriscoAlert.Name = "asteriscoAlert";
            this.asteriscoAlert.Size = new System.Drawing.Size(15, 19);
            this.asteriscoAlert.TabIndex = 20;
            this.asteriscoAlert.Text = "*";
            this.asteriscoAlert.MouseHover += new System.EventHandler(this.asteriscoAlert_MouseHover);
            // 
            // colcodigoAutor
            // 
            this.colcodigoAutor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.colcodigoAutor.FillWeight = 152.2843F;
            this.colcodigoAutor.HeaderText = "Código";
            this.colcodigoAutor.MinimumWidth = 6;
            this.colcodigoAutor.Name = "colcodigoAutor";
            this.colcodigoAutor.ReadOnly = true;
            this.colcodigoAutor.Width = 82;
            // 
            // colnomeDoAutor
            // 
            this.colnomeDoAutor.FillWeight = 73.85786F;
            this.colnomeDoAutor.HeaderText = "Nome do autor";
            this.colnomeDoAutor.MinimumWidth = 6;
            this.colnomeDoAutor.Name = "colnomeDoAutor";
            this.colnomeDoAutor.ReadOnly = true;
            // 
            // coldecricaoAutor
            // 
            this.coldecricaoAutor.FillWeight = 73.85786F;
            this.coldecricaoAutor.HeaderText = "Descrição do autor";
            this.coldecricaoAutor.MinimumWidth = 6;
            this.coldecricaoAutor.Name = "coldecricaoAutor";
            this.coldecricaoAutor.ReadOnly = true;
            // 
            // FrmCadastroAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(576, 383);
            this.Controls.Add(this.asteriscoAlert);
            this.Controls.Add(this.dadosGrid);
            this.Controls.Add(this.btn_Excluir);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtDescAutor);
            this.Controls.Add(this.labelDescAutor);
            this.Controls.Add(this.txtNomeAutor);
            this.Controls.Add(this.txtcodAutor);
            this.Controls.Add(this.labelCodAutor);
            this.Controls.Add(this.labelNomeAutor);
            this.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCadastroAutor";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de autor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dadosGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dadosGrid;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtDescAutor;
        private System.Windows.Forms.Label labelDescAutor;
        private System.Windows.Forms.TextBox txtNomeAutor;
        private System.Windows.Forms.TextBox txtcodAutor;
        private System.Windows.Forms.Label labelCodAutor;
        private System.Windows.Forms.Label labelNomeAutor;
        private System.Windows.Forms.Label asteriscoAlert;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcodigoAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colnomeDoAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldecricaoAutor;
    }
}

