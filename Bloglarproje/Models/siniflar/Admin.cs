﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bloglarproje.Models.siniflar
{
    public class Admin
    {
        [Key]
     public int ID { get; set; }
    public string kullanici { get; set; }
    public string sifre { get; set; }
}
}