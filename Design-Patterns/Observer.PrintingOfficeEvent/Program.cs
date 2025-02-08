using Observer.PrintingOfficeEvent.Publications;
using Observer.PrintingOfficeEvent.Publishers;
using Observer.PrintingOfficeEvent.Subscribers;

PrintingOffice printingOffice = new PrintingOffice();

BookLover bookLover1 = new BookLover("James", printingOffice);
BookLover bookLover2 = new BookLover("Mary", printingOffice);

NewsHunter newsHunter1 = new NewsHunter("Donald", printingOffice);
NewsHunter newsHunter2 = new NewsHunter("Jane", printingOffice);
NewsHunter newsHunter3 = new NewsHunter("Peter", printingOffice);

printingOffice.PrintBook(new Book
{
    Author = "Stephen King",
    Title = "The shining",
    Year = 1997,
});

printingOffice.PrintNewspaper(new Newspaper
{
    Number = 123,
    Title = "New world event",
});