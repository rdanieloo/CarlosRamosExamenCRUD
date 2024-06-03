using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace CarlosRamosExamenCRUD.Data
{
    internal class conexionMySQL
    {

        string connectionString = "server=localhost;database=carlosramos_examenfinalprogra;user=root;password=Ram0s.24CC19";
        private MySqlConnection connection;


        //constructor
        public conexionMySQL()
        {
            connection = new MySqlConnection(connectionString);
        }

        public void Insertar(string Nombre, string SKU, string Proveedor, string Categoria, decimal Costo, decimal Precio_de_venta, DateTime Fecha_de_registro, int Disponible)
        {
            try
            {
                string query = "INSERT INTO productos (Nombre, SKU, Proveedor, Categoria, Costo, Precio_de_venta, Fecha_de_registro, Disponible) VALUES (@Nombre, @SKU, @Proveedor, @Categoria, @Costo, @Precio_de_venta, @Fecha_de_registro, @Disponible)";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Nombre", Nombre);
                cmd.Parameters.AddWithValue("@SKU", SKU);
                cmd.Parameters.AddWithValue("@Proveedor", Proveedor);
                cmd.Parameters.AddWithValue("@Categoria", Categoria);
                cmd.Parameters.AddWithValue("@Costo", Costo);
                cmd.Parameters.AddWithValue("@Precio_de_venta", Precio_de_venta);
                cmd.Parameters.AddWithValue("@Fecha_de_registro", Fecha_de_registro);
                cmd.Parameters.AddWithValue("@Disponible", Disponible);
                connection.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el registro: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}


    
