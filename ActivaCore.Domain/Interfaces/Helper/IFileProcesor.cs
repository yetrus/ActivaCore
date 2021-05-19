using System.Collections.Generic;

namespace ActivaCore.Domain
{
    public interface IFileProcesor
    {
        string DecryptString(string cipherText);
        string EncryptString(string plainText);
        string GetCsv<T>(IEnumerable<T> items);
    }
}
