﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace AbcStore.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Naziv { get; set; }
        public string Kategorija { get; set; }
        public string Cijena { get; set; }
        public string FileName { get; set; }
    }
}