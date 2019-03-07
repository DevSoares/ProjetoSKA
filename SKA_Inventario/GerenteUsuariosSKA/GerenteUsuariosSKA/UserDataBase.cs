using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace GerenteUsuariosSKA
{
    public class UserDataBase
    {
        private static string connectionstring = "Server=DESKTOP-FP3Q8AQ\\SQLEXPRESS2008; Database=ProjectSKA; User Id=SQL_PROJECT_SKA;Password=Dev0test@;";

        public static bool AddUser(string username, string password)
        {
            // This function will add a user to our database

            // First create a new Guid for the user. This will be unique for each user
            Guid userGuid = System.Guid.NewGuid();

            // Hash the password together with our unique userGuid
            string hashedPassword = Security.HashSHA1(password + userGuid.ToString());

            SqlConnection con = new SqlConnection(connectionstring);
            using (SqlCommand cmd = new SqlCommand("INSERT INTO Usuarios (usuario, senha, guid_usuario) VALUES (@username, @password, @userguid)", con))
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", hashedPassword); // store the hashed value
                cmd.Parameters.AddWithValue("@userguid", userGuid.ToString()); // store the Guid

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            return true;
        }

        public static int GetUserIdByUsernameAndPassword(string username, string password)
        {
            // this is the value we will return
            int userId = 0;

            SqlConnection con = new SqlConnection(connectionstring);
            using (SqlCommand cmd = new SqlCommand("SELECT cod_usuario, senha, guid_usuario FROM Usuarios WHERE usuario=@username", con))
            {
                cmd.Parameters.AddWithValue("@username", username);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    // dr.Read() = we found user(s) with matching username!

                    int dbUserId = Convert.ToInt32(dr["cod_usuario"]);
                    string dbPassword = Convert.ToString(dr["senha"]);
                    string dbUserGuid = Convert.ToString(dr["guid_usuario"]);

                    // Now we hash the UserGuid from the database with the password we wan't to check
                    // In the same way as when we saved it to the database in the first place. (see AddUser() function)                   
                    string hashedPassword = Security.HashSHA1(password + dbUserGuid);

                    // if its correct password the result of the hash is the same as in the database
                    if (dbPassword == hashedPassword)
                    {
                        // The password is correct
                        userId = dbUserId;
                    }
                }
                con.Close();
            }

            // Return the user id which is 0 if we did not found a user.
            return userId;
        }

        public static void EditUser(string nome, int cod_usuario, string senha)
        {
            Guid userGuid = System.Guid.NewGuid();
            string hashedPassword = Security.HashSHA1(senha + userGuid.ToString());

            SqlConnection con = new SqlConnection(connectionstring);
            using (SqlCommand cmd = new SqlCommand("UPDATE Usuarios SET usuario=@usuario, senha=@senha, guid_usuario=@guid_usuario  WHERE cod_usuario=@Cod_usuario", con))
            {
                cmd.Parameters.AddWithValue("@Cod_usuario", cod_usuario);
                cmd.Parameters.AddWithValue("@usuario", nome);
                cmd.Parameters.AddWithValue("@senha", hashedPassword);
                cmd.Parameters.AddWithValue("@guid_usuario", userGuid.ToString());
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public static DataGridView GetUsuarios(DataGridView dataGridView)
        {
            try
            {
                string connString = "Server=DESKTOP-FP3Q8AQ\\SQLEXPRESS2008; Database=ProjectSKA; User Id=SQL_PROJECT_SKA;Password=Dev0test@;";
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    // abrindo conexão com o DB
                    connection.Open();
                    //definindo sqlcommand
                    string cmdQuery = "SELECT * FROM Usuarios";
                    SqlCommand sqlCommand = new SqlCommand(cmdQuery, connection);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand);

                    //  definindo dataSet
                    DataSet dataSet = new DataSet();
                    //  preenchendo o dataset com os resultados da query
                    dataAdapter.Fill(dataSet);
                    // definindo gridview como read-only
                    dataGridView.ReadOnly = true;
                    // preenchendo o gridview com o dataset
                    dataGridView.DataSource = dataSet.Tables[0];
                    connection.Close();

                    return dataGridView;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return dataGridView;
            }
        }
    }
}
