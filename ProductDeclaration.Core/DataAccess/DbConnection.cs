using Advantage.Data.Provider;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDeclaration.Core.DataAccess
{
    public static class DbConnection
    {
        private static DatabaseType _databaseType;

        public static void InitializeConnections(DatabaseType databaseType)
        {
            _databaseType = databaseType;
        }

        public static IDbConnection GetConnection()
        {
            if (_databaseType == DatabaseType.SqlServer)
            {
                return GetSqlConnection();
            }
            else if (_databaseType == DatabaseType.MySql)
            {
                return GetMySqlConnection();
            }
            else if (_databaseType == DatabaseType.AdsServer)
            {
                return GetAdsConnection();
            }

            throw new Exception("Database type doesn't exist!");
        }


        private static string GetConnectionString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

        public static SqlConnection GetSqlConnection()
        {
            SqlConnection connection;
            try
            {
                connection = new SqlConnection(GetConnectionString(GlobalConfig.cnnStrName));
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return connection;
        }

        private static AdsConnection GetAdsConnection()
        {
            AdsConnection connection;
            try
            {
                connection = new AdsConnection(GetConnectionString(GlobalConfig.cnnStrName));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return connection;
        }

        private static MySqlConnection GetMySqlConnection()
        {
            MySqlConnection connection;
            try
            {
                connection = new MySqlConnection(GetConnectionString(GlobalConfig.cnnStrName));
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return connection;
        }
    }
}
