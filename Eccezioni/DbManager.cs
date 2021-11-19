using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eccezioni
{
    class DbManager
    {
        //Stringa connessione: la imposta vuota per farmi catturare l eccezione stringa di connessione vuota;
        string connectionString = @"";
        //string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Users;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";


        public List<User> GetAll()
            {

            SqlConnection connection = null;
            try
            {
                using (connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandType = System.Data.CommandType.Text;
                    command.CommandText = "select * from Users";

                    SqlDataReader reader = command.ExecuteReader();

                    List<User> users = new List<User>();

                    while (reader.Read())
                    {
                        var id = (int)reader["Id"];
                        var nome = (string)reader["Nome"];
                        var cognome = (string)reader["Cognome"];

                        User u = new User();
                        u.Id = id;
                        u.Nome = nome;
                        u.Cognome = cognome;

                        users.Add(u);
                    }

                    return users;
                }
            }

            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return new List<User>();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new List<User>();
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }


        //metodo per restitutire user dal nome, tentativo di inserire eccezione personalizzata USERNOTFOUNDEXCEPTION

        //public List<User> GetByName(string nome)  //TODO
        //{
        //    using (SqlConnection connection = new SqlConnection(connectionString))
        //    {
        //        connection.Open();

        //        SqlCommand command = new SqlCommand();
        //        command.Connection = connection;
        //        command.CommandType = System.Data.CommandType.Text;
        //        command.CommandText = "select  from Users where Nome = @nome";
        //        command.Parameters.AddWithValue("@nome", nome);

        //        SqlDataReader reader = command.ExecuteReader();
        //        List<User> users = new List<User>();


        //        User user = null;

        //        while (reader.Read())
        //        {
        //            var id = (int)reader["Id"];
        //           // var nome = (string)reader["Nome"];
        //            var cognome = (string)reader["Cognome"];
                   

        //            user = new User(id, nome, cognome);
        //            users.Add(user);
        //        }
        //        connection.Close();
        //        return users;
        //    }
        //}
       





            }
    }
