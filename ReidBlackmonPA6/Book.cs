﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReidBlackmonPA6
{
    class Book
    {
        //have to name data the same thing its named in database
        public String cwid { get; set; }
        public String isbn { get; set; }
        public String title { get; set; }
        public String author { get; set; }
        public String cover { get; set; }
        public String genre { get; set; }
        public int length  { get; set; }
        public int copies { get; set; }
        //keeps up with a hidden book id
        public string _id { get; set; }

        public Book(string cwid, string isbn, string title, string author, string cover, string genre, int length, int copies, string id)
        {
            this.cwid = cwid;
            this.isbn = isbn;
            this.title = title;
            this.author = author;
            this.cover = cover;
            this.genre = genre;
            this.length = length;
            this.copies = copies;
            _id = id;
        }

        public Book()
        {

        }

        public override string ToString()
        {
            return this.title;
        }

    }
}