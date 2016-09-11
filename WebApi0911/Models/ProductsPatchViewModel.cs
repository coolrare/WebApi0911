using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApi0911.Models
{
    public class ProductsPatchViewModel : IValidatableObject
    {
        public Nullable<decimal> Price { get; set; }
        public Nullable<decimal> Stock { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            throw new NotImplementedException();
        }
    }
}