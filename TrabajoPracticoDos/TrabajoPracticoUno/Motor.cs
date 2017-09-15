using System;

namespace TrabajoPracticoUno
{
    internal class Motor: IMovilidad
    {
        private string diametro { get; set; }
        private string cilindrada { get; set; }

        public static implicit operator Motor(string v)
        {
            throw new NotImplementedException();
        }
    }
}