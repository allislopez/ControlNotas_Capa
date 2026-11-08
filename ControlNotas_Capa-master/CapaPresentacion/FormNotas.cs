using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FormNotas : Form
    {
        private CN_Calificaciones objetoCN = new CN_Calificaciones();
        private string idDocenteLogueado;

        private DataTable dtCalificacionesGlobal = new DataTable();
        private string idCalificacionSeleccionada = null;

        private bool cargandoCombo = false;

        public FormNotas(string idDocente)
        {
            InitializeComponent();
            idDocenteLogueado = idDocente;
        }

        private void FormNotas_Load(object sender, EventArgs e)
        {
            CargarDatosTabla();
        }

        private void CargarDatosTabla()
        {
            dtCalificacionesGlobal =
                objetoCN.MostrarCalificacionesDocente(idDocenteLogueado);

            cargandoCombo = true;

            CargarFiltroCursos();

            if (cboCursos.Items.Count > 0)
            {
                cboCursos.SelectedIndex = 0;
            }

            cargandoCombo = false;

            MostrarResumenTodosLosCursos();
        }

        private void CargarFiltroCursos()
        {
            if (dtCalificacionesGlobal != null &&
                dtCalificacionesGlobal.Rows.Count > 0)
            {
                DataView dvMaterias = new DataView(dtCalificacionesGlobal);

                DataTable dtMateriasUnicas =
                    dvMaterias.ToTable(true, "Nombre_Materia");

                DataRow filaTodos = dtMateriasUnicas.NewRow();

                filaTodos["Nombre_Materia"] = "-- Todos los cursos --";

                dtMateriasUnicas.Rows.InsertAt(filaTodos, 0);

                cboCursos.DataSource = null;
                cboCursos.DataSource = dtMateriasUnicas;

                cboCursos.DisplayMember = "Nombre_Materia";
                cboCursos.ValueMember = "Nombre_Materia";
            }
        }

        // MOSTRAR LOS 5 ESTUDIANTES SIN REPETIR
        private void MostrarResumenTodosLosCursos()
        {
            DataView vistaCompleta = new DataView(dtCalificacionesGlobal);

            vistaCompleta.RowFilter = "";
            vistaCompleta.Sort = "Id_Estudiante ASC";

            DataTable resumen = new DataTable();

            resumen.Columns.Add("N°", typeof(int));
            resumen.Columns.Add("Id_Estudiante");
            resumen.Columns.Add("Estudiante");

            // Obtener todas las materias
            DataTable materias = vistaCompleta.ToTable(
                true, "Nombre_Materia");

            foreach (DataRow materia in materias.Rows)
            {
                string nombreMateria =
                    materia["Nombre_Materia"].ToString();

                resumen.Columns.Add(nombreMateria);
            }

            // Obtener estudiantes sin repetir y ordenados
            DataTable estudiantes = vistaCompleta.ToTable(
                true, "Id_Estudiante", "Estudiante");

            DataView vistaEstudiantes = new DataView(estudiantes);
            vistaEstudiantes.Sort = "Id_Estudiante ASC";

            foreach (DataRowView estudiante in vistaEstudiantes)
            {
                DataRow nuevaFila = resumen.NewRow();

                string idEstudiante =
                    estudiante["Id_Estudiante"].ToString();

                nuevaFila["N°"] = resumen.Rows.Count + 1;

                nuevaFila["Id_Estudiante"] = idEstudiante;

                nuevaFila["Estudiante"] =
                    estudiante["Estudiante"].ToString();

                foreach (DataRow materia in materias.Rows)
                {
                    string nombreMateria =
                        materia["Nombre_Materia"].ToString();

                    string materiaFiltro =
                        nombreMateria.Replace("'", "''");

                    DataRow[] calificacion = dtCalificacionesGlobal.Select(
                        $"Id_Estudiante = '{idEstudiante}' AND Nombre_Materia = '{materiaFiltro}'");

                    if (calificacion.Length > 0)
                    {
                        nuevaFila[nombreMateria] =
                            calificacion[0]["Promedio"];
                    }
                    else
                    {
                        nuevaFila[nombreMateria] = 0;
                    }
                }

                resumen.Rows.Add(nuevaFila);
            }

            dgvCalificaciones.DataSource = resumen;

            // Ocultar el ID del estudiante
            if (dgvCalificaciones.Columns.Contains("Id_Estudiante"))
            {
                dgvCalificaciones.Columns["Id_Estudiante"].Visible = false;
            }
        }

        // FILTRO DE CURSOS
        private void cboCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cargandoCombo ||
                cboCursos.SelectedValue == null ||
                dtCalificacionesGlobal.Rows.Count == 0)
            {
                return;
            }

            string cursoSeleccionado =
                cboCursos.SelectedValue.ToString();

            if (cursoSeleccionado == "-- Todos los cursos --")
            {
                MostrarResumenTodosLosCursos();
            }
            else
            {
                // Crear una vista independiente para cada materia
                DataView dvFiltro = new DataView(dtCalificacionesGlobal);

                dvFiltro.RowFilter =
                    $"Nombre_Materia = '{cursoSeleccionado.Replace("'", "''")}'";

                // Mantener el orden de los estudiantes
                dvFiltro.Sort = "Id_Estudiante ASC";

                DataTable tablaCurso = dvFiltro.ToTable();

                // Agregar numeración consecutiva
                tablaCurso.Columns.Add("N°", typeof(int));
                tablaCurso.Columns["N°"].SetOrdinal(0);

                for (int i = 0; i < tablaCurso.Rows.Count; i++)
                {
                    tablaCurso.Rows[i]["N°"] = i + 1;
                }

                dgvCalificaciones.DataSource = tablaCurso;

                // Ocultar los identificadores
                if (dgvCalificaciones.Columns.Contains("Id_Califcacion"))
                {
                    dgvCalificaciones.Columns["Id_Califcacion"].Visible = false;
                }

                if (dgvCalificaciones.Columns.Contains("Id_Estudiante"))
                {
                    dgvCalificaciones.Columns["Id_Estudiante"].Visible = false;
                }
            }

            idCalificacionSeleccionada = null;
            LimpiarCampos();
        }

        // SELECCIONAR ESTUDIANTE
        private void dgvCalificaciones_CellClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (cboCursos.SelectedValue == null ||
                cboCursos.SelectedValue.ToString() == "-- Todos los cursos --")
            {
                MessageBox.Show(
                    "Seleccione un curso individual para editar sus calificaciones.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                return;
            }

            DataGridViewRow fila = dgvCalificaciones.Rows[e.RowIndex];

            // Obtener el ID real aunque esté oculto
            idCalificacionSeleccionada =
                fila.Cells["Id_Califcacion"].Value?.ToString().Trim();

            txtNota1.Text =
                fila.Cells["Nota_1"].Value?.ToString() ?? "";

            txtNota2.Text =
                fila.Cells["Nota_2"].Value?.ToString() ?? "";

            txtExamen.Text =
                fila.Cells["Examen"].Value?.ToString() ?? "";
        }

        // GUARDAR NOTAS
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (idCalificacionSeleccionada != null)
            {
                try
                {
                    objetoCN.GuardarNotas(
                        idCalificacionSeleccionada,
                        txtNota1.Text,
                        txtNota2.Text,
                        txtExamen.Text);

                    MessageBox.Show(
                        "Se actualizó correctamente",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    CargarDatosTabla();
                    LimpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Error al guardar: " + ex.Message,
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(
                    "Por favor, seleccione un estudiante de un curso primero.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void LimpiarCampos()
        {
            txtNota1.Clear();
            txtNota2.Clear();
            txtExamen.Clear();

            idCalificacionSeleccionada = null;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvCalificaciones_CellContentClick(
            object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}