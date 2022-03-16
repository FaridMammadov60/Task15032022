namespace ConsoleApp1
{
    public class Book
    {
        public Book()
        {

        }
        public Book(string name, double price, int pageCount, Authors authors):this()
        {
            this.name = name;
            this.price = price;            
            this.pageCount = pageCount;
            this.author = authors;

        }
        #region Fields
        readonly int pageCount;
        string name;
        double price;
        Authors author;
        #endregion

        #region Property
        public string Name
        {
            get { return name; }
        }
        public double Price
        {
            get
            {
                return price;
            }
        }
        #endregion

        public override string ToString()
        {
            return $"Kitabın adı: {name}\n" +
                $"Sehifə sayı: {pageCount}\n" +
                $"Kitabın qiyməti: {price}\n" +
                $"{author}";
        }


    }
}
