namespace GMR.BLL.Abstractions.Models
{
    public class ImportResultRow<T>
    {
        public T Item { get; set; }

        public string Error { set; get; }

        public bool IsSuccess => string.IsNullOrEmpty(Error);
    }
}
