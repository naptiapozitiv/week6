namespace week6
{
    public class Library
    {
        public string Name { get; set; }
        public Book[] Books { get; set; }
        private int BookCount { get; set; }

        public Library(string name) 
        {
            Name = name;
            Books = new Book[1000];
            BookCount = 0;
        }

        public void addBook(Book newOne)
        {
            if (BookCount < 1000)
            {
                if (newOne.ISBN_Check())
                {
                    Books[BookCount] = newOne;
                    BookCount++;
                    Console.WriteLine($"Book {newOne.Title} has been succesfully added.\n");
                }
                else
                    Console.WriteLine("The book is not valid and can not be added.\n");
            }
            else
                Console.WriteLine("The book can not be added because the library is full.\n");
        }
        public void ShowArray()
        {
            Console.WriteLine("__________________________________Library__________________________________");
            for (int i = 0; i < BookCount; i++)
                Console.WriteLine(Books[i].DisplayBookInfo());
            Console.WriteLine("___________________________________________________________________________");
        }
    }
}
