namespace Proyecto_Examen.Entidades
{
    public class TipoUsuario
    {
        public byte CodigoTipoUsuario { set; get; }
        public string DescripcionTipoUsuario { set; get; }

        public static TipoUsuario  EliminarTipoUsuario(byte codTipoUsuario)
        {
            return new TipoUsuario()
            {
                CodigoTipoUsuario = codTipoUsuario
            };
        }
        public static TipoUsuario CrearTipoUsuario(byte codTipoUsuario, string descripcionTipoUsuario)
        {
            return new TipoUsuario()
            {
                CodigoTipoUsuario = codTipoUsuario,
                DescripcionTipoUsuario=descripcionTipoUsuario
                
            };
        }
        public static TipoUsuario ModificarTipoUsuario(byte codTipoUsuario,string descripcionTipoUsuario)
        {
            return new TipoUsuario()
            {
                CodigoTipoUsuario = codTipoUsuario,
                DescripcionTipoUsuario=descripcionTipoUsuario
            };
        }
    }

}
