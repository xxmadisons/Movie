﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Movie.Models
{
    public class ApplicationResponse
    {
        [Key]
        [Required]
        public int ApplicationId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Year { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public string Rating { get; set; }
        public bool Edited { get; set; }
        public string LentTo { get; set; }
        public string Notes { get; set; }

    }
}
