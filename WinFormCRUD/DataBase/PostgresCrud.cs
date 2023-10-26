using Dapper.Contrib.Extensions;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors;
using WinFormCRUD.DataBase;

namespace WinFormCRUD
{
    internal class PostgresCrud
    {
        public static T GetById<T>(int id) where T : class
        {
            var dataSourceBuilder = new NpgsqlDataSourceBuilder(ConnectDb.PostgresConnection);
            var dataSource = dataSourceBuilder.Build();

            using (var connection = dataSource.OpenConnection())
            {

                try
                {
                    return connection.Get<T>(id);
                }
                catch (Exception ex)
                {
                    return null;
                }

            }
        }

        public static List<T> GetAll<T>() where T : class
        {
            var dataSourceBuilder = new NpgsqlDataSourceBuilder(ConnectDb.PostgresConnection);
            var dataSource = dataSourceBuilder.Build();

            using (var connection = dataSource.OpenConnection())
            {

                try
                {
                    return connection.GetAll<T>().ToList();
                }
                catch (Exception ex)
                {
                    return new List<T>();
                }

            }
        }

        public static long Insert<T>(T entityToInsert) where T : class
        {
            var dataSourceBuilder = new NpgsqlDataSourceBuilder(ConnectDb.PostgresConnection);
            var dataSource = dataSourceBuilder.Build();

            using (var connection = dataSource.OpenConnection())
            {
                long result = 0;
                try
                {
                    result = connection.Insert(entityToInsert);
                }
                catch (Exception ex)
                {
                    result = 0;
                    XtraMessageBox.Show(ex.Message);
                }
                return result;
            }
        }

        public static bool Update<T>(T entityToUpdate) where T : class
        {
            var dataSourceBuilder = new NpgsqlDataSourceBuilder(ConnectDb.PostgresConnection);
            var dataSource = dataSourceBuilder.Build();

            using (var connection = dataSource.OpenConnection())
            {
                var result = false;
                try
                {
                    result = connection.Update(entityToUpdate);
                }
                catch (Exception ex)
                {
                    result = false;
                    XtraMessageBox.Show(ex.Message);
                }
                return result;
            }
        }

        public static bool Delete<T>(T entityToDelete) where T : class
        {
            var dataSourceBuilder = new NpgsqlDataSourceBuilder(ConnectDb.PostgresConnection);
            var dataSource = dataSourceBuilder.Build();

            using (var connection = dataSource.OpenConnection())
            {
                bool success = false;
                try
                {
                    success = connection.Delete(entityToDelete);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
                return success;
            }
        }
    }
}
