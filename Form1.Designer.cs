namespace Despesas_forms
{
    partial class Form1
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
            this.btn_importar = new System.Windows.Forms.Button();
            this.btn_Marcar = new System.Windows.Forms.Button();
            this.btn_Desmarcar = new System.Windows.Forms.Button();
            this.dgv_Despesa = new System.Windows.Forms.DataGridView();
            this.btn_Baixar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Selecao = new System.Windows.Forms.Label();
            this.lbl_Total = new System.Windows.Forms.Label();
            this.ofdArquivo = new System.Windows.Forms.OpenFileDialog();
            this.btn_Fechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Despesa)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_importar
            // 
            this.btn_importar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_importar.Location = new System.Drawing.Point(12, 12);
            this.btn_importar.Name = "btn_importar";
            this.btn_importar.Size = new System.Drawing.Size(170, 49);
            this.btn_importar.TabIndex = 0;
            this.btn_importar.Text = "Importar Arquivo";
            this.btn_importar.UseVisualStyleBackColor = true;
            this.btn_importar.Click += new System.EventHandler(this.btn_importar_Click);
            // 
            // btn_Marcar
            // 
            this.btn_Marcar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Marcar.Location = new System.Drawing.Point(820, 16);
            this.btn_Marcar.Name = "btn_Marcar";
            this.btn_Marcar.Size = new System.Drawing.Size(131, 45);
            this.btn_Marcar.TabIndex = 2;
            this.btn_Marcar.Text = "Marcar todos";
            this.btn_Marcar.UseVisualStyleBackColor = true;
            this.btn_Marcar.Click += new System.EventHandler(this.btn_Marcar_Click);
            // 
            // btn_Desmarcar
            // 
            this.btn_Desmarcar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Desmarcar.Location = new System.Drawing.Point(1005, 16);
            this.btn_Desmarcar.Name = "btn_Desmarcar";
            this.btn_Desmarcar.Size = new System.Drawing.Size(131, 45);
            this.btn_Desmarcar.TabIndex = 3;
            this.btn_Desmarcar.Text = "Desmarcar Todos";
            this.btn_Desmarcar.UseVisualStyleBackColor = true;
            this.btn_Desmarcar.Click += new System.EventHandler(this.btn_Desmarcar_Click);
            // 
            // dgv_Despesa
            // 
            this.dgv_Despesa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Despesa.Location = new System.Drawing.Point(12, 96);
            this.dgv_Despesa.Name = "dgv_Despesa";
            this.dgv_Despesa.Size = new System.Drawing.Size(1124, 470);
            this.dgv_Despesa.TabIndex = 4;
            this.dgv_Despesa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Despesa_CellContentClick);
            // 
            // btn_Baixar
            // 
            this.btn_Baixar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Baixar.Location = new System.Drawing.Point(857, 625);
            this.btn_Baixar.Name = "btn_Baixar";
            this.btn_Baixar.Size = new System.Drawing.Size(131, 45);
            this.btn_Baixar.TabIndex = 5;
            this.btn_Baixar.Text = "Baixar Selecionadas";
            this.btn_Baixar.UseVisualStyleBackColor = true;
            this.btn_Baixar.Click += new System.EventHandler(this.btn_Baixar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 639);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(289, 639);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Seleção:";
            // 
            // lbl_Selecao
            // 
            this.lbl_Selecao.AutoSize = true;
            this.lbl_Selecao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Selecao.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Selecao.Location = new System.Drawing.Point(368, 631);
            this.lbl_Selecao.Name = "lbl_Selecao";
            this.lbl_Selecao.Size = new System.Drawing.Size(71, 31);
            this.lbl_Selecao.TabIndex = 8;
            this.lbl_Selecao.Text = "0,00";
            // 
            // lbl_Total
            // 
            this.lbl_Total.AutoSize = true;
            this.lbl_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Total.ForeColor = System.Drawing.Color.Blue;
            this.lbl_Total.Location = new System.Drawing.Point(65, 631);
            this.lbl_Total.Name = "lbl_Total";
            this.lbl_Total.Size = new System.Drawing.Size(71, 31);
            this.lbl_Total.TabIndex = 10;
            this.lbl_Total.Text = "0,00";
            // 
            // ofdArquivo
            // 
            this.ofdArquivo.FileName = "openFileDialog1";
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Fechar.Location = new System.Drawing.Point(1005, 625);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(131, 45);
            this.btn_Fechar.TabIndex = 11;
            this.btn_Fechar.Text = "Fechar";
            this.btn_Fechar.UseVisualStyleBackColor = true;
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 679);
            this.Controls.Add(this.btn_Fechar);
            this.Controls.Add(this.lbl_Total);
            this.Controls.Add(this.lbl_Selecao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Baixar);
            this.Controls.Add(this.dgv_Despesa);
            this.Controls.Add(this.btn_Desmarcar);
            this.Controls.Add(this.btn_Marcar);
            this.Controls.Add(this.btn_importar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Despesa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_importar;
        private System.Windows.Forms.Button btn_Marcar;
        private System.Windows.Forms.Button btn_Desmarcar;
        private System.Windows.Forms.DataGridView dgv_Despesa;
        private System.Windows.Forms.Button btn_Baixar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Selecao;
        private System.Windows.Forms.Label lbl_Total;
        private System.Windows.Forms.OpenFileDialog ofdArquivo;
        private System.Windows.Forms.Button btn_Fechar;
    }
}

