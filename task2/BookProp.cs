using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    public abstract class BookProp {
        public string content_;
        private ConsoleColor color_;

        public BookProp(string content, ConsoleColor color) {
            content_ = content;
            color_ = color;
        }

        public virtual void Show() {
            
            Console.ForegroundColor = color_; 
            Console.WriteLine(content_);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}