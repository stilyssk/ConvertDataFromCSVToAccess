using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Text;
using ConvertAsset.Models;
using System.Linq;
namespace ConvertAsset.Repository
{
    public class RepositoryModel<T>
    {
        private List<T> listOfGeneric;
        private string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=TempDataBase.accdb;Persist Security Info=False";

        public RepositoryModel(List<T> assignSignalsIn)
        {
            listOfGeneric = assignSignalsIn;
            CreateTable();
            AlterTable(connectionString);
            Insert();
        }



        //public void InsertBak()
        //{
        //    var tempInstanceFromT = Activator.CreateInstance<T>();
        //    var listOfColumns = tempInstanceFromT.GetType().GetProperties();
        //    var nameOfTable = tempInstanceFromT.GetType().Name;
        //    using (OleDbConnection connection = new OleDbConnection(connectionString))
        //    {
        //        OleDbCommand command = new OleDbCommand();
        //        command.Connection = connection;
        //        connection.Open();
        //        foreach (var insertElement in listOfGeneric)
        //        {

        //            string queryString = $"INSERT INTO {nameOfTable} (";

        //            foreach (var currentProperty in listOfColumns)
        //            {
        //                queryString += $"{currentProperty.Name},";
        //            }
        //            queryString = queryString.Substring(0, queryString.Length - 1);
        //            queryString += $") VALUES (";
        //            if (insertElement is Assets)
        //            {
        //                var tempInsertElement = insertElement as Assets;
        //                //var tempInsertElement = insertElement.GetType().BaseType;
        //                var arrayProperties = tempInsertElement.GetType().GetProperties();
        //                foreach (var currentValue in arrayProperties)
        //                {
        //                    var AAA = currentValue.GetValue(tempInsertElement, null);
        //                    //if (AAA == "")
        //                    //{
        //                    //    AAA = "NULL";
        //                    //}
        //                    //if (AAA == null)
        //                    //{
        //                    //    AAA = 0;
        //                    //}
        //                    var propertyName = currentValue.PropertyType.Name;
        //                    if (propertyName == "DateTime" || propertyName == "String")
        //                    {
        //                        queryString += $"'{AAA}', ";
        //                    }
        //                    else
        //                    {
        //                        queryString += $"{AAA}, ";
        //                    }
        //                }
        //                queryString = queryString.Substring(0, queryString.Length - 1);
        //            }
        //            queryString = queryString.Substring(0, queryString.Length - 1);
        //            queryString += $")";
        //            command.CommandText = queryString;
        //            command.ExecuteNonQuery();
        //        }
        //    }
        //}
        

        public void Insert()
        {
            var tempInstanceFromT = Activator.CreateInstance<T>();
            var listOfColumns = tempInstanceFromT.GetType().GetProperties();
            var nameOfTable = tempInstanceFromT.GetType().Name;
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                connection.Open();
                foreach (var insertElement in listOfGeneric)
                {

                    string queryString = $"INSERT INTO {nameOfTable} (";

                    foreach (var currentProperty in listOfColumns)
                    {
                        queryString += $"{currentProperty.Name},";
                    }
                    queryString = queryString.Substring(0, queryString.Length - 1);
                    queryString += $") VALUES (";

                    var arrayProperties = insertElement.GetType().GetProperties();
                    foreach (var currentValue in arrayProperties)
                    {
                        var value = currentValue.GetValue(insertElement);

                        var propertyName = currentValue.PropertyType.Name;
                        if (propertyName == "DateTime" || propertyName == "String" )
                        {
                            queryString += $"'{value}', ";
                        }
                        else if (propertyName == "Single")
                        {
                            //queryString += $"'{value}', ";
                            queryString += $"{value.ToString().Replace(',', '.')}, ";
                        }
                        else if (propertyName == "TimeSpan")
                        {
                            queryString += $"'{value}', ";
                        }
                        else
                        {
                            queryString += $"{value}, ";
                        }
                    }
                    queryString = queryString.Substring(0, queryString.Length - 1);

                    queryString = queryString.Substring(0, queryString.Length - 1);
                    queryString += $")";
                    command.CommandText = queryString;
                    //Console.WriteLine(queryString);
                    command.ExecuteNonQuery();
                }
            }
        }
        private void CreateTable()
        {
            string queryString;
            ManipulateQuery manipulateQuery = new ManipulateQuery();
            try
            {
                var tempInstanceFromT = Activator.CreateInstance<T>();

                var nameOfTable = tempInstanceFromT.GetType().Name;
                queryString = $"DROP TABLE {nameOfTable} ";

                manipulateQuery.ExecuteNonQuery(connectionString, queryString);
                queryString = $"CREATE TABLE {nameOfTable} ( ID AUTOINCREMENT )";
                manipulateQuery.ExecuteNonQuery(connectionString, queryString);
            }
            catch (Exception)
            {
                var tempInstanceFromT = Activator.CreateInstance<T>();
                var nameOfTable = tempInstanceFromT.GetType().Name;
                queryString = $"CREATE TABLE {nameOfTable} ( ID AUTOINCREMENT )";
                manipulateQuery.ExecuteNonQuery(connectionString, queryString);
            }
        }
        private void AlterTable(string tableName)
        {
            var tempInstanceFromT = Activator.CreateInstance<T>();
            var listOfColumns = tempInstanceFromT.GetType().GetProperties();
            var nameOfTable = tempInstanceFromT.GetType().Name;
            ManipulateQuery manipulateQuery = new ManipulateQuery();
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                connection.Open();
                foreach (var currentProperty in listOfColumns)
                {
                    if (currentProperty.PropertyType.Name == "String")
                    {
                        string queryString = $"ALTER TABLE {nameOfTable} ADD COLUMN {currentProperty.Name} TEXT";
                        command.CommandText = queryString;
                        command.ExecuteNonQuery();
                    }
                    else if (currentProperty.PropertyType.Name == "DateTime")
                    {
                        string queryString = $"ALTER TABLE {nameOfTable} ADD COLUMN {currentProperty.Name} DATETIME";
                        command.CommandText = queryString;
                        command.ExecuteNonQuery();
                    }
                    else if (currentProperty.PropertyType.Name == "Int32")
                    {
                        string queryString = $"ALTER TABLE {nameOfTable} ADD COLUMN {currentProperty.Name} INT";
                        command.CommandText = queryString;
                        command.ExecuteNonQuery();
                    }
                    else if (currentProperty.PropertyType.Name == "Single")
                    {
                        string queryString = $"ALTER TABLE {nameOfTable} ADD COLUMN {currentProperty.Name} NUMERIC(18,3)";
                        command.CommandText = queryString;
                        command.ExecuteNonQuery();
                    }else if (currentProperty.PropertyType.Name == "TimeSpan")
                    {
                        string queryString = $"ALTER TABLE {nameOfTable} ADD COLUMN {currentProperty.Name} TIME";
                        command.CommandText = queryString;
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        public List<T> ReturnData()
        {
            return listOfGeneric;
        }

    }
}
