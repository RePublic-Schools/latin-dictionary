using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LatinDictionaryNoAuth.Models
{
    //Class Name: WordType
    //Author: Craig Meister, Delaine Wendling, Kenny Skaggs
    //Purpose of the class: This class serves as a model for our WordType object
    //Methods in Class: None.
    public class EnglishLatin
    {
        [Required]
        public int EnglishWordId {get;set;}
        public EnglishWord EnglishWord {get;set;}

        [Required]
        public int LatinWordId {get;set;}
        public LatinWord LatinWord {get;set;}

        public ICollection<EnglishWord> EnglishWords;

        public ICollection<LatinWord> LatinWords;

    }
}