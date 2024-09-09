using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models
{
    public class groceryList
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<groceryItem> Items { get; set; } = new List<groceryItem>();
    }
}