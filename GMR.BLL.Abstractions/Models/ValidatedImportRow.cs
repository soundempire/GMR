namespace GMR.BLL.Abstractions.Models
{
    public class ValidatedImportRow<T>
    {
        public T Item { get; set; }

        public string Error { set; get; }

        public bool IsValid => string.IsNullOrEmpty(Error);

        public static ValidatedImportRow<T> CreateWithError(string errorMessage) => new ValidatedImportRow<T>() { Error = errorMessage };
    }
}
