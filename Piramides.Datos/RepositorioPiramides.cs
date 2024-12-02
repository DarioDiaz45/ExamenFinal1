using Piramides.Entidades;
using System.Drawing;
namespace Piramides.Datos
{
    public class RepositorioPiramides
    {
        private List<TipoPiramides> piramides;
        private string? nombreArchivo = "Piramide.txt";
        private string? rutaProyecto = Environment.CurrentDirectory;
        private string? rutaCompletaArchivo;

        public RepositorioPiramides()
        {
            piramides = LeerDatos();
        }

        private List<TipoPiramides>? LeerDatos()
        {
            var listaPiramides = new List<TipoPiramides>();
            rutaCompletaArchivo = Path.Combine(rutaProyecto!, nombreArchivo!);
            if (!File.Exists(rutaCompletaArchivo))
            {
                return listaPiramides;
            }
            using (var lector = new StreamReader(rutaCompletaArchivo))
            {
                while (!lector.EndOfStream)
                {
                    string? linea = lector.ReadLine();
                    TipoPiramides? piramide = ConstruirPiramide(linea);
                    listaPiramides.Add(piramide!);
                }
            }
            return listaPiramides;
        }

        private TipoPiramides? ConstruirPiramide(string? linea)
        {
            var campos = linea!.Split('|');
            var dM = int.Parse(campos[0]);
            var dm = int.Parse(campos[1]);
            var tipoMaterial = (MaterialesPiramide)int.Parse(campos[2]);
            var color = (ColorPiramide)int.Parse(campos[3]);
            return new TipoPiramides(dM, dm, tipoMaterial);
        }
        public void AgregarRombo(TipoPiramides piramide)
        {
            piramides.Add(piramide);
        }
        public void EliminarRombo(TipoPiramides piramide)
        {
            piramides.Remove(piramide);
        }
        

        public bool Existe(int lB, int a)
        {
            return piramides.Any(e => e.LadoBase == a &&
             e.Altura == a);
        }

        public bool Existe(TipoPiramides tipoPiramides)
        {
            return piramides.Any(e => e.LadoBase == tipoPiramides.Altura &&
                e.LadoBase == tipoPiramides.Altura);
        }
        public int GetCantidad(MaterialesPiramide? MaterialSeleccionado = null)
        {
            if (MaterialSeleccionado == null)
                return piramides.Count;
            return piramides.Count(e => e.Material == MaterialSeleccionado);
        }
        public List<TipoPiramides> ObtenerPiramides()
        {
            return new List<TipoPiramides>(piramides);
        }
        public List<TipoPiramides>? OrdenarAsc()
        {
            return piramides.OrderBy(e => e.CalcularAreaBase()).ToList();
        }
        public List<TipoPiramides>? OrdenarDesc()
        {
            return piramides.OrderByDescending(e => e.CalcularAreaBase()).ToList();
        }
        public void GuardarDatos()
        {
            rutaCompletaArchivo = Path.Combine(rutaProyecto!, nombreArchivo!);
            using (var escritor = new StreamWriter(rutaCompletaArchivo))
            {
                foreach (var rombo in piramides)
                {
                    string linea = ConstruirLinea(rombo);
                    escritor.WriteLine(linea);
                }
            }
        }

        private string ConstruirLinea(TipoPiramides piramide)
        {
            return $"{piramide.LadoBase}|{piramide.Altura}|{piramide.Material.GetHashCode()}|{piramide.Color.GetHashCode}";
        }

        public List<TipoPiramides> ObtenerMaterial()
        {
            return new List<TipoPiramides>(piramides);
        }

        public List<TipoPiramides>? ObtenerPiramide()
        {
            return new List<TipoPiramides>(piramides);
        }
    }
}
