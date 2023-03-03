namespace Books
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.опцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьАвтораToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьАвтораToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьАвтораToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьАвтораToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьАвтораToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьАвтораToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.опцииToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem,
            this.выйтиToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "&Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.открытьToolStripMenuItem.Text = "&Открыть...";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.openfile);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.сохранитьToolStripMenuItem.Text = "&Сохранить...";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.SeveToolStripMenuItem_Click);
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.выйтиToolStripMenuItem.Text = "&Выйти";
            this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.выйтиToolStripMenuItem_Click);
            // 
            // опцииToolStripMenuItem
            // 
            this.опцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьАвтораToolStripMenuItem,
            this.удалитьАвтораToolStripMenuItem,
            this.редактироватьАвтораToolStripMenuItem,
            this.добавитьАвтораToolStripMenuItem1,
            this.удалитьАвтораToolStripMenuItem1,
            this.редактироватьАвтораToolStripMenuItem1});
            this.опцииToolStripMenuItem.Name = "опцииToolStripMenuItem";
            this.опцииToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.опцииToolStripMenuItem.Text = "&Опции";
            // 
            // добавитьАвтораToolStripMenuItem
            // 
            this.добавитьАвтораToolStripMenuItem.Name = "добавитьАвтораToolStripMenuItem";
            this.добавитьАвтораToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.добавитьАвтораToolStripMenuItem.Text = "&Добавить автора";
            this.добавитьАвтораToolStripMenuItem.Click += new System.EventHandler(this.AddAndEditToolStripMenuItem_Click);
            // 
            // удалитьАвтораToolStripMenuItem
            // 
            this.удалитьАвтораToolStripMenuItem.Name = "удалитьАвтораToolStripMenuItem";
            this.удалитьАвтораToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.удалитьАвтораToolStripMenuItem.Text = "&Удалить автора";
            this.удалитьАвтораToolStripMenuItem.Click += new System.EventHandler(this.DeleteьАвтораToolStripMenuItem_Click);
            // 
            // редактироватьАвтораToolStripMenuItem
            // 
            this.редактироватьАвтораToolStripMenuItem.Name = "редактироватьАвтораToolStripMenuItem";
            this.редактироватьАвтораToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.редактироватьАвтораToolStripMenuItem.Text = "&Редактировать  автора";
            this.редактироватьАвтораToolStripMenuItem.Click += new System.EventHandler(this.AddAndEditToolStripMenuItem_Click);
            // 
            // добавитьАвтораToolStripMenuItem1
            // 
            this.добавитьАвтораToolStripMenuItem1.Name = "добавитьАвтораToolStripMenuItem1";
            this.добавитьАвтораToolStripMenuItem1.Size = new System.Drawing.Size(197, 22);
            this.добавитьАвтораToolStripMenuItem1.Text = "&Добавить книгу";
            this.добавитьАвтораToolStripMenuItem1.Click += new System.EventHandler(this.AddAndEditToolStripMenuItem_Click);
            // 
            // удалитьАвтораToolStripMenuItem1
            // 
            this.удалитьАвтораToolStripMenuItem1.Name = "удалитьАвтораToolStripMenuItem1";
            this.удалитьАвтораToolStripMenuItem1.Size = new System.Drawing.Size(197, 22);
            this.удалитьАвтораToolStripMenuItem1.Text = "&Удалить книгу";
            this.удалитьАвтораToolStripMenuItem1.Click += new System.EventHandler(this.DeleteьАвтораToolStripMenuItem_Click);
            // 
            // редактироватьАвтораToolStripMenuItem1
            // 
            this.редактироватьАвтораToolStripMenuItem1.Name = "редактироватьАвтораToolStripMenuItem1";
            this.редактироватьАвтораToolStripMenuItem1.Size = new System.Drawing.Size(197, 22);
            this.редактироватьАвтораToolStripMenuItem1.Text = "&Редактировать  книгу";
            this.редактироватьАвтораToolStripMenuItem1.Click += new System.EventHandler(this.AddAndEditToolStripMenuItem_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(395, 423);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(93, 19);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "фильтрация";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Click += new System.EventHandler(this.filter);
            // 
            // listBox1
            // 
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 75);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(776, 334);
            this.listBox1.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(776, 23);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.filter);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "C# json|*.json|All files|*.*";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "C# json|*.json|All files|*.*";
            this.openFileDialog1.Multiselect = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Библиотека";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem опцииToolStripMenuItem;
        private CheckBox checkBox1;
        private ListBox listBox1;
        private ComboBox comboBox1;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem выйтиToolStripMenuItem;
        private ToolStripMenuItem добавитьАвтораToolStripMenuItem;
        private ToolStripMenuItem удалитьАвтораToolStripMenuItem;
        private ToolStripMenuItem редактироватьАвтораToolStripMenuItem;
        private ToolStripMenuItem добавитьАвтораToolStripMenuItem1;
        private ToolStripMenuItem удалитьАвтораToolStripMenuItem1;
        private ToolStripMenuItem редактироватьАвтораToolStripMenuItem1;
        private SaveFileDialog saveFileDialog1;
        private OpenFileDialog openFileDialog1;
    }
}