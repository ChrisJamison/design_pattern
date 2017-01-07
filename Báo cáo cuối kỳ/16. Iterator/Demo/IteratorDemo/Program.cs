namespace IteratorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BookCollection collection = new BookCollection();
            collection[0] = new Book("Harry Potter");
            collection[1] = new Book("Lord of the Ring");
            collection[2] = new Book("Dac Nhan Tam");


            // Create iterator
            Iterator iterator = collection.CreateIterator();

            // Skip every other item
            iterator.Step = 1;

            System.Console.WriteLine("Iterating over collection:");

            for (Book book = iterator.First(); !iterator.IsDone; book = iterator.Next())
            {
                System.Console.WriteLine(book.Name);
            }

            // Wait for user
            System.Console.ReadKey();
        }
    }
}
