
namespace Vista
{
    partial class FrmCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCategoria));
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.pb_Closed = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pb_Restaurar = new System.Windows.Forms.PictureBox();
            this.pb_Minimizar = new System.Windows.Forms.PictureBox();
            this.pb_Maximizar = new System.Windows.Forms.PictureBox();
            this.pb_Exit = new System.Windows.Forms.PictureBox();
            this.txt_Buscar = new System.Windows.Forms.TextBox();
            this.pb_Vender = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_TablaCategoria = new System.Windows.Forms.DataGridView();
            this.btn_NuevoProducto = new System.Windows.Forms.Button();
            this.pb_Mas = new System.Windows.Forms.PictureBox();
            this.pb_Eliminar = new System.Windows.Forms.PictureBox();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.pb_Editar = new System.Windows.Forms.PictureBox();
            this.btn_Editar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_DescripcionIngresado = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_NombreIngresado = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pb_Guardar = new System.Windows.Forms.PictureBox();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnl_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Closed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Vender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TablaCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Mas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Eliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Editar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Guardar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Top
            // 
            this.pnl_Top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.pnl_Top.Controls.Add(this.pb_Closed);
            this.pnl_Top.Controls.Add(this.label1);
            this.pnl_Top.Controls.Add(this.pb_Restaurar);
            this.pnl_Top.Controls.Add(this.pb_Minimizar);
            this.pnl_Top.Controls.Add(this.pb_Maximizar);
            this.pnl_Top.Controls.Add(this.pb_Exit);
            this.pnl_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Top.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(64)))), ((int)(((byte)(94)))));
            this.pnl_Top.Location = new System.Drawing.Point(3, 0);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Size = new System.Drawing.Size(797, 35);
            this.pnl_Top.TabIndex = 2;
            this.pnl_Top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_Top_MouseDown);
            // 
            // pb_Closed
            // 
            this.pb_Closed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_Closed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Closed.Image = global::Vista.Properties.Resources.icons8_cerrar_ventana_30;
            this.pb_Closed.Location = new System.Drawing.Point(767, 5);
            this.pb_Closed.Name = "pb_Closed";
            this.pb_Closed.Size = new System.Drawing.Size(25, 25);
            this.pb_Closed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Closed.TabIndex = 6;
            this.pb_Closed.TabStop = false;
            this.pb_Closed.Click += new System.EventHandler(this.pb_Closed_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 19);
            this.label1.TabIndex = 37;
            this.label1.Text = "CATEGORIAS";
            // 
            // pb_Restaurar
            // 
            this.pb_Restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_Restaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Restaurar.Image = global::Vista.Properties.Resources.icons8_restaurar_ventana_30;
            this.pb_Restaurar.Location = new System.Drawing.Point(1636, 5);
            this.pb_Restaurar.Name = "pb_Restaurar";
            this.pb_Restaurar.Size = new System.Drawing.Size(25, 25);
            this.pb_Restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Restaurar.TabIndex = 5;
            this.pb_Restaurar.TabStop = false;
            this.pb_Restaurar.Visible = false;
            // 
            // pb_Minimizar
            // 
            this.pb_Minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_Minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Minimizar.Image = global::Vista.Properties.Resources.icons8_minimizar_la_ventana_30;
            this.pb_Minimizar.Location = new System.Drawing.Point(1605, 5);
            this.pb_Minimizar.Name = "pb_Minimizar";
            this.pb_Minimizar.Size = new System.Drawing.Size(25, 25);
            this.pb_Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Minimizar.TabIndex = 5;
            this.pb_Minimizar.TabStop = false;
            // 
            // pb_Maximizar
            // 
            this.pb_Maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_Maximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Maximizar.Image = global::Vista.Properties.Resources.icons8_maximizar_la_ventana_30;
            this.pb_Maximizar.Location = new System.Drawing.Point(1636, 5);
            this.pb_Maximizar.Name = "pb_Maximizar";
            this.pb_Maximizar.Size = new System.Drawing.Size(25, 25);
            this.pb_Maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Maximizar.TabIndex = 4;
            this.pb_Maximizar.TabStop = false;
            // 
            // pb_Exit
            // 
            this.pb_Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_Exit.Image = global::Vista.Properties.Resources.icons8_cerrar_ventana_30;
            this.pb_Exit.Location = new System.Drawing.Point(1667, 5);
            this.pb_Exit.Name = "pb_Exit";
            this.pb_Exit.Size = new System.Drawing.Size(25, 25);
            this.pb_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Exit.TabIndex = 0;
            this.pb_Exit.TabStop = false;
            // 
            // txt_Buscar
            // 
            this.txt_Buscar.BackColor = System.Drawing.Color.White;
            this.txt_Buscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Buscar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_Buscar.Location = new System.Drawing.Point(58, 56);
            this.txt_Buscar.Name = "txt_Buscar";
            this.txt_Buscar.Size = new System.Drawing.Size(238, 20);
            this.txt_Buscar.TabIndex = 0;
            this.txt_Buscar.TextChanged += new System.EventHandler(this.txt_Buscar_TextChanged);
            // 
            // pb_Vender
            // 
            this.pb_Vender.BackColor = System.Drawing.Color.Transparent;
            this.pb_Vender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pb_Vender.Image = global::Vista.Properties.Resources.search_40px;
            this.pb_Vender.Location = new System.Drawing.Point(23, 53);
            this.pb_Vender.Name = "pb_Vender";
            this.pb_Vender.Size = new System.Drawing.Size(25, 25);
            this.pb_Vender.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Vender.TabIndex = 15;
            this.pb_Vender.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "NOMBRE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(176, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 19);
            this.label3.TabIndex = 18;
            this.label3.Text = "DESCRIPCIÓN";
            // 
            // dgv_TablaCategoria
            // 
            this.dgv_TablaCategoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_TablaCategoria.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_TablaCategoria.BackgroundColor = System.Drawing.Color.White;
            this.dgv_TablaCategoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_TablaCategoria.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_TablaCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_TablaCategoria.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(64)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_TablaCategoria.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_TablaCategoria.GridColor = System.Drawing.Color.Silver;
            this.dgv_TablaCategoria.Location = new System.Drawing.Point(12, 125);
            this.dgv_TablaCategoria.Name = "dgv_TablaCategoria";
            this.dgv_TablaCategoria.ReadOnly = true;
            this.dgv_TablaCategoria.RowHeadersVisible = false;
            this.dgv_TablaCategoria.RowTemplate.Height = 25;
            this.dgv_TablaCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_TablaCategoria.Size = new System.Drawing.Size(493, 262);
            this.dgv_TablaCategoria.TabIndex = 19;
            this.dgv_TablaCategoria.TabStop = false;
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
            this.btn_NuevoProducto.Location = new System.Drawing.Point(12, 399);
            this.btn_NuevoProducto.Name = "btn_NuevoProducto";
            this.btn_NuevoProducto.Size = new System.Drawing.Size(106, 39);
            this.btn_NuevoProducto.TabIndex = 1;
            this.btn_NuevoProducto.Text = "       NUEVO";
            this.btn_NuevoProducto.UseVisualStyleBackColor = false;
            this.btn_NuevoProducto.Click += new System.EventHandler(this.btn_NuevoProducto_Click);
            this.btn_NuevoProducto.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_NuevoProducto_MouseDown);
            this.btn_NuevoProducto.MouseLeave += new System.EventHandler(this.btn_NuevoProducto_MouseLeave);
            this.btn_NuevoProducto.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_NuevoProducto_MouseMove);
            // 
            // pb_Mas
            // 
            this.pb_Mas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(97)))), ((int)(((byte)(142)))));
            this.pb_Mas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pb_Mas.Enabled = false;
            this.pb_Mas.Image = global::Vista.Properties.Resources.icons8_más_2_matemáticas_30;
            this.pb_Mas.Location = new System.Drawing.Point(20, 406);
            this.pb_Mas.Name = "pb_Mas";
            this.pb_Mas.Size = new System.Drawing.Size(25, 25);
            this.pb_Mas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Mas.TabIndex = 21;
            this.pb_Mas.TabStop = false;
            // 
            // pb_Eliminar
            // 
            this.pb_Eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(97)))), ((int)(((byte)(142)))));
            this.pb_Eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pb_Eliminar.Enabled = false;
            this.pb_Eliminar.Image = global::Vista.Properties.Resources.delete_40px;
            this.pb_Eliminar.Location = new System.Drawing.Point(244, 407);
            this.pb_Eliminar.Name = "pb_Eliminar";
            this.pb_Eliminar.Size = new System.Drawing.Size(25, 25);
            this.pb_Eliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Eliminar.TabIndex = 23;
            this.pb_Eliminar.TabStop = false;
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
            this.btn_Eliminar.Location = new System.Drawing.Point(236, 399);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(120, 39);
            this.btn_Eliminar.TabIndex = 3;
            this.btn_Eliminar.Text = "       ELIMINAR";
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            this.btn_Eliminar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Eliminar_MouseDown);
            this.btn_Eliminar.MouseLeave += new System.EventHandler(this.btn_Eliminar_MouseLeave);
            this.btn_Eliminar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_Eliminar_MouseMove);
            // 
            // pb_Editar
            // 
            this.pb_Editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(97)))), ((int)(((byte)(142)))));
            this.pb_Editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pb_Editar.Enabled = false;
            this.pb_Editar.Image = global::Vista.Properties.Resources.edit_40px;
            this.pb_Editar.Location = new System.Drawing.Point(132, 407);
            this.pb_Editar.Name = "pb_Editar";
            this.pb_Editar.Size = new System.Drawing.Size(25, 25);
            this.pb_Editar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Editar.TabIndex = 25;
            this.pb_Editar.TabStop = false;
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
            this.btn_Editar.Location = new System.Drawing.Point(124, 399);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(106, 39);
            this.btn_Editar.TabIndex = 2;
            this.btn_Editar.Text = "      EDITAR";
            this.btn_Editar.UseVisualStyleBackColor = false;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            this.btn_Editar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Editar_MouseDown);
            this.btn_Editar.MouseLeave += new System.EventHandler(this.btn_Editar_MouseLeave);
            this.btn_Editar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_Editar_MouseMove);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(517, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 18);
            this.label4.TabIndex = 28;
            this.label4.Text = "DESCRIPCIÓN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(517, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 18);
            this.label5.TabIndex = 27;
            this.label5.Text = "NOMBRE";
            // 
            // txt_DescripcionIngresado
            // 
            this.txt_DescripcionIngresado.BackColor = System.Drawing.Color.White;
            this.txt_DescripcionIngresado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_DescripcionIngresado.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_DescripcionIngresado.Location = new System.Drawing.Point(523, 224);
            this.txt_DescripcionIngresado.Multiline = true;
            this.txt_DescripcionIngresado.Name = "txt_DescripcionIngresado";
            this.txt_DescripcionIngresado.Size = new System.Drawing.Size(256, 154);
            this.txt_DescripcionIngresado.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Vista.Properties.Resources.CajaTexto;
            this.pictureBox1.Location = new System.Drawing.Point(12, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // txt_NombreIngresado
            // 
            this.txt_NombreIngresado.BackColor = System.Drawing.Color.White;
            this.txt_NombreIngresado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_NombreIngresado.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_NombreIngresado.Location = new System.Drawing.Point(525, 144);
            this.txt_NombreIngresado.Name = "txt_NombreIngresado";
            this.txt_NombreIngresado.Size = new System.Drawing.Size(252, 20);
            this.txt_NombreIngresado.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Vista.Properties.Resources.CajaTexto;
            this.pictureBox2.Location = new System.Drawing.Point(516, 133);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(272, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 33;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Vista.Properties.Resources.CajaDescripcion;
            this.pictureBox3.Location = new System.Drawing.Point(516, 215);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(272, 172);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 34;
            this.pictureBox3.TabStop = false;
            // 
            // pb_Guardar
            // 
            this.pb_Guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(97)))), ((int)(((byte)(142)))));
            this.pb_Guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pb_Guardar.Enabled = false;
            this.pb_Guardar.Image = global::Vista.Properties.Resources.icons8_guardar_30;
            this.pb_Guardar.Location = new System.Drawing.Point(524, 406);
            this.pb_Guardar.Name = "pb_Guardar";
            this.pb_Guardar.Size = new System.Drawing.Size(25, 25);
            this.pb_Guardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Guardar.TabIndex = 36;
            this.pb_Guardar.TabStop = false;
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
            this.btn_Guardar.Location = new System.Drawing.Point(516, 399);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(272, 39);
            this.btn_Guardar.TabIndex = 35;
            this.btn_Guardar.Text = "GUARDAR";
            this.btn_Guardar.UseVisualStyleBackColor = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            this.btn_Guardar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Guardar_MouseDown);
            this.btn_Guardar.MouseLeave += new System.EventHandler(this.btn_Guardar_MouseLeave);
            this.btn_Guardar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_Guardar_MouseMove);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 450);
            this.panel1.TabIndex = 37;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(797, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 415);
            this.panel2.TabIndex = 38;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(18)))), ((int)(((byte)(27)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 447);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(794, 3);
            this.panel3.TabIndex = 39;
            // 
            // FrmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnl_Top);
            this.Controls.Add(this.pb_Guardar);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.txt_NombreIngresado);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txt_DescripcionIngresado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pb_Editar);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.pb_Eliminar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.pb_Mas);
            this.Controls.Add(this.btn_NuevoProducto);
            this.Controls.Add(this.dgv_TablaCategoria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pb_Vender);
            this.Controls.Add(this.txt_Buscar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categorias";
            this.Load += new System.EventHandler(this.FrmCategoria_Load);
            this.pnl_Top.ResumeLayout(false);
            this.pnl_Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Closed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Vender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_TablaCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Mas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Eliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Editar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Guardar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnl_Top;
        private System.Windows.Forms.PictureBox pb_Restaurar;
        private System.Windows.Forms.PictureBox pb_Minimizar;
        private System.Windows.Forms.PictureBox pb_Maximizar;
        private System.Windows.Forms.PictureBox pb_Exit;
        private System.Windows.Forms.PictureBox pb_Closed;
        private System.Windows.Forms.TextBox txt_Buscar;
        private System.Windows.Forms.PictureBox pb_Vender;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_TablaCategoria;
        private System.Windows.Forms.Button btn_NuevoProducto;
        private System.Windows.Forms.PictureBox pb_Mas;
        private System.Windows.Forms.PictureBox pb_Eliminar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.PictureBox pb_Editar;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_DescripcionIngresado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_NombreIngresado;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pb_Guardar;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}