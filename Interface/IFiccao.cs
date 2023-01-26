using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_streaming
{
    public interface IFiccao : IGenero
    {
        bool EFiccao { get; set; }
    }
}
