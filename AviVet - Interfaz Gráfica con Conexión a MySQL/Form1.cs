
using System;
using System.Data;
using System.Windows.Forms;
using MySqlConnector;

namespace AviVet
{
    public partial class Form1 : Form
    {
        // Guarda el ID de la fila seleccionada en cada módulo.
        private int? idPropietarioSeleccionado;
        private int? idAveSeleccionada;
        private int? idConsultaSeleccionada;

        public Form1()
        {
            InitializeComponent();

            // Propietarios
            btnAgregarProp.Click += (_, _) => EjecutarSeguro(() => GuardarPropietario(false));
            btnModificarProp.Click += (_, _) => EjecutarSeguro(() => GuardarPropietario(true));
            btnEliminarProp.Click += (_, _) => EjecutarSeguro(() => Eliminar(
                idPropietarioSeleccionado,
                "DELETE FROM propietarios WHERE id_propietario = @id"));
            btnLimpiarProp.Click += (_, _) => LimpiarPropietario();
            btnRecargarProp.Click += (_, _) => EjecutarSeguro(CargarDatos);
            dgvPropietarios.CellClick += SeleccionarPropietario;

            // Aves
            btnAgregarAve.Click += (_, _) => EjecutarSeguro(() => GuardarAve(false));
            btnModificarAve.Click += (_, _) => EjecutarSeguro(() => GuardarAve(true));
            btnEliminarAve.Click += (_, _) => EjecutarSeguro(() => Eliminar(
                idAveSeleccionada,
                "DELETE FROM aves WHERE id_ave = @id"));
            btnLimpiarAve.Click += (_, _) => LimpiarAve();
            btnRecargarAve.Click += (_, _) => EjecutarSeguro(CargarDatos);
            dgvAves.CellClick += SeleccionarAve;

            // Consultas
            btnAgregarConsulta.Click += (_, _) => EjecutarSeguro(() => GuardarConsulta(false));
            btnModificarConsulta.Click += (_, _) => EjecutarSeguro(() => GuardarConsulta(true));
            btnEliminarConsulta.Click += (_, _) => EjecutarSeguro(() => Eliminar(
                idConsultaSeleccionada,
                "DELETE FROM consultas WHERE id_consulta = @id"));
            btnLimpiarConsulta.Click += (_, _) => LimpiarConsulta();
            btnRecargarConsulta.Click += (_, _) => EjecutarSeguro(CargarDatos);
            dgvConsultas.CellClick += SeleccionarConsulta;

            // Cargar información al abrir el formulario.
            Shown += (_, _) => EjecutarSeguro(CargarDatos);
        }

        // Consultar la base de datos
        private void CargarDatos()
        {
            dgvPropietarios.DataSource = BaseDatos.Consultar(
                "SELECT id_propietario, nombre, telefono " +
                "FROM propietarios ORDER BY id_propietario DESC");

            dgvAves.DataSource = BaseDatos.Consultar(
                "SELECT a.id_ave, a.nombre, a.especie, a.id_propietario, " +
                "p.nombre AS propietario " +
                "FROM aves a INNER JOIN propietarios p " +
                "ON a.id_propietario = p.id_propietario " +
                "ORDER BY a.id_ave DESC");

            dgvConsultas.DataSource = BaseDatos.Consultar(
                "SELECT c.id_consulta, c.fecha_consulta, c.id_ave, " +
                "a.nombre AS ave, c.motivo, c.diagnostico " +
                "FROM consultas c INNER JOIN aves a ON c.id_ave = a.id_ave " +
                "ORDER BY c.id_consulta DESC");

            // Mostrar nombres sencillos en los encabezados.
            CambiarTitulo(dgvPropietarios, "id_propietario", "ID");
            CambiarTitulo(dgvPropietarios, "nombre", "Nombre");
            CambiarTitulo(dgvPropietarios, "telefono", "Teléfono");
            CambiarTitulo(dgvAves, "id_ave", "ID");
            CambiarTitulo(dgvAves, "nombre", "Nombre");
            CambiarTitulo(dgvAves, "especie", "Especie");
            CambiarTitulo(dgvAves, "propietario", "Propietario");
            CambiarTitulo(dgvConsultas, "id_consulta", "ID");
            CambiarTitulo(dgvConsultas, "fecha_consulta", "Fecha");
            CambiarTitulo(dgvConsultas, "ave", "Ave");
            CambiarTitulo(dgvConsultas, "motivo", "Motivo");
            CambiarTitulo(dgvConsultas, "diagnostico", "Diagnóstico");

            // Los IDs de relación se necesitan internamente,
            // pero no hace falta mostrarlos dos veces en la tabla.
            if (dgvAves.Columns["id_propietario"] is { } columnaPropietario)
                columnaPropietario.Visible = false;

            if (dgvConsultas.Columns["id_ave"] is { } columnaAve)
                columnaAve.Visible = false;

            // Llenar los ComboBox con los registros reales de MySQL.
            cmbPropietarios.DisplayMember = "etiqueta";
            cmbPropietarios.ValueMember = "id_propietario";
            cmbPropietarios.DataSource = BaseDatos.Consultar(
                "SELECT id_propietario, " +
                "CONCAT(nombre, ' (#', id_propietario, ')') AS etiqueta " +
                "FROM propietarios ORDER BY nombre");

            cmbAves.DisplayMember = "etiqueta";
            cmbAves.ValueMember = "id_ave";
            cmbAves.DataSource = BaseDatos.Consultar(
                "SELECT id_ave, " +
                "CONCAT(nombre, ' - ', especie, ' (#', id_ave, ')') AS etiqueta " +
                "FROM aves ORDER BY nombre");

            LimpiarPropietario();
            LimpiarAve();
            LimpiarConsulta();
        }

