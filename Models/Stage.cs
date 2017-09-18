using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LatinDictionaryNoAuth.Models
{
    //Class Name: WordType
    //Author: Craig Meister, Delaine Wendling, Kenny Skaggs
    //Purpose of the class: This class serves as a model for our WordType object
    //Methods in Class: None.
    public class Stage
    {
        [Key]
        public int StageId {get;set;}

        [Required]
        public string StageName {get;set;}

        public ICollection<EnglishWord> EnglishWords;

        public ICollection<LatinWord> LatinWords;

    }
}