
namespace Рисование_сплайнами_и_кривыми_Безье
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.выборКривойToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очисткаЭкранаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.незамкнутаяЛоманаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.замкнутаяЛоманаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.незамкнутыйСплайнToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.замкнутыйСплайнToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.однаКриваяБезьеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.незамнктуаяКриваяБезьеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.замкнутаяКриваяБезьеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(582, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Урпугость сплайна";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(741, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выборКривойToolStripMenuItem,
            this.очисткаЭкранаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // выборКривойToolStripMenuItem
            // 
            this.выборКривойToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.незамкнутаяЛоманаяToolStripMenuItem,
            this.замкнутаяЛоманаяToolStripMenuItem,
            this.незамкнутыйСплайнToolStripMenuItem,
            this.замкнутыйСплайнToolStripMenuItem,
            this.однаКриваяБезьеToolStripMenuItem,
            this.незамнктуаяКриваяБезьеToolStripMenuItem,
            this.замкнутаяКриваяБезьеToolStripMenuItem});
            this.выборКривойToolStripMenuItem.Name = "выборКривойToolStripMenuItem";
            this.выборКривойToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.выборКривойToolStripMenuItem.Text = "Выбор кривой";
            // 
            // очисткаЭкранаToolStripMenuItem
            // 
            this.очисткаЭкранаToolStripMenuItem.Name = "очисткаЭкранаToolStripMenuItem";
            this.очисткаЭкранаToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.очисткаЭкранаToolStripMenuItem.Text = "Очистка экрана";
            this.очисткаЭкранаToolStripMenuItem.Click += new System.EventHandler(this.очисткаЭкранаToolStripMenuItem_Click);
            // 
            // незамкнутаяЛоманаяToolStripMenuItem
            // 
            this.незамкнутаяЛоманаяToolStripMenuItem.Name = "незамкнутаяЛоманаяToolStripMenuItem";
            this.незамкнутаяЛоманаяToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.незамкнутаяЛоманаяToolStripMenuItem.Text = "Незамкнутая ломаная";
            this.незамкнутаяЛоманаяToolStripMenuItem.Click += new System.EventHandler(this.незамкнутаяЛоманаяToolStripMenuItem_Click);
            // 
            // замкнутаяЛоманаяToolStripMenuItem
            // 
            this.замкнутаяЛоманаяToolStripMenuItem.Name = "замкнутаяЛоманаяToolStripMenuItem";
            this.замкнутаяЛоманаяToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.замкнутаяЛоманаяToolStripMenuItem.Text = "Замкнутая ломаная";
            this.замкнутаяЛоманаяToolStripMenuItem.Click += new System.EventHandler(this.замкнутаяЛоманаяToolStripMenuItem_Click);
            // 
            // незамкнутыйСплайнToolStripMenuItem
            // 
            this.незамкнутыйСплайнToolStripMenuItem.Name = "незамкнутыйСплайнToolStripMenuItem";
            this.незамкнутыйСплайнToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.незамкнутыйСплайнToolStripMenuItem.Text = "Незамкнутый сплайн";
            this.незамкнутыйСплайнToolStripMenuItem.Click += new System.EventHandler(this.незамкнутыйСплайнToolStripMenuItem_Click);
            // 
            // замкнутыйСплайнToolStripMenuItem
            // 
            this.замкнутыйСплайнToolStripMenuItem.Name = "замкнутыйСплайнToolStripMenuItem";
            this.замкнутыйСплайнToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.замкнутыйСплайнToolStripMenuItem.Text = "Замкнутый сплайн";
            // 
            // однаКриваяБезьеToolStripMenuItem
            // 
            this.однаКриваяБезьеToolStripMenuItem.Name = "однаКриваяБезьеToolStripMenuItem";
            this.однаКриваяБезьеToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.однаКриваяБезьеToolStripMenuItem.Text = "Одна Кривая Безье";
            this.однаКриваяБезьеToolStripMenuItem.Click += new System.EventHandler(this.однаКриваяБезьеToolStripMenuItem_Click);
            // 
            // незамнктуаяКриваяБезьеToolStripMenuItem
            // 
            this.незамнктуаяКриваяБезьеToolStripMenuItem.Name = "незамнктуаяКриваяБезьеToolStripMenuItem";
            this.незамнктуаяКриваяБезьеToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.незамнктуаяКриваяБезьеToolStripMenuItem.Text = "Незамнктуая кривая Безье";
            this.незамнктуаяКриваяБезьеToolStripMenuItem.Click += new System.EventHandler(this.незамнктуаяКриваяБезьеToolStripMenuItem_Click);
            // 
            // замкнутаяКриваяБезьеToolStripMenuItem
            // 
            this.замкнутаяКриваяБезьеToolStripMenuItem.Name = "замкнутаяКриваяБезьеToolStripMenuItem";
            this.замкнутаяКриваяБезьеToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.замкнутаяКриваяБезьеToolStripMenuItem.Text = "Замкнутая кривая Безье";
            this.замкнутаяКриваяБезьеToolStripMenuItem.Click += new System.EventHandler(this.замкнутаяКриваяБезьеToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 361);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Рисование сплайнами и кривыми Безье";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem выборКривойToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem незамкнутаяЛоманаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem замкнутаяЛоманаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem незамкнутыйСплайнToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem замкнутыйСплайнToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem однаКриваяБезьеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem незамнктуаяКриваяБезьеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem замкнутаяКриваяБезьеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очисткаЭкранаToolStripMenuItem;
    }
}

