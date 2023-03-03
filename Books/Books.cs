

namespace Books
{
    public  class Books
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual AuthorS Author { get; set; }
    }
}
