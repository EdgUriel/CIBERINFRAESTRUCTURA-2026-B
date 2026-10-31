namespace AviVet
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
            tabModulos = new TabControl();
            tabPropietarios = new TabPage();
            tabAves = new TabPage();
            tabConsultas = new TabPage();
            lblNombreProp = new Label();
            txtNombreProp = new TextBox();
            lblTelefono = new Label();
            txtTelefono = new TextBox();
            btnAgregarProp = new Button();
            btnModificarProp = new Button();
            btnEliminarProp = new Button();
            btnLimpiarProp = new Button();
            btnRecargarProp = new Button();
            dgvPropietarios = new DataGridView();
            lblNombreAve = new Label();
            txtNombreAve = new TextBox();
            lblEspecie = new Label();
            txtEspecie = new TextBox();
            lblPropietarioAve = new Label();
            cmbPropietarios = new ComboBox();
            btnAgregarAve = new Button();
            btnModificarAve = new Button();
            btnEliminarAve = new Button();
            btnLimpiarAve = new Button();
            btnRecargarAve = new Button();
            dgvAves = new DataGridView();
            lblAveConsulta = new Label();
            cmbAves = new ComboBox();
            lblMotivo = new Label();
            txtMotivo = new TextBox();
            lblDiagnostico = new Label();
            txtDiagnostico = new TextBox();
            btnAgregarConsulta = new Button();
            btnModificarConsulta = new Button();
            btnEliminarConsulta = new Button();
            btnLimpiarConsulta = new Button();
            btnRecargarConsulta = new Button();
            dgvConsultas = new DataGridView();
            tabModulos.SuspendLayout();
            tabPropietarios.SuspendLayout();
            tabAves.SuspendLayout();
            tabConsultas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPropietarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAves).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvConsultas).BeginInit();
            SuspendLayout();
            // 
            // tabModulos
            // 
            tabModulos.Controls.Add(tabPropietarios);
            tabModulos.Controls.Add(tabAves);
            tabModulos.Controls.Add(tabConsultas);
            tabModulos.Dock = DockStyle.Fill;
            tabModulos.Location = new Point(0, 0);
            tabModulos.Name = "tabModulos";
            tabModulos.SelectedIndex = 0;
            tabModulos.Size = new Size(1034, 661);
            tabModulos.TabIndex = 0;
            // 
            // tabPropietarios
            // 
            tabPropietarios.Controls.Add(dgvPropietarios);
            tabPropietarios.Controls.Add(btnRecargarProp);
            tabPropietarios.Controls.Add(btnLimpiarProp);
            tabPropietarios.Controls.Add(btnEliminarProp);
            tabPropietarios.Controls.Add(btnModificarProp);
            tabPropietarios.Controls.Add(btnAgregarProp);
            tabPropietarios.Controls.Add(txtTelefono);
            tabPropietarios.Controls.Add(lblTelefono);
            tabPropietarios.Controls.Add(txtNombreProp);
            tabPropietarios.Controls.Add(lblNombreProp);
            tabPropietarios.Location = new Point(4, 24);
            tabPropietarios.Name = "tabPropietarios";
            tabPropietarios.Padding = new Padding(3);
            tabPropietarios.Size = new Size(1026, 633);
            tabPropietarios.TabIndex = 0;
            tabPropietarios.Text = "Propietarios";
            tabPropietarios.UseVisualStyleBackColor = true;
            // 
            // tabAves
            // 
            tabAves.Controls.Add(dgvAves);
            tabAves.Controls.Add(btnRecargarAve);
            tabAves.Controls.Add(btnLimpiarAve);
            tabAves.Controls.Add(btnEliminarAve);
            tabAves.Controls.Add(btnModificarAve);
            tabAves.Controls.Add(btnAgregarAve);
            tabAves.Controls.Add(cmbPropietarios);
            tabAves.Controls.Add(lblPropietarioAve);
            tabAves.Controls.Add(txtEspecie);
            tabAves.Controls.Add(lblEspecie);
            tabAves.Controls.Add(txtNombreAve);
            tabAves.Controls.Add(lblNombreAve);
            tabAves.Location = new Point(4, 24);
            tabAves.Name = "tabAves";
            tabAves.Padding = new Padding(3);
            tabAves.Size = new Size(1026, 633);
            tabAves.TabIndex = 1;
            tabAves.Text = "Aves";
            tabAves.UseVisualStyleBackColor = true;
            // 
            // tabConsultas
            // 
            tabConsultas.Controls.Add(dgvConsultas);
            tabConsultas.Controls.Add(btnRecargarConsulta);
            tabConsultas.Controls.Add(btnLimpiarConsulta);
            tabConsultas.Controls.Add(btnEliminarConsulta);
            tabConsultas.Controls.Add(btnModificarConsulta);
            tabConsultas.Controls.Add(btnAgregarConsulta);
            tabConsultas.Controls.Add(txtDiagnostico);
            tabConsultas.Controls.Add(lblDiagnostico);
            tabConsultas.Controls.Add(txtMotivo);
            tabConsultas.Controls.Add(lblMotivo);
            tabConsultas.Controls.Add(cmbAves);
            tabConsultas.Controls.Add(lblAveConsulta);
            tabConsultas.Location = new Point(4, 24);
            tabConsultas.Name = "tabConsultas";
            tabConsultas.Size = new Size(1026, 633);
            tabConsultas.TabIndex = 2;
            tabConsultas.Text = "Consultas";
            tabConsultas.UseVisualStyleBackColor = true;
            // 
            // lblNombreProp
            // 
            lblNombreProp.AutoSize = true;
            lblNombreProp.Location = new Point(28, 36);
            lblNombreProp.Name = "lblNombreProp";
            lblNombreProp.Size = new Size(154, 15);
            lblNombreProp.TabIndex = 0;
            lblNombreProp.Text = "Nombre del propietario:";
            // 
            // txtNombreProp
            // 
            txtNombreProp.Location = new Point(28, 60);
            txtNombreProp.MaxLength = 100;
            txtNombreProp.Name = "txtNombreProp";
            txtNombreProp.Size = new Size(365, 23);
            txtNombreProp.TabIndex = 1;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(423, 36);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(54, 15);
            lblTelefono.TabIndex = 2;
            lblTelefono.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(423, 60);
            txtTelefono.MaxLength = 20;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(260, 23);
            txtTelefono.TabIndex = 3;
            // 
            // btnAgregarProp
            // 
            btnAgregarProp.Location = new Point(28, 115);
            btnAgregarProp.Name = "btnAgregarProp";
            btnAgregarProp.Size = new Size(120, 32);
            btnAgregarProp.TabIndex = 4;
            btnAgregarProp.Text = "Agregar";
            btnAgregarProp.UseVisualStyleBackColor = true;
            // 
            // btnModificarProp
            // 
            btnModificarProp.Location = new Point(160, 115);
            btnModificarProp.Name = "btnModificarProp";
            btnModificarProp.Size = new Size(120, 32);
            btnModificarProp.TabIndex = 5;
            btnModificarProp.Text = "Modificar";
            btnModificarProp.UseVisualStyleBackColor = true;
            // 
            // btnEliminarProp
            // 
            btnEliminarProp.Location = new Point(292, 115);
            btnEliminarProp.Name = "btnEliminarProp";
            btnEliminarProp.Size = new Size(120, 32);
            btnEliminarProp.TabIndex = 6;
            btnEliminarProp.Text = "Eliminar";
            btnEliminarProp.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarProp
            // 
            btnLimpiarProp.Location = new Point(424, 115);
            btnLimpiarProp.Name = "btnLimpiarProp";
            btnLimpiarProp.Size = new Size(120, 32);
            btnLimpiarProp.TabIndex = 7;
            btnLimpiarProp.Text = "Limpiar";
            btnLimpiarProp.UseVisualStyleBackColor = true;
            // 
            // btnRecargarProp
            // 
            btnRecargarProp.Location = new Point(556, 115);
            btnRecargarProp.Name = "btnRecargarProp";
            btnRecargarProp.Size = new Size(120, 32);
            btnRecargarProp.TabIndex = 8;
            btnRecargarProp.Text = "Recargar";
            btnRecargarProp.UseVisualStyleBackColor = true;
            // 
            // dgvPropietarios
            // 
            dgvPropietarios.AllowUserToAddRows = false;
            dgvPropietarios.AllowUserToDeleteRows = false;
            dgvPropietarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPropietarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPropietarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPropietarios.Location = new Point(28, 170);
            dgvPropietarios.MultiSelect = false;
            dgvPropietarios.Name = "dgvPropietarios";
            dgvPropietarios.ReadOnly = true;
            dgvPropietarios.RowHeadersVisible = false;
            dgvPropietarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPropietarios.Size = new Size(965, 415);
            dgvPropietarios.TabIndex = 9;
            // 
            // lblNombreAve
            // 
            lblNombreAve.AutoSize = true;
            lblNombreAve.Location = new Point(28, 36);
            lblNombreAve.Name = "lblNombreAve";
            lblNombreAve.Size = new Size(97, 15);
            lblNombreAve.TabIndex = 0;
            lblNombreAve.Text = "Nombre del ave:";
            // 
            // txtNombreAve
            // 
            txtNombreAve.Location = new Point(28, 60);
            txtNombreAve.MaxLength = 80;
            txtNombreAve.Name = "txtNombreAve";
            txtNombreAve.Size = new Size(270, 23);
            txtNombreAve.TabIndex = 1;
            // 
            // lblEspecie
            // 
            lblEspecie.AutoSize = true;
            lblEspecie.Location = new Point(322, 36);
            lblEspecie.Name = "lblEspecie";
            lblEspecie.Size = new Size(50, 15);
            lblEspecie.TabIndex = 2;
            lblEspecie.Text = "Especie:";
            // 
            // txtEspecie
            // 
            txtEspecie.Location = new Point(322, 60);
            txtEspecie.MaxLength = 80;
            txtEspecie.Name = "txtEspecie";
            txtEspecie.Size = new Size(270, 23);
            txtEspecie.TabIndex = 3;
            // 
            // lblPropietarioAve
            // 
            lblPropietarioAve.AutoSize = true;
            lblPropietarioAve.Location = new Point(616, 36);
            lblPropietarioAve.Name = "lblPropietarioAve";
            lblPropietarioAve.Size = new Size(73, 15);
            lblPropietarioAve.TabIndex = 4;
            lblPropietarioAve.Text = "Propietario:";
            // 
            // cmbPropietarios
            // 
            cmbPropietarios.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPropietarios.FormattingEnabled = true;
            cmbPropietarios.Location = new Point(616, 60);
            cmbPropietarios.Name = "cmbPropietarios";
            cmbPropietarios.Size = new Size(340, 23);
            cmbPropietarios.TabIndex = 5;
            // 
            // btnAgregarAve
            // 
            btnAgregarAve.Location = new Point(28, 115);
            btnAgregarAve.Name = "btnAgregarAve";
            btnAgregarAve.Size = new Size(120, 32);
            btnAgregarAve.TabIndex = 6;
            btnAgregarAve.Text = "Agregar";
            btnAgregarAve.UseVisualStyleBackColor = true;
            // 
            // btnModificarAve
            // 
            btnModificarAve.Location = new Point(160, 115);
            btnModificarAve.Name = "btnModificarAve";
            btnModificarAve.Size = new Size(120, 32);
            btnModificarAve.TabIndex = 7;
            btnModificarAve.Text = "Modificar";
            btnModificarAve.UseVisualStyleBackColor = true;
            // 
            // btnEliminarAve
            // 
            btnEliminarAve.Location = new Point(292, 115);
            btnEliminarAve.Name = "btnEliminarAve";
            btnEliminarAve.Size = new Size(120, 32);
            btnEliminarAve.TabIndex = 8;
            btnEliminarAve.Text = "Eliminar";
            btnEliminarAve.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarAve
            // 
            btnLimpiarAve.Location = new Point(424, 115);
            btnLimpiarAve.Name = "btnLimpiarAve";
            btnLimpiarAve.Size = new Size(120, 32);
            btnLimpiarAve.TabIndex = 9;
            btnLimpiarAve.Text = "Limpiar";
            btnLimpiarAve.UseVisualStyleBackColor = true;
            // 
            // btnRecargarAve
            // 
            btnRecargarAve.Location = new Point(556, 115);
            btnRecargarAve.Name = "btnRecargarAve";
            btnRecargarAve.Size = new Size(120, 32);
            btnRecargarAve.TabIndex = 10;
            btnRecargarAve.Text = "Recargar";
            btnRecargarAve.UseVisualStyleBackColor = true;
            // 
            // dgvAves
            // 
            dgvAves.AllowUserToAddRows = false;
            dgvAves.AllowUserToDeleteRows = false;
            dgvAves.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAves.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAves.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAves.Location = new Point(28, 170);
            dgvAves.MultiSelect = false;
            dgvAves.Name = "dgvAves";
            dgvAves.ReadOnly = true;
            dgvAves.RowHeadersVisible = false;
            dgvAves.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAves.Size = new Size(965, 415);
            dgvAves.TabIndex = 11;
            // 
            // lblAveConsulta
            // 
            lblAveConsulta.AutoSize = true;
            lblAveConsulta.Location = new Point(28, 30);
            lblAveConsulta.Name = "lblAveConsulta";
            lblAveConsulta.Size = new Size(29, 15);
            lblAveConsulta.TabIndex = 0;
            lblAveConsulta.Text = "Ave:";
            // 
            // cmbAves
            // 
            cmbAves.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAves.FormattingEnabled = true;
            cmbAves.Location = new Point(28, 54);
            cmbAves.Name = "cmbAves";
            cmbAves.Size = new Size(290, 23);
            cmbAves.TabIndex = 1;
            // 
            // lblMotivo
            // 
            lblMotivo.AutoSize = true;
            lblMotivo.Location = new Point(342, 30);
            lblMotivo.Name = "lblMotivo";
            lblMotivo.Size = new Size(116, 15);
            lblMotivo.TabIndex = 2;
            lblMotivo.Text = "Motivo de consulta:";
            // 
            // txtMotivo
            // 
            txtMotivo.Location = new Point(342, 54);
            txtMotivo.MaxLength = 200;
            txtMotivo.Name = "txtMotivo";
            txtMotivo.Size = new Size(614, 23);
            txtMotivo.TabIndex = 3;
            // 
            // lblDiagnostico
            // 
            lblDiagnostico.AutoSize = true;
            lblDiagnostico.Location = new Point(28, 98);
            lblDiagnostico.Name = "lblDiagnostico";
            lblDiagnostico.Size = new Size(75, 15);
            lblDiagnostico.TabIndex = 4;
            lblDiagnostico.Text = "Diagnóstico:";
            // 
            // txtDiagnostico
            // 
            txtDiagnostico.Location = new Point(28, 122);
            txtDiagnostico.MaxLength = 200;
            txtDiagnostico.Name = "txtDiagnostico";
            txtDiagnostico.Size = new Size(928, 23);
            txtDiagnostico.TabIndex = 5;
            // 
            // btnAgregarConsulta
            // 
            btnAgregarConsulta.Location = new Point(28, 175);
            btnAgregarConsulta.Name = "btnAgregarConsulta";
            btnAgregarConsulta.Size = new Size(120, 32);
            btnAgregarConsulta.TabIndex = 6;
            btnAgregarConsulta.Text = "Agregar";
            btnAgregarConsulta.UseVisualStyleBackColor = true;
            // 
            // btnModificarConsulta
            // 
            btnModificarConsulta.Location = new Point(160, 175);
            btnModificarConsulta.Name = "btnModificarConsulta";
            btnModificarConsulta.Size = new Size(120, 32);
            btnModificarConsulta.TabIndex = 7;
            btnModificarConsulta.Text = "Modificar";
            btnModificarConsulta.UseVisualStyleBackColor = true;
            // 
            // btnEliminarConsulta
            // 
            btnEliminarConsulta.Location = new Point(292, 175);
            btnEliminarConsulta.Name = "btnEliminarConsulta";
            btnEliminarConsulta.Size = new Size(120, 32);
            btnEliminarConsulta.TabIndex = 8;
            btnEliminarConsulta.Text = "Eliminar";
            btnEliminarConsulta.UseVisualStyleBackColor = true;
            // 
            // btnLimpiarConsulta
            // 
            btnLimpiarConsulta.Location = new Point(424, 175);
            btnLimpiarConsulta.Name = "btnLimpiarConsulta";
            btnLimpiarConsulta.Size = new Size(120, 32);
            btnLimpiarConsulta.TabIndex = 9;
            btnLimpiarConsulta.Text = "Limpiar";
            btnLimpiarConsulta.UseVisualStyleBackColor = true;
            // 
            // btnRecargarConsulta
            // 
            btnRecargarConsulta.Location = new Point(556, 175);
            btnRecargarConsulta.Name = "btnRecargarConsulta";
            btnRecargarConsulta.Size = new Size(120, 32);
            btnRecargarConsulta.TabIndex = 10;
            btnRecargarConsulta.Text = "Recargar";
            btnRecargarConsulta.UseVisualStyleBackColor = true;
            // 
            // dgvConsultas
            // 
            dgvConsultas.AllowUserToAddRows = false;
            dgvConsultas.AllowUserToDeleteRows = false;
            dgvConsultas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvConsultas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvConsultas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultas.Location = new Point(28, 230);
            dgvConsultas.MultiSelect = false;
            dgvConsultas.Name = "dgvConsultas";
            dgvConsultas.ReadOnly = true;
            dgvConsultas.RowHeadersVisible = false;
            dgvConsultas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvConsultas.Size = new Size(965, 355);
            dgvConsultas.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 661);
            Controls.Add(tabModulos);
            Name = "Form1";
            Text = "AviVet - Veterinaria de Aves";
            ((System.ComponentModel.ISupportInitialize)dgvPropietarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAves).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvConsultas).EndInit();
            tabPropietarios.ResumeLayout(false);
            tabPropietarios.PerformLayout();
            tabAves.ResumeLayout(false);
            tabAves.PerformLayout();
            tabConsultas.ResumeLayout(false);
            tabConsultas.PerformLayout();
            tabModulos.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabModulos;
        private TabPage tabPropietarios;
        private TabPage tabAves;
        private TabPage tabConsultas;
        private Label lblNombreProp;
        private TextBox txtNombreProp;
        private Label lblTelefono;
        private TextBox txtTelefono;
        private Button btnAgregarProp;
        private Button btnModificarProp;
        private Button btnEliminarProp;
        private Button btnLimpiarProp;
        private Button btnRecargarProp;
        private DataGridView dgvPropietarios;
        private Label lblNombreAve;
        private TextBox txtNombreAve;
        private Label lblEspecie;
        private TextBox txtEspecie;
        private Label lblPropietarioAve;
        private ComboBox cmbPropietarios;
        private Button btnAgregarAve;
        private Button btnModificarAve;
        private Button btnEliminarAve;
        private Button btnLimpiarAve;
        private Button btnRecargarAve;
        private DataGridView dgvAves;
        private Label lblAveConsulta;
        private ComboBox cmbAves;
        private Label lblMotivo;
        private TextBox txtMotivo;
        private Label lblDiagnostico;
        private TextBox txtDiagnostico;
        private Button btnAgregarConsulta;
        private Button btnModificarConsulta;
        private Button btnEliminarConsulta;
        private Button btnLimpiarConsulta;
        private Button btnRecargarConsulta;
        private DataGridView dgvConsultas;
    }
}
