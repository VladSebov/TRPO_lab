namespace TechProg2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Файл = new System.Windows.Forms.ToolStripMenuItem();
            this.Создать = new System.Windows.Forms.ToolStripMenuItem();
            this.Открыть = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.Сохранить = new System.Windows.Forms.ToolStripMenuItem();
            this.СохранитьКак = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Выход = new System.Windows.Forms.ToolStripMenuItem();
            this.Правка = new System.Windows.Forms.ToolStripMenuItem();
            this.ОтменаДействия = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Вырезать = new System.Windows.Forms.ToolStripMenuItem();
            this.Копировать = new System.Windows.Forms.ToolStripMenuItem();
            this.Вставка = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ВыделитьВсе = new System.Windows.Forms.ToolStripMenuItem();
            this.Вид = new System.Windows.Forms.ToolStripMenuItem();
            this.Шрифт = new System.Windows.Forms.ToolStripMenuItem();
            this.ЦветТекста = new System.Windows.Forms.ToolStripMenuItem();
            this.ЦветФона = new System.Windows.Forms.ToolStripMenuItem();
            this.разделениеЭкранаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вертикальноеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.горизонтальноеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.снятьРазделениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Справка = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.ОПрограмме = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripLengthLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox2 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Файл,
            this.Правка,
            this.Вид,
            this.Справка});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(2, 2, 0, 0);
            this.menuStrip1.Size = new System.Drawing.Size(804, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Файл
            // 
            this.Файл.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Создать,
            this.Открыть,
            this.toolStripSeparator,
            this.Сохранить,
            this.СохранитьКак,
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.Выход});
            this.Файл.Name = "Файл";
            this.Файл.Size = new System.Drawing.Size(48, 22);
            this.Файл.Text = "&Файл";
            // 
            // Создать
            // 
            this.Создать.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Создать.Name = "Создать";
            this.Создать.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.Создать.Size = new System.Drawing.Size(226, 22);
            this.Создать.Text = "&Создать";
            this.Создать.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // Открыть
            // 
            this.Открыть.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Открыть.Name = "Открыть";
            this.Открыть.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.Открыть.Size = new System.Drawing.Size(226, 22);
            this.Открыть.Text = "&Открыть";
            this.Открыть.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(223, 6);
            // 
            // Сохранить
            // 
            this.Сохранить.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Сохранить.Name = "Сохранить";
            this.Сохранить.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.Сохранить.Size = new System.Drawing.Size(226, 22);
            this.Сохранить.Text = "&Сохранить";
            this.Сохранить.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // СохранитьКак
            // 
            this.СохранитьКак.Name = "СохранитьКак";
            this.СохранитьКак.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.СохранитьКак.Size = new System.Drawing.Size(226, 22);
            this.СохранитьКак.Text = "Сохранить &как";
            this.СохранитьКак.Click += new System.EventHandler(this.сохранитькакToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(223, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(223, 6);
            // 
            // Выход
            // 
            this.Выход.Name = "Выход";
            this.Выход.Size = new System.Drawing.Size(226, 22);
            this.Выход.Text = "Вы&ход";
            this.Выход.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // Правка
            // 
            this.Правка.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ОтменаДействия,
            this.toolStripSeparator3,
            this.Вырезать,
            this.Копировать,
            this.Вставка,
            this.toolStripSeparator4,
            this.ВыделитьВсе});
            this.Правка.Name = "Правка";
            this.Правка.Size = new System.Drawing.Size(59, 22);
            this.Правка.Text = "&Правка";
            // 
            // ОтменаДействия
            // 
            this.ОтменаДействия.Name = "ОтменаДействия";
            this.ОтменаДействия.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.ОтменаДействия.Size = new System.Drawing.Size(209, 22);
            this.ОтменаДействия.Text = "&Отмена действия";
            this.ОтменаДействия.Click += new System.EventHandler(this.отменадействияToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(206, 6);
            // 
            // Вырезать
            // 
            this.Вырезать.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Вырезать.Name = "Вырезать";
            this.Вырезать.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.Вырезать.Size = new System.Drawing.Size(209, 22);
            this.Вырезать.Text = "Вырезат&ь";
            this.Вырезать.Click += new System.EventHandler(this.вырезатьToolStripMenuItem_Click);
            // 
            // Копировать
            // 
            this.Копировать.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Копировать.Name = "Копировать";
            this.Копировать.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.Копировать.Size = new System.Drawing.Size(209, 22);
            this.Копировать.Text = "&Копировать";
            this.Копировать.Click += new System.EventHandler(this.копироватьToolStripMenuItem_Click);
            // 
            // Вставка
            // 
            this.Вставка.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Вставка.Name = "Вставка";
            this.Вставка.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.Вставка.Size = new System.Drawing.Size(209, 22);
            this.Вставка.Text = "Вст&авка";
            this.Вставка.Click += new System.EventHandler(this.вставкаToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(206, 6);
            // 
            // ВыделитьВсе
            // 
            this.ВыделитьВсе.Name = "ВыделитьВсе";
            this.ВыделитьВсе.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.ВыделитьВсе.Size = new System.Drawing.Size(209, 22);
            this.ВыделитьВсе.Text = "Выделить &все";
            this.ВыделитьВсе.Click += new System.EventHandler(this.выделитьвсеToolStripMenuItem_Click);
            // 
            // Вид
            // 
            this.Вид.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Шрифт,
            this.ЦветТекста,
            this.ЦветФона,
            this.разделениеЭкранаToolStripMenuItem});
            this.Вид.Name = "Вид";
            this.Вид.Size = new System.Drawing.Size(39, 22);
            this.Вид.Text = "Вид";
            // 
            // Шрифт
            // 
            this.Шрифт.Name = "Шрифт";
            this.Шрифт.Size = new System.Drawing.Size(178, 22);
            this.Шрифт.Text = "Шрифт";
            this.Шрифт.Click += new System.EventHandler(this.шрифтToolStripMenuItem_Click);
            // 
            // ЦветТекста
            // 
            this.ЦветТекста.Name = "ЦветТекста";
            this.ЦветТекста.Size = new System.Drawing.Size(178, 22);
            this.ЦветТекста.Text = "Цвет текста";
            this.ЦветТекста.Click += new System.EventHandler(this.цветТекстаToolStripMenuItem_Click);
            // 
            // ЦветФона
            // 
            this.ЦветФона.Name = "ЦветФона";
            this.ЦветФона.Size = new System.Drawing.Size(178, 22);
            this.ЦветФона.Text = "Цвет фона";
            this.ЦветФона.Click += new System.EventHandler(this.цветФонаToolStripMenuItem_Click);
            // 
            // разделениеЭкранаToolStripMenuItem
            // 
            this.разделениеЭкранаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вертикальноеToolStripMenuItem,
            this.горизонтальноеToolStripMenuItem,
            this.снятьРазделениеToolStripMenuItem});
            this.разделениеЭкранаToolStripMenuItem.Name = "разделениеЭкранаToolStripMenuItem";
            this.разделениеЭкранаToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.разделениеЭкранаToolStripMenuItem.Text = "Разделение экрана";
            // 
            // вертикальноеToolStripMenuItem
            // 
            this.вертикальноеToolStripMenuItem.Name = "вертикальноеToolStripMenuItem";
            this.вертикальноеToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.вертикальноеToolStripMenuItem.Text = "Вертикальное";
            this.вертикальноеToolStripMenuItem.Click += new System.EventHandler(this.вертикальноеToolStripMenuItem_Click);
            // 
            // горизонтальноеToolStripMenuItem
            // 
            this.горизонтальноеToolStripMenuItem.Name = "горизонтальноеToolStripMenuItem";
            this.горизонтальноеToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.горизонтальноеToolStripMenuItem.Text = "Горизонтальное";
            this.горизонтальноеToolStripMenuItem.Click += new System.EventHandler(this.горизонтальноеToolStripMenuItem_Click);
            // 
            // снятьРазделениеToolStripMenuItem
            // 
            this.снятьРазделениеToolStripMenuItem.Name = "снятьРазделениеToolStripMenuItem";
            this.снятьРазделениеToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.снятьРазделениеToolStripMenuItem.Text = "Снять разделение";
            this.снятьРазделениеToolStripMenuItem.Visible = false;
            this.снятьРазделениеToolStripMenuItem.Click += new System.EventHandler(this.снятьРазделениеToolStripMenuItem_Click);
            // 
            // Справка
            // 
            this.Справка.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator5,
            this.ОПрограмме});
            this.Справка.Name = "Справка";
            this.Справка.Size = new System.Drawing.Size(65, 22);
            this.Справка.Text = "Спра&вка";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(155, 6);
            // 
            // ОПрограмме
            // 
            this.ОПрограмме.Name = "ОПрограмме";
            this.ОПрограмме.Size = new System.Drawing.Size(158, 22);
            this.ОПрограмме.Text = "&О программе...";
            this.ОПрограмме.Click += new System.EventHandler(this.опрограммеToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripLengthLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 429);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(804, 22);
            this.statusStrip.TabIndex = 3;
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(161, 17);
            this.toolStripStatusLabel.Text = "Статус: Создан пустой файл";
            this.toolStripStatusLabel.TextChanged += new System.EventHandler(this.toolStripStatusLabel_TextChanged);
            // 
            // toolStripLengthLabel
            // 
            this.toolStripLengthLabel.Name = "toolStripLengthLabel";
            this.toolStripLengthLabel.Size = new System.Drawing.Size(76, 17);
            this.toolStripLengthLabel.Text = "Символов: 0";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(2, 22);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBox2);
            this.splitContainer1.Panel2Collapsed = true;
            this.splitContainer1.Size = new System.Drawing.Size(794, 411);
            this.splitContainer1.SplitterDistance = 220;
            this.splitContainer1.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(780, 395);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(7, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(780, 288);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 451);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.splitContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Безымянный - Блокнот";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClosing_Click);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Файл;
        private System.Windows.Forms.ToolStripMenuItem Создать;
        private System.Windows.Forms.ToolStripMenuItem Открыть;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem Сохранить;
        private System.Windows.Forms.ToolStripMenuItem СохранитьКак;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem Выход;
        private System.Windows.Forms.ToolStripMenuItem Правка;
        private System.Windows.Forms.ToolStripMenuItem ОтменаДействия;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem Вырезать;
        private System.Windows.Forms.ToolStripMenuItem Копировать;
        private System.Windows.Forms.ToolStripMenuItem Вставка;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem ВыделитьВсе;
        private System.Windows.Forms.ToolStripMenuItem Вид;
        private System.Windows.Forms.ToolStripMenuItem Шрифт;
        private System.Windows.Forms.ToolStripMenuItem ЦветТекста;
        private System.Windows.Forms.ToolStripMenuItem ЦветФона;
        private System.Windows.Forms.ToolStripMenuItem Справка;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem ОПрограмме;
        private System.Windows.Forms.ToolStripMenuItem разделениеЭкранаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вертикальноеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem горизонтальноеToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripLengthLabel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripMenuItem снятьРазделениеToolStripMenuItem;
        private System.Windows.Forms.RichTextBox textBox1;
        private System.Windows.Forms.RichTextBox textBox2;
    }
}

