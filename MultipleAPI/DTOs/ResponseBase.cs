namespace MultipleAPI.DTOs
{
    public class ResponseBase<T>
    {
        public T Result { get; set; }

        public ResponseBase(T result)
        {
            Result = result;
        }
    }
}
