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
using Entidades;
using Negocio;

namespace Vista
{
    public partial class FrmCategoria : Form
    {
        int idCategoria;
        bool editar;
        E_Categoria objEntidad;
        N_Categoria objNegocio;

        public FrmCategoria()
        {
            InitializeComponent();
            editar = false;
            objEntidad = new E_Categoria();
            objNegocio = new N_Categoria(); 
        }

        private void pb_Closed_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region top mover ventana


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

        #region Configuracion colores botones nuevo, editar, eliminar

        private void btn_NuevoProducto_MouseMove(object sender, MouseEventArgs e)
        {
            pb_Mas.BackColor = Color.FromArgb(139, 183, 240);
            btn_NuevoProducto.ForeColor = Color.White;
        }

        private void btn_NuevoProducto_MouseLeave(object sender, EventArgs e)
        {
            pb_Mas.BackColor = Color.FromArgb(36, 97, 142);
            btn_NuevoProducto.ForeColor = Color.White;
        }

        private void btn_NuevoProducto_MouseDown(object sender, MouseEventArgs e)
        {
            pb_Mas.BackColor = Color.PaleGreen;
            btn_NuevoProducto.ForeColor = Color.Black;
        }

        private void btn_Editar_MouseMove(object sender, MouseEventArgs e)
        {
            pb_Editar.BackColor = Color.FromArgb(139, 183, 240);
            btn_Editar.ForeColor = Color.White;
        }

        private void btn_Editar_MouseLeave(object sender, EventArgs e)
        {
            pb_Editar.BackColor = Color.FromArgb(36, 97, 142);
            btn_Editar.ForeColor = Color.White;
        }

        private void btn_Editar_MouseDown(object sender, MouseEventArgs e)
        {
            pb_Editar.BackColor = Color.SandyBrown;
            btn_Editar.ForeColor = Color.Black;
        }

        private void btn_Eliminar_MouseMove(object sender, MouseEventArgs e)
        {
            pb_Eliminar.BackColor = Color.FromArgb(139, 183, 240);
            btn_Eliminar.ForeColor = Color.White;
        }

        private void btn_Eliminar_MouseLeave(object sender, EventArgs e)
        {
            pb_Eliminar.BackColor = Color.FromArgb(36, 97, 142);
            btn_Eliminar.ForeColor = Color.White;
        }

        private void btn_Eliminar_MouseDown(object sender, MouseEventArgs e)
        {
            pb_Eliminar.BackColor = Color.LightCoral;
            btn_Eliminar.ForeColor = Color.Black;
        }


        private void btn_Guardar_MouseMove(object sender, MouseEventArgs e)
        {
            pb_Guardar.BackColor = Color.FromArgb(139, 183, 240);
            btn_Guardar.ForeColor = Color.White;
        }

        private void btn_Guardar_MouseLeave(object sender, EventArgs e)
        {
            pb_Guardar.BackColor = Color.FromArgb(36, 97, 142);
            btn_Guardar.ForeColor = Color.White;
        }

        private void btn_Guardar_MouseDown(object sender, MouseEventArgs e)
        {
            pb_Guardar.BackColor = Color.PaleGreen;
            btn_Guardar.ForeColor = Color.Black;
        }
        #endregion

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            MostrarBuscarTabla("");
            AccionesTabla();
        }

        public void AccionesTabla()
        {
            dgv_TablaCategoria.Columns[0].Visible = false;
            dgv_TablaCategoria.Columns[1].Width = 160;
            dgv_TablaCategoria.ClearSelection();
        }

        public void MostrarBuscarTabla(string buscar)
        {
            N_Categoria obj = new N_Categoria();
            dgv_TablaCategoria.DataSource = obj.ListarCategoria(buscar);
        }

        private void txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            MostrarBuscarTabla(txt_Buscar.Text);
        }

        private void btn_NuevoProducto_Click(object sender, EventArgs e)
        {
            editar = false;
            LimpiarCampos();
            txt_NombreIngresado.Focus(); // arranca a escribir e
        }

        public void LimpiarCampos()
        {
            editar = false;
            dgv_TablaCategoria.ClearSelection();
            txt_NombreIngresado.Text = "";
            txt_DescripcionIngresado.Text = "";
        }


        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if(dgv_TablaCategoria.SelectedRows.Count > 0)
            {
                editar = true;
                idCategoria = int.Parse(dgv_TablaCategoria.CurrentRow.Cells[0].Value.ToString());
                txt_NombreIngresado.Text = dgv_TablaCategoria.CurrentRow.Cells[1].Value.ToString();
                txt_DescripcionIngresado.Text = dgv_TablaCategoria.CurrentRow.Cells[2].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione Categoria.");
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            if(editar==false)
            {
                try
                {
                    objEntidad.Nombre = txt_NombreIngresado.Text.ToUpper();
                    objEntidad.Descripcion = txt_DescripcionIngresado.Text.ToUpper();
                   
                    objNegocio.InsertarCategoria(objEntidad);
                    MessageBox.Show("Guardada Categoria.");

                    MostrarBuscarTabla("");
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al Guardar Categoria. " + ex.Message);
                }
            }
            else if (editar)
            {
                try
                {
                    objEntidad.IdCategoria = idCategoria;
                    objEntidad.Nombre = txt_NombreIngresado.Text.ToUpper();
                    objEntidad.Descripcion = txt_DescripcionIngresado.Text.ToUpper();

                    objNegocio.EditarCategoria(objEntidad);

                    MessageBox.Show("Se editó Categoria.");

                    MostrarBuscarTabla("");
                    LimpiarCampos();
                    editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al Editar Categoria. " + ex.Message);
                }
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if(dgv_TablaCategoria.SelectedRows.Count > 0)
                {
                    objEntidad.IdCategoria = int.Parse(dgv_TablaCategoria.CurrentRow.Cells[0].Value.ToString());
                    objNegocio.EliminarCategoria(objEntidad);


                    MessageBox.Show("Se eliminó Categoria.");
                    MostrarBuscarTabla("");
                }
                else { MessageBox.Show("Seleccione categoria a eliminar."); }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al eliminar Categoria. " + ex.Message);

            }
        }
    }
}
