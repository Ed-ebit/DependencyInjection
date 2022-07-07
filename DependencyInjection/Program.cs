
namespace DependencyInjection
{
    public class PrintingPress
    {
        public static void Main()
        {
            //PrintingPress press = new PrintingPress();
            Page page = new Page(new YourBook());
            page.add("Auf diese Seite wurde was geschrieben!\n");
        }


        public class Page
        {
            IBook book;
            public Page(IBook book)
            {
                this.book = book;
            }

            public void add(string data)
            {
                book.persist(data);
            }
        }

        public interface IBook
        {
            void persist(string data);
        }

        public class MyBook : IBook
        {
            public void persist(string data)
            {
                Console.WriteLine("MyBook has stored data: " + data);
            }
        }
        public class YourBook : IBook
        {
            public void persist(string data)
            {
                Console.WriteLine("YourBook has stored data: " + data);
            }
        }
    }
}