using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using crudApp.data;
using crudApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace crudApp.Controllers
{
    [Route("[controller]")]
    public class ListController : Controller
    {
        private readonly ApplicationDbContext _db;

         public ListController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<ItemsList> itemsLists = _db.ListTable.ToList();
            return View(itemsLists);
        }

       

    }
}