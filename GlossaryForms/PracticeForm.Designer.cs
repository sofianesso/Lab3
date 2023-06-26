namespace GlossaryForms
{
    partial class PracticeForm
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
            lblQuestion = new Label();
            txtUserAnswer = new TextBox();
            btnOk = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblQuestion
            // 
            lblQuestion.AutoSize = true;
            lblQuestion.Location = new Point(132, 60);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(59, 25);
            lblQuestion.TabIndex = 0;
            lblQuestion.Text = "label1";
            lblQuestion.Click += lblQuestion_Click;
            // 
            // txtUserAnswer
            // 
            txtUserAnswer.Location = new Point(66, 135);
            txtUserAnswer.Name = "txtUserAnswer";
            txtUserAnswer.Size = new Size(310, 31);
            txtUserAnswer.TabIndex = 1;
            txtUserAnswer.TextChanged += txtUserAnswer_TextChanged;
            // 
            // btnOk
            // 
            btnOk.DialogResult = DialogResult.OK;
            btnOk.Location = new Point(66, 203);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(112, 34);
            btnOk.TabIndex = 2;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Click += btnOk_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(264, 203);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 3;
            btnCancel.Text = "Ångra";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // PracticeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 308);
            Controls.Add(btnCancel);
            Controls.Add(btnOk);
            Controls.Add(txtUserAnswer);
            Controls.Add(lblQuestion);
            Name = "PracticeForm";
            Text = "PracticeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label lblQuestion;
        private TextBox txtUserAnswer;
        private Button btnOk;
        private Button btnCancel;

    }
}