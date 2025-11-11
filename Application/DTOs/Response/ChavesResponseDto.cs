using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Application.DTOs.Response
{
    internal class ChavesResponseDto
    {
        public string Id { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public int Quantidade { get; set; }

    }
}
