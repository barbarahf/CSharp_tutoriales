namespace DenpendencyInjection
{
    // Implementación de un servicio
    public class Hamburguesa : IAlimento
    {    public Hamburguesa(string ingrediente)
        {
            Nombre = "Pizza de " + ingrediente;
        }
    

        public string Nombre { get; private set; }
    }
}