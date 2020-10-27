using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using PatronDiseñoMVC_WindowsForms.Models;
using PatronDiseñoMVC_WindowsForms.Models.Dto;

namespace PatronDiseñoMVC_WindowsForms.Models.Dao
{
    class ClienteDao : DbContext
    {
        // 3 Esta clase sólo contiene métodos crud
        SqlDataReader LeerFilas; // Lee filas de tablas
        SqlCommand Comando = new SqlCommand(); // Para ejecutar sp o t-sql

        // METODOS CRUD
        public List<Cliente> VerRegistros(string Condicion) // Reemplazar List<ClientesDTO> por Cliente de la carpeta DTO
        {
            Comando.Connection = Conexion;
            Comando.CommandText = "VerRegistros"; // Igual al SP de la DB
            Comando.CommandType = CommandType.StoredProcedure;
            Comando.Parameters.AddWithValue("@Condicion", Condicion); // Parametro con el mismo valor de variable en sp. Se envia como parametro el metodo condicion 

            Conexion.Open();

            LeerFilas = Comando.ExecuteReader(); // Para ller filas de tablas
            List<Cliente> ListaGenerica = new List<Cliente>();
            /*
             * Para obtener datos se puede:
             * -List
             * -Diccionario
             * -Serialización
             */

            // While: Mientras se leen filas, ir agregando registros a ListaGenerica
            while (LeerFilas.Read())
            {
                ListaGenerica.Add(new Cliente
                {
                    // Se asignan valores a los atributos de ClientesDTO
                    ID = LeerFilas.GetInt32(0), // Se envía como parametro el número de columna de la db que tiene el id (empezando desde 0)
                    Nombre = LeerFilas.GetString(1),
                    Apellido = LeerFilas.GetString(2),
                    Direccion = LeerFilas.GetString(3),
                    Ciudad = LeerFilas.GetString(4),
                    Email = LeerFilas.GetString(5),
                    Telefono = LeerFilas.GetString(6),
                    Ocupacion = LeerFilas.GetString(7),
                });
            }
            LeerFilas.Close();
            Conexion.Close();
            return ListaGenerica;
        }

        public void Insert()
        {

        }

        public void Edit()
        {

        }

        public void Delete()
        {

        }

    }
}
