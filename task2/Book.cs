using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 


namespace Book 
{
    public class Book {
        Author author;
        Title title;
        Content content;
        public Book(Author author, Title title, Content content) {
            this.author = author;
            this.title = title;
            this.content = content;
        }

        public void Show() {
            author.Show();
            title.Show();
            content.Show();
        }
    }
}