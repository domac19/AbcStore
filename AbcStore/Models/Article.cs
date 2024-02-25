using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace AbcStore.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Kategorija { get; set; }
        public string Cijena { get; set; }

        [DisplayName("Upload image")]
        public string Image { get; set; }

        [NotMapped]
        public HttpPostedFileBase ImageFile { get; set; }
    }
}