using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmSuccess : Form
    {
        public FrmSuccess()
        {
            InitializeComponent();
        }

        private void FrmSuccess_Load(object sender, EventArgs e)
        {
            timer.Start();
            lbl_Accion.Text = lbl_Accion.Text.ToUpper();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.Opacity += .10;
            if (this.Opacity == 1) { timer.Stop(); }
        }

        public static void ConfirmarMensajeFrmSucces(string msjAccion)
        {
            FrmSuccess frm = new FrmSuccess();
            frm.lbl_Accion.Text = msjAccion;
            frm.ShowDialog();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Mover ventana barra top

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void FrmSuccess_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void pnl_Top_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

    }
}
