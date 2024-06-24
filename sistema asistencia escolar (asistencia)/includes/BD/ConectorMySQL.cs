using sistema_asistencia_escolar__asistencia_.Properties;
using MySql.Data.MySqlClient;
using System;


namespace sistema_asistencia_escolar__asistencia_.includes.BD
{
    internal class ConectorMySQL
    {
        #region Atributos
        private static string Host { get; set; } = Settings.Default.host;
        private static string Name_db { get; set; } = Settings.Default.name_db;
        private static string Port { get; set; } = Settings.Default.port;
        private static string User { get; set; } = Settings.Default.user;
        private static string Password { get; set; } = Settings.Default.password;

        private static readonly string Cad_conexion = "Server=" + Host + ";Username= " + User + ";Database= " + Name_db + " ;Port= " + Port + ";Password= " + Password;
        #endregion

        #region Metodos
        
        /// <summary>
        /// Incializa la conexion con la base de datos
        /// </summary>
        /// <returns>Un objeto con la conexion de base de datos tipo NpgsqlConnection</returns>
        /// <exception cref="Exception">Succede cuando hay una excepcion en el manejador de base de datos</exception>
        public static MySqlConnection InitConexion()
        {
            MySqlConnection conn = new MySqlConnection()
            {
                ConnectionString = Cad_conexion
            };

            try
            {
                if (conn.State == System.Data.ConnectionState.Open)
                    return conn;
                else
                    conn.Open();
            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.Message);
            }
            return conn;
        }

        /// <summary>
        /// Cierra y libera recursos generados en la conexion con la base de datos
        /// </summary>
        /// <param name="conn">Objeto de la clase MySqlConnection con la conexion abierta</param>
        /// <exception cref="Exception">Succede cuando hay una excepcion en el manejador de base de datos</exception>
        public static void TermConexion(MySqlConnection conn)
        {
            try
            {
                if (conn != null)
                {
                    conn.Dispose();
                    MySqlConnection.ClearPool(conn);
                    conn.Close();
                }
            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion
    }
}
