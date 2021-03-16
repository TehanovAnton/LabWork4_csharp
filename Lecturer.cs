using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork2_elementyUprvlenia
{
    [Serializable]
    public class Lecturer : Prototype<Lecturer>, ILecturer
    {
        public string cafedra { get; set; }
        public string fio { get; set; }
        public string audienceNumber { get; set; }

        public Lecturer() {}
        public Lecturer (string cafedra, string fio, string audienceNumber)
        {
            this.cafedra = cafedra;
            this.fio = fio;
            this.audienceNumber = audienceNumber;
        }
    }
}
