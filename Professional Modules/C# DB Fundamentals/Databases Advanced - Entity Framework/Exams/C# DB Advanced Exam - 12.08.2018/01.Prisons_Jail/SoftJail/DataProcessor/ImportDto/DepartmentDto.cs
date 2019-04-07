using System.ComponentModel.DataAnnotations;

namespace SoftJail.DataProcessor.ImportDto
{
    public class DepartmentDto
    {
        [Required]
        [MinLength(2), MaxLength(25)]
        public string Name { get; set; }

        public CellDto[] Cells { get; set; }
        //        "Name": "",
        //        "Cells": [
        //    {
        //        "CellNumber": 101,
        //        "HasWindow": true
        //    },
        //    {
        //    "CellNumber": 102,
        //    "HasWindow": false
        //}
        //]

    }

    public class CellDto
    {
        [Required]
        [Range(typeof(int), "1", "1000")]
        public int CellNumber { get; set; }

        [Required]
        public bool HasWindow { get; set; }
    }
}