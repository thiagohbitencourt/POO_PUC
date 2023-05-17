using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade7
{
    internal class TesteException : Exception
    {
        public class ExcecaoAcimaDeCem : Exception
        {
            public ExcecaoAcimaDeCem(string mensagem) : base(mensagem)
            {
            }
        }
    }
}
