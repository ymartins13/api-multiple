namespace MultipleAPI.DTOs
{
    public class MultipleResponse
    {
        public int Number { get; set; }
        public bool IsMultiple { get; set; }

        public MultipleResponse(int number, bool isMultiple)
        {
            Number = number;
            IsMultiple = isMultiple;
        }
    }
}
