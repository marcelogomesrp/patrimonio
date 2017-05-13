using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDePatrimonioWinForms.dao
{
    public class ConnectionFactory
    {
        private String connectionString;
        public ConnectionFactory()
        {
            connectionString = @"server=localhost;database=controle_patrimonio;userid=usuario;password=senhaa;";
        }

        public MySqlConnection getConnection(){
            MySqlConnection conn = new MySqlConnection(connectionString);
            return conn;
        }


    }
}
