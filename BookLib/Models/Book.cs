using System;
using System.Collections.Generic;
using System.Text;

namespace BookLib.Models
{
    public class Book
    {
        private string _title;
        private string _author;
        private int _pageNr;
        private string _iSBN;

        public Book()
        {

        }

        public Book(string title, string author, int pageNR, string iSBN)
        {
            _title = title;
            _author = author;
            _pageNr = pageNR;
            _iSBN = iSBN;

        }
        public string Title
        {
            get => _title;

            set
            {
                if (_title.Length == null)
                {
                    throw new ArgumentNullException();
                }

                _title = value;
            }
        }

        public string Author
        {
            get => _author;

            set
            {
                if (_author.Length == null)
                {
                    throw new ArgumentNullException();
                }
                if (_author.Length < 2)
                {
                    throw new ArgumentOutOfRangeException();
                }

                _author = value;
            }


        }

        public int PageNR
        {
            get => _pageNr;

            set
            {
                if (_pageNr == null)
                {
                    throw new ArgumentNullException();
                }

                if (_pageNr < 4 || _pageNr > 1000)
                {
                    throw new ArgumentOutOfRangeException();
                }

                _pageNr = value;
            }
        }

        public string ISBN
        {
            get => _iSBN;

            set
            {
                if (_iSBN.Length == null)
                {
                    throw new ArgumentNullException();
                }
                if (_iSBN.Length != 13)
                {
                    throw new ArgumentOutOfRangeException();

                }
                
                _iSBN = value;

            }

        }
        public string ToString()
        {
            return " ";
        }
    }
}
