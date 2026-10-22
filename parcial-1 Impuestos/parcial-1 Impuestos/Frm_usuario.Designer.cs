namespace parcial_1_Impuestos
{
    partial class Frm_usuario
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtconfirmarclave = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.usuarios_usss075226DataSet = new parcial_1_Impuestos.usuarios_usss075226DataSet();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new parcial_1_Impuestos.usuarios_usss075226DataSetTableAdapters.TableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grbEdicionAlumno.SuspendLayout();
            this.grbNavegacionAlumno.SuspendLayout();
            this.grbDatosAlumno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarios_usss075226DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.direccion,
            this.telefono});
            this.dataGridView1.DataSource = this.tableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(397, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(425, 192);
            this.dataGridView1.TabIndex = 11;
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
            // grbEdicionAlumno
            // 
            this.grbEdicionAlumno.Controls.Add(this.btnAgregarAlumno);
            this.grbEdicionAlumno.Controls.Add(this.btnModificarAlumno);
            this.grbEdicionAlumno.Controls.Add(this.btnEliminarAlumno);
            this.grbEdicionAlumno.Location = new System.Drawing.Point(478, 366);
            this.grbEdicionAlumno.Name = "grbEdicionAlumno";
            this.grbEdicionAlumno.Size = new System.Drawing.Size(280, 60);
            this.grbEdicionAlumno.TabIndex = 14;
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
            this.grbNavegacionAlumno.Location = new System.Drawing.Point(24, 378);
            this.grbNavegacionAlumno.Name = "grbNavegacionAlumno";
            this.grbNavegacionAlumno.Size = new System.Drawing.Size(250, 60);
            this.grbNavegacionAlumno.TabIndex = 12;
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
            this.grbDatosAlumno.Controls.Add(this.label1);
            this.grbDatosAlumno.Controls.Add(this.txtdireccion);
            this.grbDatosAlumno.Controls.Add(this.label2);
            this.grbDatosAlumno.Controls.Add(this.txttelefono);
            this.grbDatosAlumno.Controls.Add(this.lblId);
            this.grbDatosAlumno.Controls.Add(this.txtid);
            this.grbDatosAlumno.Controls.Add(this.lblCodigo);
            this.grbDatosAlumno.Controls.Add(this.txtusuario);
            this.grbDatosAlumno.Controls.Add(this.lblNombre);
            this.grbDatosAlumno.Controls.Add(this.txtclave);
            this.grbDatosAlumno.Controls.Add(this.lblDireccion);
            this.grbDatosAlumno.Controls.Add(this.txtconfirmarclave);
            this.grbDatosAlumno.Controls.Add(this.lblTel);
            this.grbDatosAlumno.Controls.Add(this.txtnombre);
            this.grbDatosAlumno.Location = new System.Drawing.Point(10, 26);
            this.grbDatosAlumno.Name = "grbDatosAlumno";
            this.grbDatosAlumno.Size = new System.Drawing.Size(381, 333);
            this.grbDatosAlumno.TabIndex = 10;
            this.grbDatosAlumno.TabStop = false;
            this.grbDatosAlumno.Text = "DATOS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "DIRECCION:";
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(128, 214);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(220, 20);
            this.txtdireccion.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "TELEFONO:";
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(128, 250);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(120, 20);
            this.txttelefono.TabIndex = 13;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(98, 30);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 13);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID:";
            // 
            // txtid
            // 
            this.txtid.AutoSize = true;
            this.txtid.Location = new System.Drawing.Point(125, 30);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(13, 13);
            this.txtid.TabIndex = 1;
            this.txtid.Text = "1";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(63, 63);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(59, 13);
            this.lblCodigo.TabIndex = 2;
            this.lblCodigo.Text = "USUARIO:";
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(128, 60);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(120, 20);
            this.txtusuario.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(78, 103);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "CLAVE:";
            // 
            // txtclave
            // 
            this.txtclave.Location = new System.Drawing.Point(128, 100);
            this.txtclave.Name = "txtclave";
            this.txtclave.Size = new System.Drawing.Size(220, 20);
            this.txtclave.TabIndex = 5;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(11, 143);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(111, 13);
            this.lblDireccion.TabIndex = 6;
            this.lblDireccion.Text = "CONFIRMAR CLAVE:";
            // 
            // txtconfirmarclave
            // 
            this.txtconfirmarclave.Location = new System.Drawing.Point(128, 140);
            this.txtconfirmarclave.Name = "txtconfirmarclave";
            this.txtconfirmarclave.Size = new System.Drawing.Size(220, 20);
            this.txtconfirmarclave.TabIndex = 7;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(65, 183);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(57, 13);
            this.lblTel.TabIndex = 8;
            this.lblTel.Text = "NOMBRE:";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(128, 180);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(120, 20);
            this.txtnombre.TabIndex = 9;
            // 
            // usuarios_usss075226DataSet
            // 
            this.usuarios_usss075226DataSet.DataSetName = "usuarios_usss075226DataSet";
            this.usuarios_usss075226DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.usuarios_usss075226DataSet;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 516);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.grbEdicionAlumno);
            this.Controls.Add(this.grbNavegacionAlumno);
            this.Controls.Add(this.grbDatosAlumno);
            this.Name = "Frm_usuario";
            this.Text = "Frm_usuario";
            this.Load += new System.EventHandler(this.Frm_usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grbEdicionAlumno.ResumeLayout(false);
            this.grbNavegacionAlumno.ResumeLayout(false);
            this.grbNavegacionAlumno.PerformLayout();
            this.grbDatosAlumno.ResumeLayout(false);
            this.grbDatosAlumno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarios_usss075226DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
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
        private System.Windows.Forms.Label txtid;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtconfirmarclave;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttelefono;
        private usuarios_usss075226DataSet usuarios_usss075226DataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private usuarios_usss075226DataSetTableAdapters.TableTableAdapter tableTableAdapter;
    }
}