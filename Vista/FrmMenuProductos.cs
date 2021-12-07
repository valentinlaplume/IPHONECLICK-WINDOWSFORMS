using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace Vista
{
    public partial class FrmMenuProductos : Form
    {
        N_Producto objNegocio;
        E_Producto objEntidad;
        public FrmMenuProductos()
        {
            InitializeComponent();
            objNegocio = new N_Producto();
            objEntidad = new E_Producto();
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Configuracion de colores abm

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

        private void btn_AbrirCategorias_Click(object sender, EventArgs e)
        {
            FrmCategoria frm = new FrmCategoria();
            frm.ShowDialog();
        }

        private void FrmMenuProductos_Load(object sender, EventArgs e)
        {
            PrepararFormulario();
            dgv_TablaProductos.DataSource = objNegocio.ListarProductos();
            OcultarMoverAncharColumnas();
        }

        private void OcultarMoverAncharColumnas()
        {
            dgv_TablaProductos.Columns[0].DisplayIndex = dgv_TablaProductos.Columns.Count - 1; // muevo Columna EDITAR
            dgv_TablaProductos.Columns[1].DisplayIndex = 8; // muevo Columna ELIMINAR

            dgv_TablaProductos.Columns[7].Visible = false; // Oculto Columna id Categoria
            dgv_TablaProductos.Columns[4].Visible = false; // Oculto Columna precio compra
            dgv_TablaProductos.Columns[9].Visible = false;

            dgv_TablaProductos.Columns[0].Width = 60;
            dgv_TablaProductos.Columns[1].Width = 90;
            dgv_TablaProductos.Columns[2].Width = 90;
            dgv_TablaProductos.Columns[3].Width = 250;
            dgv_TablaProductos.Columns[5].Width = 150; // PRECIO VENTA
            dgv_TablaProductos.Columns[6].Width = 100;
            dgv_TablaProductos.Columns[8].Width = 180;
        }

        private void PrepararFormulario()
        {
            this.BackColor = Configuracion.ColorWhite;
            dgv_TablaProductos.BackgroundColor = Configuracion.ColorWhite;
        }

        private void txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            MostrarBuscarTabla(txt_Buscar.Text);
        }

        private void MostrarBuscarTabla(string buscar)
        {
            dgv_TablaProductos.DataSource = objNegocio.BuscarProducto(txt_Buscar.Text);
        }

        private void dgv_TablaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgv_TablaProductos.Rows[e.RowIndex].Cells["ELIMINAR"].Selected &&
                    new FrmConfirm("ELIMINAR PRODUCTO").ShowDialog() == DialogResult.OK)
                {
                    objEntidad.IdProducto = Convert.ToInt32(dgv_TablaProductos.Rows[e.RowIndex].Cells[2].Value.ToString());
                    objNegocio.EliminarProducto(objEntidad);
                    FrmSuccess.ConfirmarMensajeFrmSucces("ELIMINADO");
                    MostrarBuscarTabla("");
                }

                //if (dgv_TablaProductos.Rows[e.RowIndex].Cells["EDITAR"].Selected)
                //{

                //}

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar Producto. " + ex.Message);
            }
        }

        private void btn_NuevoProducto_Click(object sender, EventArgs e)
        {
            FrmNewEditProducto fr = new FrmNewEditProducto();
            fr.ShowDialog();
        }
        //if(dgv_TablaProductos.SelectedRows[0].Selected) // EDITAR
        //{
        //    MessageBox.Show("EDITAR SELECCIONE");
        //}

        //if (dgv_TablaProductos.SelectedRows[1].Selected) // EDITAR
        //{
        //    MessageBox.Show("ELIMINAR SELECCIONE");
        //}
    }
}
