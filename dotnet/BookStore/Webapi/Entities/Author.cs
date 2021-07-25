using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Webapi.Entities
{

    public class Author
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public String Surname { get; set; }
        public DateTime BirthDate { get; set; }
    }
}