namespace GlossaryForms
{
    partial class WordListControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cbLists = new ComboBox();
            lbWords = new ListBox();
            btnRemoveList = new Button();
            txtAddWord = new TextBox();
            btnAddWord = new Button();
            btnRemoveWord = new Button();
            txtRemoveWord = new TextBox();
            btnCountWords = new Button();
            btnPractice = new Button();
            txtListInput = new TextBox();
            btnAddList = new Button();
            txtLanguages = new TextBox();
            lblTranslations = new Label();
            label1 = new Label();
            lblLanguages = new Label();
            lbltillgängligaListor = new Label();
            lblTillgänligaOrd = new Label();
            SuspendLayout();
            // 
            // cbLists
            // 
            cbLists.FormattingEnabled = true;
            cbLists.Location = new Point(42, 126);
            cbLists.Margin = new Padding(4, 3, 4, 3);
            cbLists.Name = "cbLists";
            cbLists.Size = new Size(460, 33);
            cbLists.TabIndex = 0;
            cbLists.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            // 
            // lbWords
            // 
            lbWords.FormattingEnabled = true;
            lbWords.ItemHeight = 25;
            lbWords.Location = new Point(567, 137);
            lbWords.Margin = new Padding(4, 3, 4, 3);
            lbWords.Name = "lbWords";
            lbWords.Size = new Size(285, 204);
            lbWords.TabIndex = 1;
            lbWords.SelectedIndexChanged += ListBox1_SelectedIndexChanged;
            // 
            // btnRemoveList
            // 
            btnRemoveList.Font = new Font("JetBrains Mono", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemoveList.Location = new Point(294, 389);
            btnRemoveList.Margin = new Padding(4, 3, 4, 3);
            btnRemoveList.Name = "btnRemoveList";
            btnRemoveList.Size = new Size(207, 43);
            btnRemoveList.TabIndex = 2;
            btnRemoveList.Text = "Ta bort lista";
            btnRemoveList.UseVisualStyleBackColor = true;
            btnRemoveList.Click += Button1_Click;
            // 
            // txtAddWord
            // 
            txtAddWord.BorderStyle = BorderStyle.FixedSingle;
            txtAddWord.Location = new Point(565, 365);
            txtAddWord.Margin = new Padding(4, 3, 4, 3);
            txtAddWord.Multiline = true;
            txtAddWord.Name = "txtAddWord";
            txtAddWord.Size = new Size(285, 89);
            txtAddWord.TabIndex = 3;
            txtAddWord.TextChanged += TxtAddWord_TextChanged;
            // 
            // btnAddWord
            // 
            btnAddWord.Font = new Font("JetBrains Mono", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddWord.Location = new Point(563, 460);
            btnAddWord.Margin = new Padding(4, 3, 4, 3);
            btnAddWord.Name = "btnAddWord";
            btnAddWord.Size = new Size(287, 49);
            btnAddWord.TabIndex = 4;
            btnAddWord.Text = "Lägg till ord";
            btnAddWord.UseVisualStyleBackColor = true;
            btnAddWord.Click += BtnAddWord_Click;
            // 
            // btnRemoveWord
            // 
            btnRemoveWord.Font = new Font("JetBrains Mono", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemoveWord.Location = new Point(567, 617);
            btnRemoveWord.Margin = new Padding(4, 3, 4, 3);
            btnRemoveWord.Name = "btnRemoveWord";
            btnRemoveWord.Size = new Size(285, 49);
            btnRemoveWord.TabIndex = 5;
            btnRemoveWord.Text = "Ta bort ord";
            btnRemoveWord.UseVisualStyleBackColor = true;
            btnRemoveWord.Click += BtnRemoveWord_Click;
            // 
            // txtRemoveWord
            // 
            txtRemoveWord.Location = new Point(565, 521);
            txtRemoveWord.Margin = new Padding(4, 3, 4, 3);
            txtRemoveWord.Multiline = true;
            txtRemoveWord.Name = "txtRemoveWord";
            txtRemoveWord.Size = new Size(285, 90);
            txtRemoveWord.TabIndex = 6;
            txtRemoveWord.TextChanged += TxtRemoveWord_TextChanged;
            // 
            // btnCountWords
            // 
            btnCountWords.Font = new Font("JetBrains Mono", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            btnCountWords.Location = new Point(96, 479);
            btnCountWords.Margin = new Padding(4, 3, 4, 3);
            btnCountWords.Name = "btnCountWords";
            btnCountWords.Size = new Size(306, 52);
            btnCountWords.TabIndex = 7;
            btnCountWords.Text = "Räkna ord";
            btnCountWords.UseVisualStyleBackColor = true;
            btnCountWords.Click += BtnCountWords_Click;
            // 
            // btnPractice
            // 
            btnPractice.Font = new Font("JetBrains Mono", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            btnPractice.Location = new Point(96, 537);
            btnPractice.Margin = new Padding(4, 3, 4, 3);
            btnPractice.Name = "btnPractice";
            btnPractice.Size = new Size(306, 52);
            btnPractice.TabIndex = 8;
            btnPractice.Text = "Öva";
            btnPractice.UseVisualStyleBackColor = true;
            btnPractice.Click += BtnPractice_Click;
            // 
            // txtListInput
            // 
            txtListInput.Location = new Point(42, 346);
            txtListInput.Margin = new Padding(4, 5, 4, 5);
            txtListInput.Name = "txtListInput";
            txtListInput.Size = new Size(461, 31);
            txtListInput.TabIndex = 9;
            txtListInput.TextChanged += TxtListInput_TextChanged;
            // 
            // btnAddList
            // 
            btnAddList.Font = new Font("JetBrains Mono", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddList.Location = new Point(42, 389);
            btnAddList.Margin = new Padding(4, 5, 4, 5);
            btnAddList.Name = "btnAddList";
            btnAddList.Size = new Size(207, 43);
            btnAddList.TabIndex = 10;
            btnAddList.Text = "Skapa lista";
            btnAddList.UseVisualStyleBackColor = true;
            btnAddList.Click += BtnAddList_Click;
            // 
            // txtLanguages
            // 
            txtLanguages.Location = new Point(41, 272);
            txtLanguages.Name = "txtLanguages";
            txtLanguages.Size = new Size(460, 31);
            txtLanguages.TabIndex = 11;
            // 
            // lblTranslations
            // 
            lblTranslations.AutoSize = true;
            lblTranslations.Font = new Font("JetBrains Mono SemiBold", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            lblTranslations.Location = new Point(42, 246);
            lblTranslations.Name = "lblTranslations";
            lblTranslations.Size = new Size(461, 23);
            lblTranslations.TabIndex = 12;
            lblTranslations.Text = "Ange översättningar med kommatecken ( , )";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("JetBrains Mono SemiBold", 8.999999F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(42, 318);
            label1.Name = "label1";
            label1.Size = new Size(164, 23);
            label1.TabIndex = 13;
            label1.Text = "Namnge listan.";
            // 
            // lblLanguages
            // 
            lblLanguages.AutoSize = true;
            lblLanguages.Font = new Font("JetBrains Mono", 7.999999F, FontStyle.Bold, GraphicsUnit.Point);
            lblLanguages.Location = new Point(42, 162);
            lblLanguages.Name = "lblLanguages";
            lblLanguages.Size = new Size(70, 21);
            lblLanguages.TabIndex = 14;
            lblLanguages.Text = "Språk:";
            lblLanguages.Click += LblLanguages_Click;
            // 
            // lbltillgängligaListor
            // 
            lbltillgängligaListor.AutoSize = true;
            lbltillgängligaListor.Font = new Font("JetBrains Mono", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            lbltillgängligaListor.Location = new Point(42, 91);
            lbltillgängligaListor.Name = "lbltillgängligaListor";
            lbltillgängligaListor.Size = new Size(294, 31);
            lbltillgängligaListor.TabIndex = 15;
            lbltillgängligaListor.Text = "Tillgängliga listor.";
            // 
            // lblTillgänligaOrd
            // 
            lblTillgänligaOrd.AutoSize = true;
            lblTillgänligaOrd.Font = new Font("JetBrains Mono", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lblTillgänligaOrd.Location = new Point(664, 86);
            lblTillgänligaOrd.Name = "lblTillgänligaOrd";
            lblTillgänligaOrd.Size = new Size(85, 37);
            lblTillgänligaOrd.TabIndex = 16;
            lblTillgänligaOrd.Text = "Ord.";
            // 
            // WordListControl
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblTillgänligaOrd);
            Controls.Add(lbltillgängligaListor);
            Controls.Add(lblLanguages);
            Controls.Add(label1);
            Controls.Add(lblTranslations);
            Controls.Add(txtLanguages);
            Controls.Add(btnAddList);
            Controls.Add(txtListInput);
            Controls.Add(btnPractice);
            Controls.Add(btnCountWords);
            Controls.Add(txtRemoveWord);
            Controls.Add(btnRemoveWord);
            Controls.Add(btnAddWord);
            Controls.Add(txtAddWord);
            Controls.Add(btnRemoveList);
            Controls.Add(lbWords);
            Controls.Add(cbLists);
            Margin = new Padding(4, 3, 4, 3);
            Name = "WordListControl";
            Size = new Size(990, 683);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbLists;
        private ListBox lbWords;
        private Button btnRemoveList;
        private TextBox txtAddWord;
        private Button btnAddWord;
        private Button btnRemoveWord;
        private TextBox txtRemoveWord;
        private Button btnCountWords;
        private Button btnPractice;
        private TextBox txtListInput;
        private Button btnAddList;
        private TextBox txtLanguages;
        private Label lblTranslations;
        private Label label1;
        private Label lblLanguages;
        private Label lbltillgängligaListor;
        private Label lblTillgänligaOrd;
    }
}
