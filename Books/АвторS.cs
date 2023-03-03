namespace Books
{
    public partial class АвторS : Form
    {
        string book;
        Formar form;
       
        public АвторS(string b, Formar f)
        {
            InitializeComponent();
            this.form = f;
            this.book = b;
            if (form == Formar.EditAuthor)
            {
                textBox1.Text = b;
               
                this.Text = "Редактирование автора";
                label1.Text = "Введите имя автора";
            }
            else if (form == Formar.AddAuthor)
            {
                this.Text = "Добавление автора";
                label1.Text = "Введите имя автора";
            }
            else if (form == Formar.AddBook)
            {
                this.Text = "Добавление книги";
                label1.Text = "Введите название книги";
            }
            else if (form == Formar.EditBook)
            {
                textBox1.Text = b;
                this.Text = "Редактирование книги";
                label1.Text = "Введите название книги";
            }
        }
        public string TextBoxName
        {
            get { return textBox1.Text.Trim(); }
            set { textBox1.Text = value; }
        }
        private void OK_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" )
            {
                MessageBox.Show("Заполните поле");
                return;
            }
            book = textBox1.Text;
            Text = book;
        }
    }
}
