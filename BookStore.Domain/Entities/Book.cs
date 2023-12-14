using System.Security.Cryptography.X509Certificates;

namespace BookStore.Domain.Entities
{
    public class Book : BaseEntity<Guid>
    {
        public Book()
        {
            Id = Guid.NewGuid();
            float real = 25.4f;
            int inteiro = 0;

            inteiro = int.Parse(real.ToString());

        }

        public string Title { get; set; }
        public Author Author { get; set; }
        public Category Category { get; set; }
        public DateTime PublicationDate { get; set; }
        public string Synopsis { get; set; }
        public string Isb { get; set; }
        public Publisher Publisher { get; set; }
        public Language Language { get; set; }
        public IList<Formats> Formats { get; set; }
        public IList<Review> Reviews { get; set; }   
           
    }
}
