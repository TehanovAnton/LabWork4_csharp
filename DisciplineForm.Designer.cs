
namespace LabWork2_elementyUprvlenia
{
    partial class DisciplineForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.curs = new System.Windows.Forms.GroupBox();
            this.secondCurs = new System.Windows.Forms.RadioButton();
            this.firstCurs = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.secondSemestr = new System.Windows.Forms.RadioButton();
            this.firstSemestr = new System.Windows.Forms.RadioButton();
            this.disciplineName = new System.Windows.Forms.TextBox();
            this.lecNumber = new System.Windows.Forms.MaskedTextBox();
            this.labNumber = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.zachyt = new System.Windows.Forms.RadioButton();
            this.akzamen = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.infoBox = new System.Windows.Forms.TextBox();
            this.ShowWin = new System.Windows.Forms.TextBox();
            this.ShowSavedButton = new System.Windows.Forms.Button();
            this.Styles = new System.Windows.Forms.Button();
            this.curs.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(420, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "название дисциплины";
            this.label1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(420, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "количество лекций";
            this.label2.UseWaitCursor = true;
            // 
            // curs
            // 
            this.curs.Controls.Add(this.secondCurs);
            this.curs.Controls.Add(this.firstCurs);
            this.curs.Location = new System.Drawing.Point(271, 188);
            this.curs.Name = "curs";
            this.curs.Size = new System.Drawing.Size(200, 100);
            this.curs.TabIndex = 2;
            this.curs.TabStop = false;
            this.curs.Text = "курс";
            this.curs.UseWaitCursor = true;
            // 
            // secondCurs
            // 
            this.secondCurs.AutoSize = true;
            this.secondCurs.Location = new System.Drawing.Point(6, 55);
            this.secondCurs.Name = "secondCurs";
            this.secondCurs.Size = new System.Drawing.Size(43, 24);
            this.secondCurs.TabIndex = 2;
            this.secondCurs.TabStop = true;
            this.secondCurs.Text = "2";
            this.secondCurs.UseVisualStyleBackColor = true;
            this.secondCurs.UseWaitCursor = true;
            // 
            // firstCurs
            // 
            this.firstCurs.AutoSize = true;
            this.firstCurs.Location = new System.Drawing.Point(6, 25);
            this.firstCurs.Name = "firstCurs";
            this.firstCurs.Size = new System.Drawing.Size(43, 24);
            this.firstCurs.TabIndex = 3;
            this.firstCurs.TabStop = true;
            this.firstCurs.Text = "1";
            this.firstCurs.UseVisualStyleBackColor = true;
            this.firstCurs.UseWaitCursor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.secondSemestr);
            this.groupBox2.Controls.Add(this.firstSemestr);
            this.groupBox2.Location = new System.Drawing.Point(477, 188);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "семестр";
            this.groupBox2.UseWaitCursor = true;
            // 
            // secondSemestr
            // 
            this.secondSemestr.AutoSize = true;
            this.secondSemestr.Location = new System.Drawing.Point(6, 63);
            this.secondSemestr.Name = "secondSemestr";
            this.secondSemestr.Size = new System.Drawing.Size(43, 24);
            this.secondSemestr.TabIndex = 1;
            this.secondSemestr.TabStop = true;
            this.secondSemestr.Text = "2";
            this.secondSemestr.UseVisualStyleBackColor = true;
            this.secondSemestr.UseWaitCursor = true;
            // 
            // firstSemestr
            // 
            this.firstSemestr.AutoSize = true;
            this.firstSemestr.Location = new System.Drawing.Point(6, 33);
            this.firstSemestr.Name = "firstSemestr";
            this.firstSemestr.Size = new System.Drawing.Size(43, 24);
            this.firstSemestr.TabIndex = 0;
            this.firstSemestr.TabStop = true;
            this.firstSemestr.Text = "1";
            this.firstSemestr.UseVisualStyleBackColor = true;
            this.firstSemestr.UseWaitCursor = true;
            // 
            // disciplineName
            // 
            this.disciplineName.Location = new System.Drawing.Point(271, 80);
            this.disciplineName.Name = "disciplineName";
            this.disciplineName.Size = new System.Drawing.Size(100, 26);
            this.disciplineName.TabIndex = 4;
            this.disciplineName.UseWaitCursor = true;
            // 
            // lecNumber
            // 
            this.lecNumber.Location = new System.Drawing.Point(271, 114);
            this.lecNumber.Mask = "0";
            this.lecNumber.Name = "lecNumber";
            this.lecNumber.Size = new System.Drawing.Size(100, 26);
            this.lecNumber.TabIndex = 5;
            this.lecNumber.UseWaitCursor = true;
            this.lecNumber.ValidatingType = typeof(int);
            // 
            // labNumber
            // 
            this.labNumber.Location = new System.Drawing.Point(271, 146);
            this.labNumber.Mask = "0";
            this.labNumber.Name = "labNumber";
            this.labNumber.Size = new System.Drawing.Size(100, 26);
            this.labNumber.TabIndex = 7;
            this.labNumber.UseWaitCursor = true;
            this.labNumber.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(420, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "количество лабороторных";
            this.label3.UseWaitCursor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.zachyt);
            this.groupBox3.Controls.Add(this.akzamen);
            this.groupBox3.Location = new System.Drawing.Point(271, 294);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "контроль";
            this.groupBox3.UseWaitCursor = true;
            // 
            // zachyt
            // 
            this.zachyt.AutoSize = true;
            this.zachyt.Location = new System.Drawing.Point(6, 55);
            this.zachyt.Name = "zachyt";
            this.zachyt.Size = new System.Drawing.Size(78, 24);
            this.zachyt.TabIndex = 2;
            this.zachyt.TabStop = true;
            this.zachyt.Text = "зачёт";
            this.zachyt.UseVisualStyleBackColor = true;
            this.zachyt.UseWaitCursor = true;
            // 
            // akzamen
            // 
            this.akzamen.AutoSize = true;
            this.akzamen.Location = new System.Drawing.Point(6, 25);
            this.akzamen.Name = "akzamen";
            this.akzamen.Size = new System.Drawing.Size(97, 24);
            this.akzamen.TabIndex = 3;
            this.akzamen.TabStop = true;
            this.akzamen.Text = "экзамен";
            this.akzamen.UseVisualStyleBackColor = true;
            this.akzamen.UseWaitCursor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(477, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "лектор";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.UseWaitCursor = true;
            this.button1.Click += new System.EventHandler(this.LectorButton);
            // 
            // infoBox
            // 
            this.infoBox.Location = new System.Drawing.Point(271, 48);
            this.infoBox.Name = "infoBox";
            this.infoBox.ReadOnly = true;
            this.infoBox.Size = new System.Drawing.Size(406, 26);
            this.infoBox.TabIndex = 8;
            this.infoBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.infoBox.UseWaitCursor = true;
            // 
            // ShowWin
            // 
            this.ShowWin.Location = new System.Drawing.Point(50, 48);
            this.ShowWin.Multiline = true;
            this.ShowWin.Name = "ShowWin";
            this.ShowWin.ReadOnly = true;
            this.ShowWin.Size = new System.Drawing.Size(215, 346);
            this.ShowWin.TabIndex = 9;
            this.ShowWin.UseWaitCursor = true;
            // 
            // ShowSavedButton
            // 
            this.ShowSavedButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ShowSavedButton.Location = new System.Drawing.Point(477, 349);
            this.ShowSavedButton.Name = "ShowSavedButton";
            this.ShowSavedButton.Size = new System.Drawing.Size(97, 37);
            this.ShowSavedButton.TabIndex = 10;
            this.ShowSavedButton.Text = "показать";
            this.ShowSavedButton.UseVisualStyleBackColor = true;
            this.ShowSavedButton.UseWaitCursor = true;
            this.ShowSavedButton.Click += new System.EventHandler(this.ShowSavedButton_Click);
            // 
            // Styles
            // 
            this.Styles.Location = new System.Drawing.Point(593, 306);
            this.Styles.Name = "Styles";
            this.Styles.Size = new System.Drawing.Size(84, 37);
            this.Styles.TabIndex = 11;
            this.Styles.Text = "стили";
            this.Styles.UseVisualStyleBackColor = true;
            this.Styles.UseWaitCursor = true;
            this.Styles.Click += new System.EventHandler(this.Styles_Click);
            // 
            // DisciplineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.CancelButton = this.ShowSavedButton;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Styles);
            this.Controls.Add(this.ShowSavedButton);
            this.Controls.Add(this.ShowWin);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.labNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lecNumber);
            this.Controls.Add(this.disciplineName);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.curs);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Olive;
            this.KeyPreview = true;
            this.Name = "DisciplineForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Discipline";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Discipline_Load);
            this.curs.ResumeLayout(false);
            this.curs.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox curs;
        private System.Windows.Forms.RadioButton secondCurs;
        private System.Windows.Forms.RadioButton firstCurs;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton secondSemestr;
        private System.Windows.Forms.RadioButton firstSemestr;
        private System.Windows.Forms.TextBox disciplineName;
        private System.Windows.Forms.MaskedTextBox lecNumber;
        private System.Windows.Forms.MaskedTextBox labNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton zachyt;
        private System.Windows.Forms.RadioButton akzamen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox infoBox;
        private System.Windows.Forms.TextBox ShowWin;
        private System.Windows.Forms.Button ShowSavedButton;
        private System.Windows.Forms.Button Styles;
    }
}

