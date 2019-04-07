using System.ComponentModel.DataAnnotations;

namespace SoftJail.DataProcessor.ImportDto
{
    public class ImportPrisonersMailsDto
    {
        [Required]
        [MinLength(3), MaxLength(20)]
        public string FullName { get; set; }

        [Required]
        [RegularExpression("(The [A-Z]{1}[a-z]+)")]
        public string Nickname { get; set; }

        [Required]
        [Range(typeof(int), "18", "65")]
        public int Age { get; set; }

        [Required]
        public string IncarcerationDate { get; set; }

        public string ReleaseDate { get; set; }

        [Range(typeof(decimal), "0.0", "79228162514264337593543950335")]
        public decimal? Bail { get; set; }

        public int? CellId { get; set; }

        public MailsDto[] Mails { get; set; }
    }

    public class MailsDto
    {
        [Required]
        public string Description { get; set; }

        [Required]
        public string Sender { get; set; }

        [RegularExpression("([A-Za-z 0-9]+ str.?)")]
        public string Address { get; set; } 
    }
}

//{
//"FullName": null,
//"Nickname": "The Null",
//"Age": 38,
//"IncarcerationDate": "12/09/1967",
//"ReleaseDate": "07/02/1989",
//"Bail": 93934.2,
//"CellId": 4,
//"Mails": [
//{
//    "Description": "Hello, my name is Mr. Null and I am invisible for computers",
//    "Sender": "Mr. Null",
//    "Address": "6 Riverside Trail str."
//}
//]
//},
