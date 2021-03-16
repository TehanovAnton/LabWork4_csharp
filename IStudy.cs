using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork2_elementyUprvlenia
{
    public interface IStudy
    {
        IDiscipline CreateDiscipline(string disicplineName, string labNumber, string lecNumber,
            string curs, string semestr, string knowledgeControl);
        ILecturer CreateLecturer(string cafedra, string fio, string audienceNumber);
    }
}
