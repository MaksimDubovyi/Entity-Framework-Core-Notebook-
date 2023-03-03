
using System.Data;
using Microsoft.EntityFrameworkCore;

namespace Books
{
    internal class Presenter
    {
        IVeiw veiw;
        Authors_And_Books_Context Model;
        string Str="";
        

        public Presenter(IVeiw Veiw1, Authors_And_Books_Context ModelB)
        {
            veiw = Veiw1;
            Model = ModelB;
            try
            {
                using (var db = new Authors_And_Books_Context())
                {
                    var query = from b in db.AuthorS_
                                select b;
                    veiw.DataSource_Author(query);
                    veiw.DisplayMember_Author();

                     var query2 = from b in db.Books_
                                 select b;
                    veiw.DataSource_Book(query2);
                    veiw.DisplayMember_Book();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

            veiw.AddAuthor += new EventHandler<EventArgs>(Add_A);
            veiw.AddBook += new EventHandler<EventArgs>(Add_B);
            veiw.EditAuthor += new EventHandler<EventArgs>(Edit_A);
            veiw.EditBook += new EventHandler<EventArgs>(Edit_B);
            veiw.DeleteAuthor += new EventHandler<EventArgs>(Delete_A);
            veiw.DeleteBook += new EventHandler<EventArgs>(Delete_B);
            veiw.Filter += new EventHandler<EventArgs>(filter_ON);
            veiw.Filter2 += new EventHandler<EventArgs>(filter_OFF);

    }
        private void Add_A(object sender, EventArgs e)
        {
            try
            {
                АвторS add = new АвторS(Str, Formar.AddAuthor);
                if (add.ShowDialog() == DialogResult.OK)
                {
                    using (var db = new Authors_And_Books_Context())
                    {
                        var Author1 = new AuthorS { Name = add.Text };
                        db.AuthorS_.Add(Author1);
                        db.SaveChanges();

                        var query = from b in db.AuthorS_
                                    select b;

                        veiw.DataSource_Author(query);
                        veiw.DisplayMember_Author();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void Add_B(object sender, EventArgs e)
        {

            АвторS add = new АвторS(Str, Formar.AddBook);
            if (veiw.Index_A == -1)
            {
                MessageBox.Show("Вы не выбрали автора"); return;
            }
            if (add.ShowDialog() == DialogResult.OK)
            {
                using (var db = new Authors_And_Books_Context())
                {
                    List<AuthorS> list = veiw.DataSource_B();
                    string Authors1 = list[veiw.Index_A].Name;
                    var query = (from b in db.AuthorS_
                                 where b.Name == Authors1
                                 select b).Single();

                    var book = new Books
                    {
                        Name = add.Text,
                        Author = query
                    };
                    db.Books_.Add(book);
                    db.SaveChanges();

                    var query2 = from b in db.Books_
                                 select b;
                    veiw.DataSource_Book(query2);
                    veiw.DisplayMember_Book();
                }
            }
        } 
        private void Edit_A(object sender, EventArgs e)
        {
            try
            {
                АвторS add = new АвторS(Str, Formar.EditAuthor);
                if (add.ShowDialog() == DialogResult.OK)
                {
                    using (var db = new Authors_And_Books_Context())
                    {
                        List<AuthorS> list = veiw.DataSource_B();
                        string Authors1 = list[veiw.Index_A].Name;
                        var query = (from b in db.AuthorS_
                                     where b.Name == Authors1
                                     select b).Single();
                        query.Name = add.Text;
                        db.SaveChanges();
                       

                        var query2 = from b in db.AuthorS_
                                     select b;
                        veiw.DataSource_Author(query2);
                        veiw.DisplayMember_Author();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Edit_B(object sender, EventArgs e)
        {
            try
            {
                АвторS add = new АвторS(Str, Formar.EditBook);
                if (add.ShowDialog() == DialogResult.OK)
                {
                    using (var db = new Authors_And_Books_Context())
                    {
                        List<AuthorS> list = veiw.DataSource_B();
                        string Authors1 = list[veiw.Index_A].Name;
                        var query = (from b in db.AuthorS_
                                     where b.Name == Authors1
                                     select b).Single();
                        if (query == null)
                            return;

                        List<Books> list1 = veiw.DataSource_A();
                        string Book1 = list1[veiw.Index_B].Name;
                        var query2 = (from b in db.Books_
                                      where b.Name == Book1
                                      select b).Single();

                        query2.Author = query;
                        query2.Name = add.Text;
                        db.SaveChanges();

                        var query3 = from b in db.Books_
                                     select b;
                        veiw.DataSource_Book(query3);
                        veiw.DisplayMember_Book();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Delete_A(object sender, EventArgs e)
        {
            try
            {
                using (var db = new Authors_And_Books_Context())
                {
                    List<AuthorS> list = veiw.DataSource_B();
                    string Authors1 = list[veiw.Index_A].Name;
                    var query = from b in db.AuthorS_
                                where b.Name == Authors1
                                select b;
                    db.AuthorS_.RemoveRange(query);
                    db.SaveChanges();

                    query = from b in db.AuthorS_
                            select b;
                    veiw.DataSource_Author(query);
                    veiw.DisplayMember_Author();

                    var query2 = from b in db.Books_
                                 select b;
                    veiw.DataSource_Book(query2);
                    veiw.DisplayMember_Book();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Delete_B(object sender, EventArgs e)
        {
            try
            {
                using (var db = new Authors_And_Books_Context())
                {
                    List<Books> list = veiw.DataSource_A();
                    string Books1 = list[veiw.Index_B].Name;
              
                    var query = from b in db.Books_
                                where b.Name == Books1
                                select b;
                    db.Books_.RemoveRange(query); 
                    db.SaveChanges();

                    var query2 = from b in db.Books_
                                 select b;
                    veiw.DataSource_Book(query2);
                    veiw.DisplayMember_Book();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void filter_ON(object sender, EventArgs e)
        {
            try
            {
                List<AuthorS> AuthorS1 = veiw.DataSource_B();
                               if (AuthorS1 == null)
                        return;
                using (var db = new Authors_And_Books_Context())
                {
                    int Id = AuthorS1[veiw.Index_A].Id;

                    var query = (from b in db.Books_.Include(s => s.Author)
                                 where b.Author.Id == Id
                                 select b);

                    veiw.DataSource_Book(query);
                    veiw.DisplayMember_Book();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void filter_OFF(object sender, EventArgs e)
        {
            try
            {
                using (var db = new Authors_And_Books_Context())
                {
                    var query = (from b in db.Books_
                                 select b);
                    veiw.DataSource_Book(query);
                    veiw.DisplayMember_Book();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}


