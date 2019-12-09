namespace TestsApplication
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.User = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.UserTestList = new System.Windows.Forms.ListBox();
            this.bsTests = new System.Windows.Forms.BindingSource(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.UserTestTimetextBox = new System.Windows.Forms.Label();
            this.UserTestNametextBox = new System.Windows.Forms.Label();
            this.lbTimer = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Startbutton = new System.Windows.Forms.Button();
            this.Finishbutton = new System.Windows.Forms.Button();
            this.Admin = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.TestsList = new System.Windows.Forms.ListBox();
            this.searchTestBox = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.AddTest = new System.Windows.Forms.ToolStripButton();
            this.DelTest = new System.Windows.Forms.ToolStripButton();
            this.EditTest = new System.Windows.Forms.ToolStripButton();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.QuestionGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsQuestions = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.AddQuestion = new System.Windows.Forms.ToolStripButton();
            this.DelQuestion = new System.Windows.Forms.ToolStripButton();
            this.EditQuestion = new System.Windows.Forms.ToolStripButton();
            this.AnswersGrid = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsAnswers = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.AddAnswer = new System.Windows.Forms.ToolStripButton();
            this.DelAnswer = new System.Windows.Forms.ToolStripButton();
            this.EditAnswer = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MinutesForTestTextBox = new System.Windows.Forms.TextBox();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.test2DBDataSet = new TestsApplication.Test2DBDataSet();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.User.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsTests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.Admin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsQuestions)).BeginInit();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnswersGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAnswers)).BeginInit();
            this.toolStrip3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.test2DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.User);
            this.tabControl1.Controls.Add(this.Admin);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1099, 633);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // User
            // 
            this.User.Controls.Add(this.splitContainer1);
            this.User.Location = new System.Drawing.Point(4, 25);
            this.User.Name = "User";
            this.User.Padding = new System.Windows.Forms.Padding(3);
            this.User.Size = new System.Drawing.Size(1091, 604);
            this.User.TabIndex = 0;
            this.User.Text = "User";
            this.User.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.UserTestList);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.textBox2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer4);
            this.splitContainer1.Size = new System.Drawing.Size(1085, 598);
            this.splitContainer1.SplitterDistance = 291;
            this.splitContainer1.TabIndex = 0;
            // 
            // UserTestList
            // 
            this.UserTestList.DataSource = this.bsTests;
            this.UserTestList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserTestList.FormattingEnabled = true;
            this.UserTestList.ItemHeight = 16;
            this.UserTestList.Location = new System.Drawing.Point(0, 26);
            this.UserTestList.Name = "UserTestList";
            this.UserTestList.Size = new System.Drawing.Size(291, 539);
            this.UserTestList.TabIndex = 0;
            this.UserTestList.SelectedIndexChanged += new System.EventHandler(this.UserTestList_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox2.Location = new System.Drawing.Point(0, 0);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(291, 26);
            this.textBox2.TabIndex = 1;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.UserTestTimetextBox);
            this.splitContainer4.Panel1.Controls.Add(this.UserTestNametextBox);
            this.splitContainer4.Panel1.Controls.Add(this.lbTimer);
            this.splitContainer4.Panel1.Controls.Add(this.label4);
            this.splitContainer4.Panel1.Controls.Add(this.label3);
            this.splitContainer4.Panel1.Controls.Add(this.Startbutton);
            this.splitContainer4.Panel1.Controls.Add(this.Finishbutton);
            this.splitContainer4.Size = new System.Drawing.Size(790, 598);
            this.splitContainer4.SplitterDistance = 86;
            this.splitContainer4.TabIndex = 0;
            // 
            // UserTestTimetextBox
            // 
            this.UserTestTimetextBox.Location = new System.Drawing.Point(335, 43);
            this.UserTestTimetextBox.Name = "UserTestTimetextBox";
            this.UserTestTimetextBox.Size = new System.Drawing.Size(100, 25);
            this.UserTestTimetextBox.TabIndex = 9;
            this.UserTestTimetextBox.Text = "label6";
            // 
            // UserTestNametextBox
            // 
            this.UserTestNametextBox.Location = new System.Drawing.Point(335, 20);
            this.UserTestNametextBox.Name = "UserTestNametextBox";
            this.UserTestNametextBox.Size = new System.Drawing.Size(100, 20);
            this.UserTestNametextBox.TabIndex = 8;
            this.UserTestNametextBox.Text = "label6";
            // 
            // lbTimer
            // 
            this.lbTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimer.Location = new System.Drawing.Point(471, 18);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(203, 50);
            this.lbTimer.TabIndex = 7;
            this.lbTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(21, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(289, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Час для виконання тесту в хвилинах";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Назва тесту";
            // 
            // Startbutton
            // 
            this.Startbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Startbutton.Location = new System.Drawing.Point(685, 17);
            this.Startbutton.Name = "Startbutton";
            this.Startbutton.Size = new System.Drawing.Size(93, 23);
            this.Startbutton.TabIndex = 2;
            this.Startbutton.Text = "Розпочати";
            this.Startbutton.UseVisualStyleBackColor = true;
            this.Startbutton.Click += new System.EventHandler(this.Startbutton_Click);
            // 
            // Finishbutton
            // 
            this.Finishbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Finishbutton.Location = new System.Drawing.Point(685, 49);
            this.Finishbutton.Name = "Finishbutton";
            this.Finishbutton.Size = new System.Drawing.Size(93, 23);
            this.Finishbutton.TabIndex = 1;
            this.Finishbutton.Text = "Закінчити";
            this.Finishbutton.UseVisualStyleBackColor = true;
            this.Finishbutton.Click += new System.EventHandler(this.Finishbutton_Click);
            // 
            // Admin
            // 
            this.Admin.Controls.Add(this.splitContainer2);
            this.Admin.Location = new System.Drawing.Point(4, 25);
            this.Admin.Name = "Admin";
            this.Admin.Padding = new System.Windows.Forms.Padding(3);
            this.Admin.Size = new System.Drawing.Size(1091, 604);
            this.Admin.TabIndex = 1;
            this.Admin.Text = "Admin";
            this.Admin.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 3);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.TestsList);
            this.splitContainer2.Panel1.Controls.Add(this.searchTestBox);
            this.splitContainer2.Panel1.Controls.Add(this.toolStrip1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Panel2.Controls.Add(this.panel1);
            this.splitContainer2.Size = new System.Drawing.Size(1085, 598);
            this.splitContainer2.SplitterDistance = 321;
            this.splitContainer2.TabIndex = 0;
            // 
            // TestsList
            // 
            this.TestsList.DataSource = this.bsTests;
            this.TestsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TestsList.FormattingEnabled = true;
            this.TestsList.ItemHeight = 16;
            this.TestsList.Location = new System.Drawing.Point(0, 52);
            this.TestsList.Name = "TestsList";
            this.TestsList.Size = new System.Drawing.Size(321, 546);
            this.TestsList.TabIndex = 0;
            this.TestsList.SelectedIndexChanged += new System.EventHandler(this.TestsList_SelectedIndexChanged);
            // 
            // searchTestBox
            // 
            this.searchTestBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchTestBox.Location = new System.Drawing.Point(0, 27);
            this.searchTestBox.Margin = new System.Windows.Forms.Padding(0);
            this.searchTestBox.Multiline = true;
            this.searchTestBox.Name = "searchTestBox";
            this.searchTestBox.Size = new System.Drawing.Size(321, 25);
            this.searchTestBox.TabIndex = 1;
            this.searchTestBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddTest,
            this.DelTest,
            this.EditTest});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(321, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // AddTest
            // 
            this.AddTest.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddTest.Image = ((System.Drawing.Image)(resources.GetObject("AddTest.Image")));
            this.AddTest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddTest.Name = "AddTest";
            this.AddTest.Size = new System.Drawing.Size(24, 24);
            this.AddTest.Text = "toolStripButton1";
            this.AddTest.Click += new System.EventHandler(this.AddTest_Click);
            // 
            // DelTest
            // 
            this.DelTest.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DelTest.Image = ((System.Drawing.Image)(resources.GetObject("DelTest.Image")));
            this.DelTest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DelTest.Name = "DelTest";
            this.DelTest.Size = new System.Drawing.Size(24, 24);
            this.DelTest.Text = "toolStripButton2";
            this.DelTest.Click += new System.EventHandler(this.DelTest_Click);
            // 
            // EditTest
            // 
            this.EditTest.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EditTest.Image = ((System.Drawing.Image)(resources.GetObject("EditTest.Image")));
            this.EditTest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditTest.Name = "EditTest";
            this.EditTest.Size = new System.Drawing.Size(24, 24);
            this.EditTest.Text = "toolStripButton3";
            this.EditTest.Click += new System.EventHandler(this.EditTest_Click);
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 73);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.QuestionGrid);
            this.splitContainer3.Panel1.Controls.Add(this.toolStrip2);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.AnswersGrid);
            this.splitContainer3.Panel2.Controls.Add(this.toolStrip3);
            this.splitContainer3.Size = new System.Drawing.Size(760, 525);
            this.splitContainer3.SplitterDistance = 177;
            this.splitContainer3.TabIndex = 1;
            // 
            // QuestionGrid
            // 
            this.QuestionGrid.AllowUserToDeleteRows = false;
            this.QuestionGrid.AutoGenerateColumns = false;
            this.QuestionGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.QuestionGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.QuestionGrid.DataSource = this.bsQuestions;
            this.QuestionGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QuestionGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.QuestionGrid.Location = new System.Drawing.Point(0, 27);
            this.QuestionGrid.MultiSelect = false;
            this.QuestionGrid.Name = "QuestionGrid";
            this.QuestionGrid.RowTemplate.Height = 24;
            this.QuestionGrid.Size = new System.Drawing.Size(760, 150);
            this.QuestionGrid.TabIndex = 0;
            this.QuestionGrid.SelectionChanged += new System.EventHandler(this.QuestionGrid_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "QuestionText";
            this.Column1.HeaderText = "Текст питання";
            this.Column1.Name = "Column1";
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddQuestion,
            this.DelQuestion,
            this.EditQuestion});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(760, 27);
            this.toolStrip2.TabIndex = 3;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // AddQuestion
            // 
            this.AddQuestion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddQuestion.Image = ((System.Drawing.Image)(resources.GetObject("AddQuestion.Image")));
            this.AddQuestion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddQuestion.Name = "AddQuestion";
            this.AddQuestion.Size = new System.Drawing.Size(24, 24);
            this.AddQuestion.Text = "toolStripButton1";
            this.AddQuestion.Click += new System.EventHandler(this.AddQuestion_Click);
            // 
            // DelQuestion
            // 
            this.DelQuestion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DelQuestion.Image = ((System.Drawing.Image)(resources.GetObject("DelQuestion.Image")));
            this.DelQuestion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DelQuestion.Name = "DelQuestion";
            this.DelQuestion.Size = new System.Drawing.Size(24, 24);
            this.DelQuestion.Text = "toolStripButton2";
            this.DelQuestion.Click += new System.EventHandler(this.DelQuestion_Click);
            // 
            // EditQuestion
            // 
            this.EditQuestion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EditQuestion.Image = ((System.Drawing.Image)(resources.GetObject("EditQuestion.Image")));
            this.EditQuestion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditQuestion.Name = "EditQuestion";
            this.EditQuestion.Size = new System.Drawing.Size(24, 24);
            this.EditQuestion.Text = "toolStripButton3";
            this.EditQuestion.Click += new System.EventHandler(this.EditQuestion_Click);
            // 
            // AnswersGrid
            // 
            this.AnswersGrid.AllowUserToDeleteRows = false;
            this.AnswersGrid.AutoGenerateColumns = false;
            this.AnswersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AnswersGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column2});
            this.AnswersGrid.DataSource = this.bsAnswers;
            this.AnswersGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AnswersGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.AnswersGrid.Location = new System.Drawing.Point(0, 27);
            this.AnswersGrid.Name = "AnswersGrid";
            this.AnswersGrid.RowTemplate.Height = 24;
            this.AnswersGrid.Size = new System.Drawing.Size(760, 317);
            this.AnswersGrid.TabIndex = 0;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "IsCorrect";
            this.Column3.HeaderText = "Вірна відповідь";
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "AnswerText";
            this.Column2.HeaderText = "Текст відповіді";
            this.Column2.Name = "Column2";
            // 
            // toolStrip3
            // 
            this.toolStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddAnswer,
            this.DelAnswer,
            this.EditAnswer});
            this.toolStrip3.Location = new System.Drawing.Point(0, 0);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(760, 27);
            this.toolStrip3.TabIndex = 3;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // AddAnswer
            // 
            this.AddAnswer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddAnswer.Image = ((System.Drawing.Image)(resources.GetObject("AddAnswer.Image")));
            this.AddAnswer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddAnswer.Name = "AddAnswer";
            this.AddAnswer.Size = new System.Drawing.Size(24, 24);
            this.AddAnswer.Text = "toolStripButton1";
            this.AddAnswer.Click += new System.EventHandler(this.AddAnswer_Click);
            // 
            // DelAnswer
            // 
            this.DelAnswer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DelAnswer.Image = ((System.Drawing.Image)(resources.GetObject("DelAnswer.Image")));
            this.DelAnswer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DelAnswer.Name = "DelAnswer";
            this.DelAnswer.Size = new System.Drawing.Size(24, 24);
            this.DelAnswer.Text = "toolStripButton2";
            this.DelAnswer.Click += new System.EventHandler(this.DelAnswer_Click);
            // 
            // EditAnswer
            // 
            this.EditAnswer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EditAnswer.Image = ((System.Drawing.Image)(resources.GetObject("EditAnswer.Image")));
            this.EditAnswer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditAnswer.Name = "EditAnswer";
            this.EditAnswer.Size = new System.Drawing.Size(24, 24);
            this.EditAnswer.Text = "toolStripButton3";
            this.EditAnswer.Click += new System.EventHandler(this.EditAnswer_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MinutesForTestTextBox);
            this.panel1.Controls.Add(this.NametextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 73);
            this.panel1.TabIndex = 0;
            // 
            // MinutesForTestTextBox
            // 
            this.MinutesForTestTextBox.Location = new System.Drawing.Point(337, 36);
            this.MinutesForTestTextBox.Name = "MinutesForTestTextBox";
            this.MinutesForTestTextBox.Size = new System.Drawing.Size(100, 22);
            this.MinutesForTestTextBox.TabIndex = 4;
            // 
            // NametextBox
            // 
            this.NametextBox.Location = new System.Drawing.Point(139, 11);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(298, 22);
            this.NametextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Тривалість проходження тесту в хвилинах";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Назва тесту";
            // 
            // test2DBDataSet
            // 
            this.test2DBDataSet.DataSetName = "Test2DBDataSet";
            this.test2DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(0, 565);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(291, 33);
            this.button1.TabIndex = 2;
            this.button1.Text = "Переглянути статистику";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1099, 633);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Проходження тестів";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.User.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsTests)).EndInit();
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.Admin.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            this.splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.QuestionGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsQuestions)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AnswersGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAnswers)).EndInit();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.test2DBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage User;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabPage Admin;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.ListBox TestsList;
        private System.Windows.Forms.TextBox searchTestBox;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.DataGridView QuestionGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.BindingSource bsQuestions;
        private System.Windows.Forms.BindingSource bsTests;
        private System.Windows.Forms.DataGridView AnswersGrid;
        private System.Windows.Forms.BindingSource bsAnswers;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.TextBox MinutesForTestTextBox;
        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox UserTestList;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Startbutton;
        private System.Windows.Forms.Button Finishbutton;
        private Test2DBDataSet test2DBDataSet;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton AddTest;
        private System.Windows.Forms.ToolStripButton DelTest;
        private System.Windows.Forms.ToolStripButton EditTest;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton AddQuestion;
        private System.Windows.Forms.ToolStripButton DelQuestion;
        private System.Windows.Forms.ToolStripButton EditQuestion;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton AddAnswer;
        private System.Windows.Forms.ToolStripButton DelAnswer;
        private System.Windows.Forms.ToolStripButton EditAnswer;
        private System.Windows.Forms.Label UserTestTimetextBox;
        private System.Windows.Forms.Label UserTestNametextBox;
        private System.Windows.Forms.Label lbTimer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
    }
}

