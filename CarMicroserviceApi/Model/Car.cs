using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarMicroserviceApi.Model
{
    [Table("cars",Schema ="dbo")]
    public class Car
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("car_id")]
        public int CarId {  get; set; }

        [Column("car_name")]
        public char CarName { get; set; }

        [Column("car_description")]
        public string CarDescription { get; set; }
    }
}
