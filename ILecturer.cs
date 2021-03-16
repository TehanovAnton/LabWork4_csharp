using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork2_elementyUprvlenia
{
    public interface ILecturer
    {
        string cafedra { get; set; }
        string fio { get; set; }
        string audienceNumber { get; set; }
    }
}
