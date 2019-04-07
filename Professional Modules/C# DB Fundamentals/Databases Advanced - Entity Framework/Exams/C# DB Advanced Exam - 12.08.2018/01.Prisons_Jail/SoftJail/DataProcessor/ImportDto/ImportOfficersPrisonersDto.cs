using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;
using SoftJail.Data.Models.Enums;

namespace SoftJail.DataProcessor.ImportDto
{
    [XmlType("Officer")]
    public class ImportOfficersPrisonersDto
    {
        [Required]
        [MinLength(3), MaxLength(30)]
        [XmlElement("Name")]
        public string FullName { get; set; }

        [Required]
        [Range(typeof(decimal), "0.00", "79228162514264337593543950335")]
        [XmlElement("Money")]
        public decimal Money { get; set; }

        [Required]
        [XmlElement("Position")]
        public string Position { get; set; }

        [Required]
        [XmlElement("Weapon")]
        public string Weapon { get; set; }

        [XmlElement("DepartmentId")]
        public int DepartmentId { get; set; }

        [XmlArray("Prisoners")]
        public PrisonersDto[] Prisoners { get; set; }

    }
    [XmlType("Prisoner")]
    public class PrisonersDto
    {
        [XmlAttribute("id")]
        public int Id { get; set; }
    }
}

//<Officer>
//<Name>Paddy Weiner</Name>
//<Money>2854.56</Money>
//<Position>Guard</Position>
//<Weapon>ChainRifle</Weapon>
//<DepartmentId>3</DepartmentId>
//<Prisoners>
//<Prisoner id = "4" />
//< Prisoner id= "1" />
//</ Prisoners >
//</ Officer >
//< Officer >
