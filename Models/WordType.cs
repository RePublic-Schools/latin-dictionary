using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LatinDictionaryNoAuth.Models
{
    //Class Name: WordType
    //Author: Craig Meister, Delaine Wendling, Kenny Skaggs
    //Purpose of the class: This class serves as a model for our WordType object
    //Methods in Class: None.
    public class WordType
    {
        [Key]
        public int WordTypeId {get;set;}

        [Required]
        public string Type {get;set;}

        public ICollection<EnglishWord> EnglishWords;

        public ICollection<LatinWord> LatinWords;
    }
}