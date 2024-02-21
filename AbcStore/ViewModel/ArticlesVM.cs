using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AbcStore.ViewModel
{
    public class ArticlesVM
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Kategorija { get; set; }
        public string Cijena { get; set; }
        
        [Display(Name = "UploadImage")]
        public HttpPostedFileBase Image { get; set; }
    }
}