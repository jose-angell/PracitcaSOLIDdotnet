using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// Interfaz para guardar reportes a partir de un metodo específico.
namespace PracitcaSOLID.Reports
{
    public interface IReportSaver
    {
        void Save(string content);
    }
}
