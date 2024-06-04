using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< HEAD
using CarlosRamosExamenCRUD.Data;
using CarlosRamosExamenCRUD.Data.Modelos;
using static System.Net.Mime.MediaTypeNames;
using System.IO; // Agregamos esta línea para usar la clase archivo
=======
>>>>>>> 0820bb166d729fff25819f622d61df8128c8ac24

namespace CarlosRamosExamenCRUD
{
    public partial class Form1 : Form
    {
<<<<<<< HEAD
        //Instancia Clscone de la clase conexionMySQL, maneja la conexion con nuestra base de datos y las operaciones CRUD

        conexionMySQL Clscone = new conexionMySQL();

        Productos usr = new Productos();

        // Declaramos la variable imagenBytes aquí para que este disponible en toda la clase
        private byte[] imagenBytes = null;


        public Form1()
        {
            InitializeComponent();

        }

       



        private void botonGrabar_Click(object sender, EventArgs e)
        {

            try
            {

                //Nos aseguramos que los parámetros que pasamos a Clscone.Insertar sean los adecuados y del tipo correcto 
                string nombre = textBoxNombre.Text;
                string sku = textBoxSKU.Text;
                string proveedor = textBoxProveedor.Text;
                string categoria = textBoxCategoria.Text;
                decimal costo = decimal.Parse(maskedTextBoxCosto.Text);
                decimal precioDeVenta = decimal.Parse(maskedTextBoxPrecioVenta.Text);
                DateTime fechaDeRegistro = dateTimePickerFechaRegistro.Value;
                int disponible = (int)numericUpDownSTOK.Value;



                Clscone.Insertar(new Productos
                {
                    Nombre = nombre,
                    SKU = sku,
                    Proveedor = proveedor,
                    Categoria = categoria,
                    CostoProducto = costo,
                    PrecioVenta = precioDeVenta,
                    FechaRegistro = fechaDeRegistro,
                    Disponible = disponible,
                    Imagen = imagenBytes
                });

                MessageBox.Show("Registro agregado correctamente");


            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops!! Cometiste un error al agregar el registro: " + ex.Message);
            }

        }

        private void botonInsertar_Click(object sender, EventArgs e)
        {
            //Grabacion con modelo Productos

            //Agregarlos de forma correcta

            //Llamamos a la función ValidarCampos para asegurararnos de que todos los campos contienen datos válidos antes de avanzar

            if (ValidarCampos())
            {

                //Utilizamos un Try Catch donde intenta capturar los datos del formulario y llamamos al metodo Insert, en este caso de Clscone
                try
                {
                    usr.Nombre = textBoxNombre.Text;
                    usr.SKU = textBoxSKU.Text;
                    usr.Proveedor = textBoxProveedor.Text;
                    usr.Categoria = textBoxCategoria.Text;
                    usr.CostoProducto = decimal.Parse(maskedTextBoxCosto.Text);
                    usr.PrecioVenta = decimal.Parse(maskedTextBoxPrecioVenta.Text);
                    usr.FechaRegistro = dateTimePickerFechaRegistro.Value;
                    usr.Disponible = (int)numericUpDownSTOK.Value;

                    // Asignamos imagen seleccionada
                    usr.Imagen = imagenBytes;

                    Clscone.Insertar(usr);
                    //Mensaje de que se realizo correctamente el Registro
                    MessageBox.Show("Registro agregado correctamente");
                }
                catch (Exception ex)
                {
                    //Mensaje de que hay un error al agregar un Registro
                    MessageBox.Show("Oops!! Cometiste un error al agregar el registro: " + ex.Message);
                }
            }
        }

        //La funcion Validar Campos nos ayuda a que ej usuario ingrese datos correctamente
        //Mostramos un mensaje si ingresa un dato incorrecto

