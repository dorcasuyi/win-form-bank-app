namespace DCity_Bank_Core.Interface
{
    public interface IRegexVallidators
    {
        bool CheckEmail(string email);
        bool CheckName(string name);
        bool CheckPassword(string password);
        bool CheckPoneNumber(string phoneNumber);
    }
}