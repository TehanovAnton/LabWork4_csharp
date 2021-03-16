using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork2_elementyUprvlenia
{
    public class BSTUStudy : IStudy
    {
        public static string filePath =
            @"C:\Users\Anton\source\repos\pacei_NV_OOTP\лабораторные\решения\LabWork2_elementyUprvlenia\savedInformation";

        public IDiscipline CreateDiscipline(string disicplineName, string labNumber, string lecNumber,
            string curs, string semestr, string knowledgeControl)
        {
            return new Discipline(disicplineName, labNumber, lecNumber,
            curs, semestr, knowledgeControl);
        }

        public ILecturer CreateLecturer(string cafedra, string fio, string audienceNumber)
        {
            return new Lecturer(cafedra, fio, audienceNumber);
        }
    }
}
