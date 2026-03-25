using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gestiunea_stocurilor
{
    public partial class ProdusTransfer
    {
        [NotMapped]
        public decimal Pret { get; set; }
    }
}
