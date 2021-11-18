using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spa
{
    public partial class frmConfiguraciones : Form
    {

        Bunifu.UI.WinForms.BunifuPictureBox photo = new Bunifu.UI.WinForms.BunifuPictureBox();
        bool bandera = false;
        public frmConfiguraciones(Bunifu.UI.WinForms.BunifuPictureBox foto,string tipoUsuario)
        {
            photo = foto;   
            InitializeComponent();
            if(tipoUsuario =="Admin")
            {
                btnCargarFoto.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                btnCargarFoto.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                btnCargarFoto.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
                btnCargarFoto.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                btnCargarFoto.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                btnCargarFoto.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
                btnCargarFoto.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                btnCargarFoto.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                txtCorreo.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                txtCorreo.OnActiveState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                txtCorreo.OnHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
                txtDireccion.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                txtDireccion.OnActiveState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                txtDireccion.OnHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
                txtTelefono.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                txtTelefono.OnActiveState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                txtTelefono.OnHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
                txtContraseñaNueva.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                txtContraseñaNueva.OnActiveState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                txtContraseñaNueva.OnHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
                txtNuevaContraseña2.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                txtNuevaContraseña2.OnActiveState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                txtNuevaContraseña2.OnHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
                SwitchVerificiacion2Pasos.ToggleStateOn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                SwitchVerificiacion2Pasos.ToggleStateOn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                SwitchModo.ToggleStateOn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                SwitchModo.ToggleStateOn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                bfbtnCancelar.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                bfbtnCancelar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
                bfbtnCancelar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                bfbtnCancelar.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                btnModificar.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                btnModificar.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                btnModificar.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
                btnModificar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                btnModificar.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                btnModificar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(255)))));
                btnModificar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
                btnModificar.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));

            }
            
            Logica.Usuarios.cargarDetallesUsuario(SwitchVerificiacion2Pasos, SwitchModo, Logica.logica.UsuarioActual,txtCorreo,txtDireccion,txtTelefono);
            bandera = true;
            pnlDatos.Visible = false;
            pnlEditar.Width = 0;
            Logica.Usuarios.cargarPerfil(Logica.logica.UsuarioActual, lblNombre, lblApellido, lblCedula,lblCargo,lblCorreo,lblDireccion,lblTelefono);
           Foto.Image = Logica.Usuarios.cargarFotoUsuario(Logica.logica.UsuarioActual);
        }
        private static async void cargar(Bunifu.UI.WinForms.BunifuToggleSwitch SwitchVerificiacion2Pasos)
        {
            frmCargar asd = new frmCargar();
            asd.Show();
            await Logica.logica.Email(Logica.Usuarios.getEmail(Logica.logica.UsuarioActual));
            asd.Close();
            frmToken hola = new frmToken(Logica.logica.UsuarioActual);
            if (hola.ShowDialog() == DialogResult.OK)
            {
                Logica.Usuarios.activarToken(true, Logica.logica.UsuarioActual);
            }
            else
            {
                SwitchVerificiacion2Pasos.Checked = false;
            }
        }
        private void SwitchVerificiacion2Pasos_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
            if(bandera) { 
            if (SwitchVerificiacion2Pasos.Checked)  {
                cargar(SwitchVerificiacion2Pasos);
            }
            else
            {
                Logica.Usuarios.activarToken(false, Logica.logica.UsuarioActual);
            }
            }


        }
        private bool validar()
        {
            if (!Logica.logica.validarCampoVacio(txtCorreo.Text))
            {
                frmNegativo negativo = new frmNegativo("El campo correo no puede estar vacio");
                negativo.ShowDialog();
                return false;
            }
            else if (!Logica.logica.validarCampoVacio(txtDireccion.Text))
            {
                frmNegativo negativo = new frmNegativo("El campo dirección no puede estar vacio");
                negativo.ShowDialog();
                return false;
            }
            else if (!Logica.logica.validarCampoVacio(txtTelefono.Text))
            {
                frmNegativo negativo = new frmNegativo("El campo telefono no puede estar vacio");
                negativo.ShowDialog();
                return false;
            }
            else
            {
                return true;
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            pnlDatos.Visible = false;
            pnlMayor.Enabled = false;
            pnlEditar.Width = 395;
            xd.Show(pnlDatos);
        }

        private void bfbtnCancelar_Click(object sender, EventArgs e)
        {
            pnlDatos.Visible = false;
            pnlMayor.Enabled = true;
            pnlEditar.Width = 0;
        }

        private void SwitchModo_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuToggleSwitch.CheckedChangedEventArgs e)
        {
            if (bandera)
            {
                if (SwitchModo.Checked)
                {
                    Logica.Usuarios.CambiarColorPantalla(true, Logica.logica.UsuarioActual);
                    BackColor = Logica.logica.fondo;
                }
                else
                {
                    Logica.Usuarios.CambiarColorPantalla(false, Logica.logica.UsuarioActual);
                    BackColor = Color.White;
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (validar()) {
                if(txtContraseñaNueva.Text != string.Empty) {
                    if (txtContraseñaNueva.Text == txtNuevaContraseña2.Text)
                    {

                        VerificadorPass xd = new VerificadorPass();
                        if (xd.ShowDialog() == DialogResult.OK)
                        {

                            Logica.Usuarios.editarInfoContacto(txtCorreo.Text, txtDireccion.Text, txtTelefono.Text, Logica.logica.UsuarioActual);
                            Logica.Usuarios.cargarPerfil(Logica.logica.UsuarioActual, lblNombre, lblApellido, lblCedula, lblCargo, lblCorreo, lblDireccion, lblTelefono);
                            Logica.Usuarios.EditarContraseña(txtContraseñaNueva.Text,Logica.logica.UsuarioActual);
                            frmPositivo positivo = new frmPositivo("Datos Modificados correctamente");
                            positivo.ShowDialog();
                            
                        }
                    }
                    else
                    {
                        frmNegativo negativo = new frmNegativo("Las contraseñas no coinciden");
                        negativo.ShowDialog();
                    }
                }
            else
            {
                    VerificadorPass xd = new VerificadorPass();
                    if (xd.ShowDialog() == DialogResult.OK)
                    {

                        Logica.Usuarios.editarInfoContacto(txtCorreo.Text, txtDireccion.Text, txtTelefono.Text, Logica.logica.UsuarioActual);
                        Logica.Usuarios.cargarPerfil(Logica.logica.UsuarioActual, lblNombre, lblApellido, lblCedula, lblCargo, lblCorreo, lblDireccion, lblTelefono);
                        frmPositivo positivo = new frmPositivo("Datos Modificados correctamente");
                        positivo.ShowDialog();
                    }
                }
            }
        }
        private void bfbtnBuscar_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscar = new OpenFileDialog();
            buscar.Filter = "Image Files(*.jpg;*.jpeg;*.gif;) | *.jpg;*.jpeg;*.gif;";
            if (buscar.ShowDialog() == DialogResult.OK)
            {
                Foto.Image = new Bitmap(buscar.FileName);
                Foto.BackgroundImage = Image.FromFile(buscar.FileName);
                Foto.ImageLocation = buscar.FileName;
                Foto.SizeMode = PictureBoxSizeMode.Zoom;
                photo.Image = new Bitmap(buscar.FileName);
                photo.SizeMode = PictureBoxSizeMode.Zoom;
                FileStream fs;
                BinaryReader br;
                byte[] ImageData;
                fs = new FileStream(Foto.ImageLocation, FileMode.Open, FileAccess.Read);
                br = new BinaryReader(fs);
                ImageData = br.ReadBytes((int)fs.Length);
                br.Close();
                fs.Close();
                Logica.Usuarios.cambiarFotoUsuario(ImageData,Logica.logica.UsuarioActual);
            }
        }


        private void txtNuevaContraseña2_TextChanged(object sender, EventArgs e)
        {
            if(txtNuevaContraseña2.Text != string.Empty)
            {
                txtNuevaContraseña2.UseSystemPasswordChar = true;
            }
            else
            {
                txtNuevaContraseña2.UseSystemPasswordChar = false;

            }
        }

        private void txtContraseñaNueva_TextChange(object sender, EventArgs e)
        {
            if (txtContraseñaNueva.Text != string.Empty)
            {
                txtContraseñaNueva.UseSystemPasswordChar = true;
            }
            else
            {
                txtContraseñaNueva.UseSystemPasswordChar = false;
            }
        }
    }
}
