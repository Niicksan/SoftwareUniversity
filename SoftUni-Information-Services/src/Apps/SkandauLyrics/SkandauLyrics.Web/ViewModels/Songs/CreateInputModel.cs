using SIS.MvcFramework.Attributes.Validation;
using System;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SkandauLyrics.Web.ViewModels.Songs
{
    public class CreateInputModel
    {
        [RequiredSis]
        [StringLengthSis(3, 55, "Name should be between 3 and 55 characters!")]
        public string Name { get; set; }

        [RequiredSis]
        [StringLengthSis(11, 11, "This Url must be exact 11 characters")]
        public string Url { get; set; }

        [RequiredSis]
        public DateTime DateAdded { get; set; }

        [RequiredSis]
        public string Lyric { get; set; }

        [RequiredSis]
        public string SingerName { get; set; }
    }
}