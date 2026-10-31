using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using MySqlConnector;

namespace AviVet
{
    internal static class BaseDatos
    {
        // Obtener la conexión desde App.config
        private static string CadenaConexion =>
            ConfigurationManager.ConnectionStrings["VeterinariaDB"]?.ConnectionString
            ?? throw new Exception("No se encontró la conexión a MySQL.");

        // Consultar registros (SELECT)
        public static DataTable Consultar(string sql)
        {
            using var conexion = new MySqlConnection(CadenaConexion);
            using var comando = new MySqlCommand(sql, conexion);

            conexion.Open();

            using var lector = comando.ExecuteReader();

            DataTable tabla = new DataTable();
            tabla.Load(lector);

            return tabla;
        }

        // Insertar, modificar y eliminar registros
        public static int Ejecutar(
            string sql,
            params (string Nombre, object? Valor)[] parametros)
        {
            using var conexion = new MySqlConnection(CadenaConexion);
            using var comando = new MySqlCommand(sql, conexion);

            foreach (var parametro in parametros)
            {
                comando.Parameters.AddWithValue(
                    parametro.Nombre,
                    parametro.Valor ?? DBNull.Value);
            }

            conexion.Open();

            return comando.ExecuteNonQuery();
        }
    }
}
