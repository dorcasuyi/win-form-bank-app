namespace DCity_Bank_Core.Interface
{
    public interface IUserAuthentication
    {
        global::System.Boolean AuthLoginCredentials(global::System.String email, global::System.String password);
        global::System.Boolean CheckIfEmailExist(global::System.String email);
        global::System.String CheckIfEmpty(global::System.String email, global::System.String password);
        global::System.String getCustomerByEmail(global::System.String email);
        global::System.String GetLoginCustomerByID();
        global::System.String LogIn(global::System.String email, global::System.String Password);
        void SetLog(global::System.String email);
    }
}