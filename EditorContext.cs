using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
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

        public void ToDefaultStyle(System.Windows.Forms.TextBox textBox)
        {
            textBox.Font = new Font("Microsoft Sans Serif", 8);
            textBox.BackColor = Color.White;
            textBox.ForeColor = Color.Black;
        }

        public void ToEmptyContent(System.Windows.Forms.TextBox textBox, ToolStripStatusLabel status)
        {
            textBox.Clear();
            unsaved = false;
            filename = "Безымянный";
            content = string.Empty;
            status.Text = "Статус: Создан пустой файл";
        }

        public void ChangeForeColor(System.Windows.Forms.TextBox textBox)
        {
            ColorDialog myColor = new ColorDialog();
            if (myColor.ShowDialog() == DialogResult.OK)
            {
                textBox.ForeColor = myColor.Color;
            }
        }

        public void ChangeBackColor(System.Windows.Forms.TextBox textBox)
        {
            ColorDialog myColor = new ColorDialog();
            if (myColor.ShowDialog() == DialogResult.OK)
            {
                textBox.BackColor = myColor.Color;
            }
        }

        public void Opening(System.Windows.Forms.TextBox textBox1, ToolStripStatusLabel status)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Текстовый документ (*.txt) |*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(ofd.FileName);
                textBox1.Text = content = sr.ReadToEnd();
                sr.Close();
                filename = ofd.FileName;
                status.Text = "Статус: Файл открыт";
            }
        }

        public void Saving(System.Windows.Forms.TextBox textBox1, ToolStripStatusLabel status)
        {
            content = textBox1.Text;
            StreamWriter sw = new StreamWriter(filename);
            sw.Write(textBox1.Text);
            sw.Close();
            status.Text = "Статус: Файл сохранен";
            unsaved = false;
        }
        

        public void SavingAs(System.Windows.Forms.TextBox textBox1, ToolStripStatusLabel status)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Текстовый документ (*.txt) |*.txt";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(sfd.FileName);
                sw.Write(textBox1.Text);
                sw.Close();
                filename = sfd.FileName;
                content = textBox1.Text;
                status.Text = "Статус: Файл сохранен";
                unsaved = false;
            }
        }


        public void ChangeFont(System.Windows.Forms.TextBox textBox1) 
        {
            FontDialog myFont = new FontDialog();

            if (myFont.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = myFont.Font;

            }
        }


    }
}
