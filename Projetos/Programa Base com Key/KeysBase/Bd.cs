using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeysBase
{
    class Bd
    {

        private static MySqlConnection conexao;
        public static DataTable dql(string sql) // data query language (Select)
        {
            MySqlDataAdapter da = null;
            DataTable dt = new DataTable();
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = sql;
                da = new MySqlDataAdapter(cmd.CommandText, vcon);
                da.Fill(dt);
                vcon.Close();
                return dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void dml(string q, string msgOK = null, string msgERRO = null) // data manipulation language (insert, delete, update)
        {
            try
            {
                var vcon = ConexaoBanco();
                var cmd = vcon.CreateCommand();
                cmd.CommandText = q;
                cmd.ExecuteNonQuery();
                vcon.Close();
                if (msgOK != null)
                {
                    MessageBox.Show(msgOK);
                }
            }
            catch (Exception ex)
            {
                if (msgERRO != null)
                {
                    MessageBox.Show(msgERRO + "\n" + ex.Message);
                }
                throw ex;
            }
        }
         
        /* abaixo dados do Sv */
        private static string ipServer = "";
        private static string dbName = "";
        private static string userBd = "";
        private static string senhaBd = "";

        private static MySqlConnection ConexaoBanco()
        {
            string connString = "Server=" + ipServer +
                                ";Database=" + dbName +
                                ";Uid=" + userBd +
                                ";Pwd=" + senhaBd +
                                ";SslMode=none;";
            conexao = new MySqlConnection(connString);
            conexao.Open();
            return conexao;
        }
    }
}