        // Agregar / modificar propietarios
        private void GuardarPropietario(bool modificar)
        {
            if (modificar && !ValidarSeleccion(idPropietarioSeleccionado))
                return;

            if (string.IsNullOrWhiteSpace(txtNombreProp.Text))
            {
                Aviso("Escribe el nombre del propietario.");
                txtNombreProp.Focus();
                return;
            }

            string nombre = txtNombreProp.Text.Trim();
            object? telefono = ValorOpcional(txtTelefono.Text);

            if (modificar)
            {
                BaseDatos.Ejecutar(
                    "UPDATE propietarios SET nombre = @nombre, telefono = @telefono " +
                    "WHERE id_propietario = @id",
                    ("@nombre", nombre), ("@telefono", telefono),
                    ("@id", idPropietarioSeleccionado));
            }
            else
            {
                BaseDatos.Ejecutar(
                    "INSERT INTO propietarios (nombre, telefono) " +
                    "VALUES (@nombre, @telefono)",
                    ("@nombre", nombre), ("@telefono", telefono));
            }

            CargarDatos();
            Aviso(modificar ? "Propietario modificado." : "Propietario registrado.");
        }

        // Agregar / modificar aves
        private void GuardarAve(bool modificar)
        {
            if (modificar && !ValidarSeleccion(idAveSeleccionada))
                return;

            if (string.IsNullOrWhiteSpace(txtNombreAve.Text) ||
                string.IsNullOrWhiteSpace(txtEspecie.Text))
            {
                Aviso("Escribe el nombre y la especie del ave.");
                return;
            }

            if (cmbPropietarios.SelectedValue is not int idPropietario)
            {
                Aviso("Selecciona un propietario. Si no aparece, regístralo primero.");
                return;
            }

            if (modificar)
            {
                BaseDatos.Ejecutar(
                    "UPDATE aves SET nombre = @nombre, especie = @especie, " +
                    "id_propietario = @propietario WHERE id_ave = @id",
                    ("@nombre", txtNombreAve.Text.Trim()),
                    ("@especie", txtEspecie.Text.Trim()),
                    ("@propietario", idPropietario),
                    ("@id", idAveSeleccionada));
            }
            else
            {
                BaseDatos.Ejecutar(
                    "INSERT INTO aves (nombre, especie, id_propietario) " +
                    "VALUES (@nombre, @especie, @propietario)",
                    ("@nombre", txtNombreAve.Text.Trim()),
                    ("@especie", txtEspecie.Text.Trim()),
                    ("@propietario", idPropietario));
            }

            CargarDatos();
            Aviso(modificar ? "Ave modificada." : "Ave registrada.");
        }

