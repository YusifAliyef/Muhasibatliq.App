
using MuhasibatliqApp.Enums;
using MuhasibatliqApp.Wrappers.Classes;
using MuhasibatliqApp.Wrappers.Interfaces;

namespace MuhasibatliqApp.Wrappers.Implementations
{
    public class ResponseResult : IResponseResult
    {
        public string Message { get; set; }
        public ResponseType ResponseType { get; set; }
        public ICollection<ResponseValidationResult> ResponseValidationResults { get; set; }
        Microsoft.VisualStudio.Services.DelegatedAuthorization.ResponseType IResponseResult.ResponseType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public ResponseResult(ResponseType responseType, string message)
        {
            ResponseType = responseType;
            Message = message;
        }

        public ResponseResult(ICollection<ResponseValidationResult> responseValidationResults)
        {
            Message = " Validation error";
            ResponseType = ResponseType.ValidationError;
            ResponseValidationResults = responseValidationResults;
        }

    }
}
