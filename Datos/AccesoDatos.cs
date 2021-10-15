using Entidad;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public class AccesoDatos
    {
        public static DataTable EjecutarComando(SqlCommand _comando)
        {
            HuellaDactilar huella = new HuellaDactilar();

            DataTable _tabla = new DataTable();
            try
            {
                _comando.Connection.Open();
                SqlDataAdapter _adaptador = new SqlDataAdapter();
                _adaptador.SelectCommand = _comando;
                _adaptador.Fill(_tabla);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _comando.Connection.Close();
            }
            return _tabla;
        }

        public static SqlCommand BuscaListado(string Coneccion)
        {
            string _cadenaconexion = Coneccion;
            SqlConnection _conexion = new SqlConnection(_cadenaconexion);
            SqlCommand _comando = new SqlCommand("SP_BUSCA_HUELLAS_VOTECHAIN", _conexion);            
            _comando.Connection.Close();
            return _comando;
        }

        public static SqlCommand BuscaHuellas(string Coneccion)
        {
            string _cadenaconexion = Coneccion;
            SqlConnection _conexion = new SqlConnection(_cadenaconexion);
            SqlCommand _comando = new SqlCommand("SP_VALIDACION_HUELLAS_VOTECHAIN", _conexion);
            _comando.Connection.Close();
            return _comando;
        }

        public static SqlCommand InsertaHuella(HuellaDactilar huella, string Coneccion)
        {
            string _cadenaconexion = Coneccion;
            SqlConnection _conexion = new SqlConnection(_cadenaconexion);
            SqlCommand _comando = new SqlCommand("SP_INSERTA_HUELLA_VOTECHAIN", _conexion);
            _comando.Parameters.AddWithValue("@Nombre", huella.nombre);
            _comando.Parameters.AddWithValue("@huella", huella.huella);            
            _comando.Connection.Close();
            return _comando;
        }
    }
}
