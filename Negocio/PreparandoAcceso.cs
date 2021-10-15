using Datos;
using Entidad;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Negocio
{
    public class PreparandoAcceso
    {

        public static DataTable InsertaHuella(HuellaDactilar huella, string Coneccion)
        {
            SqlCommand _comando = AccesoDatos.InsertaHuella(huella, Coneccion);
            _comando.CommandType = CommandType.StoredProcedure;
            return AccesoDatos.EjecutarComando(_comando);
        }

        public static DataTable BuscaListado(string Coneccion)
        {
            SqlCommand _comando = AccesoDatos.BuscaListado(Coneccion);
            _comando.CommandType = CommandType.StoredProcedure;
            return AccesoDatos.EjecutarComando(_comando);
        }

        public static DataTable BuscaHuellas(string Coneccion)
        {
            SqlCommand _comando = AccesoDatos.BuscaHuellas(Coneccion);
            _comando.CommandType = CommandType.StoredProcedure;
            return AccesoDatos.EjecutarComando(_comando);
        }
    }
}
