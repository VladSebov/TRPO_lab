using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TechProg2
{
    public class EditorContext
    {
        public bool unsaved = false;
        public string filename = "Безымянный";
        public string content = string.Empty;
        public bool splitMode = false;
        RichTextBoxStreamType stream_type;

        public void ToDefaultStyle(System.Windows.Forms.RichTextBox textBox)
        {
            textBox.Font = new Font("Microsoft Sans Serif", 8);
            textBox.BackColor = Color.White;
            textBox.ForeColor = Color.Black;
        }

        public void ToEmptyContent(System.Windows.Forms.RichTextBox textBox, ToolStripStatusLabel status)
        {
            textBox.Clear();
            unsaved = false;
            filename = "Безымянный";
            content = string.Empty;
            status.Text = "Статус: Создан пустой файл";
        }

        public void ChangeForeColor(System.Windows.Forms.RichTextBox textBox)
        {
            ColorDialog myColor = new ColorDialog();
            if (myColor.ShowDialog() == DialogResult.OK)
            {
                textBox.ForeColor = myColor.Color;
            }
        }

        public void ChangeBackColor(System.Windows.Forms.RichTextBox textBox)
        {
            ColorDialog myColor = new ColorDialog();
            if (myColor.ShowDialog() == DialogResult.OK)
            {
                textBox.BackColor = myColor.Color;
            }
        }

        public void Opening(System.Windows.Forms.RichTextBox textBox1, ToolStripStatusLabel status)
        {
                OpenFileDialog file_open = new OpenFileDialog();
                file_open.Filter = "Rich Text File (*.rtf)|*.rtf| Plain Text File (*.txt)|*.txt";
                file_open.FilterIndex = 1;
                file_open.Title = "Open text or RTF file";

                //Richtext: Display the dialog and grab the file name
                stream_type = RichTextBoxStreamType.RichText;
                if (DialogResult.OK == file_open.ShowDialog())
                {
                    //Richtext: Set the correct stream type 
                    //(Rich text or Plain text?)
                    if (string.IsNullOrEmpty(file_open.FileName))
                        return;
                    if (file_open.FilterIndex == 2)
                        stream_type = RichTextBoxStreamType.PlainText;
                //Richtext: Open the content of the selected file
                try
                {
                    textBox1.LoadFile(file_open.FileName, stream_type);
                    filename = file_open.FileName;
                    content = textBox1.Text;
                    unsaved = false;
                    status.Text = "Статус: Файл открыт";
                }
                catch
                {
                    status.Text = "Статус: Не удалось открыть файл";
                }
                
            }
                
        }

        public void Saving(System.Windows.Forms.RichTextBox textBox1, ToolStripStatusLabel status)
        {
            textBox1.SaveFile(filename, stream_type);
            content = textBox1.Text;
            unsaved = false;
            status.Text = "Статус: Файл сохранен";
        }
        

        public void SavingAs(System.Windows.Forms.RichTextBox textBox1, ToolStripStatusLabel status)
        {
            SaveFileDialog saveDlg = new SaveFileDialog();
            saveDlg.Filter = "Rich Text File (*.rtf)|*.rtf|Plain Text File (*.txt)|*.txt";
            saveDlg.DefaultExt = "*.rtf";
            saveDlg.FilterIndex = 1;
            saveDlg.Title = "Save the contents";

                //Richtext: Show the save file dialog
            DialogResult retval = saveDlg.ShowDialog();
                if (retval == DialogResult.OK)
                    filename = saveDlg.FileName;
                else
                    return;

                
                if (saveDlg.FilterIndex == 2)
                    stream_type = RichTextBoxStreamType.PlainText;
                else
                    stream_type = RichTextBoxStreamType.RichText;

                //Richtext: Now its time to save the content
            textBox1.SaveFile(filename, stream_type);
            content = textBox1.Text;
            unsaved = false;
            status.Text = "Статус: Файл сохранен";
                
        }


        public void ChangeFont(System.Windows.Forms.RichTextBox textBox1) 
        {
            FontDialog myFont = new FontDialog();

            if (myFont.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = myFont.Font;

            }
        }


    }
}