        private bool ValidarCampos()
        {
            // Nombre
            if (string.IsNullOrWhiteSpace(textBoxNombre.Text))
            {
                MessageBox.Show("Oops!!! Cometiste un error :( \nPuedes completar de forma correcta el campo Nombre, por favor :D");
                return false;
            }

            // SKU
            if (string.IsNullOrWhiteSpace(textBoxSKU.Text))
            {
                MessageBox.Show("Oops!!! Cometiste un error :( \nPuedes completar de forma correcta el campo SKU, por favor :D");
                return false;
            }

            // Proveedor
            if (string.IsNullOrWhiteSpace(textBoxProveedor.Text))
            {
                MessageBox.Show("Oops!!! Cometiste un error :( \nPuedes completar de forma correcta un Proveedor, por favor :D");
                return false;
            }

            // Categoría
            if (string.IsNullOrWhiteSpace(textBoxCategoria.Text))
            {
                MessageBox.Show("Oops!!! Cometiste un error :( \nPuedes completar de forma correcta una Categoría, por favor :D");
                return false;
            }

            //Costo
            if (string.IsNullOrWhiteSpace(maskedTextBoxCosto.Text))
            {
                MessageBox.Show("Oops!!! Cometiste un error :( \nPuedes completar de forma correcta el campo Costo, por favor :D");
                return false;
            }

            // Precio de Venta
            if (string.IsNullOrWhiteSpace(maskedTextBoxPrecioVenta.Text))
            {
                MessageBox.Show("Oops!!! Cometiste un error :( \nPuedes completar de forma correcta el campo Precio de Venta, por favor :D");
                return false;
            }

            //FechaRegistro
            if (dateTimePickerFechaRegistro.Value == DateTime.MinValue)
            {
                MessageBox.Show("Oops!!! Cometiste un error :( \nPor favor, puedes seleccionar una fecha valida :D");
                return false;
            }


            if (numericUpDownSTOK.Value < 0)
            {
                MessageBox.Show("Oops!!! Cometiste un error :( \nLa cantidad disponible no puede ser negativa.");
                return false;
            }

            return true;
        }

        private void comboBoxProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void botonSeleccionarImagen_Click(object sender, EventArgs e)
        {

            try
            {
                // Abrir el OpenFileDialog para que el usuario pueda seleccionar una imagen

                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lee los datos binarios de la imagen seleccionada

                    imagenBytes = File.ReadAllBytes(openFileDialog.FileName);

                    // Mostramos la imagen en pictureBox
                    pictureBoxImagen.Image = System.Drawing.Image.FromFile(openFileDialog.FileName);

                    // Mostramos mensaje de éxito
                    MessageBox.Show("Imagen seleccionada correctamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops!! Cometiste un error al seleccionar la imagen: " + ex.Message);
            }
        }

        private void pictureBoxImagen_Click(object sender, EventArgs e)
        {

        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                string sku = textBoxSKU.Text;

                if (string.IsNullOrWhiteSpace(sku))
                {
                    MessageBox.Show("Por favor, ingresa el SKU del producto a eliminar.");
                    return;
                }

                Clscone.Eliminar(sku);
                MessageBox.Show("Producto eliminado correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oops!! Cometiste un error al eliminar el producto: " + ex.Message);
            }

        }

        private byte[] ConvertirImagenAByteArray(System.Drawing.Image imagen)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                imagen.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg); 
                return ms.ToArray();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

