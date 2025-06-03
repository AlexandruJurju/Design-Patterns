using Observer.PrintingOfficeEvent.Publications;
using Observer.PrintingOfficeEvent.Publishers;
using Observer.PrintingOfficeEvent.Subscribers;

var printingOffice = new PrintingOffice();

var bookLover1 = new BookLover("James", printingOffice);
var bookLover2 = new BookLover("Mary", printingOffice);

var newsHunter1 = new NewsHunter("Donald", printingOffice);
var newsHunter2 = new NewsHunter("Jane", printingOffice);
var newsHunter3 = new NewsHunter("Peter", printingOffice);

printingOffice.PrintBook(new Book
{
    Author = "Stephen King",
    Title = "The shining",
    Year = 1997
});

printingOffice.PrintNewspaper(new Newspaper
{
    Number = 123,
    Title = "New world event"
});