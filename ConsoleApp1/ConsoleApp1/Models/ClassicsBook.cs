namespace ConsoleApp1.Models
{
    public class ClassicsBook : Book
    {
        public ClassicsBook()
        {

        }
        public ClassicsBook(string type, string subject) : this()
        {
            this.type = type;
            this.subject = subject;

        }
        #region Fields
        string type;
        string subject;
        #endregion

        #region Property
        public string Type
        {
            get
            {
                return type;
            }
        }
        public string Subject
        {
            get
            {
                return subject;
            }
        }

        #endregion

        public override string ToString()
        {
            return $"Kitabın növü: {type}";
        }


    }
}
