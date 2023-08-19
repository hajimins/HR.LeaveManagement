using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR.LeaveManagement.Application.DTOs.LeaveAllocation.Validators
{
    public class CreateLeaveAllocationDtoValidator : AbstractValidator<CreateLeaveAllocationDto>
    {
        public CreateLeaveAllocationDtoValidator()
        {
            RuleFor(p=>p.NumberOfDays)
                .NotEmpty().WithMessage("{PropertyName} should not be empty")
                .NotNull()
                .GreaterThan(0).WithMessage("{PropertyName} should have more than 0 characters");

            RuleFor(p => p.LeaveTypeId)
               .NotEmpty().WithMessage("{PropertyName} should not be empty")
               .NotNull()
               .GreaterThan(0).WithMessage("{PropertyName} should have more than 0 characters");

        }
    }
}
