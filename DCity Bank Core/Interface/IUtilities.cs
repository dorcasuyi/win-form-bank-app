namespace DCity_Bank_Core.Interface
{
    public interface IUtilities
    {
        string ComputeSha256Hash(string rawData);
        string ConvertToTitle(string str);
        string CustomerIDGenerator();
        string GenerateAccID();
        string GenerateAccNumber(int length);
        string removeCharacter(string str);
    }
}