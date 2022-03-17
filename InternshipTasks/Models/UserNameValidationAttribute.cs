using InternshipTasks.Models.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InternshipTasks.Models
{
    public class UserNameValidationAttribute:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var _context = (ApplicationDbContext)validationContext.GetService(typeof(ApplicationDbContext));
            var entity = _context.users.SingleOrDefault(e => e.UserName == value.ToString());

            if (entity != null)
            {
                return new ValidationResult(GetErrorMessage(value.ToString()));
            }
            return ValidationResult.Success;
        }

        public string GetErrorMessage(string userName)
        {
            return $"UserName {userName} is already in use.";
        }
    }
}
