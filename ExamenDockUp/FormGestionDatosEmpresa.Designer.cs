using System.Windows.Forms;

namespace DatosEmpresa
{
    partial class FormGestionDatosEmpresa
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAgregarVen = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRif = new System.Windows.Forms.TextBox();
            this.txtNomEmpresa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEliminarCelda = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.PictureBox();
            this.dtgvEmpleados = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarVen
            // 
            this.btnAgregarVen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAgregarVen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarVen.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAgregarVen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarVen.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarVen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAgregarVen.Location = new System.Drawing.Point(391, 52);
            this.btnAgregarVen.Margin = new System.Windows.Forms.Padding(0);
            this.btnAgregarVen.Name = "btnAgregarVen";
            this.btnAgregarVen.Size = new System.Drawing.Size(151, 30);
            this.btnAgregarVen.TabIndex = 1;
            this.btnAgregarVen.Text = "Agregar Vendedor";
            this.btnAgregarVen.UseVisualStyleBackColor = false;
            this.btnAgregarVen.Click += new System.EventHandler(this.btnAgregarVen_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(255, 73);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 20);
            this.linkLabel1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtCorreo);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtRif);
            this.groupBox1.Controls.Add(this.txtNomEmpresa);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(580, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 346);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de la Empresa";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label8.Location = new System.Drawing.Point(6, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 19);
            this.label8.TabIndex = 19;
            this.label8.Text = "Correo Electronico";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.txtCorreo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtCorreo.Location = new System.Drawing.Point(15, 245);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(227, 25);
            this.txtCorreo.TabIndex = 18;
            this.txtCorreo.Text = "No Asignado";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.txtDireccion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDireccion.Location = new System.Drawing.Point(15, 183);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(227, 25);
            this.txtDireccion.TabIndex = 17;
            this.txtDireccion.Text = "No Asignada";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.RosyBrown;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Location = new System.Drawing.Point(62, 289);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(127, 32);
            this.btnGuardar.TabIndex = 11;
            this.btnGuardar.Text = "Guardar Datos";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label5.Location = new System.Drawing.Point(6, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "Direccion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label7.Location = new System.Drawing.Point(6, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Rif";
            // 
            // txtRif
            // 
            this.txtRif.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.txtRif.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtRif.Location = new System.Drawing.Point(15, 121);
            this.txtRif.Name = "txtRif";
            this.txtRif.Size = new System.Drawing.Size(227, 25);
            this.txtRif.TabIndex = 14;
            this.txtRif.Text = "No Asignado";
            // 
            // txtNomEmpresa
            // 
            this.txtNomEmpresa.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.txtNomEmpresa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtNomEmpresa.Location = new System.Drawing.Point(15, 61);
            this.txtNomEmpresa.Name = "txtNomEmpresa";
            this.txtNomEmpresa.Size = new System.Drawing.Size(227, 25);
            this.txtNomEmpresa.TabIndex = 11;
            this.txtNomEmpresa.Text = "TuProductoOnline";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F);
            this.label6.Location = new System.Drawing.Point(42, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.Location = new System.Drawing.Point(6, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nombre de la Empresa";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft PhagsPa", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(21, 42);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.richTextBox1.Size = new System.Drawing.Size(272, 50);
            this.richTextBox1.TabIndex = 22;
            this.richTextBox1.Text = "De manera Predeterminada los Empleados Agregados \na la Base de Datos de la Empres" +
    "a Tendran como\nUsuario y Clave: Su Cedula de Identidad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Lista de Empleados";
            // 
            // lblEliminarCelda
            // 
            this.lblEliminarCelda.AutoSize = true;
            this.lblEliminarCelda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEliminarCelda.ForeColor = System.Drawing.Color.Red;
            this.lblEliminarCelda.Location = new System.Drawing.Point(17, 349);
            this.lblEliminarCelda.Name = "lblEliminarCelda";
            this.lblEliminarCelda.Size = new System.Drawing.Size(94, 20);
            this.lblEliminarCelda.TabIndex = 25;
            this.lblEliminarCelda.Text = "Eliminar Fila";
            this.lblEliminarCelda.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Image = global::ExamenDockUp.Properties.Resources.botonX;
            this.btnEliminar.Location = new System.Drawing.Point(109, 340);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(43, 38);
            this.btnEliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEliminar.TabIndex = 24;
            this.btnEliminar.TabStop = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dtgvEmpleados
            // 
            this.dtgvEmpleados.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.dtgvEmpleados.AllowUserToAddRows = false;
            this.dtgvEmpleados.AllowUserToDeleteRows = false;
            this.dtgvEmpleados.AllowUserToResizeRows = false;
            this.dtgvEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvEmpleados.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dtgvEmpleados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgvEmpleados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dtgvEmpleados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dtgvEmpleados.ColumnHeadersHeight = 36;
            this.dtgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dtgvEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellido,
            this.Cedula});
            this.dtgvEmpleados.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dtgvEmpleados.Location = new System.Drawing.Point(21, 98);
            this.dtgvEmpleados.MultiSelect = false;
            this.dtgvEmpleados.Name = "dtgvEmpleados";
            this.dtgvEmpleados.RowHeadersWidth = 20;
            this.dtgvEmpleados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgvEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvEmpleados.Size = new System.Drawing.Size(539, 240);
            this.dtgvEmpleados.TabIndex = 26;
            this.dtgvEmpleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvEmpleados_CellClick);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            // 
            // Cedula
            // 
            this.Cedula.HeaderText = "Cedula de Identidad";
            this.Cedula.Name = "Cedula";
            // 
            // FormGestionDatosEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 382);
            this.Controls.Add(this.dtgvEmpleados);
            this.Controls.Add(this.lblEliminarCelda);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.btnAgregarVen);
            this.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Name = "FormGestionDatosEmpresa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos de la Empresa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnAgregarVen;
        private LinkLabel linkLabel1;
        private GroupBox groupBox1;
        private Label label7;
        private TextBox txtRif;
        private TextBox txtNomEmpresa;
        private Label label6;
        private Label label4;
        private Button btnGuardar;
        private Label label5;
        private Label label8;
        private TextBox txtCorreo;
        private TextBox txtDireccion;
        private RichTextBox richTextBox1;
        private Label label1;
        private PictureBox btnEliminar;
        private Label lblEliminarCelda;
        private DataGridView dtgvEmpleados;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Cedula;
    }
}