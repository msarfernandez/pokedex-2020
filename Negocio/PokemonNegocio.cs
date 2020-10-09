using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using System.Data.SqlClient;


namespace Negocio
{
    public class PokemonNegocio
    {
        public List<Pokemon> listar()
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            List<Pokemon> lista = new List<Pokemon>();

            conexion.ConnectionString = "data source=MAXIMILIANO8285\\SQLEXPRESS; initial catalog=POKEMON_DB; integrated security=sspi";
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "select P.id idPoke, P.nombre, P.descripcion, P.Imagen, T.Descripcion tipo, T.id idTipo from POKEMONS P, TIPOS T Where P.IdTipo=T.Id";
            comando.Connection = conexion;

            try
            {
                //throw new Exception("Error forzado");
                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Pokemon aux = new Pokemon();
                    aux.Id = (int)lector["idPoke"];
                    aux.Nombre = lector.GetString(1);
                    aux.Descripcion = lector.GetString(2);
                    aux.UrlImage = (string)lector["Imagen"];

                    aux.Tipo = new Tipo();
                    aux.Tipo.Descripcion = (string)lector["tipo"];
                    aux.Tipo.Id = (int)lector["idTipo"];

                    lista.Add(aux);

                }

                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public void modificar(Pokemon pokemon)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {   //
                conexion.setearQuery("Update POKEMONS Set Nombre=@nombre, Descripcion=@descripcion, IdTipo=@idTipo Where Id=@id");
                //
                conexion.agregarParametro("@nombre", pokemon.Nombre);
                conexion.agregarParametro("@descripcion", pokemon.Descripcion);
                conexion.agregarParametro("@idTipo", pokemon.Tipo.Id);
                conexion.agregarParametro("@id", pokemon.Id);
                conexion.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void eliminar(int id)
        {
            AccesoDatos conexion = new AccesoDatos();
            try
            {
                conexion.setearQuery("Delete from POKEMONS Where Id=@id");
                conexion.agregarParametro("@id", id);
                conexion.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void agregar(Pokemon nuevo)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();

            conexion.ConnectionString = "data source=MAXIMILIANO8285\\SQLEXPRESS; initial catalog=POKEMON_DB; integrated security=sspi";
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "insert into POKEMONS (Nombre, Descripcion, Imagen, IdTipo) values ('" + nuevo.Nombre + "', '" + nuevo.Descripcion + "',  @urlImg, @idTipo)";
            comando.Parameters.AddWithValue("@idTipo", nuevo.Tipo.Id);
            comando.Parameters.AddWithValue("@urlImg", nuevo.UrlImage);
            comando.Connection = conexion;

            conexion.Open();
            comando.ExecuteNonQuery();
        }
    }
}
