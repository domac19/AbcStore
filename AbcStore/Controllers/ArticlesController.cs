using AbcStore.DbConnect;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AbcStore.Controllers
{
    public class ArticlesController : Controller
    {
        private AbcStoreContext _abcStoreContext;

        public ArticlesController()
        {
            _abcStoreContext = new AbcStoreContext();
        }

        // GET: Articles
        public ActionResult Index()
        {
            return View(_abcStoreContext.Artikli.ToList());
        }
    }
}