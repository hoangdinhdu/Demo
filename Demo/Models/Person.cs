using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Demo.Models
{
    [Table("Person")]
    public class Person
    {
        [Key]

        public string PersonID { get; set; }
        public string PersonName { get; set; }

        
    }
}
//dotnet-aspnet-codegenerator controller -name PersonsController -m Person -dc DemoDBContext --relativeFolderPath Controllers --useDefaultLayout --referenceScriptLibraries -sqlite