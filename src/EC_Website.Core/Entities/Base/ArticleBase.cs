using System.ComponentModel.DataAnnotations;
using EC_Website.Core.Entities.UserModel;
using EC_Website.Core.Interfaces.Entities;

namespace EC_Website.Core.Entities.Base
{
    public abstract class ArticleBase : EntityBase, ISlugifiedEntity
    {
        [StringLength(80)]
        [Display(Name = "Slug")]
        public string Slug { get; set; }
        
        [Required(ErrorMessage = "Please enter the article topic name")]
        [StringLength(80, ErrorMessage = "Characters must be less than 80")]
        [Display(Name = "Title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter the article text")]
        [Display(Name = "Content")]
        public string Content { get; set; }
        public virtual ApplicationUser Author { get; set; }
    }
}
