
namespace LabWork2_elementyUprvlenia
{
    partial class LecturerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.fio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.audienceNumber = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cafedra = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.BackToDiscipline = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // fio
            // 
            this.fio.Location = new System.Drawing.Point(219, 62);
            this.fio.Name = "fio";
            this.fio.Size = new System.Drawing.Size(100, 26);
            this.fio.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(325, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ф.И.О.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "кафедра";
            // 
            // audienceNumber
            // 
            this.audienceNumber.Location = new System.Drawing.Point(219, 126);
            this.audienceNumber.Mask = "0";
            this.audienceNumber.Name = "audienceNumber";
            this.audienceNumber.Size = new System.Drawing.Size(100, 26);
            this.audienceNumber.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "номер аудитори";
            // 
            // cafedra
            // 
            this.cafedra.FormattingEnabled = true;
            this.cafedra.Items.AddRange(new object[] {
            "инф. системы и технологии",
            "инф. и web дизайна",
            "физики"});
            this.cafedra.Location = new System.Drawing.Point(219, 94);
            this.cafedra.Name = "cafedra";
            this.cafedra.Size = new System.Drawing.Size(100, 28);
            this.cafedra.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(219, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 41);
            this.button1.TabIndex = 7;
            this.button1.Text = "сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SaveButton);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(219, 30);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(244, 26);
            this.textBox2.TabIndex = 8;
            // 
            // BackToDiscipline
            // 
            this.BackToDiscipline.Location = new System.Drawing.Point(329, 158);
            this.BackToDiscipline.Name = "BackToDiscipline";
            this.BackToDiscipline.Size = new System.Drawing.Size(100, 41);
            this.BackToDiscipline.TabIndex = 9;
            this.BackToDiscipline.Text = "назад";
            this.BackToDiscipline.UseVisualStyleBackColor = true;
            this.BackToDiscipline.Click += new System.EventHandler(this.BackToDiscipline_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(469, 30);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 10;
            // 
            // LecturerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.BackToDiscipline);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cafedra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.audienceNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fio);
            this.Name = "LecturerForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LecturerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox fio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox audienceNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cafedra;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button BackToDiscipline;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}