﻿
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using EdarShop.Model.Abstract;

namespace EdarShop.Model.Models
{
    [Table("PostCategories")]
    public class PostCategory:Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Alias { get; set; }

        public string Description { get; set; }

        public int? ParentID { get; set; }

        public int? DisplayOrder { get; set; }

        public bool? HomeFlag { get; set; }


        public virtual IEnumerable<Post> Posts { get; set; }
    }
}
