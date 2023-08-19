using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR.LeaveManagement.Application.DTOs.LeaveType.Validators
{
    public class CreateLeaveTypeDtoValidator : AbstractValidator<CreateLeaveTypeDto>
    {
        public CreateLeaveTypeDtoValidator()
        {
            RuleFor(p => p.Name)
                            .NotEmpty().WithMessage("{PropertyName} is required.")
                            .NotNull()
                            .MaximumLength(50).WithMessage("{PropertyName} should not exceed 50 characters");

            RuleFor(p => p.DefaultDays)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .GreaterThan(0).WithMessage("{PropertyName} should be greater than 0.")
                .LessThan(100).WithMessage("{PropertyName} should be less than 100");
        }
    }
}