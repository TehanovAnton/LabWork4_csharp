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
        public readonly IStudy study;
        public StudyPlane studyPlane;
        public StudyPlaneBuilder studyPlaneBuilder;
        public FormsStyle formsStyle;
        public LecturerForm lecturerForm;


        public readonly Action<KeyPressEventArgs> AddLetter = (e) =>
        {
            char entered = e.KeyChar;
            if (Char.IsLetter(entered) || Char.IsControl(entered))
                e.Handled = false;
            else
                e.Handled = true;
        };
        public readonly Action<RadioButton, RadioButton, string, string> radioButtonSetting = (button1, button2, stateText, text) =>
        {
            if (stateText == text)
                button1.Focus();
            else
                button2.Focus();
        };
        public readonly Func<DisciplineForm, bool> CheckDiscipline = (discipline) =>
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


        public void SetInfoBox(string text)
        {
            infoBox.Text = text;
        }
        public void SetShowWin(string text)
        {
            ShowWin.Text = text;
        }


        public void Save()
        {
            studyPlaneBuilder.BuildDiscipline(disciplineName.Text, labNumber.Text, lecNumber.Text,
                firstCurs.Checked ? "курс: 1" : "курс: 2", firstSemestr.Checked ? "семестр: 1" : "семестр: 2",
                akzamen.Checked ? "экзамен" : "зачёт");

            lecturerForm = new LecturerForm(this);
        }
        public void ShowSaved(StudyPlane saved)
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
        public void Discipline_Load(object sender, EventArgs e)
        {

        }
        public DisciplineFormState getState()
        {
            return new DisciplineFormState(
                    disciplineName.Text, labNumber.Text,
                    lecNumber.Text, firstCurs.Checked ? "курс: 1" : "курс: 2",
                    firstSemestr.Checked ? "семестр: 1" : "семестр: 2", akzamen.Checked ? "экзамен" : "зачёт",
                    ShowWin.Text, infoBox.Text
                );
        }
        public void setState(DisciplineFormState state)
        {
            disciplineName.Text = state.disicplineName;
            labNumber.Text = state.labNumber;
            lecNumber.Text = state.lecNumber;
            radioButtonSetting(firstCurs, secondCurs, state.curs, "курс: 1");
            radioButtonSetting(firstCurs, secondCurs, state.curs, "экзамен");
            infoBox.Text = state.infoBox;
        }


        public virtual void LectorButton(object sender, EventArgs e)
        {

        }
        public virtual void ShowSavedButton_Click(object sender, EventArgs e)
        {
        }
        public virtual void Styles_Click(object sender, EventArgs e)
        {
        }
    }
}