=======
        public Form1()
        {
            InitializeComponent();
>>>>>>> 0820bb166d729fff25819f622d61df8128c8ac24
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
<<<<<<< HEAD

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            // Obtenemos el ID del producto ingresado por el usuario
            if (int.TryParse(textBoxID.Text, out int id))
            {
                // Llamamos al metodo para buscar el producto por ID
                List<Productos> productosEncontrados = Clscone.BuscarProductoPorId(id);

                // Verificamos si encontramos productos
                if (productosEncontrados.Count > 0)
                {
                    // Mostramos los datos del primer producto encontrado
                    var productoEncontrado = productosEncontrados[0];

                    // Asignamos los datos del producto al formulario
                    MostrarDatosDelProducto(productoEncontrado);
                }
                else
                {
                    // Si no se encontraron productos con el ID, mostramos un mensaje
                    MessageBox.Show("Oops!!! \nNo se encontraron productos con el ID :(");
        }
    }
            else
            {
                // Si el usuario no ingresó un ID válido, mostrar un mensaje
                MessageBox.Show("Ingrese un ID válido, por favor :D");
            }
        }

        private void MostrarDatosDelProducto(Productos producto)
        {
            // Mostramos los datos del producto en los controles correspondientes
            textBoxNombre.Text = producto.Nombre;
            textBoxSKU.Text = producto.SKU;
            textBoxProveedor.Text = producto.Proveedor;
            textBoxCategoria.Text = producto.Categoria;
            maskedTextBoxCosto.Text = producto.CostoProducto.ToString();
            maskedTextBoxPrecioVenta.Text = producto.PrecioVenta.ToString();
            dateTimePickerFechaRegistro.Value = producto.FechaRegistro;
            numericUpDownSTOK.Value = producto.Disponible;

            // Verificamos si el producto tiene una imagen
            if (producto.Imagen != null)
            {
                // Mostramos la imagen del producto en el pictureBoxImagen
                MemoryStream ms = new MemoryStream(producto.Imagen);
                pictureBoxImagen.Image = System.Drawing.Image.FromStream(ms);
}
            else
            {
                // Limpiamos el pictureBoxImagen 
                pictureBoxImagen.Image = null;
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void buttonPruebaConexion_Click(object sender, EventArgs e)
        {
            if (Clscone.PruebaConexion())
            {
                MessageBox.Show("Conexión exitosa con la base de datos :D ");
            }
            else
            {
                MessageBox.Show("Ospss!!! No exites conexión con la base de datos:( ");
            }

        }

        private void botonLeer_Click(object sender, EventArgs e)
        {

            try
            {
                List<Productos> productos = Clscone.LeerProductos();
                dataGridViewProductos.DataSource = productos;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer los datos: " + ex.Message);
            }


        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void botonActualizar_Click(object sender, EventArgs e)
        {

            // Verificamos si se ha ingresado un ID válido
            if (!string.IsNullOrWhiteSpace(textBoxID.Text))
            {
                // Obtenemos el ID ingresado por el usuario
                int id = int.Parse(textBoxID.Text);

                // Buscamos el producto por su ID
                List<Productos> productosEncontrados = Clscone.BuscarProductoPorId(id);

                // Verificamos si se encontró algún producto con el ID especificado
                if (productosEncontrados.Count > 0)
                {
                    // Mostramos el primer producto encontrado 
                    Productos producto = productosEncontrados[0];

                    // Actualizamos los datos del producto con los valores de los controles del formulario
                    producto.Nombre = textBoxNombre.Text;
                    producto.SKU = textBoxSKU.Text;
                    producto.Proveedor = textBoxProveedor.Text;
                    producto.Categoria = textBoxCategoria.Text;
                    producto.CostoProducto = decimal.Parse(maskedTextBoxCosto.Text);
                    producto.PrecioVenta = decimal.Parse(maskedTextBoxPrecioVenta.Text);
                    producto.FechaRegistro = dateTimePickerFechaRegistro.Value;
                    producto.Disponible = (int)numericUpDownSTOK.Value;

                    // Si se seleccionamos una imagen, lo cual actualizarla
                    if (imagenBytes != null)
                    {
                        producto.Imagen = imagenBytes;
                    }

                    // Llamamos al metodo en la clase conexionMySQL para actualizar el producto
                    Clscone.ActualizarProducto(producto);

                    MessageBox.Show("Datos actualizados correctamente.");
                }
                else
                {
                    MessageBox.Show("No se encontró ningún producto con el ID :(");
                }
            }
            else
            {
                MessageBox.Show("Ingresar un ID valido, por favor");
            }


        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }





        private void botonBucarPorFechas_Click(object sender, EventArgs e)
        {
            // Obtenemos las fechas seleccionadas por el usuario en el MonthCalendar
            DateTime fechaInicio = monthCalendarFechasSeleccionas.SelectionStart;
            DateTime fechaFin = monthCalendarFechasSeleccionas.SelectionEnd;

            // Llamaamos al método de la clase conexionMySQL para obtener los productos dentro del rango de fechas
            List<Productos> productos = Clscone.LeerProductos(fechaInicio, fechaFin);

            // Mostraamos los productos en el DataGridView
            dataGridViewProductos.DataSource = productos;

        }

        // MEetodo para realizar la consulta por rango de fechas
        private void RealizarConsultaPorRangoDeFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            try
            {
                List<Productos> productos = Clscone.ObtenerProductosPorRangoDeFechas(fechaInicio, fechaFin);
                // Aquí puedemos mostrar los productos en un DataGridView 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la consulta por rango de fechas: " + ex.Message);
            }
        }

        // Evento del botón para realizar la consulta por rango de fechas
        private void botonConsultarPorFechas_Click(object sender, EventArgs e)
        {
            // Obtenemos las fechas seleccionadas por el usuario en el MonthCalendar
            DateTime fechaInicio = monthCalendarFechasSeleccionas.SelectionStart;
            DateTime fechaFin = monthCalendarFechasSeleccionas.SelectionEnd;

            // Llamamos al método para realizar la consulta por rango de fechas
            RealizarConsultaPorRangoDeFechas(fechaInicio, fechaFin);
        }
    }


}



    
    




=======
    }
}
>>>>>>> 0820bb166d729fff25819f622d61df8128c8ac24
