namespace Farmacia
{
    partial class ABMC
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
            btnNuevo = new Button();
            btnEditar = new Button();
            btnGrabar = new Button();
            btnBorrar = new Button();
            btnSalir = new Button();
            gb = new GroupBox();
            textBox1 = new TextBox();
            label11 = new Label();
            cboTipoProducto = new ComboBox();
            label9 = new Label();
            label10 = new Label();
            cboUnidadMedida = new ComboBox();
            label8 = new Label();
            chkBajoReceta = new CheckBox();
            nudStockMinimo = new NumericUpDown();
            nudStockActual = new NumericUpDown();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            dtpFec_vencimiento = new DateTimePicker();
            label4 = new Label();
            chkHabilitado = new CheckBox();
            txtPrecioUnitario = new TextBox();
            label3 = new Label();
            txtDescripcion = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtID = new TextBox();
            dataGridView1 = new DataGridView();
            gb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudStockMinimo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudStockActual).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(18, 502);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(75, 23);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(144, 502);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(75, 23);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new Point(414, 502);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(75, 23);
            btnGrabar.TabIndex = 3;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(275, 502);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(75, 23);
            btnBorrar.TabIndex = 2;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(554, 502);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // gb
            // 
            gb.Controls.Add(textBox1);
            gb.Controls.Add(label11);
            gb.Controls.Add(cboTipoProducto);
            gb.Controls.Add(label9);
            gb.Controls.Add(label10);
            gb.Controls.Add(cboUnidadMedida);
            gb.Controls.Add(label8);
            gb.Controls.Add(chkBajoReceta);
            gb.Controls.Add(nudStockMinimo);
            gb.Controls.Add(nudStockActual);
            gb.Controls.Add(label7);
            gb.Controls.Add(label6);
            gb.Controls.Add(label5);
            gb.Controls.Add(dtpFec_vencimiento);
            gb.Controls.Add(label4);
            gb.Controls.Add(chkHabilitado);
            gb.Controls.Add(txtPrecioUnitario);
            gb.Controls.Add(label3);
            gb.Controls.Add(txtDescripcion);
            gb.Controls.Add(label2);
            gb.Controls.Add(label1);
            gb.Controls.Add(txtID);
            gb.Location = new Point(18, 12);
            gb.Name = "gb";
            gb.Size = new Size(294, 469);
            gb.TabIndex = 5;
            gb.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(90, 346);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(183, 23);
            textBox1.TabIndex = 45;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(21, 349);
            label11.Name = "label11";
            label11.Size = new Size(63, 15);
            label11.TabIndex = 44;
            label11.Text = "Descuento";
            // 
            // cboTipoProducto
            // 
            cboTipoProducto.FormattingEnabled = true;
            cboTipoProducto.Location = new Point(125, 305);
            cboTipoProducto.Name = "cboTipoProducto";
            cboTipoProducto.Size = new Size(148, 23);
            cboTipoProducto.TabIndex = 43;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(21, 308);
            label9.Name = "label9";
            label9.Size = new Size(98, 15);
            label9.TabIndex = 42;
            label9.Text = "Tipo de Producto";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(20, 266);
            label10.Name = "label10";
            label10.Size = new Size(104, 15);
            label10.TabIndex = 41;
            label10.Text = "Unidad de Medida";
            // 
            // cboUnidadMedida
            // 
            cboUnidadMedida.FormattingEnabled = true;
            cboUnidadMedida.Location = new Point(130, 263);
            cboUnidadMedida.Name = "cboUnidadMedida";
            cboUnidadMedida.Size = new Size(143, 23);
            cboUnidadMedida.TabIndex = 40;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 427);
            label8.Name = "label8";
            label8.Size = new Size(68, 15);
            label8.TabIndex = 39;
            label8.Text = "Bajo Receta";
            // 
            // chkBajoReceta
            // 
            chkBajoReceta.AutoSize = true;
            chkBajoReceta.Checked = true;
            chkBajoReceta.CheckState = CheckState.Checked;
            chkBajoReceta.Location = new Point(75, 428);
            chkBajoReceta.Name = "chkBajoReceta";
            chkBajoReceta.Size = new Size(15, 14);
            chkBajoReceta.TabIndex = 38;
            chkBajoReceta.UseVisualStyleBackColor = true;
            // 
            // nudStockMinimo
            // 
            nudStockMinimo.Location = new Point(111, 221);
            nudStockMinimo.Name = "nudStockMinimo";
            nudStockMinimo.Size = new Size(161, 23);
            nudStockMinimo.TabIndex = 37;
            // 
            // nudStockActual
            // 
            nudStockActual.Location = new Point(111, 183);
            nudStockActual.Name = "nudStockActual";
            nudStockActual.Size = new Size(161, 23);
            nudStockActual.TabIndex = 36;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 223);
            label7.Name = "label7";
            label7.Size = new Size(81, 15);
            label7.TabIndex = 35;
            label7.Text = "Stock Minimo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 185);
            label6.Name = "label6";
            label6.Size = new Size(73, 15);
            label6.TabIndex = 34;
            label6.Text = "Stock Actual";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 149);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 33;
            label5.Text = "Vencimiento";
            // 
            // dtpFec_vencimiento
            // 
            dtpFec_vencimiento.Format = DateTimePickerFormat.Short;
            dtpFec_vencimiento.Location = new Point(111, 143);
            dtpFec_vencimiento.Name = "dtpFec_vencimiento";
            dtpFec_vencimiento.Size = new Size(161, 23);
            dtpFec_vencimiento.TabIndex = 32;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(159, 426);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 31;
            label4.Text = "Estado";
            // 
            // chkHabilitado
            // 
            chkHabilitado.AutoSize = true;
            chkHabilitado.Checked = true;
            chkHabilitado.CheckState = CheckState.Checked;
            chkHabilitado.Location = new Point(207, 425);
            chkHabilitado.Name = "chkHabilitado";
            chkHabilitado.Size = new Size(81, 19);
            chkHabilitado.TabIndex = 30;
            chkHabilitado.Text = "Habilitado";
            chkHabilitado.UseVisualStyleBackColor = true;
            // 
            // txtPrecioUnitario
            // 
            txtPrecioUnitario.Enabled = false;
            txtPrecioUnitario.Location = new Point(111, 102);
            txtPrecioUnitario.Name = "txtPrecioUnitario";
            txtPrecioUnitario.Size = new Size(161, 23);
            txtPrecioUnitario.TabIndex = 29;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 105);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 28;
            label3.Text = "Precio Unitario";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Enabled = false;
            txtDescripcion.Location = new Point(95, 61);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(177, 23);
            txtDescripcion.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 64);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 26;
            label2.Text = "Descripcion";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(108, 27);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 25;
            label1.Text = "ID";
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(132, 24);
            txtID.Name = "txtID";
            txtID.Size = new Size(51, 23);
            txtID.TabIndex = 24;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(321, 20);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(308, 461);
            dataGridView1.TabIndex = 6;
            // 
            // ABMC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 537);
            Controls.Add(dataGridView1);
            Controls.Add(gb);
            Controls.Add(btnSalir);
            Controls.Add(btnGrabar);
            Controls.Add(btnBorrar);
            Controls.Add(btnEditar);
            Controls.Add(btnNuevo);
            Name = "ABMC";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ABMC";
            gb.ResumeLayout(false);
            gb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudStockMinimo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudStockActual).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnNuevo;
        private Button btnEditar;
        private Button btnGrabar;
        private Button btnBorrar;
        private Button btnSalir;
        private GroupBox gb;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Label label11;
        private ComboBox cboTipoProducto;
        private Label label9;
        private Label label10;
        private ComboBox cboUnidadMedida;
        private Label label8;
        private CheckBox chkBajoReceta;
        private NumericUpDown nudStockMinimo;
        private NumericUpDown nudStockActual;
        private Label label7;
        private Label label6;
        private Label label5;
        private DateTimePicker dtpFec_vencimiento;
        private Label label4;
        private CheckBox chkHabilitado;
        private TextBox txtPrecioUnitario;
        private Label label3;
        private TextBox txtDescripcion;
        private Label label2;
        private Label label1;
        private TextBox txtID;
    }
}