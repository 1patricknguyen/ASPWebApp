using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using backend.Data;
using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers
{
    [Route("api/groceryList")]
    [ApiController]
    public class groceryListController : ControllerBase
    {   
        private readonly ApplicationDBContext _context;
        public groceryListController(ApplicationDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var groceryLists = _context.groceryList.ToList();

            return Ok(groceryLists);
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute]int id)
        {
            var groceryList = _context.groceryList.Find(id);

            if (groceryList == null)
            {
                return NotFound();
            }

            return Ok(groceryList);
        }
    }
}