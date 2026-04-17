/* Завдання 2
Створіть додаток "Список книг для прочитання". Додаток
повинен надавати можливість додавати книги до списку, видаляти
книги зі списку, перевіряти, чи є книга у списку. Використовуйте для
зберігання книг масив. Реалізуйте індексатор для отримання доступу до
книги за індексом у клієнтській частині додатку. Також використовуйте
механізм властивостей та перевантаження операторів
*/

using System;
using System.Text;

public class Book
{
    public string Author { get; set; }
    public string Title { get; set; }

    public override string ToString()
    {
        return $"{Author} {Title} ";
    }

    public class ToRead
    {
        Book[] BookArr;
        public ToRead(int size)
        {
            BookArr = new Book[size];
        }

        public int Length
        {
            get { return BookArr.Length; }
        }

        public Book this[int index]
        {
            get
            {
                if (index >= 0 && index < BookArr.Length)
                {
                    return BookArr[index];
                }
                else
                {
                    throw new Exception("\nNot correct index" + index);
                }
            }
            set
            {
                if (index >= 0 && index < BookArr.Length)
                {
                    BookArr[index] = value;
                }
                else
                {
                    throw new Exception("\nNot correct index " + index);
                }
            }
        }

        public int FindByAuthor(string author)
        {
            for (int i = 0; i < BookArr.Length; i++)
            {
                if (BookArr[i].Author == author)
                {
                    return i;
                }
            }
            return -1;
        }

        public bool Contains(Book book)
        {
            for (int i = 0; i < BookArr.Length; i++)
            {
                if (BookArr[i] != null && BookArr[i].Equals(book))
                    return true;
            }
            return false;
        }

        public void Remove(Book book)
        {
            for (int i = 0; i < BookArr.Length; i++)
            {
                if (BookArr[i] != null && BookArr[i].Equals(book))
                {
                    for (int j = i; j < BookArr.Length - 1; j++)
                    {
                        BookArr[j] = BookArr[j + 1];
                    }
                    BookArr[BookArr.Length - 1] = null;
                    break;
                }
            }
        }

        public static ToRead operator +(ToRead list, Book book)
        {
            for (int i = 0; i < list.BookArr.Length; i++)
            {
                if (list.BookArr[i] == null)
                {
                    list.BookArr[i] = book;
                    return list;
                }
            }
            return list;
            }

        public static ToRead operator -(ToRead list, Book book)
        {
            list.Remove(book);
                return list;
        }
        public void Show()
        {
            for (int i = 0; i < BookArr.Length; i++)
            {
                if (BookArr[i] != null)
                    Console.WriteLine($"{i + 1}.{BookArr[i]}");
            }
        }

        public class Program
        {
            public static void Main()
            {
                try
                {
                    ToRead Books = new ToRead(10);
                    Books[0] = new Book { Author = "Matthew Pearl", Title = "The Last Dickens" };
                    Books[1] = new Book { Author = "Cormac McCarthy", Title = "No Country for Old Men" };
                    Books[2] = new Book { Author = "Stephen King", Title = "Full Dark, No Stars" };
                    Books.Show();

                    Book newBook = new Book { Author = "George Orwell", Title = "1984" };

                    Books += newBook;
                    Console.WriteLine("\nAfter add: ");
                    Books.Show();

                    Console.WriteLine("\nContains '1984' ");
                    Console.WriteLine(Books.Contains(newBook));

                    Books -= newBook;
                    Console.WriteLine("\nAfter remove:");
                    Books.Show();
                }
                catch (Exception ex) 
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}

