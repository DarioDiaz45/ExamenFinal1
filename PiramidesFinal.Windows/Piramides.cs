using Piramides.Datos;
using Piramides.Entidades;

namespace PiramidesFinal.Windows
{
    public partial class Piramides : Form
    {
        private RepositorioPiramides? repositorio;
        private int cantidadRegistros;
        private List<TipoPiramides>? piramides;
        public Piramides()
        {
            InitializeComponent();
            repositorio = new RepositorioPiramides();
        }

        private void tsbnuevo_Click(object sender, EventArgs e)
        {
            frmPiramidesAE frm = new frmPiramidesAE(repositorio) { Text = "Agregar Piramide" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) return;
            TipoPiramides? piramide = frm.GetPiramide();
            try
            {
                if (!repositorio!.Existe(piramide!))
                {
                    repositorio.AgregarRombo(piramide!);
                    DataGridViewRow r = ConstruirFila(dgvDatos);
                    SetearFila(r, piramide!);
                    AgregarFila(r, dgvDatos);
                    MessageBox.Show("Registro agregado", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {

                    MessageBox.Show("Registro existente!!!", "Error",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Algún error!!!", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void SetearFila(DataGridViewRow r, TipoPiramides obj)
        {
            r.Cells[0].Value = obj.LadoBase;
            r.Cells[1].Value = obj.Altura;
            r.Cells[2].Value = obj.Material.ToString();
            r.Cells[3].Value = obj.Color.ToString();
            r.Cells[4].Value = obj.CalcularAreaBase().ToString("N2");
            r.Cells[5].Value = obj.CalcularVolumen().ToString("N2");
            r.Cells[6].Value = obj.CalcularPerimetroBase().ToString("N2");

            r.Tag = obj;
        }

        private void AgregarFila(DataGridViewRow r, DataGridView dgv)
        {
            dgv.Rows.Add(r);
        }

        private DataGridViewRow ConstruirFila(DataGridView grid)
        {
            var r = new DataGridViewRow();
            r.CreateCells(grid);
            return r;
        }
        private void MostrarDatosGrilla()
        {
            LimpiarGrilla(dgvDatos);
            foreach (var item in piramides!)
            {
                var r = ConstruirFila(dgvDatos);
                SetearFila(r, item);
                AgregarFila(r, dgvDatos);
            }
        }

        private void LimpiarGrilla(DataGridView grid)
        {
            grid.Rows.Clear();
        }

        private void Piramides_Load(object sender, EventArgs e)
        {

            cantidadRegistros = repositorio!.GetCantidad();
            if (cantidadRegistros > 0)
            {
                piramides = repositorio.ObtenerMaterial();
                MostrarDatosGrilla();
                MostrarCantidadRegistros();
            }
        }

        private void MostrarCantidadRegistros()
        {
            txtCantidad.Text = cantidadRegistros.ToString();
        }

        private void CargarComboMaterial(ref ToolStripComboBox tsCboMaterial)
        {
            var listaMaterial = Enum.GetValues(typeof(MaterialesPiramide));
            foreach (var item in listaMaterial)
            {
                tsCboMaterial.Items.Add(item);
            }
            tsCboMaterial.DropDownStyle = ComboBoxStyle.DropDownList;
            tsCboMaterial.SelectedIndex = 0;
        }

        private void tsbBorrar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            DataGridViewRow r = dgvDatos.SelectedRows[0];
            TipoPiramides rombos = (TipoPiramides)r.Tag!;
            DialogResult dr = MessageBox.Show("¿Desea borrar la elipse?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.No) { return; }
            try
            {
                repositorio!.EliminarRombo(rombos);
                EliminarFila(r, dgvDatos);
                MessageBox.Show("Registro agregado", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            catch (Exception)
            {

                MessageBox.Show("Algún error!!!", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void EliminarFila(DataGridViewRow r, DataGridView grid)
        {
            grid.Rows.Remove(r);
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (dgvDatos.SelectedRows.Count == 0)
            {
                return;
            }
            DataGridViewRow r = dgvDatos.SelectedRows[0];
            TipoPiramides? piramide = (TipoPiramides)r.Tag!;
            frmPiramidesAE frm = new frmPiramidesAE(repositorio) { Text = "Editar Piramide" };
            frm.SetPiramide(piramide);
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel) { return; }
            try
            {
                piramide = frm.GetPiramide();
                SetearFila(r, piramide);
                MessageBox.Show("Registro editado", "Mensaje",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {

                MessageBox.Show("Algún error!!!", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void tsbActualizar_Click(object sender, EventArgs e)
        {
            piramides = repositorio!.ObtenerPiramide();
            MostrarDatosGrilla();
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            repositorio!.GuardarDatos();
            MessageBox.Show("Fin del Programa", "Mensaje",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();
        }
    }
}
