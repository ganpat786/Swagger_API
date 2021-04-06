using FluentValidation;
using Swagger_API.Context;
using Swagger_API.Models;
using Swagger_API.Models.View_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Swagger_API.Validator
{
    public class BatchdetailsVaidator : AbstractValidator<CreateBatchViewModel>
    {
        private readonly CRUDContext _CRUDContext;

        public BatchdetailsVaidator(CRUDContext CRUDContext)
        {
            _CRUDContext = CRUDContext;
            RuleFor(x => x.BusinessUnit).NotEmpty().NotNull().Must(UniqueName);
            RuleFor(x => x.acl.readGroups).NotEmpty().NotNull().WithMessage("Please specify a readGroups");
            RuleFor(x => x.acl.readUsers).NotEmpty().NotNull().WithMessage("Please specify a readUsers");
            RuleFor(x => x.EmpiryDate).NotEmpty().NotNull().WithMessage("Please specify a EmpiryDate");

        }

        private bool UniqueName(CreateBatchViewModel category, string businessUnit)
        {
            var dbCategory = _CRUDContext.BatchBusinessUnitTables
                                .Where(x => x.BusinessUnitName.ToLower() == businessUnit.ToLower())
                                .SingleOrDefault();

            if (dbCategory != null)
                return true;

            return false;
        }
    }
    
}
