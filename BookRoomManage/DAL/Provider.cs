﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace BookRoomManage
{
    public class Provider
    {
        private static string _connectionString = @"Data Source=ADMIN-PC\NGUYENHUUNAM;Initial Catalog=BookRoom_Manage;Integrated Security=True";

        private SqlConnection _connection;

        private SqlCommand _sqlCommand;

        private static Provider instance;

        public static Provider Instance
        {
            get { if (instance == null) instance = new Provider(); return Provider.instance; }
            private set { Provider.instance = value; }
        }

        public Provider()
        {
            _connection = new SqlConnection(_connectionString);
            _sqlCommand = _connection.CreateCommand();
            _sqlCommand.CommandType = CommandType.StoredProcedure;
            _connection.Open();
        }

        public DataTable ExcuteQuery(string storeName, object parameters = null)
        {
            _sqlCommand.CommandText = storeName;
            if (parameters != null)
            {
                string[] parameterNames = parameters.GetType().GetProperties().Select(p => p.Name).ToArray();
                foreach (var item in parameterNames)
                {
                    _sqlCommand.Parameters.AddWithValue("@" + item, parameters.GetType().GetProperty(item).GetValue(parameters, null));
                }
            }
            SqlDataAdapter adapter = new SqlDataAdapter(_sqlCommand);
            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);
            _connection.Close();

            return dataTable;
        }

        public int ExcuteNonQuery(string storeName, object parameters = null)
        {
            int result = -1;
            _sqlCommand.CommandText = storeName;
            if (parameters != null)
            {   
                string[] parameterNames = parameters.GetType().GetProperties().Select(p => p.Name).ToArray();
                foreach (var item in parameterNames)
                {
                    var parameterValue = parameters.GetType().GetProperty(item).GetValue(parameters, null);
                    _sqlCommand.Parameters.AddWithValue("@" + item, parameterValue ?? DBNull.Value );
                }
                result = _sqlCommand.ExecuteNonQuery();
            }

            return result;
        }

        public object ExcuteScalar(string storeName, object parameters = null)
        {
            object result = -1;
            _sqlCommand.CommandText = storeName;
            if (parameters != null)
            {
                string[] parameterNames = parameters.GetType().GetProperties().Select(p => p.Name).ToArray();
                foreach (var item in parameterNames)
                {
                    var parameterValue = parameters.GetType().GetProperty(item).GetValue(parameters, null);
                    _sqlCommand.Parameters.AddWithValue("@" + item, parameterValue);
                }
                result = _sqlCommand.ExecuteScalar();
            }

            return result;
        }
    }
}
