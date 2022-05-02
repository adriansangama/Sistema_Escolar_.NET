namespace appSistemaEscolar.bean
{
    public class Cargo
    {

        #region Propiedades

        public int id { get; set; }
        public string Detalle { get; set; }

        #endregion

        #region Constructor

        public Cargo() { }

        public Cargo(int id, string detalle)
        {
            this.id = id;
            Detalle = detalle;
        }

        #endregion

    }
}
