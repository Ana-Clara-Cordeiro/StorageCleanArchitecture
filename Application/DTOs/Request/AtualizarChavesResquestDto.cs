using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Application.DTOs.Request
{
    public class AtualizarChavesResquestDto
    {
        public string Nome { get; set; }

        public string Descricao { get; set; }

        public int Quantidade { get; set; }
    }
}
