using System.Data.OleDb;


namespace ConvertAsset
{
    public class ManipulateQuery
    {
        public void ExecuteNonQuery(string connectionString, string queryString)
        {
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand command = new OleDbCommand(queryString, connection);
                connection.Open();
                command.ExecuteNonQuery();


            }
        }
    }
}
