using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork2_elementyUprvlenia
{
    [Serializable]
    public class Discipline : Prototype<Discipline>, IDiscipline
    {
        public string disicplineName { get; set; }
        public string labNumber { get; set; }
        public string lecNumber { get; set; }
        public string curs { get; set; }
        public string semestr { get; set; }
        public string knowledgeControl { get; set; }

        public Discipline(string disicplineName, string labNumber, string lecNumber,
            string curs, string semestr, string knowledgeControl)
        {
            this.disicplineName = disicplineName;
            this.labNumber = labNumber;
            this.lecNumber = lecNumber;
            this.curs = curs;
            this.semestr = semestr;
            this.knowledgeControl = knowledgeControl;
        }
    }
}
