using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;



namespace crudApp.Models
{
    public class ItemsList
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedAt {get; set;} = DateTime.Now;
        [Required]
        public string? Title {get; set;}
        public string? ListBody { get; set; }

    }
}