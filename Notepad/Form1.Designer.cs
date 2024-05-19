namespace Notepad
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            створитиToolStripMenuItem = new ToolStripMenuItem();
            новеВікноToolStripMenuItem = new ToolStripMenuItem();
            відкритиToolStripMenuItem = new ToolStripMenuItem();
            зберегтиToolStripMenuItem = new ToolStripMenuItem();
            зберегтиЯкToolStripMenuItem = new ToolStripMenuItem();
            параметриСторінкиToolStripMenuItem = new ToolStripMenuItem();
            друкToolStripMenuItem = new ToolStripMenuItem();
            вийтиToolStripMenuItem = new ToolStripMenuItem();
            редагуванняToolStripMenuItem = new ToolStripMenuItem();
            скасуватиToolStripMenuItem = new ToolStripMenuItem();
            вирізатиToolStripMenuItem = new ToolStripMenuItem();
            копіюватиToolStripMenuItem = new ToolStripMenuItem();
            вставитиToolStripMenuItem = new ToolStripMenuItem();
            видалитиToolStripMenuItem = new ToolStripMenuItem();
            знайтиToolStripMenuItem = new ToolStripMenuItem();
            знайтиДаліToolStripMenuItem = new ToolStripMenuItem();
            знайтиРанішеToolStripMenuItem = new ToolStripMenuItem();
            замінитиToolStripMenuItem = new ToolStripMenuItem();
            виділитиВсеToolStripMenuItem = new ToolStripMenuItem();
            датаЙЧасToolStripMenuItem = new ToolStripMenuItem();
            форматToolStripMenuItem = new ToolStripMenuItem();
            переносПоСловахToolStripMenuItem = new ToolStripMenuItem();
            включитьToolStripMenuItem = new ToolStripMenuItem();
            виключитьToolStripMenuItem = new ToolStripMenuItem();
            шрифтToolStripMenuItem = new ToolStripMenuItem();
            темаToolStripMenuItem = new ToolStripMenuItem();
            світлаToolStripMenuItem = new ToolStripMenuItem();
            темнаToolStripMenuItem = new ToolStripMenuItem();
            виглядToolStripMenuItem = new ToolStripMenuItem();
            маштабToolStripMenuItem = new ToolStripMenuItem();
            включитьToolStripMenuItem2 = new ToolStripMenuItem();
            зменшитиToolStripMenuItem = new ToolStripMenuItem();
            виключитьToolStripMenuItem2 = new ToolStripMenuItem();
            рядокСтануToolStripMenuItem = new ToolStripMenuItem();
            включитьToolStripMenuItem1 = new ToolStripMenuItem();
            виключитьToolStripMenuItem1 = new ToolStripMenuItem();
            довідкаToolStripMenuItem = new ToolStripMenuItem();
            переглянутиДовідкиToolStripMenuItem = new ToolStripMenuItem();
            надіслатиВідгукToolStripMenuItem = new ToolStripMenuItem();
            проПрограмуToolStripMenuItem = new ToolStripMenuItem();
            richTextBox1 = new RichTextBox();
            panel1 = new Panel();
            Simvol = new Label();
            Tekst = new Label();
            label2 = new Label();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ButtonShadow;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, редагуванняToolStripMenuItem, форматToolStripMenuItem, виглядToolStripMenuItem, довідкаToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { створитиToolStripMenuItem, новеВікноToolStripMenuItem, відкритиToolStripMenuItem, зберегтиToolStripMenuItem, зберегтиЯкToolStripMenuItem, параметриСторінкиToolStripMenuItem, друкToolStripMenuItem, вийтиToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(59, 24);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // створитиToolStripMenuItem
            // 
            створитиToolStripMenuItem.Name = "створитиToolStripMenuItem";
            створитиToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            створитиToolStripMenuItem.Size = new Size(272, 26);
            створитиToolStripMenuItem.Text = "Створити";
            створитиToolStripMenuItem.Click += CreateToolStripMenuItem_Click;
            // 
            // новеВікноToolStripMenuItem
            // 
            новеВікноToolStripMenuItem.Name = "новеВікноToolStripMenuItem";
            новеВікноToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.N;
            новеВікноToolStripMenuItem.Size = new Size(272, 26);
            новеВікноToolStripMenuItem.Text = "Нове вікно";
            новеВікноToolStripMenuItem.Click += NewWindowToolStripMenuItem_Click;
            // 
            // відкритиToolStripMenuItem
            // 
            відкритиToolStripMenuItem.Name = "відкритиToolStripMenuItem";
            відкритиToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            відкритиToolStripMenuItem.Size = new Size(272, 26);
            відкритиToolStripMenuItem.Text = "Відкрити...";
            відкритиToolStripMenuItem.Click += OpenToolStripMenuItem_Click;
            // 
            // зберегтиToolStripMenuItem
            // 
            зберегтиToolStripMenuItem.Name = "зберегтиToolStripMenuItem";
            зберегтиToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            зберегтиToolStripMenuItem.Size = new Size(272, 26);
            зберегтиToolStripMenuItem.Text = "Зберегти";
            зберегтиToolStripMenuItem.Click += SaveToolStripMenuItem_Click;
            // 
            // зберегтиЯкToolStripMenuItem
            // 
            зберегтиЯкToolStripMenuItem.Name = "зберегтиЯкToolStripMenuItem";
            зберегтиЯкToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Shift | Keys.S;
            зберегтиЯкToolStripMenuItem.Size = new Size(272, 26);
            зберегтиЯкToolStripMenuItem.Text = "Зберегти як";
            зберегтиЯкToolStripMenuItem.Click += SaveAsToolStripMenuItem_Click;
            // 
            // параметриСторінкиToolStripMenuItem
            // 
            параметриСторінкиToolStripMenuItem.Name = "параметриСторінкиToolStripMenuItem";
            параметриСторінкиToolStripMenuItem.Size = new Size(272, 26);
            параметриСторінкиToolStripMenuItem.Text = "Параметри сторінки";
            параметриСторінкиToolStripMenuItem.Click += PageSetupСторінкиToolStripMenuItem_Click;
            // 
            // друкToolStripMenuItem
            // 
            друкToolStripMenuItem.Name = "друкToolStripMenuItem";
            друкToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            друкToolStripMenuItem.Size = new Size(272, 26);
            друкToolStripMenuItem.Text = "Друк...";
            друкToolStripMenuItem.Click += PrintToolStripMenuItem_Click;
            // 
            // вийтиToolStripMenuItem
            // 
            вийтиToolStripMenuItem.Name = "вийтиToolStripMenuItem";
            вийтиToolStripMenuItem.Size = new Size(272, 26);
            вийтиToolStripMenuItem.Text = "Вийти";
            вийтиToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            // 
            // редагуванняToolStripMenuItem
            // 
            редагуванняToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { скасуватиToolStripMenuItem, вирізатиToolStripMenuItem, копіюватиToolStripMenuItem, вставитиToolStripMenuItem, видалитиToolStripMenuItem, знайтиToolStripMenuItem, знайтиДаліToolStripMenuItem, знайтиРанішеToolStripMenuItem, замінитиToolStripMenuItem, виділитиВсеToolStripMenuItem, датаЙЧасToolStripMenuItem });
            редагуванняToolStripMenuItem.Name = "редагуванняToolStripMenuItem";
            редагуванняToolStripMenuItem.Size = new Size(110, 24);
            редагуванняToolStripMenuItem.Text = "Редагування";
            // 
            // скасуватиToolStripMenuItem
            // 
            скасуватиToolStripMenuItem.Name = "скасуватиToolStripMenuItem";
            скасуватиToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            скасуватиToolStripMenuItem.Size = new Size(267, 26);
            скасуватиToolStripMenuItem.Text = "Скасувати ";
            скасуватиToolStripMenuItem.Click += UndoToolStripMenuItem_Click;
            // 
            // вирізатиToolStripMenuItem
            // 
            вирізатиToolStripMenuItem.Name = "вирізатиToolStripMenuItem";
            вирізатиToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            вирізатиToolStripMenuItem.Size = new Size(267, 26);
            вирізатиToolStripMenuItem.Text = "Вирізати";
            вирізатиToolStripMenuItem.Click += CutToolStripMenuItem_Click;
            // 
            // копіюватиToolStripMenuItem
            // 
            копіюватиToolStripMenuItem.Name = "копіюватиToolStripMenuItem";
            копіюватиToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            копіюватиToolStripMenuItem.Size = new Size(267, 26);
            копіюватиToolStripMenuItem.Text = "Копіювати";
            копіюватиToolStripMenuItem.Click += CopyToolStripMenuItem_Click;
            // 
            // вставитиToolStripMenuItem
            // 
            вставитиToolStripMenuItem.Name = "вставитиToolStripMenuItem";
            вставитиToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            вставитиToolStripMenuItem.Size = new Size(267, 26);
            вставитиToolStripMenuItem.Text = "Вставити";
            вставитиToolStripMenuItem.Click += PasteToolStripMenuItem_Click;
            // 
            // видалитиToolStripMenuItem
            // 
            видалитиToolStripMenuItem.Name = "видалитиToolStripMenuItem";
            видалитиToolStripMenuItem.ShortcutKeys = Keys.Delete;
            видалитиToolStripMenuItem.Size = new Size(267, 26);
            видалитиToolStripMenuItem.Text = "Видалити";
            видалитиToolStripMenuItem.Click += DeleteToolStripMenuItem_Click;
            // 
            // знайтиToolStripMenuItem
            // 
            знайтиToolStripMenuItem.Name = "знайтиToolStripMenuItem";
            знайтиToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F;
            знайтиToolStripMenuItem.Size = new Size(267, 26);
            знайтиToolStripMenuItem.Text = "Знайти ";
            знайтиToolStripMenuItem.Click += FindToolStripMenuItem_Click;
            // 
            // знайтиДаліToolStripMenuItem
            // 
            знайтиДаліToolStripMenuItem.Name = "знайтиДаліToolStripMenuItem";
            знайтиДаліToolStripMenuItem.ShortcutKeys = Keys.F3;
            знайтиДаліToolStripMenuItem.Size = new Size(267, 26);
            знайтиДаліToolStripMenuItem.Text = "Знайти далі";
            знайтиДаліToolStripMenuItem.Click += FindNextToolStripMenuItem_Click;
            // 
            // знайтиРанішеToolStripMenuItem
            // 
            знайтиРанішеToolStripMenuItem.Name = "знайтиРанішеToolStripMenuItem";
            знайтиРанішеToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F3;
            знайтиРанішеToolStripMenuItem.Size = new Size(267, 26);
            знайтиРанішеToolStripMenuItem.Text = "Знайти раніше";
            знайтиРанішеToolStripMenuItem.Click += FindPreviousToolStripMenuItem_Click;
            // 
            // замінитиToolStripMenuItem
            // 
            замінитиToolStripMenuItem.Name = "замінитиToolStripMenuItem";
            замінитиToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.H;
            замінитиToolStripMenuItem.Size = new Size(267, 26);
            замінитиToolStripMenuItem.Text = "Замінити...";
            замінитиToolStripMenuItem.Click += ReplaceToolStripMenuItem_Click;
            // 
            // виділитиВсеToolStripMenuItem
            // 
            виділитиВсеToolStripMenuItem.Name = "виділитиВсеToolStripMenuItem";
            виділитиВсеToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            виділитиВсеToolStripMenuItem.Size = new Size(267, 26);
            виділитиВсеToolStripMenuItem.Text = "Виділити все";
            виділитиВсеToolStripMenuItem.Click += SelectAllToolStripMenuItem_Click;
            // 
            // датаЙЧасToolStripMenuItem
            // 
            датаЙЧасToolStripMenuItem.Name = "датаЙЧасToolStripMenuItem";
            датаЙЧасToolStripMenuItem.ShortcutKeys = Keys.F5;
            датаЙЧасToolStripMenuItem.Size = new Size(267, 26);
            датаЙЧасToolStripMenuItem.Text = "Дата й час";
            датаЙЧасToolStripMenuItem.Click += DateTimeToolStripMenuItem_Click;
            // 
            // форматToolStripMenuItem
            // 
            форматToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { переносПоСловахToolStripMenuItem, шрифтToolStripMenuItem, темаToolStripMenuItem });
            форматToolStripMenuItem.Name = "форматToolStripMenuItem";
            форматToolStripMenuItem.Size = new Size(81, 24);
            форматToolStripMenuItem.Text = "Формат ";
            // 
            // переносПоСловахToolStripMenuItem
            // 
            переносПоСловахToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { включитьToolStripMenuItem, виключитьToolStripMenuItem });
            переносПоСловахToolStripMenuItem.Name = "переносПоСловахToolStripMenuItem";
            переносПоСловахToolStripMenuItem.Size = new Size(226, 26);
            переносПоСловахToolStripMenuItem.Text = "Перенос по словах";
            // 
            // включитьToolStripMenuItem
            // 
            включитьToolStripMenuItem.Name = "включитьToolStripMenuItem";
            включитьToolStripMenuItem.Size = new Size(168, 26);
            включитьToolStripMenuItem.Text = "Включить";
            включитьToolStripMenuItem.Click += EnableWordWrapToolStripMenuItem_Click;
            // 
            // виключитьToolStripMenuItem
            // 
            виключитьToolStripMenuItem.Name = "виключитьToolStripMenuItem";
            виключитьToolStripMenuItem.Size = new Size(168, 26);
            виключитьToolStripMenuItem.Text = "Виключить";
            виключитьToolStripMenuItem.Click += DisableWordWrapToolStripMenuItem_Click;
            // 
            // шрифтToolStripMenuItem
            // 
            шрифтToolStripMenuItem.Name = "шрифтToolStripMenuItem";
            шрифтToolStripMenuItem.Size = new Size(226, 26);
            шрифтToolStripMenuItem.Text = "Шрифт";
            шрифтToolStripMenuItem.Click += FontToolStripMenuItem_Click;
            // 
            // темаToolStripMenuItem
            // 
            темаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { світлаToolStripMenuItem, темнаToolStripMenuItem });
            темаToolStripMenuItem.Name = "темаToolStripMenuItem";
            темаToolStripMenuItem.Size = new Size(226, 26);
            темаToolStripMenuItem.Text = "Тема";
            // 
            // світлаToolStripMenuItem
            // 
            світлаToolStripMenuItem.Name = "світлаToolStripMenuItem";
            світлаToolStripMenuItem.Size = new Size(136, 26);
            світлаToolStripMenuItem.Text = "Світла";
            світлаToolStripMenuItem.Click += LightThemeToolStripMenuItem_Click;
            // 
            // темнаToolStripMenuItem
            // 
            темнаToolStripMenuItem.Name = "темнаToolStripMenuItem";
            темнаToolStripMenuItem.Size = new Size(136, 26);
            темнаToolStripMenuItem.Text = "Темна";
            темнаToolStripMenuItem.Click += DarkThemeToolStripMenuItem_Click;
            // 
            // виглядToolStripMenuItem
            // 
            виглядToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { маштабToolStripMenuItem, рядокСтануToolStripMenuItem });
            виглядToolStripMenuItem.Name = "виглядToolStripMenuItem";
            виглядToolStripMenuItem.Size = new Size(71, 24);
            виглядToolStripMenuItem.Text = "Вигляд";
            // 
            // маштабToolStripMenuItem
            // 
            маштабToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { включитьToolStripMenuItem2, зменшитиToolStripMenuItem, виключитьToolStripMenuItem2 });
            маштабToolStripMenuItem.Name = "маштабToolStripMenuItem";
            маштабToolStripMenuItem.Size = new Size(224, 26);
            маштабToolStripMenuItem.Text = "Маштаб";
            маштабToolStripMenuItem.Click += ZoonInToolStripMenuItem_Click;
            // 
            // включитьToolStripMenuItem2
            // 
            включитьToolStripMenuItem2.Name = "включитьToolStripMenuItem2";
            включитьToolStripMenuItem2.Size = new Size(224, 26);
            включитьToolStripMenuItem2.Text = "Збільшити";
            включитьToolStripMenuItem2.Click += ZoomInToolStripMenuItem2_Click;
            // 
            // зменшитиToolStripMenuItem
            // 
            зменшитиToolStripMenuItem.Name = "зменшитиToolStripMenuItem";
            зменшитиToolStripMenuItem.Size = new Size(224, 26);
            зменшитиToolStripMenuItem.Text = "Зменшити";
            зменшитиToolStripMenuItem.Click += ZoomOutToolStripMenuItem_Click;
            // 
            // виключитьToolStripMenuItem2
            // 
            виключитьToolStripMenuItem2.Name = "виключитьToolStripMenuItem2";
            виключитьToolStripMenuItem2.Size = new Size(224, 26);
            виключитьToolStripMenuItem2.Text = "Відновити ";
            виключитьToolStripMenuItem2.Click += RestoreZoomToolStripMenuItem2_Click;
            // 
            // рядокСтануToolStripMenuItem
            // 
            рядокСтануToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { включитьToolStripMenuItem1, виключитьToolStripMenuItem1 });
            рядокСтануToolStripMenuItem.Name = "рядокСтануToolStripMenuItem";
            рядокСтануToolStripMenuItem.Size = new Size(224, 26);
            рядокСтануToolStripMenuItem.Text = "Рядок стану";
            рядокСтануToolStripMenuItem.Click += StatusLineToolStripMenuItem_Click;
            // 
            // включитьToolStripMenuItem1
            // 
            включитьToolStripMenuItem1.Name = "включитьToolStripMenuItem1";
            включитьToolStripMenuItem1.Size = new Size(224, 26);
            включитьToolStripMenuItem1.Text = "Включить";
            включитьToolStripMenuItem1.Click += Enablestatus_barToolStripMenuItem1_Click;
            // 
            // виключитьToolStripMenuItem1
            // 
            виключитьToolStripMenuItem1.Name = "виключитьToolStripMenuItem1";
            виключитьToolStripMenuItem1.Size = new Size(224, 26);
            виключитьToolStripMenuItem1.Text = "Виключить";
            виключитьToolStripMenuItem1.Click += Disablestatus_barToolStripMenuItem1_Click;
            // 
            // довідкаToolStripMenuItem
            // 
            довідкаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { переглянутиДовідкиToolStripMenuItem, надіслатиВідгукToolStripMenuItem, проПрограмуToolStripMenuItem });
            довідкаToolStripMenuItem.Name = "довідкаToolStripMenuItem";
            довідкаToolStripMenuItem.Size = new Size(77, 24);
            довідкаToolStripMenuItem.Text = "Довідка";
            // 
            // переглянутиДовідкиToolStripMenuItem
            // 
            переглянутиДовідкиToolStripMenuItem.Name = "переглянутиДовідкиToolStripMenuItem";
            переглянутиДовідкиToolStripMenuItem.Size = new Size(238, 26);
            переглянутиДовідкиToolStripMenuItem.Text = "Переглянути довідки";
            переглянутиДовідкиToolStripMenuItem.Click += ViewHelpToolStripMenuItem_Click;
            // 
            // надіслатиВідгукToolStripMenuItem
            // 
            надіслатиВідгукToolStripMenuItem.Name = "надіслатиВідгукToolStripMenuItem";
            надіслатиВідгукToolStripMenuItem.Size = new Size(238, 26);
            надіслатиВідгукToolStripMenuItem.Text = "Надіслати відгук";
            надіслатиВідгукToolStripMenuItem.Click += SendFeedbackToolStripMenuItem_Click;
            // 
            // проПрограмуToolStripMenuItem
            // 
            проПрограмуToolStripMenuItem.Name = "проПрограмуToolStripMenuItem";
            проПрограмуToolStripMenuItem.Size = new Size(238, 26);
            проПрограмуToolStripMenuItem.Text = "Про програму";
            проПрограмуToolStripMenuItem.Click += AboutProgramToolStripMenuItem_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.DimGray;
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.ForeColor = Color.White;
            richTextBox1.Location = new Point(0, 28);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(800, 422);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(Simvol);
            panel1.Controls.Add(Tekst);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 414);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 36);
            panel1.TabIndex = 2;
            // 
            // Simvol
            // 
            Simvol.AutoSize = true;
            Simvol.Location = new Point(189, 8);
            Simvol.Name = "Simvol";
            Simvol.Size = new Size(21, 20);
            Simvol.TabIndex = 3;
            Simvol.Text = "....";
            // 
            // Tekst
            // 
            Tekst.AutoSize = true;
            Tekst.Location = new Point(75, 8);
            Tekst.Name = "Tekst";
            Tekst.Size = new Size(21, 20);
            Tekst.TabIndex = 2;
            Tekst.Text = "....";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(131, 8);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 1;
            label2.Text = "Рядок:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 7);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 0;
            label1.Text = "Текст:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = " текстовий редактор:Блокнот";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem відкритиToolStripMenuItem;
        private ToolStripMenuItem зберегтиToolStripMenuItem;
        private ToolStripMenuItem зберегтиЯкToolStripMenuItem;
        private ToolStripMenuItem параметриСторінкиToolStripMenuItem;
        private ToolStripMenuItem редагуванняToolStripMenuItem;
        private ToolStripMenuItem форматToolStripMenuItem;
        private ToolStripMenuItem виглядToolStripMenuItem;
        private ToolStripMenuItem довідкаToolStripMenuItem;
        private ToolStripMenuItem друкToolStripMenuItem;
        private ToolStripMenuItem вийтиToolStripMenuItem;
        private ToolStripMenuItem скасуватиToolStripMenuItem;
        private ToolStripMenuItem вирізатиToolStripMenuItem;
        private ToolStripMenuItem копіюватиToolStripMenuItem;
        private ToolStripMenuItem вставитиToolStripMenuItem;
        private ToolStripMenuItem знайтиToolStripMenuItem;
        private ToolStripMenuItem знайтиДаліToolStripMenuItem;
        private RichTextBox richTextBox1;
        private Panel panel1;
        private Label Simvol;
        private Label Tekst;
        private Label label2;
        private Label label1;
        private ToolStripMenuItem створитиToolStripMenuItem;
        private ToolStripMenuItem новеВікноToolStripMenuItem;
        private ToolStripMenuItem знайтиРанішеToolStripMenuItem;
        private ToolStripMenuItem замінитиToolStripMenuItem;
        private ToolStripMenuItem виділитиВсеToolStripMenuItem;
        private ToolStripMenuItem датаЙЧасToolStripMenuItem;
        private ToolStripMenuItem переносПоСловахToolStripMenuItem;
        private ToolStripMenuItem шрифтToolStripMenuItem;
        private ToolStripMenuItem маштабToolStripMenuItem;
        private ToolStripMenuItem рядокСтануToolStripMenuItem;
        private ToolStripMenuItem переглянутиДовідкиToolStripMenuItem;
        private ToolStripMenuItem надіслатиВідгукToolStripMenuItem;
        private ToolStripMenuItem проПрограмуToolStripMenuItem;
        private ToolStripMenuItem видалитиToolStripMenuItem;
        private ToolStripMenuItem темаToolStripMenuItem;
        private ToolStripMenuItem світлаToolStripMenuItem;
        private ToolStripMenuItem темнаToolStripMenuItem;
        private ToolStripMenuItem включитьToolStripMenuItem;
        private ToolStripMenuItem виключитьToolStripMenuItem;
        private ToolStripMenuItem включитьToolStripMenuItem1;
        private ToolStripMenuItem виключитьToolStripMenuItem1;
        private ToolStripMenuItem включитьToolStripMenuItem2;
        private ToolStripMenuItem виключитьToolStripMenuItem2;
        private ToolStripMenuItem зменшитиToolStripMenuItem;
    }
}