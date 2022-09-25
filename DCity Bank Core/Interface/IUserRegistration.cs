namespace DCity_Bank_Core.Interface
{
    public interface IUserRegistration
    {
        global::System.String RegisterCustomer(global::System.String email, global::System.String Password);
        global::System.String UserIDGenerator();
    }
}