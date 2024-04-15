using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Text.Json.Serialization;

namespace Lab4Entrega.Data.Entities
{
    public class TodoItem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_todo_item { get; set; }
        public string Tittle { get; set; }

        public string Description { get; set; }

        public int UserId { get; set; }


        public User User { get; set; }
    
    }
}
