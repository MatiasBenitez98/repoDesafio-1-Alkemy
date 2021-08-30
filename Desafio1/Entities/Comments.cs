using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Desafio1.Entities
{
    public class Comments
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public string Comment { get; set; }
        public Users Users { get; set; }
    }
}
