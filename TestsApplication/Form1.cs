using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestsSeviceLib;

namespace TestsApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            QuestionGrid.AutoGenerateColumns = false;
            AnswersGrid.AutoGenerateColumns = false;
        }

        Service service = new Service();

        private void Form1_Load(object sender, EventArgs e)
        {
            bsTests.DataSource = service.GetTests();
            TestsList.DisplayMember = "name";
            UserTestList.DisplayMember = "name";
        }

        private void QuestionGrid_SelectionChanged(object sender, EventArgs e)
        {
            bsAnswers.DataSource = service.GetAnswers(SelectedQuestion);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            TestsList.SelectedItem = ((List<UITest>)bsTests.DataSource).FirstOrDefault(x => x.name.StartsWith(searchTestBox.Text));
        }

        int secondsCounter;

        private void Startbutton_Click(object sender, EventArgs e)
        {
            splitContainer4.Panel2.Controls.Clear();
            var qq = service.GetQuestions(SelectedTest).OrderByDescending(x => x.Id);
            splitContainer4.Panel2.Tag = qq.Count();
            foreach (var quest in qq)
            {
                var ctr = new GroupBox();
                ctr.Dock = DockStyle.Top;
                ctr.Padding = new Padding(5);
                ctr.Text = quest.QuestionText;
                foreach (var ans in service.GetAnswers(quest))
                {
                    ButtonBase tb;
                    if (quest.MultyChoice)
                        tb = new CheckBox();
                    else
                        tb = new RadioButton();
                    tb.Text = ans.AnswerText;
                    tb.Tag = ans;
                    tb.Dock = DockStyle.Top;
                    ctr.Controls.Add(tb);
                    tb.Parent = ctr;
                }
                splitContainer4.Panel2.Controls.Add(ctr);
                ctr.Parent = splitContainer4.Panel2;
            }

            lbTimer.BackColor = Color.Red;
            DisableUI(true);
            secondsCounter = 0;
            timer1.Start();
        }

        private void DisableUI(bool v)
        {
            Startbutton.Enabled = !v;
            Finishbutton.Enabled = v;

            UserTestList.Enabled = !v;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lbTimer.Text = TimeSpan.FromSeconds(++secondsCounter).ToString();
            Application.DoEvents();
            if (secondsCounter >= SelectedTest.time * 60)
                Finishbutton_Click(sender, e);
        }

        private void TestsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedTest != null)
            {
                bsQuestions.DataSource = service.GetQuestions(SelectedTest);
                NametextBox.Text = SelectedTest.name;
                MinutesForTestTextBox.Text = SelectedTest.time.ToString();
            }
        }

        private void UserTestList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedTest != null)
            {
                bsQuestions.DataSource = service.GetQuestions(SelectedTest);
                UserTestNametextBox.Text = SelectedTest.name;
                UserTestTimetextBox.Text = SelectedTest.time.ToString();
            }
        }

        UITest SelectedTest
        { get { return (UITest)bsTests.Current; } }

        UIQuestion SelectedQuestion
        { get { return (UIQuestion)bsQuestions.Current; } }

        UIAnswer SelectedAnswer
        { get { return (UIAnswer)bsAnswers.Current; } }

        private void AddTest_Click(object sender, EventArgs e)
        {
            var s = new NewTestForm();
            var s1 = s.ShowDialog();
            if (s1 == DialogResult.OK)
                service.SaveTest(new UITest(s.NametextBox.Text, (int)s.numericUpDown1.Value));
            bsTests.DataSource = service.GetTests();
        }

        private void DelTest_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ви впевнені?", "Видалення запису", MessageBoxButtons.OKCancel) == DialogResult.OK)
                service.DeleteTest(SelectedTest);
            bsTests.DataSource = service.GetTests();
        }

        private void EditTest_Click(object sender, EventArgs e)
        {
            var s = new NewTestForm();
            s.NametextBox.Text = SelectedTest.name;
            s.numericUpDown1.Value = SelectedTest.time;
            var s1 = s.ShowDialog();
            if (s1 == DialogResult.OK)
                service.SaveTest(new UITest(s.NametextBox.Text, (int)s.numericUpDown1.Value, SelectedTest.id));
            bsTests.DataSource = service.GetTests();
            NametextBox.Text = SelectedTest.name;
            MinutesForTestTextBox.Text = SelectedTest.time.ToString();
        }

        private void AddQuestion_Click(object sender, EventArgs e)
        {
            var s = new NewQuestionForm();
            var s1 = s.ShowDialog();
            if (s1 == DialogResult.OK)
                service.SaveQuestion(new UIQuestion(s.NewQuestiontextBox.Text), SelectedTest);
            bsQuestions.DataSource = service.GetQuestions(SelectedTest);
        }

        private void DelQuestion_Click(object sender, EventArgs e)
        {
            if (SelectedQuestion != null)
            {
                if (MessageBox.Show("Ви впевнені?", "Видалення запису", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    service.DeleteQuestion(SelectedQuestion);
                bsQuestions.DataSource = service.GetQuestions(SelectedTest);
            }
        }

        private void EditQuestion_Click(object sender, EventArgs e)
        {
            if (SelectedQuestion != null)
            {
                var s = new NewQuestionForm();
                s.NewQuestiontextBox.Text = SelectedQuestion.QuestionText;
                var s1 = s.ShowDialog();
                if (s1 == DialogResult.OK)
                    service.SaveQuestion(new UIQuestion(s.NewQuestiontextBox.Text, SelectedQuestion.Id), SelectedTest);
                bsQuestions.DataSource = service.GetQuestions(SelectedTest);
            }
        }

        private void AddAnswer_Click(object sender, EventArgs e)
        {
            if (SelectedQuestion != null)
            {
                var s = new NewAnswerForm();
                var s1 = s.ShowDialog();
                if (s1 == DialogResult.OK)
                    service.SaveAnswer(new UIAnswer(s.NewAnswerTextBox.Text, s.NewAnswerIsCorrect.Checked), SelectedQuestion);
                bsAnswers.DataSource = service.GetAnswers(SelectedQuestion);
            }
        }

        private void DelAnswer_Click(object sender, EventArgs e)
        {
            if (SelectedAnswer != null)
            {
                if (MessageBox.Show("Ви впевнені?", "Видалення запису", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    service.DeleteAnswer(SelectedAnswer);
                bsAnswers.DataSource = service.GetAnswers(SelectedQuestion);
            }
        }

        private void EditAnswer_Click(object sender, EventArgs e)
        {
            if (SelectedAnswer != null)
            {
                var s = new NewAnswerForm();
                s.NewAnswerTextBox.Text = SelectedAnswer.AnswerText;
                s.NewAnswerIsCorrect.Checked = SelectedAnswer.IsCorrect;
                var s1 = s.ShowDialog();
                if (s1 == DialogResult.OK)
                    service.SaveAnswer(new UIAnswer(s.NewAnswerTextBox.Text, s.NewAnswerIsCorrect.Checked, SelectedAnswer.Id), SelectedQuestion);
                bsAnswers.DataSource = service.GetAnswers(SelectedQuestion);
            }
        }

        private void Finishbutton_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            lbTimer.BackColor = Color.Transparent;
            DisableUI(false);

            var stat = new UIStatistics();

            foreach (var item in splitContainer4.Panel2.Controls)
            {
                var s = item as GroupBox;
                if (s != null)
                {
                    var res = 0;
                    var correct = 0;
                    foreach (Control btn in s.Controls)
                    {
                        var tag = (UIAnswer)btn.Tag;
                        if (tag.IsCorrect)
                            correct++;
                        var w = btn as RadioButton;
                        if (w != null)
                        {
                            if (w.Checked && tag.IsCorrect)
                                res++;
                        }

                        var w1 = btn as CheckBox;
                        if (w1 != null)
                        {
                            if (w1.Checked && tag.IsCorrect)
                                res++;
                        }
                    }
                    if (res == correct)
                        stat.NumberOfCorrect++;

                }
            }
            stat.TestName = SelectedTest.name;
            stat.TimeInMinutes = secondsCounter;
            stat.PercentOfCorrect = stat.NumberOfCorrect * 100 / (int)splitContainer4.Panel2.Tag;
            service.SaveStatistics(stat);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Startbutton.Enabled)
                if (MessageBox.Show("Ви впевнені?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    Finishbutton_Click(sender, e);
                else
                    e.Cancel = true;
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (!Startbutton.Enabled)
            {
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var s = new StatisticsForm(service);
            
            s.ShowDialog();
        }
    }
}