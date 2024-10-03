using System;
using System.Data;
using System.Windows.Forms;

namespace PonderaciónConDataTable
{
    public partial class Form1 : Form
    {
        DataColumn columnna;
        DataTable estudiantes = new DataTable("Estudiantes");
        public Form1()
        {
            InitializeComponent();

            columnna = new DataColumn
            {
                ColumnName = "ID",
                DataType = typeof(int),
                AutoIncrement = true,
                ReadOnly = true,
                Unique = true
            };
            estudiantes.Columns.Add(columnna);

            columnna = new DataColumn
            {
                ColumnName = "Nombre",
                DataType = typeof(string),
                AutoIncrement = false
            };
            estudiantes.Columns.Add(columnna);

            columnna = new DataColumn
            {
                ColumnName = "Asignatura",
                DataType = typeof(string)
            };
            estudiantes.Columns.Add(columnna);

            columnna = new DataColumn
            {
                ColumnName = "Nota 1",
                DataType = typeof(int)
            };
            estudiantes.Columns.Add(columnna);

            columnna = new DataColumn
            {
                ColumnName = "Nota 2",
                DataType = typeof(int)
            };
            estudiantes.Columns.Add(columnna);

            columnna = new DataColumn
            {
                ColumnName = "Nota 3",
                DataType = typeof(int)
            };
            estudiantes.Columns.Add(columnna);

            columnna = new DataColumn
            {
                ColumnName = "Nota 4",
                DataType = typeof(int)
            };
            estudiantes.Columns.Add(columnna);

            columnna = new DataColumn
            {
                ColumnName = "Promedio",
                DataType = typeof(int)
            };
            estudiantes.Columns.Add(columnna);

            tablaRegistros.DataSource = estudiantes;
        }

        private void agregarBtn_Click(object sender, EventArgs e)
        {
            if (DatosIngresados() && !DatosReplicados())
            {
                int promedio = (int)(nota1input.Value + nota2input.Value + nota3input.Value + nota4input.Value) / 4;
                estudiantes.Rows.Add(null, nombreInput.Text, asignturaSeleccion.Text, nota1input.Value, nota2input.Value, nota3input.Value, nota4input.Value, promedio);
            }
            else if (DatosReplicados())
            {
                MessageBox.Show("Fila Replicada");
            }
            else
            {
                MessageBox.Show("Celdas Incompletas");
            }
        }

        private bool DatosReplicados()
        {
            int promedio = (int)(nota1input.Value + nota2input.Value + nota3input.Value + nota4input.Value) / 4;
            foreach (DataGridViewRow row in tablaRegistros.Rows)
            {
                if (row.Cells[1].Value.ToString() == nombreInput.Text &&
                    row.Cells[2].Value.ToString() == asignturaSeleccion.Text &&
                    (int)row.Cells[3].Value == nota1input.Value &&
                    (int)row.Cells[4].Value == nota2input.Value &&
                    (int)row.Cells[5].Value == nota3input.Value &&
                    (int)row.Cells[6].Value == nota4input.Value
                    )
                {
                    return true;
                }
            }
            return false;
        }

        private bool DatosIngresados()
        {
            if (nombreInput.TextLength > 3 && asignturaSeleccion.Text.Length > 3)
            {
                return true;
            }
            return false;
        }

        private void eliminarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                estudiantes.Rows.RemoveAt(indice);
            }
            catch
            {
                MessageBox.Show("Seleccione una fila.");
            }
        }

        int indice;
        private void tablaRegistros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                indice = e.RowIndex;
                DataGridViewRow fila = tablaRegistros.Rows[indice];
                nombreInput.Text = fila.Cells[1].Value.ToString();
                asignturaSeleccion.Text = fila.Cells[2].Value.ToString();
                nota1input.Value = (int)fila.Cells[3].Value;
                nota2input.Value = (int)fila.Cells[4].Value;
                nota3input.Value = (int)fila.Cells[5].Value;
                nota4input.Value = (int)fila.Cells[6].Value;
            }
            catch { }

        }

        private void editarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (DatosIngresados())
                {
                    int promedio = (int)(nota1input.Value + nota2input.Value + nota3input.Value + nota4input.Value) / 4;
                    DataGridViewRow fila = tablaRegistros.Rows[indice];
                    fila.Cells[1].Value = nombreInput.Text;
                    fila.Cells[2].Value = asignturaSeleccion.Text;
                    fila.Cells[3].Value = nota1input.Value;
                    fila.Cells[4].Value = nota2input.Value;
                    fila.Cells[5].Value = nota3input.Value;
                    fila.Cells[6].Value = nota4input.Value;
                    fila.Cells[7].Value = promedio;
                }

            }
            catch { }
        }
    }
}
