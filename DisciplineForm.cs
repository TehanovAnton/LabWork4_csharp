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
    public partial class DisciplineForm : Form
    {
        private readonly IStudy study;
        public StudyPlane studyPlane;
        public StudyPlaneBuilder studyPlaneBuilder;
        private FormsStyle formsStyle;

        private LecturerForm lecturerForm;

        private readonly Action<KeyPressEventArgs> AddLetter = (e) =>
        {
            char entered = e.KeyChar;
            if (Char.IsLetter(entered) || Char.IsControl(entered))
                e.Handled = false;
            else
                e.Handled = true;
        };
        private readonly Func<DisciplineForm, bool> CheckDiscipline = (discipline) =>
        {
            bool semestr = false;
            bool curs = false;
            bool knowlegControl = false;
            foreach (RadioButton radioButton in discipline.curs.Controls)
                curs |= radioButton.Checked;

            foreach (RadioButton radioButton in discipline.groupBox2.Controls)
                semestr |= radioButton.Checked;

            foreach (RadioButton radioButton in discipline.groupBox3.Controls)
                knowlegControl |= radioButton.Checked;

            return discipline.disciplineName.Text != null &&
            discipline.lecNumber.Text != null &&
            discipline.labNumber.Text != null &&
            semestr && curs && knowlegControl;
        };

        public DisciplineForm()
        {
            InitializeComponent();
            study = new BSTUStudy();
            studyPlane = new StudyPlane();
            studyPlaneBuilder = new StudyPlaneBuilder();
            formsStyle = FormsStyle.GetInstance();
        }

        private void Save()
        {
            studyPlaneBuilder.BuildDiscipline(disciplineName.Text, labNumber.Text, lecNumber.Text,
                firstCurs.Checked ? "курс: 1" : "курс: 2", firstSemestr.Checked ? "семестр: 1" : "семестр: 2",
                akzamen.Checked ? "экзамен" : "зачёт");

            lecturerForm = new LecturerForm(this);
        }
        private void ShowSaved(StudyPlane saved)
        {
            var cloneLecturer = saved.lecturer.DeepCopy();
            var cloneDiscipline = saved.discipline.DeepCopy();

            ShowWin.Text = string.Format("наз. дисциплины: {0}\r\n" +
                    "кол. лаб: {1}\r\n" +
                    "кол. лекций: {2}\r\n" +
                    "{3}\r\n" +
                    "{4}\r\n" +
                    "контроль знаний: {5}\r\n" +
                    "фио: {6}\r\n" +
                    "кафедра: {7}\r\n" +
                    "аудитория: {8}",
                    cloneDiscipline.disicplineName, cloneDiscipline.labNumber, cloneDiscipline.lecNumber,
                    saved.discipline.curs, saved.discipline.semestr, cloneDiscipline.knowledgeControl,
                    cloneLecturer.fio, cloneLecturer.cafedra, cloneLecturer.audienceNumber);
        }
        private void Discipline_Load(object sender, EventArgs e)
        {

        }

        private void LectorButton(object sender, EventArgs e)
        {
            if (CheckDiscipline(this))
            {
                Save();
                textBox2.Text = "сохранено";

                this.Hide();                
                lecturerForm.Show();
            }
            else
                textBox2.Text = "данные не введены";
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            AddLetter(e);
        }

        private void ShowSavedButton_Click(object sender, EventArgs e)
        {
            StudyPlane saved = new StudyPlane();
            using(StreamReader reader = new StreamReader(BSTUStudy.filePath))
                saved = JsonConvert.DeserializeObject<StudyPlane>(reader.ReadToEnd());

            ShowSaved(saved);
        }

        private void Styles_Click(object sender, EventArgs e)
        {
            ShowWin.Text = formsStyle.GetInfoString();
        }
    }
}
