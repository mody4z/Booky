

namespace Bookify.Web.Core.Models
{
    public class Category
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Name { get; set; } = null!;


        public bool Isdeleted { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public DateTime? lastupdatedOn { get; set; }


    }
}
