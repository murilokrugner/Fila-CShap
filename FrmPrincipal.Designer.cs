namespace FILA___MURILO_AUGUSTO_KRUGNER_ALMEIDA_LEITE
{
    partial class FrmPrincipal
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lblFila = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnQnt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(55, 186);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 46);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Adicionar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(91, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(539, 36);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // lblFila
            // 
            this.lblFila.AutoSize = true;
            this.lblFila.Location = new System.Drawing.Point(12, 31);
            this.lblFila.Name = "lblFila";
            this.lblFila.Size = new System.Drawing.Size(44, 17);
            this.lblFila.TabIndex = 2;
            this.lblFila.Text = "FILA: ";
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(91, 127);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(539, 22);
            this.textBox.TabIndex = 3;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(12, 132);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(59, 17);
            this.lblValor.TabIndex = 4;
            this.lblValor.Text = "VALOR:";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(202, 186);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(99, 46);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Remover";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnQnt
            // 
            this.btnQnt.Location = new System.Drawing.Point(357, 186);
            this.btnQnt.Name = "btnQnt";
            this.btnQnt.Size = new System.Drawing.Size(99, 46);
            this.btnQnt.TabIndex = 6;
            this.btnQnt.Text = "Quantidade";
            this.btnQnt.UseVisualStyleBackColor = true;
            this.btnQnt.Click += new System.EventHandler(this.btnQnt_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 259);
            this.Controls.Add(this.btnQnt);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.lblFila);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnAdd);
            this.Name = "FrmPrincipal";
            this.Text = "Fila";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lblFila;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnQnt;
    }
}

