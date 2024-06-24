using sistema_asistencia_escolar__asistencia_.includes.BD;
using MySql.Data.MySqlClient;
using System.Data;
using System;

namespace sistema_asistencia_escolar__asistencia_.includes.entidades
{
    internal class InfanteTutor
    {
        public static DataTable GetInfanteTutor(int ID_TUTOR, int ID_INFANTE)
        {
            string cmdText = "SELECT * FROM V_PERMISO_INFANTE_TUTOR WHERE ID_INFANTE = @ID_INFANTE AND ID_TUTOR = @ID_TUTOR";
            MySqlConnection conn;
            DataSet dataSet = new DataSet();

            try
            {
                //establecemos si se hay una conexion exitosa con la base de datos
                using (conn = ConectorMySQL.InitConexion())
                {

                    if (conn == null || conn.State != ConnectionState.Open)
                        throw new Exception("No se pudo establecer la conexion con la base de datos, revise el estado de conexion de su internet o del servidor");

                    //realizamos la consulta en la base de datos con el parametro de tipo entero
                    using (MySqlCommand cmdDB = new MySqlCommand(cmdText, conn))
                    {
                        cmdDB.Parameters.AddWithValue("@ID_INFANTE", ID_INFANTE);
                        cmdDB.Parameters.AddWithValue("@ID_TUTOR", ID_TUTOR);

                        MySqlDataAdapter da = new MySqlDataAdapter(cmdDB);

                        //si no hay ningun grupo se retorna un valor nulo
                        if (da.Fill(dataSet) == 0)
                            return null;
                    }
                }

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            ConectorMySQL.TermConexion(conn);
            return dataSet.Tables[0];
        }
    }
}
