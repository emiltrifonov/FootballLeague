﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace FootballLeague.Models
{
    public partial class RefereePosition
    {
        [Key]
        public int position_id { get; set; }
        [Required]
        [StringLength(30)]
        [Unicode(false)]
        public string position_name { get; set; }
    }
}