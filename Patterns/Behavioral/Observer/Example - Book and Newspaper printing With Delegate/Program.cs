using Observer.Observer;
using Observer.Publications.Repositories;
using Observer.Subject;

BookRepository bookRepository = new BookRepository();
NewspaperRepository newspaperRepository = new NewspaperRepository();

PrintingOffice printingOffice = new PrintingOffice(bookRepository, newspaperRepository);


BookLover william = new BookLover("William", printingOffice);
BookLover james = new BookLover("James", printingOffice);
BookLover anna = new BookLover("Anna", printingOffice);

NewsHunter alice = new NewsHunter("Alice", printingOffice);
NewsHunter johnny = new NewsHunter("Johnny", printingOffice);


printingOffice.PrintRandom(2, 2);