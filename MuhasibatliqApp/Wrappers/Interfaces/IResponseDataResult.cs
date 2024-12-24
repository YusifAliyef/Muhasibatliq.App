namespace MuhasibatliqApp.Wrappers.Interfaces
{
    public interface IResponseDataResult<T> : IResponseResult
    {
        T Data { get; set; }
    }
   
}
