using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Despesas_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double total, selecao;


        private void Form1_Load(object sender, EventArgs e)
        {
     
            dgv_Despesa.Columns.Insert(0, new DataGridViewCheckBoxColumn());
            dgv_Despesa.Columns.Insert(1, new DataGridViewTextBoxColumn());
            dgv_Despesa.Columns.Insert(2, new DataGridViewTextBoxColumn());
            dgv_Despesa.Columns.Insert(3, new DataGridViewTextBoxColumn());

          
            dgv_Despesa.Columns[0].Name = "OK";
            dgv_Despesa.Columns[1].Name = "CODIGO";
            dgv_Despesa.Columns[2].Name = "DESCRICAO";
            dgv_Despesa.Columns[3].Name = "VALOR";

       
            dgv_Despesa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgv_Despesa.ReadOnly = true;
            dgv_Despesa.AllowUserToAddRows = false;
            dgv_Despesa.AllowUserToDeleteRows = false;
            dgv_Despesa.AllowUserToOrderColumns = true;

            dgv_Despesa.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv_Despesa.Columns[3].DefaultCellStyle.Format = "###,###,##0.00";
        }


        private void btn_importar_Click(object sender, EventArgs e)
        {
            dgv_Despesa.RowCount = 0;

            ofdArquivo.FileName = "";
            ofdArquivo.ShowDialog();

            StreamReader arquivo = File.OpenText(ofdArquivo.FileName);

            String linha;
            while ((linha = arquivo.ReadLine()) != null)
            {
                string[] dados = linha.Split(';');
                string codigo = dados[0];
                string descricao = dados[1];
                double valor = double.Parse(dados[2]);

                dgv_Despesa.Rows.Add(false, codigo, descricao, valor);
                total += valor;
            }
            lbl_Total.Text = total.ToString("C");
        }




        private void dgv_Despesa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_Despesa.RowCount > 0 && e.ColumnIndex == 0)
            {
                if (Convert.ToBoolean(dgv_Despesa.CurrentRow.Cells[0].Value) == false)
                {
                    dgv_Despesa.CurrentRow.Cells[0].Value = true;
                    selecao += Convert.ToDouble(dgv_Despesa.CurrentRow.Cells[3].Value);
                }
                else
                {
                    dgv_Despesa.CurrentRow.Cells[0].Value = false;
                    selecao -= Convert.ToDouble(dgv_Despesa.CurrentRow.Cells[3].Value);
                }
                lbl_Selecao.Text = selecao.ToString("C");
            }
        }

        private void btn_Marcar_Click(object sender, EventArgs e)
        {
            selecao = 0;
            foreach (DataGridViewRow linha in dgv_Despesa.Rows)
            {
                linha.Cells[0].Value = true;
                selecao += Convert.ToDouble(linha.Cells[3].Value);
            }
            lbl_Selecao.Text = selecao.ToString("C");
        }

        private void btn_Desmarcar_Click(object sender, EventArgs e)
        {
            selecao = 0;
            foreach (DataGridViewRow linha in dgv_Despesa.Rows)
                linha.Cells[0].Value = false;
            lbl_Selecao.Text = selecao.ToString("C");
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Baixar_Click(object sender, EventArgs e)
        {
            for (int i = dgv_Despesa.RowCount - 1; i >= 0; i--)
            {
                if (Convert.ToBoolean(dgv_Despesa.Rows[i].Cells[0].Value) == true)
                {
                    selecao -= Convert.ToDouble(dgv_Despesa.Rows[i].Cells[3].Value);
                    total -= Convert.ToDouble(dgv_Despesa.Rows[i].Cells[3].Value);
                    dgv_Despesa.Rows.Remove(dgv_Despesa.Rows[i]);
                }
            }
            lbl_Selecao.Text = selecao.ToString("C");
            lbl_Total.Text = total.ToString("C");
        }

        
    }
}
