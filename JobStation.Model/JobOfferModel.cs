using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobStation.Model
{
    public class JobOfferModel
    {
             
        

        public int Id { get; set; }
        public string UniqueGuid { get; set; }
        [Required(ErrorMessage = "Category is required")]
        [Display(Name = "Category")]
        public int JobCategoryId { get; set; }
        [Required(ErrorMessage = "JobType is required")]
        [Display(Name = "Job Type")]
        public int JobTypeId { get; set; }
        [Required(ErrorMessage = "CompanyName is required")]
        [Display(Name = "Company Name")]
        public int CompanyId { get; set; }
        [Required(ErrorMessage = "Location is required")]
        [Display(Name = "Location")]
        public int LocationId { get; set; }
        public string Title { get; set; }
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }
        public int Experience { get; set; }
        public float Salary { get; set; }
        public bool IsActive { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public DateTimeOffset UpdatedOn { get; set; }

        public List<SelectListItem> CategoryItems { get; set; }
        public List<SelectListItem> CompanyItems { get; set; }
        public List<SelectListItem> LocationItems { get; set; }
        public List<SelectListItem> JobTypeItems { get; set; }


    }
}
