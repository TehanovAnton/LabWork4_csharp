using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace LabWork2_elementyUprvlenia
{
    public partial class LecturerForm : Form
    {
        private readonly DisciplineForm disciplineForm;

        private readonly Action<KeyPressEventArgs> AddLetter = (e) =>
        {
            char entered = e.KeyChar;
            if (Char.IsLetter(entered) || Char.IsControl(entered) || Char.IsPunctuation(entered) || Char.IsWhiteSpace(entered))
                e.Handled = false;
            else
                e.Handled = true;
        };
        private readonly Func<LecturerForm, bool> CheckLector = (lector) =>
        {
            return lector.fio.Text != null && lector.cafedra.SelectedItem != null &&
            lector.audienceNumber.Text != null;
        };
        public void Save()
        {
            disciplineForm.studyPlaneBuilder.BuildLecturer(cafedra.Text, fio.Text, audienceNumber.Text);
            disciplineForm.studyPlane = disciplineForm.studyPlaneBuilder.GetStudy();

            using (StreamWriter stream = new StreamWriter(BSTUStudy.filePath))
                stream.Write(JsonConvert.SerializeObject(disciplineForm.studyPlane));
        }
        private void Clear()
        {
            fio.Text = audienceNumber.Text = null;
            cafedra.SelectedItem = null;
        }

        public LecturerForm(DisciplineForm disciplineForm)
        {
            InitializeComponent();
            this.disciplineForm = disciplineForm;
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            AddLetter(e);            
        }
               
        private void SaveButton(object sender, EventArgs e)
        {
            if (CheckLector(this))
            {
                Save();
                Clear();
                textBox2.Text = "сохранено";
            }
            else
                textBox2.Text = "данные не введены";

        }
        
        private void BackToDiscipline_Click(object sender, EventArgs e)
        {
            this.Hide();
            disciplineForm.Show();
        }

        private void LecturerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
