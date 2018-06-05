using Cell.Models.Entities;
using Cell.Models.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cell.BL.Services
{
    internal class PdfExporter : AbstractExporter
    {
        public override byte[] ExportInvoice(Invoice invoice)
        {
            throw new NotImplementedException();
        }
    }
}
