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
    public partial class FrmNewEditProducto : Form
    {
        public FrmNewEditProducto()
        {
            InitializeComponent();
        }

        #region CONFIG BARRA TOP
        private void pb_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!IsValidCamposIngresados()) { throw new Exception(); }



            }
            catch (Exception ex)
            {
                FrmError fr = new FrmError("GUARDAR PRODUCTO");
                fr.ShowDialog();
            }
        }

        private bool IsValidCamposIngresados()
        {
            if (  !string.IsNullOrEmpty(txt_NombreIngresado.Text)
               && !string.IsNullOrEmpty(txt_StockIngresado.Text)
               && !string.IsNullOrEmpty(txt_PrecioVentaIngresado.Text)
               && !string.IsNullOrEmpty(txt_PrecioCompraIngresado.Text))
            {
                return true;
            }
            return false;
        }


    }
}
