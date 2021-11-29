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

namespace Vista
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
            //PersonalizarDiseño();
        }

        private void pb_CerrarVentana_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void PersonalizarDiseño()
        //{
        //    pnl_SubMenu.Visible = false;
        //}

        //private void HideSubMenu()
        //{
        //    if (pnl_SubMenu.Visible)
        //        pnl_SubMenu.Visible = false;
        //}

        //private void ShowSubMenu(Panel subMenu)
        //{
        //    if (!pnl_SubMenu.Visible)
        //    {
        //        HideSubMenu();
        //        subMenu.Visible = true;
        //    }
        //    else
        //    {
        //        subMenu.Visible = false;
        //    }
        //}

        //private void btn_Productos_Click(object sender, EventArgs e)
        //{
        //    ShowSubMenu(pnl_SubMenu);
        //}

        #region Configuracion colores botones menu lateral

        private void btn_MenuClientes_MouseMove(object sender, MouseEventArgs e)
        {
            pb_Clientes.BackColor = Color.FromArgb(139, 183, 240);
        }

        private void btn_MenuClientes_MouseLeave(object sender, EventArgs e)
        {
            pb_Clientes.BackColor = Color.FromArgb(36, 97, 142);
        }

        private void btn_MenuProductos_MouseMove(object sender, MouseEventArgs e)
        {
            pb_Productos.BackColor = Color.FromArgb(139, 183, 240);
        }

        private void btn_MenuProductos_MouseLeave(object sender, EventArgs e)
        {
            pb_Productos.BackColor = Color.FromArgb(36, 97, 142);
        }

        private void btn_MenuVender_MouseMove(object sender, MouseEventArgs e)
        {
            pb_Vender.BackColor = Color.FromArgb(139, 183, 240);
        }

        private void btn_MenuVender_MouseLeave(object sender, EventArgs e)
        {
            pb_Vender.BackColor = Color.FromArgb(36, 97, 142);
        }

        private void btn_MenuEnvios_MouseMove(object sender, MouseEventArgs e)
        {
            pb_Envios.BackColor = Color.FromArgb(139, 183, 240);
        }

        private void btn_MenuEnvios_MouseLeave(object sender, EventArgs e)
        {
            pb_Envios.BackColor = Color.FromArgb(36, 97, 142);
        }

        private void btn_MenuGanancias_MouseMove(object sender, MouseEventArgs e)
        {
            pb_Ganancias.BackColor = Color.FromArgb(139, 183, 240);
        }

        private void btn_MenuGanancias_MouseLeave(object sender, EventArgs e)
        {
            pb_Ganancias.BackColor = Color.FromArgb(36, 97, 142);
        }
        #endregion

        #region Controles barra top

        private void pb_Exit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void FrmCategoria_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (pnl_MenuLateral.Width == 135)
                pnl_MenuLateral.Width = 40;
            else
                pnl_MenuLateral.Width = 135;
        }

        private void AbrirFormulario(object formHijo)
        {
            if (this.pnl_ContenedorFormularios.Controls.Count > 0)
                this.pnl_ContenedorFormularios.Controls.RemoveAt(0);

            Form fr = formHijo as Form;
            fr.TopLevel = false;
            fr.Dock = DockStyle.Fill;
            this.pnl_ContenedorFormularios.Controls.Add(fr);
            this.pnl_ContenedorFormularios.Tag = fr;
            fr.Show();
        }
        private void btn_MenuProductos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmMenuProductos());
        }

    }
}
