using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracitcaSOLID.Reports
{
    public interface IReportService
    {
        void RunReport(List<string> data);
    }
}
