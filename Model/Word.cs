﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DictionaryApi.Model
{
    [Table("Word")]
    public class Word
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int WordTypeId { get; set; }
        public WordType WordType { get; set; }
        public IList<Meaning> Meanings { get; set; }
    }
}
