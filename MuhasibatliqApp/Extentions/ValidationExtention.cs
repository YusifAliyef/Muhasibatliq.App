using MuhasibatliqApp.Wrappers.Classes;
using FluentValidation.Results;
namespace MuhasibatliqApp.Extentions
{
    public static class ValidationExtention
    {
        public static ICollection<ResponseValidationResult> ToResponseValidationResults(this ValidationResult validationResult)
        {
            ICollection<ResponseValidationResult> responseValidationResults = [];

            foreach (var item in validationResult.Errors)
            {
                responseValidationResults.Add(new()
                {
                    ErrorMessage = item.ErrorMessage,
                    PropertyName = item.PropertyName

                });

            }
            return responseValidationResults;
        }
    }
}
