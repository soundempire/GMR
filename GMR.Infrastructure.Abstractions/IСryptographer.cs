namespace GMR.Infrastructure
{
    public interface IСryptographer
    {
        string Encrypt(string text);

        string Decrypt(string text);
    }
}
