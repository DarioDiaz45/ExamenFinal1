namespace Piramides.Entidades
{
    public class TipoPiramides
    {
        private int dM;
        private int dm;
        private MaterialesPiramide tipoMaterial;

        public TipoPiramides(int dM, int dm, MaterialesPiramide tipoMaterial)
        {
            this.dM = dM;
            this.dm = dm;
            this.tipoMaterial = tipoMaterial;
        }

        public TipoPiramides()
        {
        }

        public int LadoBase { get; set; }
        public int Altura {  get; set; }
        public int CantidadLados {  get; set; }

        public ColorPiramide Color {  get; set; }
        public MaterialesPiramide Material {  get; set; }

        public double CalcularAreaBase()
        {
            return CantidadLados switch
            {
                3 => (Math.Sqrt(3) / 4) * Math.Pow(LadoBase, 2),
                4 => Math.Pow(LadoBase, 2),
                _ => throw new InvalidOperationException("Cantidad de lados inválida.")
            };
        }

        
        public double CalcularVolumen()
        {
            return (CalcularAreaBase() * Altura) / 3;
        }

  
        public double CalcularPerimetroBase()
        {
            return LadoBase * CantidadLados;
        }
        
       

    }

}
