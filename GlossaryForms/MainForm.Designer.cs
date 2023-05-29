namespace GlossaryForms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            wordListControl1 = new WordListControl();
            lblHeader = new Label();
            SuspendLayout();
            // 
            // wordListControl1
            // 
            wordListControl1.Location = new Point(17, 150);
            wordListControl1.Margin = new Padding(4, 3, 4, 3);
            wordListControl1.Name = "wordListControl1";
            wordListControl1.Size = new Size(1000, 685);
            wordListControl1.TabIndex = 0;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Jokerman", 28F, FontStyle.Regular, GraphicsUnit.Point);
            lblHeader.Location = new Point(234, 77);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(580, 82);
            lblHeader.TabIndex = 1;
            lblHeader.Text = "The Glossary Room.";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 937);
            Controls.Add(lblHeader);
            Controls.Add(wordListControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainForm";
            Text = "Monki's Glossary Room";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private WordListControl wordListControl1;
        private Label lblHeader;
    }
}