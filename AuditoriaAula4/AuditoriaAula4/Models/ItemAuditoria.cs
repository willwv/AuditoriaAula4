using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuditoriaAula4.Model
{
    public class ItemAuditoria
    {
        public string IdLivro { get; set; }
        public string IdUsuario { get; set; }
        public string Valor { get; set; }
        public string NomeUsuario { get; set; }
        public DateTime DataVenda { get; set; }
    }
}
