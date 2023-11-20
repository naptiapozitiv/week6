
using week6;

Book RichDadPoorDad = new Book("Rich Dad, Poor Dad","Somebody U.N.","15gj381h");
Book AbraKodabra = new Book("Abra-Kodabra", "Garry H.", "1268kjhk123");
RichDadPoorDad.DisplayBookInfo();
AbraKodabra.DisplayBookInfo();

Console.WriteLine($"Is ISBN of {RichDadPoorDad.Title} longer than 13? Result: " + RichDadPoorDad.ISBN_Check());
Console.WriteLine($"Is ISBN of {AbraKodabra.Title} longer than 13? Result: " + AbraKodabra.ISBN_Check());

Library library = new Library("Central");
library.addBook(RichDadPoorDad);
library.addBook(AbraKodabra);
library.ShowArray();

Book Titanic = new Book("Titanic", "Blablabla L.B.", "187yg198yhgd");
Titanic.DisplayBookInfo();
Console.WriteLine($"Is ISBN of {Titanic.Title} longer than 13? Result: " + Titanic.ISBN_Check());

library.addBook(Titanic);
library.ShowArray();