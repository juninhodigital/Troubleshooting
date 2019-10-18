using System;

namespace Troubleshooting
{
    public interface IUser
    {
        void Comer(string comida);
        void Dormir(DateTime inicio, DateTime fim);
    }
}
