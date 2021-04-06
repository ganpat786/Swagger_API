using FluentValidation;
using Swagger_API.Models.View_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Swagger_API.Validator
{
    public class BatchAttributedetailsVaidator : AbstractValidator<CreateAttributeViewModel>
    {
        public BatchAttributedetailsVaidator()
        {
            RuleFor(x => x.Key).NotEmpty().NotNull().WithMessage("Please specify a key");
            RuleFor(x => x.Value).NotEmpty().NotNull().WithMessage("Please specify a value");
        }
    }
}
