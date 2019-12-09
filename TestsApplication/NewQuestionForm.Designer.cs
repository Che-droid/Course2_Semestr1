namespace TestsApplication
{
    partial class NewQuestionForm
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
            this.NewQuestOkButton = new System.Windows.Forms.Button();
            this.NewQuestCancelButton = new System.Windows.Forms.Button();
            this.NewQuestiontextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NewQuestOkButton
            // 
            this.NewQuestOkButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.NewQuestOkButton.Location = new System.Drawing.Point(199, 112);
            this.NewQuestOkButton.Name = "NewQuestOkButton";
            this.NewQuestOkButton.Size = new System.Drawing.Size(75, 23);
            this.NewQuestOkButton.TabIndex = 0;
            this.NewQuestOkButton.Text = "OK";
            this.NewQuestOkButton.UseVisualStyleBackColor = true;
            // 
            // NewQuestCancelButton
            // 
            this.NewQuestCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.NewQuestCancelButton.Location = new System.Drawing.Point(330, 112);
            this.NewQuestCancelButton.Name = "NewQuestCancelButton";
            this.NewQuestCancelButton.Size = new System.Drawing.Size(75, 23);
            this.NewQuestCancelButton.TabIndex = 1;
            this.NewQuestCancelButton.Text = "Cancel";
            this.NewQuestCancelButton.UseVisualStyleBackColor = true;
            // 
            // NewQuestiontextBox
            // 
            this.NewQuestiontextBox.Location = new System.Drawing.Point(136, 31);
            this.NewQuestiontextBox.Multiline = true;
            this.NewQuestiontextBox.Name = "NewQuestiontextBox";
            this.NewQuestiontextBox.Size = new System.Drawing.Size(269, 22);
            this.NewQuestiontextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Текст питання";
            // 
            // NewQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 157);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NewQuestiontextBox);
            this.Controls.Add(this.NewQuestCancelButton);
            this.Controls.Add(this.NewQuestOkButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewQuestionForm";
            this.Text = "Нове питання";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button NewQuestOkButton;
        private System.Windows.Forms.Button NewQuestCancelButton;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox NewQuestiontextBox;
    }
}