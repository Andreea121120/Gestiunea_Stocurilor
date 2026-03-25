using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestiunea_stocurilor
{
    public partial class ContinutFactura
    {
        public decimal Valoare
        {
            get
            {
                return (Cantitate ?? 0) * (Pret ?? 0);
            }
        }
    }
}
