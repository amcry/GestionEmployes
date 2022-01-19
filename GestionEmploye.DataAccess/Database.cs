using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionEmploye.DataAccess
{
    public class Database
    {
        private static readonly string _dataSource = "localhost";
        private static readonly string _user = "root";
        private static readonly string _password = "";
        private static readonly string _initialCatalog = "gestionemploye";

        private static SqlConnection _connexion = null;

        public static SqlConnection StartConnexion()
        {
            if (_connexion == null)
            {
                SqlConnectionStringBuilder builder = new();

                builder.DataSource = _dataSource;
                builder.UserID = _user;
                builder.Password = _password;
                builder.InitialCatalog = _initialCatalog;

                _connexion = new(builder.ConnectionString);

                _connexion.Open();

                return _connexion;
            }
            return null;
        }

        public static SqlConnection GetConnexion()
        {
            return _connexion;
        }

        public static void EndConnexion()
        {
            if (_connexion != null)
            {
                _connexion.Close();
                _connexion = null;
            }
        }
    }
}
