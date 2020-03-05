using Prueba.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Prueba.DataManager
{
    public class DataCliente
    {

        private DataConnection connString;

        public DataCliente()
        {
            this.connString = new DataConnection();
        }


        public ClienteModels ObtieneClientePorIdEmpresa1(string Id)
        {
            //Mensaje mensaje = new Mensaje();
            string connexion = this.connString.ObtenerConexionEmpresa1();
            List<ClienteModels> listaDetalle = new List<ClienteModels>();
            ClienteModels objCliente = new ClienteModels();
            SqlConnection sqlConnection = new SqlConnection(connexion);

            try
            {
                using (SqlCommand sqlCommand = new SqlCommand("ObtieneclientexIDqempresa1", sqlConnection))
                {
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@Identidad", Id);
                    sqlConnection.Open();
                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    objCliente = armaListaClientes(reader, "Empresa1", 1);
                }
            }
            catch (Exception ex)
            {
                //objDetalle = new Detalle();
                //objDetalle.MensajeId = -1;
                //objDetalle.textoMensaje = "Se presentó una falla al obtener el detalle de la factura; comuníquese con el área de soporte";
                //listaDetalle.Add(objDetalle);
            }
            finally
            {
                sqlConnection.Close();
            }

            return objCliente;
        }

        public ClienteModels ObtieneClientePorIdEmpresa2(string Id)
        {
            //Mensaje mensaje = new Mensaje();
            string connexion = this.connString.ObtenerConexionEmpresa2();
            List<ClienteModels> listaDetalle = new List<ClienteModels>();
            ClienteModels objCliente = new ClienteModels();
            SqlConnection sqlConnection = new SqlConnection(connexion);

            try
            {
                using (SqlCommand sqlCommand = new SqlCommand("ObtieneclientexIDqempresa2", sqlConnection))
                {
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@Identidad", Id);
                    sqlConnection.Open();
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    objCliente = armaListaClientes(reader, "Empresa2", 2);

                }
            }
            catch (Exception ex)
            {
                //objDetalle = new Detalle();
                //objDetalle.MensajeId = -1;
                //objDetalle.textoMensaje = "Se presentó una falla al obtener el detalle de la factura; comuníquese con el área de soporte";
                //listaDetalle.Add(objDetalle);
            }
            finally
            {
                sqlConnection.Close();
            }

            return objCliente;
        }

        private ClienteModels armaListaClientes(SqlDataReader reader, string Empresa, int indicadorDB)
        {
            //List<ClienteModels> listaDetalle = new List<ClienteModels>();
            ClienteModels objCliente = new ClienteModels();
            while (reader.Read())
            {
                objCliente = new ClienteModels();
                objCliente.Identidad = reader["Identidad"].ToString();
                objCliente.Nombres = reader["Nombres"].ToString();
                objCliente.Apellidos = reader["Apellidos"].ToString();
                objCliente.Ultima_Compra = reader["Ultima_Compra"].ToString();
                objCliente.Compras_Realizadas = reader["Compras_Realizadas"].ToString();
                objCliente.Correo = reader["Correo"].ToString();
                objCliente.Empresa = Empresa;
                objCliente.indiceDB = indicadorDB;
            }

            return objCliente;
        }
        public ClienteModels UpdateFechacompraycantidad(string Id, DateTime fecha, int cantidad)
        {
            //Mensaje mensaje = new Mensaje();
            string connexion = this.connString.ObtenerConexionEmpresa1();
            List<ClienteModels> listaDetalle = new List<ClienteModels>();
            ClienteModels objCliente = new ClienteModels();
            SqlConnection sqlConnection = new SqlConnection(connexion);

            try
            {
                using (SqlCommand sqlCommand = new SqlCommand("Actualizar_FechaCompra_Cantidadcompra", sqlConnection))
                {
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@Identidad", Id);
                    sqlCommand.Parameters.AddWithValue("@Fechantcompra", fecha);
                    sqlCommand.Parameters.AddWithValue("@cantidad", cantidad);
                    sqlConnection.Open();
                    SqlDataReader reader = sqlCommand.ExecuteReader();

                }
            }
            catch (Exception ex)
            {
                //objDetalle = new Detalle();
                //objDetalle.MensajeId = -1;
                //objDetalle.textoMensaje = "Se presentó una falla al obtener el detalle de la factura; comuníquese con el área de soporte";
                //listaDetalle.Add(objDetalle);
            }
            finally
            {
                sqlConnection.Close();
            }

            return objCliente;
        }

        public ClienteModels UpdateFechacompraycantidad2(string Id, DateTime fecha, int cantidad)
        {
            //Mensaje mensaje = new Mensaje();
            string connexion = this.connString.ObtenerConexionEmpresa2();
            List<ClienteModels> listaDetalle = new List<ClienteModels>();
            ClienteModels objCliente = new ClienteModels();
            SqlConnection sqlConnection = new SqlConnection(connexion);

            try
            {
                using (SqlCommand sqlCommand = new SqlCommand("Actualizar_FechaCompra_Cantidadcompra", sqlConnection))
                {
                    sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
                    sqlCommand.Parameters.AddWithValue("@Identidad", Id);
                    sqlCommand.Parameters.AddWithValue("@Fechantcompra", fecha);
                    sqlCommand.Parameters.AddWithValue("@cantidad", cantidad);
                    sqlConnection.Open();
                    SqlDataReader reader = sqlCommand.ExecuteReader();

                }
            }
            catch (Exception ex)
            {
                //objDetalle = new Detalle();
                //objDetalle.MensajeId = -1;
                //objDetalle.textoMensaje = "Se presentó una falla al obtener el detalle de la factura; comuníquese con el área de soporte";
                //listaDetalle.Add(objDetalle);
            }
            finally
            {
                sqlConnection.Close();
            }

            return objCliente;

        }
    }
}
