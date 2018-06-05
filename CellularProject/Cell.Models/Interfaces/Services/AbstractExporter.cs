using Cell.Models.Entities;

namespace Cell.Models.Interfaces.Services
{
    public abstract class AbstractExporter
    {
        public abstract byte[] ExportInvoice(Invoice invoice);
    }
}