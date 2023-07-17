
namespace BookRecommenderUI.Data
{
    public class BookService
    {
        public BookService()
        {
               
        }

        public Book[] GetBooks()
        {
            return new Book[]
            {
            new Book()
            {
                Author = "Suzanne Collins",
                Description="Winning will make you famous. Losing means certain death.The nation of Panem, formed from a post-apocalyptic North America, is a country that consists of a wealthy Capitol region surrounded by 12 poorer districts. Early in its history, a rebellion led by a 13th district against the Capitol resulted in its destruction and the creation of an annual televised event known as the Hunger Games. In punishment, and as a reminder of the power and grace of the Capitol, each district must yield one boy and one girl between the ages of 12 and 18 through a lottery system to participate in the games. The 'tributes' are chosen during the annual Reaping and are forced to fight to the death, leaving only one survivor to claim victory.When 16-year-old Katniss's young sister, Prim, is selected as District 12's female representative, Katniss volunteers to take her place. She and her male counterpart Peeta, are pitted against bigger, stronger representatives, some of whom have trained for this their whole lives. , she sees it as a death sentence. But Katniss has been close to death before. For her, survival is second nature.",
                Edition="Hardcover",
                Isbn="9.78E+12",
                PageCount = "374 pages",
                Rating = "4.33",
                Title="The Hunger Games",
                Genre="Young Adult|Fiction|Science Fiction|Dystopia|Fantasy|Science Fiction",
                ImageUrl="https://images.gr-assets.com/books/1447303603l/2767052.jpg"
            },
            new Book()
            {
                Author = "Harper Lee",
                Description="The unforgettable novel of a childhood in a sleepy Southern town and the crisis of conscience that rocked it, To Kill A Mockingbird became both an instant bestseller and a critical success when it was first published in 1960. It went on to win the Pulitzer Prize in 1961 and was later made into an Academy Award-winning film, also a classic.Compassionate, dramatic, and deeply moving, To Kill A Mockingbird takes readers to the roots of human behavior - to innocence and experience, kindness and cruelty, love and hatred, humor and pathos. Now with over 18 million copies in print and translated into forty languages, this regional story by a young Alabama woman claims universal appeal. Harper Lee always considered her book to be a simple love story. Today it is regarded as a masterpiece of American literature.",
                Edition="Paperback",
                Isbn="9780060000000",
                PageCount = "324 pages",
                Rating = "4.27",
                Title="To Kill a Mockingbird",
                Genre="Classics|Fiction|Historical|Historical Fiction|Academic|School",
                ImageUrl="https://images.gr-assets.com/books/1361975680l/2657.jpg"
            },
            };
        }
    }
}
