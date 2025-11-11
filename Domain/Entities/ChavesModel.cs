using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Domain.Entities
{
    internal class ChavesModel
    {
        public string Id { get; set; }

        public string Nome { get; set; }

        public string Descricao { get; set; }

        public int Quantidade { get; set; }

    }
}
