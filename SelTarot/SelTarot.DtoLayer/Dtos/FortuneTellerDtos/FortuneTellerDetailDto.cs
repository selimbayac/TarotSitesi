using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelTarot.DtoLayer.Dtos.FortuneTellerDtos
{
    public class FortuneTellerDetailDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Fee { get; set; }
        public string Iban { get; set; }
    }
}
