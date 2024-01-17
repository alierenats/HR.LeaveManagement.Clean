using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation.Results;
using FluentValidation;


namespace HR.LeaveManagement.Application.Exceptions;


public class BadRequestException : Exception
{

    public BadRequestException(string message) : base(message)
    {

    }

    public BadRequestException(string message, FluentValidation.Results.ValidationResult validationResult) : base(message)
    {
        ValidationErrors = new();
        foreach (var error in validationResult.Errors)
        {
            ValidationErrors.Add(error.ErrorMessage);
        }
    }

    public List<string> ValidationErrors { get; set; }
    
}
