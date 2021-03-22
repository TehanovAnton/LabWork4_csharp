using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace LabWork2_elementyUprvlenia
{
    class SimpleDisciplneForm : DisciplineForm, ISimpleDisciplineForm
    {
        public override void LectorButton(object sender, EventArgs e)
        {
            if (CheckDiscipline(this))
            {
                Save();

                SetInfoBox("сохранено");

                this.setState(new DisciplineFormState());

                this.Hide();

                lecturerForm.Show();
            }
            else
                SetInfoBox("данные не введены");
        }

        public override void ShowSavedButton_Click(object sender, EventArgs e)
        {
            StudyPlane saved = new StudyPlane();
            using (StreamReader reader = new StreamReader(BSTUStudy.filePath))
                saved = JsonConvert.DeserializeObject<StudyPlane>(reader.ReadToEnd());

            ShowSaved(saved);
        }

        public override void Styles_Click(object sender, EventArgs e)
        {
            SetShowWin(formsStyle.GetInfoString());
        }
    }
}
