using System.ComponentModel.DataAnnotations;
using System.Transactions;

namespace WeekTwo_TaskOne.Model
{
    public class Player
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Must Enter A Name")]
        [StringLength(20,MinimumLength = 3)]
        public string Name { get; set; } = "";

        [Range(1,99)]
        public int JerseyNumber { get; set; }

        [Range(18,40)]
        public int Age { get; set; }

        [Required(ErrorMessage = "Club Name Is Required")]
        public string Club { get; set; } = "";

    }
}
