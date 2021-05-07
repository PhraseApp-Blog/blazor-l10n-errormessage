using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorErrorMessageL10n.Models
{
    public class Employee
    {
        [Required(ErrorMessageResourceName = nameof(Resources.App.Name_Validation), ErrorMessageResourceType = typeof(Resources.App))]
        public string Name { get; set; }

        [Required(ErrorMessageResourceName = nameof(Resources.App.City_Validation), ErrorMessageResourceType = typeof(Resources.App))]
        public string City { get; set; }

        [Required(ErrorMessageResourceName = nameof(Resources.App.Gender_Validation), ErrorMessageResourceType = typeof(Resources.App))]
        public string Gender { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessageResourceName = nameof(Resources.App.Salary_Validation), ErrorMessageResourceType = typeof(Resources.App))]
        public int Salary { get; set; }
    }
}
