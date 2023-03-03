using System.Collections.Generic;

namespace Books
{
    public class AuthorS
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Books> Books { get; set; }
    }
}
