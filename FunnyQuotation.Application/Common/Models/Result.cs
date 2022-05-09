namespace FunnyQuotation.Application.Common.Models
{
    public class Result<T>
    {
        internal Result(bool succeeded, string errors, T data)
        {
            Succeeded = succeeded;
            Errors = errors;
            Data = data;
        }

        public bool Succeeded { get; set; }

        public string Errors { get; set; }

        public T Data { get; set; }

        public static Result<T> Success(T data)
        {
            return new Result<T>(true, string.Empty, data);
        }

        public static Result<T> Failure(string errors, T data)
        {
            return new Result<T>(false, errors, data);
        }
    }
}
