namespace week6
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public Book(string title, string author, string isbn)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
        }

        public string DisplayBookInfo()
        {
            //string result = "";
            //result =
            return $"Title: {Title}\nAuthor: {Author}\nISBN: {ISBN}\n";
            //return result;
        }
        public bool ISBN_Check()
        {
            bool result = true;
            if(ISBN.Length<=13)
                result = true;
            else
                result = false;
            return result;
        }

    }
}
