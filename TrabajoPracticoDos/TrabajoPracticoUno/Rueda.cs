using System;

namespace TrabajoPracticoUno
{
    internal class Rueda: IMovilidad
    {


    public void frenar()
    {

    }

    public void iniciar()
    {
        
    }

        public static implicit operator Rueda(Motor v)
        {
            throw new NotImplementedException();
        }
    }
}