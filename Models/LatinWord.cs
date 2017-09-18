using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LatinDictionaryNoAuth.Models
{
    //Class Name: WordType
    //Author: Craig Meister, Delaine Wendling, Kenny Skaggs
    //Purpose of the class: This class serves as a model for our WordType object
    //Methods in Class: None.
    public class LatinWord
    {
        [Key]
        public int LatinWordId {get;set;}

        [Required]
        public string Word {get;set;}

        [Required]
        [DataTypeAttribute(DataType.Date)]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Computed)]
        public DateTime DateCreated {get;set;}

        [Required]
        public int StageId {get;set;}
        public Stage Stage {get;set;}

        [Required]
        public int WordTypeId {get;set;}
        public WordType WordType {get;set;}

    }
}