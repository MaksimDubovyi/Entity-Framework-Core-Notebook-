
namespace Books
{
   public enum Formar
    {
        AddAuthor,
        AddBook,
        EditAuthor,
        EditBook
    }
    public partial class Form1 : Form, IVeiw
    {
        public event EventHandler<EventArgs> AddAuthor;
        public event EventHandler<EventArgs> AddBook;
        public event EventHandler<EventArgs> EditAuthor;
        public event EventHandler<EventArgs> EditBook;
        public event EventHandler<EventArgs> DeleteAuthor;
        public event EventHandler<EventArgs> DeleteBook;
        public event EventHandler<EventArgs> Filter;
        public event EventHandler<EventArgs> Filter2;
        public Form1()
        {
            InitializeComponent();
        }

        
        public int Index_A
        {
            get { return comboBox1.SelectedIndex; }
            set { comboBox1.SelectedIndex = value; }
        }
        public int Index_B
        {
            get { return listBox1.SelectedIndex; }
            set { listBox1.SelectedIndex = value; }
        }

        public void Items_IndexOf_Author( string s)
        {
            comboBox1.SelectedIndex = comboBox1.Items.IndexOf(s);
        }

        public List<AuthorS> DataSource_B()
        {
            List<AuthorS> list = comboBox1.DataSource as List<AuthorS>;
            return list;
        }
        public List<Books> DataSource_A()
        {
            List<Books> list = listBox1.DataSource as List<Books>;
            return list;
        }
        public void DataSource_Book(IQueryable<Books> s)
        {
            listBox1.DataSource = s.ToList();
        }
        public void DataSource_Author(IQueryable<AuthorS> s)
        {
            comboBox1.DataSource = s.ToList();
        }
        public void DisplayMember_Author()
        {
            comboBox1.DisplayMember = "Name";
        }
        public void DisplayMember_Book()
        {
            listBox1.DisplayMember = "Name";
        }

        public void Items_Add_Author(string s)
        {
            comboBox1.Items.Add(s);
        }
       
        
        private void SeveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
             
                 
            }
            catch (Exception ex) { }
        }
        private void DeleteьАвтораToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ToolStripMenuItem ToolStrip = (ToolStripMenuItem)sender;
                if (ToolStrip.Text == "&Удалить автора")
                {
                    DeleteAuthor?.Invoke(this, EventArgs.Empty);
                }
                else if (ToolStrip.Text == "&Удалить книгу")
                {
                    DeleteBook?.Invoke(this, EventArgs.Empty);
                }
            }
            catch (Exception ex) { }
        }
        private void openfile(object sender, EventArgs e)
        {
            try { 
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                  
                }
            } catch (Exception ex) { }
        }
        private void AddAndEditToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            try { 
                ToolStripMenuItem ToolStrip = (ToolStripMenuItem)sender;
                if (ToolStrip.Text == "&Добавить автора")
                    AddAuthor?.Invoke(this, EventArgs.Empty);
                else if (ToolStrip.Text == "&Добавить книгу")
                    AddBook?.Invoke(this, EventArgs.Empty);
                else if (ToolStrip.Text == "&Редактировать  автора")
                    EditAuthor?.Invoke(this, EventArgs.Empty);
                else if (ToolStrip.Text == "&Редактировать  книгу")
                    EditBook?.Invoke(this, EventArgs.Empty);
            } catch (Exception ex) { }
        }
        private void filter(object sender, EventArgs e)
        {
            try
            {
                if (checkBox1.Checked)
                {
                    Filter?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    Filter2?.Invoke(this, EventArgs.Empty);
                }
            }
            catch (Exception ex) { }
        }
        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
