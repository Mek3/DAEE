using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace taller7
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Taller7Entities db; 

        public MainWindow()
        {
            InitializeComponent();
            db = new Taller7Entities();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource productoViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("productoViewSource")));
            // Cargar datos estableciendo la propiedad CollectionViewSource.Source:
            // productoViewSource.Source = [origen de datos genérico]
            db.Productos.Load();
            productoViewSource.Source = db.Productos.Local;

        }

        public void btnDetail_Click(object sender, EventArgs e)
        {
            Producto p = (Producto)gridListado.SelectedItem;
            lblTituloDetalle.Content = "Detalle del producto: '" +
            p.Nombre + "'";
            gridListado.Visibility = Visibility.Hidden;
            gridCajaDetalle.Margin = new Thickness(5, 55, 5, 4);
            gridCajaDetalle.Visibility = Visibility.Visible;
        }

        private void btnVolverDetalle_Click(object sender, RoutedEventArgs e)
        {
            gridCajaDetalle.Margin = new Thickness(825, 55, -650, 5);
            gridCajaDetalle.Visibility = Visibility.Hidden;
            gridListado.Visibility = Visibility.Visible;
        }

        private void btnNuevo_Click(object sender, RoutedEventArgs e)
        {
            limpiarFormNuevo();
            gridListado.Visibility = Visibility.Hidden;
            btnNuevo.Visibility = Visibility.Hidden;
            gridCajaNuevo.Margin = new Thickness(5, 55, 5, 4);
            gridCajaNuevo.Visibility = Visibility.Visible;
            rellenarComboCategorias(slctCategorias);
        }

        private void btnVolverNuevo_Click(object sender, RoutedEventArgs e)
        {
            mostrarListado();
        }

        private void mostrarListado() 
        {
            gridCajaNuevo.Margin = new Thickness(5, -393, 3.6, 453);
            gridCajaNuevo.Visibility = Visibility.Hidden;
            gridListado.Visibility = Visibility.Visible;
            btnNuevo.Visibility = Visibility.Visible;
        }

        private void btnAddNuevo_Click(object sender, RoutedEventArgs e) 
        {
            Producto nuevo = new Producto();

            try
            {
                //bool datosCorrectos = false;

                /*do
                {
                    /*int i = 0;
                    string id = idTextBox1.Text;
                    string precio = 
                    if (int.TryParse(id, out i) && ()*/
                        nuevo.Id = Convert.ToInt32(idTextBox1.Text);
                   /* else
                    {
                        //
                    }*/

                    nuevo.Nombre = nombreTextBox1.Text;
                    nuevo.Descripción = descripciónTextBox1.Text;
                    nuevo.Categoría = Convert.ToInt32(slctCategorias.SelectedValue.ToString());
                    nuevo.Precio = Convert.ToDouble(precioTextBox1.Text);
              //  } while (!datosCorrectos);

                db.Productos.Add(nuevo);
                db.SaveChanges();

                mostrarListado();

                MessageBox.Show("Producto '" + nuevo.Nombre + "' añadido correctamente.",
                    "Atención!", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error al añadir un nuevo producto. Causa: " + ex.Message,
                            "Atención!", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void rellenarComboCategorias(ComboBox slct)
        {
            List<Categoria> cats = db.Categorias
            .OrderBy(c => c.Nombre).ToList();
            slct.ItemsSource = cats;
            slct.DisplayMemberPath = "Nombre";
            slct.SelectedValuePath = "Id";
        }

        private void limpiarFormNuevo()
        {
            idTextBox1.Text = "";
            nombreTextBox1.Text = "";
            descripciónTextBox1.Text = "";
            slctCategorias.SelectedIndex = 0;
            precioTextBox1.Text = "";
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e) 
        {
            Producto p = (Producto)gridListado.SelectedItem;
            MessageBoxResult res =
                MessageBox.Show("¿Está seguro que desea borrar el producto '"
                                + p.Nombre + "'?", "Atención!",
                                MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (res == MessageBoxResult.Yes) 
            {
                try
                {
                    db.Productos.Remove(p);
                    db.SaveChanges();

                    MessageBox.Show("Producto '" + p.Nombre + "' eliminado correctamente.",
                                     "Atención!", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar un producto. Causa: " + ex.Message,
                                     "Atención!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void btnVolverEdit_Click(object sender, RoutedEventArgs e)
        {
            volverDesdeEdit();
        }
        private void volverDesdeEdit()
        {
            gridCajaEditar.Margin = new Thickness(5, 432, 3.6, -372);
            gridCajaEditar.Visibility = Visibility.Hidden;
            gridListado.Visibility = Visibility.Visible;
            btnNuevo.Visibility = Visibility.Visible;
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            gridListado.Visibility = Visibility.Hidden;
            btnNuevo.Visibility = Visibility.Hidden;
            gridCajaEditar.Margin = new Thickness(5, 55, 5, 4);
            gridCajaEditar.Visibility = Visibility.Visible;
            rellenarComboCategorias(slctCategoriasEdit);
        }

        private void btnEditProd_Click(object sender, RoutedEventArgs e)
        {
            //TODO: verificar que los datos del formulario son correctos
            Producto p = (Producto)gridListado.SelectedItem;
            try
            {
                db.SaveChanges();
                volverDesdeEdit();
                MessageBox.Show("Producto '" + p.Nombre + "' modificado correctamente.",
                        "Atención!", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar un producto. Causa:" +
                ex.Message, "Atención!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
