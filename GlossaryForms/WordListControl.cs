using GlossaryLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlossaryForms
{
    public partial class WordListControl : UserControl
    {
        public WordListControl()
        {
            InitializeComponent();
            UpdateLists();
        }


        public void UpdateLists()
        {
            cbLists.Items.Clear();
            var lists = WordList.GetLists();
            foreach (var list in lists)
            {
                cbLists.Items.Add(list);
            }
        }

        private void LoadList(string listName)
        {
            lbWords.Items.Clear();

            WordList list = WordList.LoadList(listName);

            if (list != null)
            {
                list.List(0, translations =>
                {
                    lbWords.Items.Add(string.Join(", ", translations));
                });

                lblLanguages.Text = "Språk: " + string.Join(", ", list.Languages);
            }
            else
            {
                MessageBox.Show("Listan existerar inte.");
            }
        }


        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedList = cbLists.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedList))
            {
                LoadList(selectedList);
            }
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // jobb pågår.
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string listToRemove = cbLists.SelectedItem.ToString();
            string directoryPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            directoryPath = Path.Combine(directoryPath, "GlossarySolution", listToRemove + ".dat");

            if (File.Exists(directoryPath))
            {
                File.Delete(directoryPath);
                UpdateLists();
                MessageBox.Show("Listan har tagits bort.");
            }
            else
            {
                MessageBox.Show("Listan existerar inte.");
            }
        }

        private void TxtAddWord_TextChanged(object sender, EventArgs e)
        {
            // jobb pågår.
        }

        private void BtnAddWord_Click(object sender, EventArgs e)
        {
            string inputWord = txtAddWord.Text;

            if (!string.IsNullOrEmpty(inputWord))
            {
                string selectedList = cbLists.SelectedItem.ToString();
                WordList list = WordList.LoadList(selectedList);

                if (list != null)
                {
                    string[] translations = inputWord.Split(',');
                    if (translations.Length != list.Languages.Length)
                    {
                        MessageBox.Show($"Vänligen tillhandahåll översättningar för alla {list.Languages.Length} språk.");
                        return;
                    }

                    list.Add(translations);
                    list.Save();
                    LoadList(selectedList);
                    MessageBox.Show("Ordet har lagts till.");
                }
                else
                {
                    MessageBox.Show("Listan existerar inte.");
                }
            }
            else
            {
                MessageBox.Show("Vänligen ange ett ord att lägga till.");
            }
        }


        private void TxtRemoveWord_TextChanged(object sender, EventArgs e)
        {
            // jobb pågår.
        }


        private void BtnRemoveWord_Click(object sender, EventArgs e)
        {
            string wordToRemove = txtRemoveWord.Text;

            if (!string.IsNullOrEmpty(wordToRemove))
            {
                string selectedList = cbLists.SelectedItem.ToString();
                WordList list = WordList.LoadList(selectedList);

                if (list != null)
                {
                    if (list.Remove(wordToRemove))
                    {
                        list.Save();
                        LoadList(selectedList);
                        MessageBox.Show("Ordet har tagits bort.");
                    }
                    else
                    {
                        MessageBox.Show("Ordet kunde inte hittas. Se till att du skrivit in ordet korrekt.\r\n");
                    }
                }
                else
                {
                    MessageBox.Show("Listan existerar inte.");
                }
            }
            else
            {
                MessageBox.Show("Ange ett ord att ta bort.");
            }
        }


        private void BtnCountWords_Click(object sender, EventArgs e)
        {
            string selectedList = cbLists.SelectedItem.ToString();
            WordList list = WordList.LoadList(selectedList);

            if (list != null)
            {
                int wordCount = list.Count();
                MessageBox.Show($"Listan innehåller {wordCount} ord.");
            }
            else
            {
                MessageBox.Show("Listan existerar inte.");
            }
        }


        private void BtnPractice_Click(object sender, EventArgs e)
        {
            string selectedList = cbLists.SelectedItem.ToString();
            WordList list = WordList.LoadList(selectedList);

            if (list != null)
            {
                Word wordToPractice = list.GetWordToPractice();
                if (wordToPractice != null)
                {
                    MessageBox.Show($"Öva detta ord: {wordToPractice}");
                }
                else
                {
                    MessageBox.Show("Listan är tom, det finns inget att öva på.");
                }
            }
            else
            {
                MessageBox.Show("Listan existerar inte.");
            }
        }

        private void BtnAddList_Click(object sender, EventArgs e)
        {
            string newListName = txtListInput.Text; 
            string[] languages = txtLanguages.Text.Split(','); 
            WordList newList = new WordList(newListName, languages);
            newList.Save();
            UpdateLists();
        }

        private void TxtListInput_TextChanged(object sender, EventArgs e)
        {
            //jobb pågår.
        }

        private void LblLanguages_Click(object sender, EventArgs e)
        {
            //jobb pågår.

        }

    }
}
