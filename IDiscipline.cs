using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork2_elementyUprvlenia
{
    public interface IDiscipline
    {
        string disicplineName { get; set; }
        string labNumber { get; set; }
        string lecNumber { get; set; }
        string curs { get; set; }
        string semestr { get; set; }
        string knowledgeControl { get; set; }
    }
}
