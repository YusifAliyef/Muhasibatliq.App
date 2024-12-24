using Microsoft.VisualStudio.Services.DelegatedAuthorization;
using MuhasibatliqApp.Wrappers.Classes;
using MuhasibatliqApp.Wrappers.Interfaces;

namespace MuhasibatliqApp.Wrappers.Implementations
{
    public class ResponseDataResult<T> : ResponseResult, IResponseDataResult<T>
    {
       
        public ResponseDataResult(Enums.ResponseType notFound, ICollection<ResponseValidationResult> validationResults) : base(validationResults)
        {

        }

        public T Data { get; set; }

    }
}
