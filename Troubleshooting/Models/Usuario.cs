using System;
using System.Diagnostics;

namespace Troubleshooting
{
    [DebuggerDisplay("User ID:{ID} - Age:{Idade}")]
    [DebuggerTypeProxy(typeof(UserDebugViewer))]
    internal class User: IUser
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        public int Idade { get; set; }
        public bool Ativo { get; set; }

        #region| Methods |

        public void Comer(string comida)
        {

        }

        public void Dormir(DateTime inicio, DateTime fim)
        {

        } 

        #endregion
    }
}
