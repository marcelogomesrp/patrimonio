using ControleDePatrimonioWinForms.dao;
using ControleDePatrimonioWinForms.model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleDePatrimonioWinForms
{
    public partial class Form1 : Form
    {
        private PatrimonioDAO patrimonioDao;
        public Form1()
        {
            InitializeComponent();
            patrimonioDao = new PatrimonioDAO();
        }
        private void limparTela()
        {
            nomeTbx.Text = "";
            descricaoTbx.Text = "";
            fazPesquisa();
        }
        private Patrimonio criaPatrimonoDaComDadosDaTela()
        {
            Patrimonio patrimonio = new Patrimonio()
            {
                Nome = nomeTbx.Text,
                Descricao = descricaoTbx.Text
            };
            return patrimonio;
        }

        private void fazPesquisa()
        {
            patrimonioDgv.DataSource = patrimonioDao.Buscar();

        }

        private void adicionarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                patrimonioDao.Adicionar(this.criaPatrimonoDaComDadosDaTela());
                MessageBox.Show("Patrimonio adicionado com sucesso");
                limparTela();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Ops!!! " + ex.ToString());
                MessageBox.Show("Por favor contacte o suporte 16 8887587, informe errode conexao com o banco");
                this.Close();
            }
        }

        private void pesquisarBtn_Click(object sender, EventArgs e)
        {
            fazPesquisa();
        }
    }
}




/*
String connectionString = 
@"server=localhost;database=controle_patrimonio;userid=usuario;password=senha;";
MySqlConnection conn = null;
try
{
    conn = new MySqlConnection(connectionString);
    String query = "INSERT INTO patrimonio (nome,descricao) VALUES (@nome,@descricao);";
    conn.Open();
    MySqlCommand cmd = new MySqlCommand(query, conn);
    cmd.Parameters.Add(new MySqlParameter("nome", nomeTbx.Text));
    cmd.Parameters.Add(new MySqlParameter("descricao", descricaoTbx.Text));
    cmd.Prepare();
    cmd.ExecuteNonQuery();
    conn.Close();
    MessageBox.Show("Patrimonio adicionado com sucesso");
    nomeTbx.Text = "";
    descricaoTbx.Text = "";
}
catch (Exception ex)
{
    MessageBox.Show("Error: " + ex.Message);
}
 */
