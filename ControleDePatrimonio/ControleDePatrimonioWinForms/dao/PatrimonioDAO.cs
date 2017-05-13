using ControleDePatrimonioWinForms.model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDePatrimonioWinForms.dao
{
    public class PatrimonioDAO : DAO
    {

        

        public PatrimonioDAO()
        {
        }


        public void Adicionar(Patrimonio patrimonio)
        {            
            String queryInserir =
                "INSERT INTO patrimonio (nome,descricao) VALUES (@nome,@descricao);";
            List<MySqlParameter> paramatros = new List<MySqlParameter>();
            paramatros.Add(new MySqlParameter("nome", patrimonio.Nome));
            paramatros.Add(new MySqlParameter("descricao", patrimonio.Descricao));
            this.ExecutarNonQuery(queryInserir, paramatros);
        }

        public void Atualizar(Patrimonio patrimonio)
        {
            
            String queryUdate =
                "UPDATE patrimonio set nome=@nome, descricao=@descricao WHERE id_patrimonio = @idPatrimonio);";
            List<MySqlParameter> paramatros = new List<MySqlParameter>();
            paramatros.Add(new MySqlParameter("nome", patrimonio.Nome));
            paramatros.Add(new MySqlParameter("descricao", patrimonio.Descricao));
            paramatros.Add(new MySqlParameter("idPatrimonio", patrimonio.IdPatrimonio));
            this.ExecutarNonQuery(queryUdate, paramatros);
        }


        /*
        public void Adicionar(Patrimonio patrimonio)
        {
           
            MySqlConnection conn = new ConnectionFactory().getConnection();
            String query =
                "INSERT INTO patrimonio (nome,descricao) VALUES (@nome,@descricao);";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.Add(new MySqlParameter("nome", patrimonio.Nome));
            cmd.Parameters.Add(new MySqlParameter("descricao", patrimonio.Descricao));
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            conn.Close();                
        }
       
        public void Atualizar(Patrimonio patrimonio)
        {
            MySqlConnection conn = new ConnectionFactory().getConnection();
            String query = 
                "UPDATE patrimonio set nome=@nome, descricao=@descricao WHERE id_patrimonio = @idPatrimonio);";
            
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.Add(new MySqlParameter("nome", patrimonio.Nome));
            cmd.Parameters.Add(new MySqlParameter("descricao", patrimonio.Descricao));
            cmd.Parameters.Add(new MySqlParameter("idPatrimonio", patrimonio.IdPatrimonio));
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

                */



        public List<Patrimonio> Buscar()
        {
            List<Patrimonio> patrimonios = new List<Patrimonio>();
            MySqlConnection conn = new ConnectionFactory().getConnection();            
            String query = "SELECT id_patrimonio, nome, descricao FROM patrimonio;";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Prepare();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Patrimonio p = new Patrimonio()
                {
                    IdPatrimonio = Convert.ToInt32(reader["id_patrimonio"]),
                    Nome = Convert.ToString( reader["nome"] ),
                    Descricao = Convert.ToString( reader["descricao"] )
                };
                patrimonios.Add(p);
            }
            reader.Close();
            conn.Close();
            return patrimonios;
        }
    }
}
