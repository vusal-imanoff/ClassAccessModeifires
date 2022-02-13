using System;
using System.Collections.Generic;
using System.Text;

namespace ClassAccessModifiresTask
{
    class Book
    {
        private string _name;
        private int _pageCount;
       
        public Book(string name,int page)
        {
            Bookname = name;
            PageCount = page;
        }
        public string Bookname
        {
            get
            {
                return _name;
            }
            set
            {
                while (true)
                {
                    if(value.Length>3)
                    {
                        _name = value; ;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Kitabin adin duzgun daxil edin...");
                        value = Console.ReadLine();
                    }
                }
                
            }
        }
        public int PageCount
        {
            get
            {
                return _pageCount;
            }
            set
            {
                while (true)
                {
                    if (value > 10)
                    {
                         _pageCount=value;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Kitabin sehifesin duzgun daxil et...");
                        int.TryParse(Console.ReadLine(),out value);
                    }
                }
            }
        }

          public string Info()
        {
            return $"{_name} kitabi {_pageCount} sehifeden ibaretdir.";
        }  
    }

    
}
