using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace Spa
{
    public partial class frmdou : Form
    {
        public frmdou()
        {
            InitializeComponent();
        }
       
        public static Bitmap cambiarSizeImagen (Image image, int width, int height)
        {
            try {
                var destRect = new Rectangle(0, 0, width, height);
                var destImage = new Bitmap(width, height);

                destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

                using (var graphics = Graphics.FromImage(destImage))
                {
                    graphics.CompositingMode = CompositingMode.SourceCopy;
                    graphics.CompositingQuality = CompositingQuality.HighQuality;
                    graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                    graphics.SmoothingMode = SmoothingMode.HighQuality;
                    graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                    using (var wrapMode = new ImageAttributes())
                    {
                        wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                        graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                    }
                }
                return destImage;
            }
            catch (Exception e) { MessageBox.Show(e.Message);
                return null;
            }
            

            
        }

        private bool validaciones()
        {
            if(txtCedula.Text == string.Empty)
            {
                MessageBox.Show("No se a ingresado ninguna cedula");
                return false;
            }
            else if (txtCedula.Text.Length < 8 || txtCedula.Text.Length > 8)
            {
                MessageBox.Show("La cedula ingresada no es valida");
                return false;
            }
            else if (txtNombre.Text == string.Empty)
            {
                MessageBox.Show("No se a ingresado ningun Nombre");
                return false;
            }
            else if (txtNombre.Text == string.Empty)
            {
                MessageBox.Show("No se a ingresado ningun Nombre");
                return false;
            }
            else if (txtApellido.Text == string.Empty)
            {
                MessageBox.Show("No se a ingresado ningun Apellido");
                return false;
            }
            else if (cbCargos.Text == string.Empty)
            {
                MessageBox.Show("No se a seleccionado ningun Cargo");
                return false;
            }
            else if (txtTelefono.Text == string.Empty)
            {
                MessageBox.Show("No se a ingresado ningun telefono");
                return false;
            }
            else if (txtDireccion.Text == string.Empty)
            {
                MessageBox.Show("No se a ingresado ninguna direccion");
                return false;
            }
            else if (txtCorreo.Text == string.Empty)
            {
                MessageBox.Show("No se a ingresado ningun correo");
                return false;
            }
            else if (!logica.validarEmail(txtCorreo.Text))
            {
                MessageBox.Show("El correo introducido no es valido");
                return false;
            }
            else if (txtSueldo.Text == string.Empty)
            {
                MessageBox.Show("No se a ingresado ningun sueldo");
                return false;
            }
            else
            {
                return true;
            }

        }
        private void bfbtnBuscar_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscar = new OpenFileDialog();
            buscar.Filter = "Image Files(*.jpg;*.jpeg;*.gif;) | *.jpg;*.jpeg;*.gif;";
            if (buscar.ShowDialog() == DialogResult.OK)
            {
                bpbFoto.Image = new Bitmap(buscar.FileName);
                //bpbFoto.Image = cambiarSizeImagen(bpbFoto.Image, 128, 128);
                bpbFoto.BackgroundImage = Image.FromFile(buscar.FileName);
                bpbFoto.ImageLocation = buscar.FileName;
                bpbFoto.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void MenuTop_MouseDown(object sender, MouseEventArgs e)
        {
            logica.move(Handle, e);
        }

        private void frmdou_Load(object sender, EventArgs e)
        {
            Usuarios.cargarCargos(cbCargos); 
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FileStream fs;
            BinaryReader br;
            byte[] ImageData;
            
            fs = new FileStream(bpbFoto.ImageLocation, FileMode.Open, FileAccess.Read);
            br = new BinaryReader(fs);
            ImageData = br.ReadBytes((int)fs.Length);
            br.Close();
            fs.Close();
            if (validaciones()) {

                int ci = Int32.Parse(txtCedula.Text);
                int telefono = Int32.Parse(txtTelefono.Text);
                float sueldo = float.Parse(txtSueldo.Text);
                string pass = logica.passGenerator(7);
                
                Usuarios.altaEmpleado(ci, txtNombre.Text, txtApellido.Text, txtCorreo.Text, telefono, txtDireccion.Text, cbCargos.Text, sueldo, pass, ImageData);
                MessageBox.Show("Contraseña generada: " + pass);
                this.DialogResult = DialogResult.OK;
            }
            
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSueldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
