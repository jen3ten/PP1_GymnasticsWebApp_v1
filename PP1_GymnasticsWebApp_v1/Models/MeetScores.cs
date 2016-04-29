using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PP1_GymnasticsWebApp_v1.Models
{
    public class MeetScores
    {
        [Key]
        [Required]
        public DateTime MeetDate { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage ="The maximum length is 50 characters.")]
        public string Name { get; set; }

        [MaxLength(50, ErrorMessage = "The maximum length is 50 characters.")]
        public string Location { get; set; }

        public double Vault { get; set; }

        public double Bar { get; set; }

        public double Beam { get; set; }

        public double Floor { get; set; }

        public double Overall { get; set; }

    }
}