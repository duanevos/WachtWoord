﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WachtWoord.Models
{
    public class Favorite
    {
        [Key]
        public int Id { get; set; }
        public Entry entry;
    }
}
