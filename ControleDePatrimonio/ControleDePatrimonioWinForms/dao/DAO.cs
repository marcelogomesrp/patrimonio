using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDePatrimonioWinForms.dao
{
    public class DAO
    {
        public void ExecutarNonQuery(String query, List<MySqlParameter> parametros)
        {

            MySqlConnection conn = new ConnectionFactory().getConnection();                        
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            foreach (MySqlParameter p in parametros)
            {
                cmd.Parameters.Add(p);
            }
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
