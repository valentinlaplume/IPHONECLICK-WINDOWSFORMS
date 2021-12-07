
namespace Vista
{
    partial class FrmMenuProductos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuProductos));
            this.btn_Cerrar = new System.Windows.Forms.Label();
            this.pb_Guardar = new System.Windows.Forms.PictureBox();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.pb_Editar = new System.Windows.Forms.PictureBox();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.pb_Eliminar = new System.Windows.Forms.PictureBox();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.pb_Mas = new System.Windows.Forms.PictureBox();
            this.btn_NuevoProducto = new System.Windows.Forms.Button();
            this.dgv_TablaProductos = new System.Windows.Forms.DataGridView();
            this.EDITAR = new System.Windows.Forms.DataGridViewImageColumn();
            this.ELIMINAR = new System.Windows.Forms.DataGridViewImageColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.pb_Lupa = new System.Windows.Forms.PictureBox();
            this.txt_Buscar = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_DataGrid = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Guardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Editar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Eliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Mas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TablaProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Lupa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_DataGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cerrar.AutoSize = true;
            this.btn_Cerrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cerrar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Cerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(97)))), ((int)(((byte)(142)))));
            this.btn_Cerrar.Location = new System.Drawing.Point(937, 11);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(17, 19);
            this.btn_Cerrar.TabIndex = 0;
            this.btn_Cerrar.Text = "X";
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // pb_Guardar
            // 
            this.pb_Guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(97)))), ((int)(((byte)(142)))));
            this.pb_Guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pb_Guardar.Enabled = false;
            this.pb_Guardar.Image = global::Vista.Properties.Resources.icons8_guardar_30;
            this.pb_Guardar.Location = new System.Drawing.Point(675, 511);
            this.pb_Guardar.Name = "pb_Guardar";
            this.pb_Guardar.Size = new System.Drawing.Size(25, 25);
            this.pb_Guardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Guardar.TabIndex = 49;
            this.pb_Guardar.TabStop = false;
            this.pb_Guardar.Visible = false;
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(97)))), ((int)(((byte)(142)))));
            this.btn_Guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Guardar.FlatAppearance.BorderSize = 0;
            this.btn_Guardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.btn_Guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(183)))), ((int)(((byte)(240)))));
            this.btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Guardar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Guardar.ForeColor = System.Drawing.Color.White;
            this.btn_Guardar.Location = new System.Drawing.Point(667, 504);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(272, 39);
            this.btn_Guardar.TabIndex = 48;
            this.btn_Guardar.Text = "GUARDAR";
            this.btn_Guardar.UseVisualStyleBackColor = false;
            this.btn_Guardar.Visible = false;
            this.btn_Guardar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Guardar_MouseDown);
            this.btn_Guardar.MouseLeave += new System.EventHandler(this.btn_Guardar_MouseLeave);
            this.btn_Guardar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_Guardar_MouseMove);
            // 
            // pb_Editar
            // 
            this.pb_Editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(97)))), ((int)(((byte)(142)))));
            this.pb_Editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pb_Editar.Enabled = false;
            this.pb_Editar.Image = global::Vista.Properties.Resources.edit_40px;
            this.pb_Editar.Location = new System.Drawing.Point(147, 512);
            this.pb_Editar.Name = "pb_Editar";
            this.pb_Editar.Size = new System.Drawing.Size(25, 25);
            this.pb_Editar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Editar.TabIndex = 46;
            this.pb_Editar.TabStop = false;
            this.pb_Editar.Visible = false;
            // 
            // btn_Editar
            // 
            this.btn_Editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(97)))), ((int)(((byte)(142)))));
            this.btn_Editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Editar.FlatAppearance.BorderSize = 0;
            this.btn_Editar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SandyBrown;
            this.btn_Editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(183)))), ((int)(((byte)(240)))));
            this.btn_Editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Editar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Editar.ForeColor = System.Drawing.Color.White;
            this.btn_Editar.Location = new System.Drawing.Point(139, 504);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(106, 39);
            this.btn_Editar.TabIndex = 39;
            this.btn_Editar.Text = "      EDITAR";
            this.btn_Editar.UseVisualStyleBackColor = false;
            this.btn_Editar.Visible = false;
            this.btn_Editar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Editar_MouseDown);
            this.btn_Editar.MouseLeave += new System.EventHandler(this.btn_Editar_MouseLeave);
            this.btn_Editar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_Editar_MouseMove);
            // 
            // pb_Eliminar
            // 
            this.pb_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(97)))), ((int)(((byte)(142)))));
            this.pb_Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pb_Eliminar.Enabled = false;
            this.pb_Eliminar.Image = global::Vista.Properties.Resources.delete_40px;
            this.pb_Eliminar.Location = new System.Drawing.Point(259, 512);
            this.pb_Eliminar.Name = "pb_Eliminar";
            this.pb_Eliminar.Size = new System.Drawing.Size(25, 25);
            this.pb_Eliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Eliminar.TabIndex = 45;
            this.pb_Eliminar.TabStop = false;
            this.pb_Eliminar.Visible = false;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(97)))), ((int)(((byte)(142)))));
            this.btn_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Eliminar.FlatAppearance.BorderSize = 0;
            this.btn_Eliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral;
            this.btn_Eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(183)))), ((int)(((byte)(240)))));
            this.btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Eliminar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Eliminar.ForeColor = System.Drawing.Color.White;
            this.btn_Eliminar.Location = new System.Drawing.Point(251, 504);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(120, 39);
            this.btn_Eliminar.TabIndex = 40;
            this.btn_Eliminar.Text = "       ELIMINAR";
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            this.btn_Eliminar.Visible = false;
            this.btn_Eliminar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Eliminar_MouseDown);
            this.btn_Eliminar.MouseLeave += new System.EventHandler(this.btn_Eliminar_MouseLeave);
            this.btn_Eliminar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_Eliminar_MouseMove);
            // 
            // pb_Mas
            // 
            this.pb_Mas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(97)))), ((int)(((byte)(142)))));
            this.pb_Mas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pb_Mas.Enabled = false;
            this.pb_Mas.Image = global::Vista.Properties.Resources.icons8_más_2_matemáticas_30;
            this.pb_Mas.Location = new System.Drawing.Point(35, 511);
            this.pb_Mas.Name = "pb_Mas";
            this.pb_Mas.Size = new System.Drawing.Size(25, 25);
            this.pb_Mas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Mas.TabIndex = 44;
            this.pb_Mas.TabStop = false;
            this.pb_Mas.Visible = false;
            // 
            // btn_NuevoProducto
            // 
            this.btn_NuevoProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(97)))), ((int)(((byte)(142)))));
            this.btn_NuevoProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_NuevoProducto.FlatAppearance.BorderSize = 0;
            this.btn_NuevoProducto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleGreen;
            this.btn_NuevoProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(183)))), ((int)(((byte)(240)))));
            this.btn_NuevoProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NuevoProducto.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_NuevoProducto.ForeColor = System.Drawing.Color.White;
            this.btn_NuevoProducto.Location = new System.Drawing.Point(27, 504);
            this.btn_NuevoProducto.Name = "btn_NuevoProducto";
            this.btn_NuevoProducto.Size = new System.Drawing.Size(106, 39);
            this.btn_NuevoProducto.TabIndex = 38;
            this.btn_NuevoProducto.Text = "       NUEVO";
            this.btn_NuevoProducto.UseVisualStyleBackColor = false;
            this.btn_NuevoProducto.Click += new System.EventHandler(this.btn_NuevoProducto_Click);
            this.btn_NuevoProducto.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_NuevoProducto_MouseDown);
            this.btn_NuevoProducto.MouseLeave += new System.EventHandler(this.btn_NuevoProducto_MouseLeave);
            this.btn_NuevoProducto.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_NuevoProducto_MouseMove);
            // 
            // dgv_TablaProductos
            // 
            this.dgv_TablaProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_TablaProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_TablaProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_TablaProductos.BackgroundColor = System.Drawing.Color.White;
            this.dgv_TablaProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_TablaProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_TablaProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_TablaProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_TablaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TablaProductos.ColumnHeadersVisible = false;
            this.dgv_TablaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EDITAR,
            this.ELIMINAR});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(64)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_TablaProductos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_TablaProductos.GridColor = System.Drawing.Color.Silver;
            this.dgv_TablaProductos.Location = new System.Drawing.Point(14, 125);
            this.dgv_TablaProductos.Name = "dgv_TablaProductos";
            this.dgv_TablaProductos.ReadOnly = true;
            this.dgv_TablaProductos.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_TablaProductos.RowHeadersVisible = false;
            this.dgv_TablaProductos.RowTemplate.Height = 25;
            this.dgv_TablaProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_TablaProductos.Size = new System.Drawing.Size(937, 430);
            this.dgv_TablaProductos.TabIndex = 43;
            this.dgv_TablaProductos.TabStop = false;
            this.dgv_TablaProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_TablaProductos_CellContentClick);
            // 
            // EDITAR
            // 
            this.EDITAR.Description = "EDITAR";
            this.EDITAR.HeaderText = "EDITAR";
            this.EDITAR.Image = global::Vista.Properties.Resources.icons8_editar_161;
            this.EDITAR.Name = "EDITAR";
            this.EDITAR.ReadOnly = true;
            // 
            // ELIMINAR
            // 
            this.ELIMINAR.Description = "ELIMINAR";
            this.ELIMINAR.HeaderText = "ELIMINAR";
            this.ELIMINAR.Image = global::Vista.Properties.Resources.icons8_eliminar_161;
            this.ELIMINAR.Name = "ELIMINAR";
            this.ELIMINAR.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(13, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 42;
            this.label2.Text = "CODIGO";
            // 
            // pb_Lupa
            // 
            this.pb_Lupa.BackColor = System.Drawing.Color.Transparent;
            this.pb_Lupa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pb_Lupa.Image = global::Vista.Properties.Resources.search_40px;
            this.pb_Lupa.Location = new System.Drawing.Point(19, 57);
            this.pb_Lupa.Name = "pb_Lupa";
            this.pb_Lupa.Size = new System.Drawing.Size(25, 25);
            this.pb_Lupa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Lupa.TabIndex = 41;
            this.pb_Lupa.TabStop = false;
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.BackColor = System.Drawing.Color.White;
            this.txt_Buscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Buscar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Buscar.Location = new System.Drawing.Point(52, 60);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(311, 20);
            this.txt_Buscar.TabIndex = 37;
            this.txt_Buscar.TextChanged += new System.EventHandler(this.txt_Buscar_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::Vista.Properties.Resources.CajaTexto;
            this.pictureBox1.Location = new System.Drawing.Point(13, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(358, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 33);
            this.label1.TabIndex = 50;
            this.label1.Text = "PRODUCTOS";
            // 
            // pnl_DataGrid
            // 
            this.pnl_DataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_DataGrid.BackColor = System.Drawing.Color.White;
            this.pnl_DataGrid.BackgroundImage = global::Vista.Properties.Resources.FormularioBorde;
            this.pnl_DataGrid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_DataGrid.Controls.Add(this.pb_Lupa);
            this.pnl_DataGrid.Controls.Add(this.dgv_TablaProductos);
            this.pnl_DataGrid.Controls.Add(this.txt_Buscar);
            this.pnl_DataGrid.Controls.Add(this.pictureBox1);
            this.pnl_DataGrid.Controls.Add(this.label1);
            this.pnl_DataGrid.Controls.Add(this.label3);
            this.pnl_DataGrid.Controls.Add(this.btn_Cerrar);
            this.pnl_DataGrid.Controls.Add(this.label2);
            this.pnl_DataGrid.ForeColor = System.Drawing.Color.White;
            this.pnl_DataGrid.Location = new System.Drawing.Point(-1, -2);
            this.pnl_DataGrid.Name = "pnl_DataGrid";
            this.pnl_DataGrid.Size = new System.Drawing.Size(971, 574);
            this.pnl_DataGrid.TabIndex = 53;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(152, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 19);
            this.label3.TabIndex = 54;
            this.label3.Text = "NOMBRE";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(315, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 19);
            this.label4.TabIndex = 55;
            this.label4.Text = "PRECIO DE VENTA";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(644, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 19);
            this.label6.TabIndex = 57;
            this.label6.Text = "CATEGORIA";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(493, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 19);
            this.label7.TabIndex = 58;
            this.label7.Text = "STOCK";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(868, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 19);
            this.label8.TabIndex = 44;
            this.label8.Text = "ELIMINAR";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoEllipsis = true;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(791, 102);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 19);
            this.label9.TabIndex = 45;
            this.label9.Text = "EDITAR";
            // 
            // FrmMenuProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(965, 565);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pb_Guardar);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.pb_Editar);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.pb_Eliminar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.pb_Mas);
            this.Controls.Add(this.btn_NuevoProducto);
            this.Controls.Add(this.pnl_DataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMenuProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.FrmMenuProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Guardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Editar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Eliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Mas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TablaProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Lupa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_DataGrid.ResumeLayout(false);
            this.pnl_DataGrid.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btn_Cerrar;
        private System.Windows.Forms.PictureBox pb_Guardar;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.PictureBox pb_Editar;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.PictureBox pb_Eliminar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.PictureBox pb_Mas;
        private System.Windows.Forms.Button btn_NuevoProducto;
        private System.Windows.Forms.DataGridView dgv_TablaProductos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pb_Lupa;
        private System.Windows.Forms.TextBox txt_Buscar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_DataGrid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewImageColumn EDITAR;
        private System.Windows.Forms.DataGridViewImageColumn ELIMINAR;
    }
}