using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GestionProduitChimiques.Models.DAL
{
    public class DbConnection
    {

        // static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=GPCDB";
        static string connectionString = "Server=sql11.freemysqlhosting.net;Database=sql11398570;Uid=sql11398570;Pwd=6SiHzSViUt;";
       // static string connectionString = "Server=MYSQL5036.site4now.net;Database=db_a70e71_mygpc;Uid=a70e71_mygpc;Pwd=FSMGPC1234";
       //workstation id=mygpcfsm.mssql.somee.com;packet size=4096;user id=najlachenchen_SQLLogin_1;pwd=lq459jfwbm;data source=mygpcfsm.mssql.somee.com;persist security info=False;initial catalog=mygpcfsm

        public static MySqlConnection GetConnection()
        {
            MySqlConnection cn = null;
            try
            {
                cn = new MySqlConnection(connectionString);
            }
            catch (Exception ex)
            {
                throw ex;

            }
            return cn;

        }
    }
}
