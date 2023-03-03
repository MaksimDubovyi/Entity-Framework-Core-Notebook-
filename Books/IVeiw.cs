

namespace Books
{
    internal interface IVeiw
    {


        public int Index_A { get; set; }
        public int Index_B { get; set; }
        public void Items_IndexOf_Author(string s);
        public void Items_Add_Author(string s);
        public void DataSource_Book(IQueryable<Books> s);
        public void DisplayMember_Book();
        public void DataSource_Author(IQueryable<AuthorS> s);
        public void DisplayMember_Author();
        public List<AuthorS> DataSource_B();
        public List<Books> DataSource_A();

        
        public event EventHandler<EventArgs> AddAuthor;
        public event EventHandler<EventArgs> AddBook;
        public event EventHandler<EventArgs> EditAuthor;
        public event EventHandler<EventArgs> EditBook;
        public event EventHandler<EventArgs> DeleteAuthor;
        public event EventHandler<EventArgs> DeleteBook; 
        public event EventHandler<EventArgs> Filter;
        public event EventHandler<EventArgs> Filter2;


    }
}
