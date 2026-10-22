namespace parcial_1_Impuestos
{
    partial class Form1
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
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.grdAlumnos = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscarAlumnos = new System.Windows.Forms.TextBox();
            this.grbEdicionAlumno = new System.Windows.Forms.GroupBox();
            this.btnAgregarAlumno = new System.Windows.Forms.Button();
            this.btnModificarAlumno = new System.Windows.Forms.Button();
            this.btnEliminarAlumno = new System.Windows.Forms.Button();
            this.grbNavegacionAlumno = new System.Windows.Forms.GroupBox();
            this.btnPrimeroAlumno = new System.Windows.Forms.Button();
            this.btnAnteriorAlumno = new System.Windows.Forms.Button();
            this.lblnRegistrosAlumno = new System.Windows.Forms.Label();
            this.btnSiguienteAlumno = new System.Windows.Forms.Button();
            this.btnUltimoAlumno = new System.Windows.Forms.Button();
            this.grbDatosAlumno = new System.Windows.Forms.GroupBox();
            this.lblId = new System.Windows.Forms.Label();
            this.idAlumno = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigoAlumno = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombreAlumno = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccionAlumno = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtTelefonoAlumno = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdAlumnos)).BeginInit();
            this.grbEdicionAlumno.SuspendLayout();
            this.grbNavegacionAlumno.SuspendLayout();
            this.grbDatosAlumno.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblBusqueda.Location = new System.Drawing.Point(382, 16);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(114, 13);
            this.lblBusqueda.TabIndex = 3;
            this.lblBusqueda.Text = "Busqueda Alumnos";
            // 
            // grdAlumnos
            // 
            this.grdAlumnos.AllowUserToAddRows = false;
            this.grdAlumnos.AllowUserToDeleteRows = false;
            this.grdAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.codigo,
            this.nombre,
            this.direccion,
            this.telefono});
            this.grdAlumnos.Location = new System.Drawing.Point(382, 64);
            this.grdAlumnos.Name = "grdAlumnos";
            this.grdAlumnos.ReadOnly = true;
            this.grdAlumnos.RowHeadersWidth = 51;
            this.grdAlumnos.Size = new System.Drawing.Size(380, 192);
            this.grdAlumnos.TabIndex = 5;
            // 
            // id
            // 
            this.id.DataPropertyName = "idAlumno";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 125;
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "CODIGO";
            this.codigo.MinimumWidth = 6;
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 125;
            // 
            // nombre
            // 
            this.nombre.DataPropertyName = "nombre";
            this.nombre.HeaderText = "NOMBRE";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 125;
            // 
            // direccion
            // 
            this.direccion.DataPropertyName = "direccion";
            this.direccion.HeaderText = "DIRECCION";
            this.direccion.MinimumWidth = 6;
            this.direccion.Name = "direccion";
            this.direccion.ReadOnly = true;
            this.direccion.Width = 125;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "TEL";
            this.telefono.MinimumWidth = 6;
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            this.telefono.Width = 125;
            // 
            // txtBuscarAlumnos
            // 
            this.txtBuscarAlumnos.Location = new System.Drawing.Point(382, 34);
            this.txtBuscarAlumnos.Name = "txtBuscarAlumnos";
            this.txtBuscarAlumnos.Size = new System.Drawing.Size(380, 20);
            this.txtBuscarAlumnos.TabIndex = 7;
            // 
            // grbEdicionAlumno
            // 
            this.grbEdicionAlumno.Controls.Add(this.btnAgregarAlumno);
            this.grbEdicionAlumno.Controls.Add(this.btnModificarAlumno);
            this.grbEdicionAlumno.Controls.Add(this.btnEliminarAlumno);
            this.grbEdicionAlumno.Location = new System.Drawing.Point(482, 264);
            this.grbEdicionAlumno.Name = "grbEdicionAlumno";
            this.grbEdicionAlumno.Size = new System.Drawing.Size(280, 60);
            this.grbEdicionAlumno.TabIndex = 8;
            this.grbEdicionAlumno.TabStop = false;
            this.grbEdicionAlumno.Text = "Edicion";
            // 
            // btnAgregarAlumno
            // 
            this.btnAgregarAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnAgregarAlumno.Location = new System.Drawing.Point(10, 18);
            this.btnAgregarAlumno.Name = "btnAgregarAlumno";
            this.btnAgregarAlumno.Size = new System.Drawing.Size(80, 32);
            this.btnAgregarAlumno.TabIndex = 0;
            this.btnAgregarAlumno.Text = "Nuevo";
            // 
            // btnModificarAlumno
            // 
            this.btnModificarAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnModificarAlumno.Location = new System.Drawing.Point(96, 18);
            this.btnModificarAlumno.Name = "btnModificarAlumno";
            this.btnModificarAlumno.Size = new System.Drawing.Size(84, 32);
            this.btnModificarAlumno.TabIndex = 1;
            this.btnModificarAlumno.Text = "Modificar";
            // 
            // btnEliminarAlumno
            // 
            this.btnEliminarAlumno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnEliminarAlumno.Location = new System.Drawing.Point(186, 18);
            this.btnEliminarAlumno.Name = "btnEliminarAlumno";
            this.btnEliminarAlumno.Size = new System.Drawing.Size(84, 32);
            this.btnEliminarAlumno.TabIndex = 2;
            this.btnEliminarAlumno.Text = "Eliminar";
            // 
            // grbNavegacionAlumno
            // 
            this.grbNavegacionAlumno.Controls.Add(this.btnPrimeroAlumno);
            this.grbNavegacionAlumno.Controls.Add(this.btnAnteriorAlumno);
            this.grbNavegacionAlumno.Controls.Add(this.lblnRegistrosAlumno);
            this.grbNavegacionAlumno.Controls.Add(this.btnSiguienteAlumno);
            this.grbNavegacionAlumno.Controls.Add(this.btnUltimoAlumno);
            this.grbNavegacionAlumno.Location = new System.Drawing.Point(14, 264);
            this.grbNavegacionAlumno.Name = "grbNavegacionAlumno";
            this.grbNavegacionAlumno.Size = new System.Drawing.Size(250, 60);
            this.grbNavegacionAlumno.TabIndex = 6;
            this.grbNavegacionAlumno.TabStop = false;
            this.grbNavegacionAlumno.Text = "Navegacion";
            // 
            // btnPrimeroAlumno
            // 
            this.btnPrimeroAlumno.Location = new System.Drawing.Point(25, 20);
            this.btnPrimeroAlumno.Name = "btnPrimeroAlumno";
            this.btnPrimeroAlumno.Size = new System.Drawing.Size(32, 28);
            this.btnPrimeroAlumno.TabIndex = 0;
            this.btnPrimeroAlumno.Text = "|<";
            // 
            // btnAnteriorAlumno
            // 
            this.btnAnteriorAlumno.Location = new System.Drawing.Point(63, 20);
            this.btnAnteriorAlumno.Name = "btnAnteriorAlumno";
            this.btnAnteriorAlumno.Size = new System.Drawing.Size(32, 28);
            this.btnAnteriorAlumno.TabIndex = 1;
            this.btnAnteriorAlumno.Text = "<";
            // 
            // lblnRegistrosAlumno
            // 
            this.lblnRegistrosAlumno.AutoSize = true;
            this.lblnRegistrosAlumno.Location = new System.Drawing.Point(101, 28);
            this.lblnRegistrosAlumno.Name = "lblnRegistrosAlumno";
            this.lblnRegistrosAlumno.Size = new System.Drawing.Size(37, 13);
            this.lblnRegistrosAlumno.TabIndex = 2;
            this.lblnRegistrosAlumno.Text = "1 de 1";
            // 
            // btnSiguienteAlumno
            // 
            this.btnSiguienteAlumno.Location = new System.Drawing.Point(150, 20);
            this.btnSiguienteAlumno.Name = "btnSiguienteAlumno";
            this.btnSiguienteAlumno.Size = new System.Drawing.Size(32, 28);
            this.btnSiguienteAlumno.TabIndex = 3;
            this.btnSiguienteAlumno.Text = ">";
            // 
            // btnUltimoAlumno
            // 
            this.btnUltimoAlumno.Location = new System.Drawing.Point(188, 20);
            this.btnUltimoAlumno.Name = "btnUltimoAlumno";
            this.btnUltimoAlumno.Size = new System.Drawing.Size(32, 28);
            this.btnUltimoAlumno.TabIndex = 4;
            this.btnUltimoAlumno.Text = ">|";
            // 
            // grbDatosAlumno
            // 
            this.grbDatosAlumno.Controls.Add(this.lblId);
            this.grbDatosAlumno.Controls.Add(this.idAlumno);
            this.grbDatosAlumno.Controls.Add(this.lblCodigo);
            this.grbDatosAlumno.Controls.Add(this.txtCodigoAlumno);
            this.grbDatosAlumno.Controls.Add(this.lblNombre);
            this.grbDatosAlumno.Controls.Add(this.txtNombreAlumno);
            this.grbDatosAlumno.Controls.Add(this.lblDireccion);
            this.grbDatosAlumno.Controls.Add(this.txtDireccionAlumno);
            this.grbDatosAlumno.Controls.Add(this.lblTel);
            this.grbDatosAlumno.Controls.Add(this.txtTelefonoAlumno);
            this.grbDatosAlumno.Location = new System.Drawing.Point(14, 16);
            this.grbDatosAlumno.Name = "grbDatosAlumno";
            this.grbDatosAlumno.Size = new System.Drawing.Size(350, 240);
            this.grbDatosAlumno.TabIndex = 4;
            this.grbDatosAlumno.TabStop = false;
            this.grbDatosAlumno.Text = "DATOS";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(20, 30);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID:";
            // 
            // idAlumno
            // 
            this.idAlumno.AutoSize = true;
            this.idAlumno.Location = new System.Drawing.Point(100, 30);
            this.idAlumno.Name = "idAlumno";
            this.idAlumno.Size = new System.Drawing.Size(13, 13);
            this.idAlumno.TabIndex = 1;
            this.idAlumno.Text = "1";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(20, 63);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(52, 13);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "CODIGO:";
            // 
            // txtCodigoAlumno
            // 
            this.txtCodigoAlumno.Location = new System.Drawing.Point(100, 60);
            this.txtCodigoAlumno.Name = "txtCodigoAlumno";
            this.txtCodigoAlumno.Size = new System.Drawing.Size(120, 20);
            this.txtCodigoAlumno.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(20, 103);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(57, 13);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "NOMBRE:";
            // 
            // txtNombreAlumno
            // 
            this.txtNombreAlumno.Location = new System.Drawing.Point(100, 100);
            this.txtNombreAlumno.Name = "txtNombreAlumno";
            this.txtNombreAlumno.Size = new System.Drawing.Size(220, 20);
            this.txtNombreAlumno.TabIndex = 5;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(20, 143);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(69, 13);
            this.lblDireccion.TabIndex = 6;
            this.lblDireccion.Text = "DIRECCION:";
            // 
            // txtDireccionAlumno
            // 
            this.txtDireccionAlumno.Location = new System.Drawing.Point(100, 140);
            this.txtDireccionAlumno.Name = "txtDireccionAlumno";
            this.txtDireccionAlumno.Size = new System.Drawing.Size(220, 20);
            this.txtDireccionAlumno.TabIndex = 7;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(20, 183);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(30, 13);
            this.lblTel.TabIndex = 8;
            this.lblTel.Text = "TEL:";
            // 
            // txtTelefonoAlumno
            // 
            this.txtTelefonoAlumno.Location = new System.Drawing.Point(100, 180);
            this.txtTelefonoAlumno.Name = "txtTelefonoAlumno";
            this.txtTelefonoAlumno.Size = new System.Drawing.Size(120, 20);
            this.txtTelefonoAlumno.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.grdAlumnos);
            this.Controls.Add(this.txtBuscarAlumnos);
            this.Controls.Add(this.grbEdicionAlumno);
            this.Controls.Add(this.grbNavegacionAlumno);
            this.Controls.Add(this.grbDatosAlumno);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grdAlumnos)).EndInit();
            this.grbEdicionAlumno.ResumeLayout(false);
            this.grbNavegacionAlumno.ResumeLayout(false);
            this.grbNavegacionAlumno.PerformLayout();
            this.grbDatosAlumno.ResumeLayout(false);
            this.grbDatosAlumno.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.DataGridView grdAlumnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.TextBox txtBuscarAlumnos;
        private System.Windows.Forms.GroupBox grbEdicionAlumno;
        private System.Windows.Forms.Button btnAgregarAlumno;
        private System.Windows.Forms.Button btnModificarAlumno;
        private System.Windows.Forms.Button btnEliminarAlumno;
        private System.Windows.Forms.GroupBox grbNavegacionAlumno;
        private System.Windows.Forms.Button btnPrimeroAlumno;
        private System.Windows.Forms.Button btnAnteriorAlumno;
        private System.Windows.Forms.Label lblnRegistrosAlumno;
        private System.Windows.Forms.Button btnSiguienteAlumno;
        private System.Windows.Forms.Button btnUltimoAlumno;
        private System.Windows.Forms.GroupBox grbDatosAlumno;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label idAlumno;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigoAlumno;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombreAlumno;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccionAlumno;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtTelefonoAlumno;
    }
}