using Microsoft.Office.Interop.Word;
using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace l26
{
    public partial class Form1 : Form
    {
        private string templatePath = "";
        private string outputPath = "";
        private Microsoft.Office.Interop.Word.Application wordApp;

        public Form1()
        {
            InitializeComponent();
            this.FormClosed += Form1_FormClosed; // Добавляем обработчик события FormClosed
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            wordApp?.Quit();
        }

        private void btnSelectTemplate_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Word Document (*.dotx)|*.dotx";
            openFileDialog.Title = "Select a Word Template File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                templatePath = openFileDialog.FileName;
                txtTemplatePath.Text = templatePath;
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(templatePath))
            {
                wordApp = new Microsoft.Office.Interop.Word.Application();
                Document wordDoc = null;

                try
                {
                    object missingObj = System.Reflection.Missing.Value;
                    object templatePathObj = templatePath;

                    wordDoc = wordApp.Documents.Add(ref templatePathObj, ref missingObj, ref missingObj, ref missingObj);
                    wordDoc.Activate();

                    ReplacePlaceholder("<nazva>", name.Text, wordDoc);
                    ReplacePlaceholder("<instr>", about.Text, wordDoc);
                    ReplacePlaceholder("<name>", yname.Text, wordDoc);
                    ReplacePlaceholder("<number>", number.Text, wordDoc);
                    ReplacePlaceholder("<gmail>", email.Text, wordDoc);

                    wordApp.Visible = true;

                    string outputPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $"{about.Text} re.docx");
                    wordDoc.SaveAs2(outputPath);
                    MessageBox.Show(" generated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    wordDoc?.Close();
                }
            }
            else
            {
                MessageBox.Show("Please select a Word template file first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReplacePlaceholder(string placeholder, string value, Document wordDoc)
        {
            object replaceAll = WdReplace.wdReplaceAll;
            wordApp.Selection.Find.Text = placeholder;
            wordApp.Selection.Find.Replacement.Text = value;
            wordApp.Selection.Find.Execute(FindText: Type.Missing, MatchCase: false, MatchWholeWord: false, MatchWildcards: false, MatchSoundsLike: Type.Missing, MatchAllWordForms: false, Forward: true, Wrap: WdFindWrap.wdFindContinue, Format: false, ReplaceWith: Type.Missing, Replace: replaceAll);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Word Document (*.docx)|*.docx";
            saveFileDialog.Title = "Save the Word Document";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                outputPath = saveFileDialog.FileName;
                txtSave.Text = outputPath;
            }
        }
    }
}