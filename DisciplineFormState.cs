using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork2_elementyUprvlenia
{
    public class DisciplineFormState
    {
        public string disicplineName { get; set; }
        public string lecNumber { get; set; }
        public string labNumber { get; set; }
        public string curs { get; set; }
        public string semestr { get; set; }
        public string knowledgeControl { get; set; }
        public string ShoWin { get; set; }
        public string infoBox { get; set; }

        public DisciplineFormState(string disicplineName, string labNumber, string lecNumber, string curs, string semestr, string knowledgeControl, string ShoWin, string infoBox)
        {
            this.disicplineName = disicplineName;
            this.labNumber = labNumber;
            this.lecNumber = lecNumber;
            this.curs = curs;
            this.semestr = semestr;
            this.knowledgeControl = knowledgeControl;
            this.ShoWin = ShoWin;
            this.infoBox = infoBox;
        }

        public DisciplineFormState()
        {
            this.disicplineName = "";
            this.labNumber = "";
            this.lecNumber = "";
            this.curs = "";
            this.semestr = "";
            this.knowledgeControl = "";
            this.ShoWin = "";
            this.infoBox = "";
        }
    }
}
