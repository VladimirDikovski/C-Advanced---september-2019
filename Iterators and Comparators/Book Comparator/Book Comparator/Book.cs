﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Linq;

namespace IteratorsAndComparators
{
   public class Book:IComparable<Book>
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public IReadOnlyList<string> Authors { get; set; }

        public Book(string title,int year, params string[] authors)
        {
            this.Title = title;
            this.Year = year;
            this.Authors = authors;
        }

     
       public override string ToString()
       {
            return $"{this.Title} - {this.Year}";
       }

        public int CompareTo([AllowNull] Book other)
        {
            throw new NotImplementedException();
        }
    }
}
