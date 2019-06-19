using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterators_and_comparators
{
    public class Library:IEnumerable<Book>
    {
        private List<Book> books;
        public Library(params Book[] books)
        {
            this.books = new List<Book>(books);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryEnumerator(books);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        private class LibraryEnumerator:IEnumerator<Book>
        {

            public Book Current
            {
                get {return books[index]; }
            }
            private IReadOnlyList<Book> books;
            private int index;
            public LibraryEnumerator(IReadOnlyList<Book> books)
            {
                this.books = books;
                index = -1;
            }

            public void Dispose()
            {
                throw new NotImplementedException();
            }

            object System.Collections.IEnumerator.Current
            {
                get { return this.Current; }
            }

            public bool MoveNext()
            {
                index++;
                return index < books.Count;
            }

            public void Reset()
            {
                throw new NotSupportedException();
            }
        }
    }
}
