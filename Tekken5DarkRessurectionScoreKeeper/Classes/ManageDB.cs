using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

using System.Data.SqlServerCe;


namespace Tekken5DarkRessurectionScoreKeeper.Classes
{
    public class ManageDB
    {
        static ManageDB theInstance;
        public static ManageDB Instance
        {
            get
            {
                if (!isInitialized)
                    theInstance = new ManageDB();

                return theInstance;
            }
        }

        static SqlCeConnection dbConnection;
        static bool isInitialized = false;

        private ManageDB()
        {
            dbConnection = new SqlCeConnection();
            dbConnection.ConnectionString = global::Tekken5DarkRessurectionScoreKeeper.Properties.Settings.Default.TekkenScoreDBConnectionString;
            isInitialized = true;
        }


        private SqlCeConnection openConnection()
        {
            dbConnection.Open();
            return dbConnection;
        }


        private void closeConnection()
        {
            dbConnection.Close();
        }

        /// <summary>
        /// Returns a DataTable containing the results of the query (SELECT-statement only)
        /// </summary>
        /// <param name="sqlString">The SQL</param>
        /// <returns></returns>
        public DataTable query(string sqlString)
        {
            DataTable returnTable = null;
            SqlCeCommand sqlCommand = null;

            try
            {
                dbConnection.ConnectionString = global::Tekken5DarkRessurectionScoreKeeper.Properties.Settings.Default.TekkenScoreDBConnectionString;
                sqlCommand = new SqlCeCommand(sqlString, dbConnection);
                returnTable = new DataTable();
           
                
                openConnection();
                SqlCeDataReader reader = sqlCommand.ExecuteReader();
                returnTable.Load(reader);
                reader.Close();
            } 
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Database error (Query)");
            }
            finally
            {
                closeConnection();
                sqlCommand.Dispose();
            }
            return returnTable;
        }

        /// <summary>
        /// Returns the number of affected rows from the Non-Query (UPDATE-, INSERT- or DELETE-statement only)
        /// </summary>
        /// <param name="sqlString">The SQL</param>
        /// <returns></returns>
        public int nonQuery(string sqlString)
        {
            int numberOfRows = 0;

            SqlCeCommand sqlCommand = null;

            try
            {
                dbConnection.ConnectionString = global::Tekken5DarkRessurectionScoreKeeper.Properties.Settings.Default.TekkenScoreDBConnectionString;
                sqlCommand = new SqlCeCommand(sqlString, dbConnection);


                openConnection();
                numberOfRows = sqlCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Database error (NonQuery)");
            }
            finally
            {
                closeConnection();
                sqlCommand.Dispose();
            }
            return numberOfRows;

        }




    }
}
