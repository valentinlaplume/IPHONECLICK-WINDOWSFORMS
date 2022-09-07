using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class FrmError : Form
    {
        public FrmError()
        {
            InitializeComponent();
        }

        public FrmError(string mensaje) : this ()
        {
            lbl_Accion.Text = mensaje.ToUpper();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            this.Opacity += .10;
            if (this.Opacity == 1) { timer.Stop(); }
        }

        private void FrmError_Load(object sender, EventArgs e)
        {
            timer.Start();
            lbl_Accion.Text = lbl_Accion.Text.ToUpper();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
