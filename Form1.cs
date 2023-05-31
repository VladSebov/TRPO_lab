using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechProg2
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        EditorContext editor = new EditorContext();


        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (editor.content == textBox1.Text)
            {
                editor.unsaved = false;
                this.Text = $"{editor.filename} - Текстовый Редактор";
                if (editor.filename != "Безымянный") toolStripStatusLabel.Text = "Статус: Файл сохранён";
                else toolStripStatusLabel.Text = "Статус: Создан пустой файл";
            }
            else
            {
                editor.unsaved = true;
                this.Text = $"*{editor.filename} - Текстовый Редактор";
                toolStripStatusLabel.Text = "Статус: Файл изменён";
            }
            toolStripLengthLabel.Text = $"Символов: {textBox1.TextLength}";
            if (editor.splitMode == true) textBox2.Text = textBox1.Text;
        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text;
        }

        public void toolStripStatusLabel_TextChanged(object sender, EventArgs e)
        {
            if (toolStripStatusLabel.Text == "Статус: Создан пустой файл" || toolStripStatusLabel.Text == "Статус: Файл открыт")
            {
                editor.ToDefaultStyle(textBox1);
                if (editor.splitMode == true) textBox2.Text = textBox1.Text;
            }
            this.Text = $"*{editor.filename} - Текстовый Редактор";

        }

        private void создатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!editor.unsaved)
            {
                editor.ToDefaultStyle(textBox1);
                editor.ToEmptyContent(textBox1, toolStripStatusLabel);
            }
            else 
            {
                DialogResult result = MessageBox.Show($"Вы хотите сохранить изменения в файле: {editor.filename}?", "Блокнот", MessageBoxButtons.YesNoCancel);
                switch (result)
                {
                    case DialogResult.Cancel:
                        //Отмена сохранения
                        break;

                    case DialogResult.No:
                        //Создать новый без сохранения
                        editor.ToDefaultStyle(textBox1);
                        editor.ToEmptyContent(textBox1, toolStripStatusLabel);
                        break;

                    case DialogResult.Yes:
                        //Сохранение и выход
                        Сохранить.PerformClick();
                        editor.ToDefaultStyle(textBox1);
                        editor.ToEmptyContent(textBox1, toolStripStatusLabel);
                        break;
                }
            }
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (editor.unsaved)
            {
                DialogResult result = MessageBox.Show($"Вы хотите сохранить изменения в файле: {editor.filename}?", "Блокнот", MessageBoxButtons.YesNoCancel);
                switch (result)
                {
                    case DialogResult.Cancel:
                        //Отмена созранения
                        break;
                        
                    case DialogResult.No:
                        //Открыть без сохранения
                        break;

                    case DialogResult.Yes:
                        //Сохранение старого и открытие нового
                        Сохранить.PerformClick();
                        textBox1.Clear();
                        break;
                       
                }
                if(result != DialogResult.Cancel)
                {
                    editor.Opening(textBox1, toolStripStatusLabel);
                }
            }
            if (!editor.unsaved)
            {
                editor.Opening(textBox1, toolStripStatusLabel);
            }
            

        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (editor.filename == "Безымянный")
            {
                СохранитьКак.PerformClick();
            }
            else
            {
                editor.Saving(textBox1, toolStripStatusLabel);
            }

        }


        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void отменадействияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Undo();
        }

        private void вырезатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Focused)
                textBox1.Cut();
            if (textBox2.Focused) textBox2.Cut();
        }

        private void копироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Focused)
                textBox1.Copy();
            if (textBox2.Focused) textBox2.Copy();
        }

        private void вставкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Focused)
                textBox1.Paste();
            if (textBox2.Focused) textBox2.Paste();
            
        }

        private void выделитьвсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Focused)
                textBox1.SelectAll();
            if (textBox2.Focused) textBox2.SelectAll();
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Focused)
                editor.ChangeFont(textBox1);
            else if (textBox2.Focused) editor.ChangeFont(textBox2);
            else
            {
                editor.ChangeFont(textBox1);
                editor.ChangeFont(textBox2);
            }
        }

        private void цветТекстаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(textBox1.Focused)
            editor.ChangeForeColor(textBox1);
            else if(textBox2.Focused) editor.ChangeForeColor(textBox2);
            else 
            {
                editor.ChangeForeColor(textBox1);
                editor.ChangeForeColor(textBox2);
            }
        }

        private void цветФонаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.Focused)
                editor.ChangeBackColor(textBox1);
            else if (textBox2.Focused) editor.ChangeBackColor(textBox2);
            else
            {
                editor.ChangeBackColor(textBox1);
                editor.ChangeBackColor(textBox2);
            }
        }

        private void опрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Текстовый редактор\nВыполнил: Себов В. Н.");
        }

        private void сохранитькакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editor.SavingAs(textBox1, toolStripStatusLabel);
        }
        

        

        private void FormClosing_Click(object sender, FormClosingEventArgs e)
        {
            if (!editor.unsaved)
            {
                e.Cancel=false;
            }
            else
            {
                DialogResult result = MessageBox.Show($"Вы хотите сохранить изменения в файле: {editor.filename}?", "Блокнот", MessageBoxButtons.YesNoCancel);
                switch (result)
                {
                    case DialogResult.Cancel:
                        //Отмена закрытия
                        break;

                    case DialogResult.No:
                        //Выход без сохранения
                        break;

                    case DialogResult.Yes:
                        //Сохранение и выход
                        Сохранить.PerformClick();
                        break;
                }

                e.Cancel = (result == DialogResult.Cancel);
            }
            
        }

        private void вертикальноеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            splitContainer1.Orientation = Orientation.Vertical;
            splitContainer1.SplitterDistance = splitContainer1.Width / 2;
            splitContainer1.Panel2Collapsed = false;
            textBox2.Height = textBox1.Height;
            textBox2.Width = textBox1.Width;
            вертикальноеToolStripMenuItem.Visible = false;
            горизонтальноеToolStripMenuItem.Visible = false;
            снятьРазделениеToolStripMenuItem.Visible = true;
            textBox2.Text = textBox1.Text;
            editor.splitMode = true;
        }

        private void горизонтальноеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            splitContainer1.Orientation = Orientation.Horizontal;
            splitContainer1.SplitterDistance = splitContainer1.Height/2;
            splitContainer1.Panel2Collapsed = false;
            textBox2.Height = textBox1.Height;
            textBox2.Width = textBox1.Width;
            вертикальноеToolStripMenuItem.Visible = false;
            горизонтальноеToolStripMenuItem.Visible = false;
            снятьРазделениеToolStripMenuItem.Visible = true;
            textBox2.Text = textBox1.Text;
            editor.splitMode = true;
        }

        private void снятьРазделениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            splitContainer1.Panel2Collapsed = true;
            вертикальноеToolStripMenuItem.Visible = true;
            горизонтальноеToolStripMenuItem.Visible = true;
            снятьРазделениеToolStripMenuItem.Visible = false;
            editor.splitMode = false;
        }


    }
}
