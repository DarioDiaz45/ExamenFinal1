using Piramides.Entidades;
using Piramides.Datos;

namespace PiramidesFinal.Windows
{
    public partial class frmPiramidesAE : Form
    {
        private TipoPiramides? piramides;
        private readonly RepositorioPiramides? _repo;
        public frmPiramidesAE(RepositorioPiramides? repo)
        {
            InitializeComponent();
            _repo = repo;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CargarDatosCombo(ref cboColor);
            if (piramides != null)
            {
                txtLadoBase.Text = piramides.LadoBase.ToString();
                txtAltura.Text = piramides.Altura.ToString();
                switch (piramides.Material)
                {
                    case MaterialesPiramide.Plastico:
                        rbtPlastico.Checked = true;
                        break;
                    case MaterialesPiramide.Madera:
                        rbtMadera.Checked = true;
                        break;
                    case MaterialesPiramide.Vidrio:
                        rbtVidrio.Checked = true;
                        break;

                }
                cboColor.SelectedItem = piramides.Color;
            }
        }

        private void CargarDatosCombo(ref ComboBox cbo)
        {
            cbo.DataSource = Enum.GetValues(typeof(ColorPiramide));
            cbo.SelectedIndex = 0;
        }
        public TipoPiramides? GetPiramide()
        {
            return piramides;
        }
        public void SetPiramide(TipoPiramides piramide)
        {
            this.piramides = piramide;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (piramides is null)
                {
                    piramides = new TipoPiramides();
                }
                piramides.LadoBase = int.Parse(txtLadoBase.Text);
                piramides.Altura = int.Parse(txtAltura.Text);
                piramides.Color = (ColorPiramide)cboColor.SelectedItem!;
                if (rbtVidrio.Checked)
                    piramides.Material = MaterialesPiramide.Vidrio;
                else if (rbtMadera.Checked)
                    piramides.Material = MaterialesPiramide.Madera;
                else if (rbtPlastico.Checked)
                    piramides.Material = MaterialesPiramide.Plastico;
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (!int.TryParse(txtLadoBase.Text, out int lB) ||
                lB <= 0)
            {
                valido = false;
                errorProvider1.SetError(txtLadoBase, "Lado Base mal ingresado");
            }
            if (!int.TryParse(txtAltura.Text, out int A) ||
              A <= 0 || A >= lB)
            {
                valido = false;
                errorProvider1.SetError(txtAltura, "Altura mal ingresada");
            }
            if (_repo!.Existe(lB, A))
            {
                valido = false;
                errorProvider1.SetError(txtLadoBase, "Piramide  existente!!!");
            }
            return valido;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }

}