        // Agregar / modificar consultas
        private void GuardarConsulta(bool modificar)
        {
            if (modificar && !ValidarSeleccion(idConsultaSeleccionada))
                return;

            if (cmbAves.SelectedValue is not int idAve)
            {
                Aviso("Selecciona un ave. Si no aparece, regístrala primero.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtMotivo.Text))
            {
                Aviso("Escribe el motivo de la consulta.");
                txtMotivo.Focus();
                return;
            }

            object? diagnostico = ValorOpcional(txtDiagnostico.Text);

            if (modificar)
            {
                BaseDatos.Ejecutar(
                    "UPDATE consultas SET id_ave = @ave, motivo = @motivo, " +
                    "diagnostico = @diagnostico WHERE id_consulta = @id",
                    ("@ave", idAve),
                    ("@motivo", txtMotivo.Text.Trim()),
                    ("@diagnostico", diagnostico),
                    ("@id", idConsultaSeleccionada));
            }
            else
            {
                // fecha_consulta se llena automáticamente en MySQL.
                BaseDatos.Ejecutar(
                    "INSERT INTO consultas (id_ave, motivo, diagnostico) " +
                    "VALUES (@ave, @motivo, @diagnostico)",
                    ("@ave", idAve),
                    ("@motivo", txtMotivo.Text.Trim()),
                    ("@diagnostico", diagnostico));
            }

            CargarDatos();
            Aviso(modificar ? "Consulta modificada." : "Consulta registrada.");
        }

        // ====================================
        // Eliminar registros
        // ====================================
        private void Eliminar(int? id, string consultaSql)
        {
            if (!ValidarSeleccion(id))
                return;

            if (MessageBox.Show(
                    "¿Seguro que deseas eliminar el registro seleccionado?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            // La instrucción SQL llega del código, nunca del usuario.
            BaseDatos.Ejecutar(consultaSql, ("@id", id));
            CargarDatos();
            Aviso("Registro eliminado.");
        }

        // ====================================
        // Pasar datos de la tabla al formulario
        // ====================================
        private void SeleccionarPropietario(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 ||
                dgvPropietarios.Rows[e.RowIndex].DataBoundItem is not DataRowView fila)
                return;

            idPropietarioSeleccionado = Convert.ToInt32(fila["id_propietario"]);
            txtNombreProp.Text = Convert.ToString(fila["nombre"]) ?? "";
            txtTelefono.Text = Convert.ToString(fila["telefono"]) ?? "";
        }

        private void SeleccionarAve(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 ||
                dgvAves.Rows[e.RowIndex].DataBoundItem is not DataRowView fila)
                return;

            idAveSeleccionada = Convert.ToInt32(fila["id_ave"]);
            txtNombreAve.Text = Convert.ToString(fila["nombre"]) ?? "";
            txtEspecie.Text = Convert.ToString(fila["especie"]) ?? "";
            cmbPropietarios.SelectedValue = Convert.ToInt32(fila["id_propietario"]);
        }

        private void SeleccionarConsulta(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 ||
                dgvConsultas.Rows[e.RowIndex].DataBoundItem is not DataRowView fila)
                return;

            idConsultaSeleccionada = Convert.ToInt32(fila["id_consulta"]);
            cmbAves.SelectedValue = Convert.ToInt32(fila["id_ave"]);
            txtMotivo.Text = Convert.ToString(fila["motivo"]) ?? "";
            txtDiagnostico.Text = Convert.ToString(fila["diagnostico"]) ?? "";
        }

        // ====================================
        // Limpiar formularios
        // ====================================
        private void LimpiarPropietario()
        {
            idPropietarioSeleccionado = null;
            txtNombreProp.Clear();
            txtTelefono.Clear();
            dgvPropietarios.ClearSelection();
        }

        private void LimpiarAve()
        {
            idAveSeleccionada = null;
            txtNombreAve.Clear();
            txtEspecie.Clear();
            cmbPropietarios.SelectedIndex = -1;
            dgvAves.ClearSelection();
        }

        private void LimpiarConsulta()
        {
            idConsultaSeleccionada = null;
            cmbAves.SelectedIndex = -1;
            txtMotivo.Clear();
            txtDiagnostico.Clear();
            dgvConsultas.ClearSelection();
        }

        // ====================================
        // Utilidades y manejo de errores
        // ====================================
        private static object? ValorOpcional(string texto) =>
            string.IsNullOrWhiteSpace(texto) ? null : texto.Trim();

        private static bool ValidarSeleccion(int? id)
        {
            if (id.HasValue) return true;
            Aviso("Selecciona primero una fila de la tabla.");
            return false;
        }

        private static void CambiarTitulo(DataGridView tabla, string columna, string titulo)
        {
            if (tabla.Columns[columna] is DataGridViewColumn encabezado)
                encabezado.HeaderText = titulo;
        }

        private static void Aviso(string mensaje) =>
            MessageBox.Show(mensaje, "AviVet", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

        private static void EjecutarSeguro(Action accion)
        {
            try
            {
                accion();
            }
            catch (MySqlException ex) when (ex.Number == 1451)
            {
                MessageBox.Show(
                    "No puedes eliminar este registro porque tiene otros relacionados. " +
                    "Elimina primero sus consultas o aves asociadas.",
                    "Registro en uso", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error de MySQL: " + ex.Message,
                    "Error de base de datos", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message,
                    "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
