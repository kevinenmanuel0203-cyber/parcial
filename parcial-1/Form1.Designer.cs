namespace parcial_1
{
    partial class Form1
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
            lblCantidad = new Label();
            txtCantidad = new TextBox();
            lblRespuesta = new Label();
            cboDe = new ComboBox();
            cboA = new ComboBox();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // lblCantidad
            // 
            lblCantidad.AutoSize = true;
            lblCantidad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCantidad.Location = new Point(27, 31);
            lblCantidad.Name = "lblCantidad";
            lblCantidad.Size = new Size(75, 21);
            lblCantidad.TabIndex = 0;
            lblCantidad.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(108, 31);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 1;
            // 
            // lblRespuesta
            // 
            lblRespuesta.AutoSize = true;
            lblRespuesta.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRespuesta.Location = new Point(413, 36);
            lblRespuesta.Name = "lblRespuesta";
            lblRespuesta.Size = new Size(24, 21);
            lblRespuesta.TabIndex = 2;
            lblRespuesta.Text = "¿?";
            // 
            // cboDe
            // 
            cboDe.FormattingEnabled = true;
            cboDe.Location = new Point(91, 97);
            cboDe.Name = "cboDe";
            cboDe.Size = new Size(121, 23);
            cboDe.TabIndex = 3;
            // 
            // cboA
            // 
            cboA.FormattingEnabled = true;
            cboA.Location = new Point(91, 145);
            cboA.Name = "cboA";
            cboA.Size = new Size(121, 23);
            cboA.TabIndex = 4;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(316, 96);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(91, 42);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(316, 148);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(91, 40);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 100);
            label1.Name = "label1";
            label1.Size = new Size(24, 15);
            label1.TabIndex = 7;
            label1.Text = "De:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 148);
            label2.Name = "label2";
            label2.Size = new Size(18, 15);
            label2.TabIndex = 8;
            label2.Text = "A:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(316, 36);
            label3.Name = "label3";
            label3.Size = new Size(91, 21);
            label3.TabIndex = 9;
            label3.Text = "Respuesta:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 308);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(cboA);
            Controls.Add(cboDe);
            Controls.Add(lblRespuesta);
            Controls.Add(txtCantidad);
            Controls.Add(lblCantidad);
            Name = "Form1";
            Text = "Conversor de Arèa (Superficie)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCantidad;
        private TextBox txtCantidad;
        private Label lblRespuesta;
        private ComboBox cboDe;
        private ComboBox cboA;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
