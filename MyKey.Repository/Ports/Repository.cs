﻿using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyKey.Repository.Ports
{
    public abstract class Repository<T> : Irepository<T> where T : class
    {
        private string connectionString;

        public Repository()
        {
            connectionString = " ";
        }

        public bool Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                var entity = connection.Get<T>(id);

                connection.Delete<T>(entity);
                
                connection.Close();

                return true;
            }
        }

        public List<T> GetAll()
        {
            using(var connection=new SqlConnection(connectionString))
                {

                connection.Open();

                var collection = connection.GetAll<T>();

                connection.Close();

                return collection.ToList();

                
            }
        }

        public T GetbyId(int id)
        {
            using ( var connection = new SqlConnection(connectionString))
            {
                var entity = connection.Get<T>(id);

                connection.Close();

                return entity;
            }
        }

        public int Insert(T entity)
        {
            using (var connection =new SqlConnection(connectionString))
            {
                var id = connection.Insert<T>(entity);

                connection.Close();

                return Convert.ToInt32(id);
            }
        }

        public void Update(T entity)
        {
            using( var connection= new SqlConnection(connectionString))
            {
                connection.Open();

                connection.Update<T>(entity);

                connection.Close();
                           
            }
        }
    }
}
