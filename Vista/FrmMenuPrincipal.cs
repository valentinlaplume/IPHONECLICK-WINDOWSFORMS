using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using Entidades;

namespace Vista
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
            //PersonalizarDiseño();
        }

        public void AsignarTamañoFormSinEsconderBarraTarea()
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }
       
        #region Controles barra top

        private void pb_Exit_Click_1(object sender, EventArgs e)
        {
            if (new FrmConfirmacion("SALIR DEL PROGRAMA").ShowDialog() == DialogResult.OK) { Application.Exit(); }
        }

        private void pb_Maximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pb_Maximizar.Visible = false;
            pb_Restaurar.Visible = true;
        }

        private void pb_Restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pb_Restaurar.Visible = false;
            pb_Maximizar.Visible = true;
        }

        private void pb_Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region Mover ventana barra top

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnl_Top_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion


        private void AsignarFondoColorPictureBoxBotonesMenuLateral()
        {
            pb_Clientes.BackColor = Configuracion.ColorMenuLateral;
            pb_Productos.BackColor = Configuracion.ColorMenuLateral;
            pb_Vender.BackColor = Configuracion.ColorMenuLateral;
            pb_Envios.BackColor = Configuracion.ColorMenuLateral;
            pb_Ganancias.BackColor = Configuracion.ColorMenuLateral;
        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            AsignarFondoColorPictureBoxBotonesMenuLateral();
        }


        private void AbrirFormulario(object formHijo)
        {
            if (this.pnl_ContenedorFormularios.Controls.Count > 0)
            {   this.pnl_ContenedorFormularios.Controls.RemoveAt(0);    }

            Form fr = formHijo as Form;
            fr.TopLevel = false;
            fr.Dock = DockStyle.Fill;
            this.pnl_ContenedorFormularios.Controls.Add(fr);
            this.pnl_ContenedorFormularios.Tag = fr;
            fr.Show();
        }

        #region Configuracion colores botones Menu Lateral, Principal

        #region Clientes
        private void btn_MenuClientes_MouseMove(object sender, MouseEventArgs e)
        {
            pb_Clientes.BackColor = Configuracion.ColorEncimaBotones;
            btn_MenuClientes.ForeColor = Configuracion.ColorBlack;
        }

        private void btn_MenuClientes_MouseLeave(object sender, EventArgs e)
        {
            pb_Clientes.BackColor = Configuracion.ColorMenuLateral;
            btn_MenuClientes.ForeColor = Configuracion.ColorWhite;
        }

        private void btn_MenuClientes_MouseDown(object sender, MouseEventArgs e)
        {
            pb_Clientes.BackColor = Configuracion.ColorMenuLateral;
            btn_MenuClientes.ForeColor = Configuracion.ColorWhite;
        }
        #endregion

        #region Productos

        private void btn_MenuProductos_MouseMove(object sender, MouseEventArgs e)
        {
            pb_Productos.BackColor = Configuracion.ColorEncimaBotones;
            btn_MenuProductos.ForeColor = Configuracion.ColorBlack;
        }

        private void btn_MenuProductos_MouseLeave(object sender, EventArgs e)
        {
            pb_Productos.BackColor = Configuracion.ColorMenuLateral;
            btn_MenuProductos.ForeColor = Configuracion.ColorWhite;
        }

        private void btn_MenuProductos_MouseDown(object sender, MouseEventArgs e)
        {
            pb_Productos.BackColor = Configuracion.ColorMenuLateral;
            btn_MenuProductos.ForeColor = Configuracion.ColorWhite;
        }
        #endregion

        #region Vender

        private void btn_MenuVender_MouseMove(object sender, MouseEventArgs e)
        {
            pb_Vender.BackColor = Configuracion.ColorEncimaBotones;
            btn_MenuVender.ForeColor = Configuracion.ColorBlack;
        }

        private void btn_MenuVender_MouseLeave(object sender, EventArgs e)
        {
            pb_Vender.BackColor = Configuracion.ColorMenuLateral;
            btn_MenuVender.ForeColor = Configuracion.ColorWhite;
        }

        private void btn_MenuVender_MouseDown(object sender, MouseEventArgs e)
        {
            pb_Vender.BackColor = Configuracion.ColorMenuLateral;
            btn_MenuVender.ForeColor = Configuracion.ColorWhite;
        }
        #endregion

        #region Envios

        private void btn_MenuEnvios_MouseMove(object sender, MouseEventArgs e)
        {
            pb_Envios.BackColor = Configuracion.ColorEncimaBotones;
            btn_MenuEnvios.ForeColor = Configuracion.ColorBlack;
        }

        private void btn_MenuEnvios_MouseLeave(object sender, EventArgs e)
        {
            pb_Envios.BackColor = Configuracion.ColorMenuLateral;
            btn_MenuEnvios.ForeColor = Configuracion.ColorWhite;
        }

        private void btn_MenuEnvios_MouseDown(object sender, MouseEventArgs e)
        {
            pb_Envios.BackColor = Configuracion.ColorMenuLateral;
            btn_MenuEnvios.ForeColor = Configuracion.ColorWhite;
        }
        #endregion

        #region Ganancias
        private void btn_MenuGanancias_MouseMove(object sender, MouseEventArgs e)
        {
            pb_Ganancias.BackColor = Configuracion.ColorEncimaBotones;
            btn_MenuGanancias.ForeColor = Configuracion.ColorBlack;
        }

        private void btn_MenuGanancias_MouseLeave(object sender, EventArgs e)
        {
            pb_Ganancias.BackColor = Configuracion.ColorMenuLateral;
            btn_MenuGanancias.ForeColor = Configuracion.ColorWhite;

        }

        private void btn_MenuGanancias_MouseDown(object sender, MouseEventArgs e)
        {
            pb_Ganancias.BackColor = Configuracion.ColorMenuLateral;
            btn_MenuGanancias.ForeColor = Configuracion.ColorWhite;
        }
        #endregion

        #endregion

        private void btn_MenuClientes_Click(object sender, EventArgs e)
        {
            FrmSuccess.ConfirmarMensajeFrmSucces("guardado");
        }

        private void btn_MenuProductos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmMenuProductos());
        }


    }
}
