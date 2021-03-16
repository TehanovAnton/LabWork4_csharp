using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork2_elementyUprvlenia
{
    interface IStudyPlaneBuilder
    {
        void BuildDiscipline(string disicplineName, string labNumber, string lecNumber,
            string curs, string semestr, string knowledgeControl);
        void BuildLecturer(string cafedra, string fio, string audienceNumber);
        StudyPlane GetStudy();
    }
}