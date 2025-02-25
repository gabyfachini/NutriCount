﻿namespace NutriCount.Exceptions.ExceptionsBase
{
    public class ErrorOnValidationException : NutriCountException
    {
        public IList<string> ErrorMessages { get; set; }
        public ErrorOnValidationException(IList<string> errorMessages) 
        { 
            ErrorMessages = errorMessages; 
        }
    }
}
