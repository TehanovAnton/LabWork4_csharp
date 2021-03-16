using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork2_elementyUprvlenia
{
    public class StudyPlaneBuilder : IStudyPlaneBuilder
    {
        private StudyPlane studyPlane = new StudyPlane();
        private readonly static IStudy study = new BSTUStudy();

        public void BuildDiscipline(string disicplineName, string labNumber, string lecNumber,
            string curs, string semestr, string knowledgeControl)
        {
            studyPlane.discipline = (Discipline)study.CreateDiscipline(disicplineName, labNumber, lecNumber,
            curs, semestr, knowledgeControl);
        }

        public void BuildLecturer(string cafedra, string fio, string audienceNumber)
        {
            studyPlane.lecturer = (Lecturer)study.CreateLecturer(cafedra, fio, audienceNumber);
        }

        public StudyPlane GetStudy()
        {
            return studyPlane;
        }
    }
}
