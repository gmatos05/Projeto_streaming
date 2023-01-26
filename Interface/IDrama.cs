using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_streaming
{
    public interface IDrama : IGenero
    {
        bool EDrama { get; set; }

    }
}
