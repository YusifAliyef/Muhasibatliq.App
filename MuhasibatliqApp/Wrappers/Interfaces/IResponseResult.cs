using Microsoft.VisualStudio.Services.DelegatedAuthorization;
using MuhasibatliqApp.Wrappers.Classes;

namespace MuhasibatliqApp.Wrappers.Interfaces
{
    public interface IResponseResult
    {
        string Message { get; set; }
        ResponseType ResponseType { get; set; }

        ICollection<ResponseValidationResult> ResponseValidationResults { get; set; }
    }
}
