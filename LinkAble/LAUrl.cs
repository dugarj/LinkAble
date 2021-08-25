using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LABOL
{
    [Table("LAUrl")]
    public class LAUrl
    {
        [Key]
        public int UrlId { get; set; }
        public string UrlTitle { get; set; }
        public string LAUrlName { get; set; }
        public string Description { get; set; }
        public bool IsApproved { get; set; }
        
        [ForeignKey("Category")] 
        public int CategoryId { get; set; }
        
        [ForeignKey("LAUser")]
        public string Id { get; set; }
        
        public Category Category { get; set; }
        public LAUser User { get; set; }  
    }
}
