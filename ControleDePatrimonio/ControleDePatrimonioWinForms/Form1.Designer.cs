namespace ControleDePatrimonioWinForms
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.idLbl = new System.Windows.Forms.Label();
            this.nomeTbx = new System.Windows.Forms.TextBox();
            this.descricaoTbx = new System.Windows.Forms.TextBox();
            this.adicionarBtn = new System.Windows.Forms.Button();
            this.patrimonioDgv = new System.Windows.Forms.DataGridView();
            this.pesquisarBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.patrimonioDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descrição";
            // 
            // idLbl
            // 
            this.idLbl.AutoSize = true;
            this.idLbl.Location = new System.Drawing.Point(13, 48);
            this.idLbl.Name = "idLbl";
            this.idLbl.Size = new System.Drawing.Size(13, 13);
            this.idLbl.TabIndex = 3;
            this.idLbl.Text = "0";
            // 
            // nomeTbx
            // 
            this.nomeTbx.Location = new System.Drawing.Point(16, 87);
            this.nomeTbx.Name = "nomeTbx";
            this.nomeTbx.Size = new System.Drawing.Size(240, 20);
            this.nomeTbx.TabIndex = 4;
            // 
            // descricaoTbx
            // 
            this.descricaoTbx.Location = new System.Drawing.Point(16, 135);
            this.descricaoTbx.Multiline = true;
            this.descricaoTbx.Name = "descricaoTbx";
            this.descricaoTbx.Size = new System.Drawing.Size(240, 55);
            this.descricaoTbx.TabIndex = 5;
            // 
            // adicionarBtn
            // 
            this.adicionarBtn.Location = new System.Drawing.Point(181, 207);
            this.adicionarBtn.Name = "adicionarBtn";
            this.adicionarBtn.Size = new System.Drawing.Size(75, 23);
            this.adicionarBtn.TabIndex = 6;
            this.adicionarBtn.Text = "&Adicionar";
            this.adicionarBtn.UseVisualStyleBackColor = true;
            this.adicionarBtn.Click += new System.EventHandler(this.adicionarBtn_Click);
            // 
            // patrimonioDgv
            // 
            this.patrimonioDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patrimonioDgv.Location = new System.Drawing.Point(294, 12);
            this.patrimonioDgv.Name = "patrimonioDgv";
            this.patrimonioDgv.Size = new System.Drawing.Size(261, 190);
            this.patrimonioDgv.TabIndex = 7;
            // 
            // pesquisarBtn
            // 
            this.pesquisarBtn.Location = new System.Drawing.Point(294, 214);
            this.pesquisarBtn.Name = "pesquisarBtn";
            this.pesquisarBtn.Size = new System.Drawing.Size(75, 23);
            this.pesquisarBtn.TabIndex = 8;
            this.pesquisarBtn.Text = "Pesquisar";
            this.pesquisarBtn.UseVisualStyleBackColor = true;
            this.pesquisarBtn.Click += new System.EventHandler(this.pesquisarBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 249);
            this.Controls.Add(this.pesquisarBtn);
            this.Controls.Add(this.patrimonioDgv);
            this.Controls.Add(this.adicionarBtn);
            this.Controls.Add(this.descricaoTbx);
            this.Controls.Add(this.nomeTbx);
            this.Controls.Add(this.idLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.patrimonioDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label idLbl;
        private System.Windows.Forms.TextBox nomeTbx;
        private System.Windows.Forms.TextBox descricaoTbx;
        private System.Windows.Forms.Button adicionarBtn;
        private System.Windows.Forms.DataGridView patrimonioDgv;
        private System.Windows.Forms.Button pesquisarBtn;
    }
}

