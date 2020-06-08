using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Algorithms
{
    public interface IAes
    {
        string Encrypt(string value, string password);
        string Decrypt(string value, string password);
    }

    public class Aes : IAes
    {
        private readonly int _iterations = 2;
        private readonly int _keySize = 256;

        private readonly string _hash = "SHA1";
        private readonly string _salt = "aselrias38490a32";
        private readonly string _vector = "8947az34awl34kjq";

        public Aes()
        { }

        public string Encrypt(string value, string password)
        {
            return Encrypt<AesManaged>(value, password);
        }

        public string Decrypt(string value, string password)
        {
            return Decrypt<AesManaged>(value, password);
        }

        private string Encrypt<T>(string value, string password)
                where T : SymmetricAlgorithm, new()
        {
            try
            {
                byte[] vectorBytes = Encoding.UTF8.GetBytes(_vector);
                byte[] saltBytes = Encoding.UTF8.GetBytes(_salt);
                byte[] valueBytes = Encoding.UTF8.GetBytes(value);

                byte[] encrypted;
                using (T cipher = new T())
                {
                    PasswordDeriveBytes _passwordBytes =
                        new PasswordDeriveBytes(password, saltBytes, _hash, _iterations);
                    byte[] keyBytes = _passwordBytes.GetBytes(_keySize / 8);

                    cipher.Mode = CipherMode.CBC;

                    using (ICryptoTransform encryptor = cipher.CreateEncryptor(keyBytes, vectorBytes))
                    {
                        using MemoryStream to = new MemoryStream();
                        using CryptoStream writer = new CryptoStream(to, encryptor, CryptoStreamMode.Write);

                        writer.Write(valueBytes, 0, valueBytes.Length);
                        writer.FlushFinalBlock();

                        encrypted = to.ToArray();
                    }

                    cipher.Clear();
                }

                return Convert.ToBase64String(encrypted);
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        private string Decrypt<T>(string value, string password) where T : SymmetricAlgorithm, new()
        {
            try
            {
                byte[] vectorBytes = Encoding.UTF8.GetBytes(_vector);
                byte[] saltBytes = Encoding.UTF8.GetBytes(_salt);
                byte[] valueBytes = Convert.FromBase64String(value);

                byte[] decrypted;
                int decryptedByteCount = 0;

                using (T cipher = new T())
                {
                    PasswordDeriveBytes _passwordBytes =
                        new PasswordDeriveBytes(password, saltBytes, _hash, _iterations);
                    byte[] keyBytes = _passwordBytes.GetBytes(_keySize / 8);

                    cipher.Mode = CipherMode.CBC;

                    try
                    {
                        using ICryptoTransform decryptor = cipher.CreateDecryptor(keyBytes, vectorBytes);
                        using MemoryStream from = new MemoryStream(valueBytes);
                        using CryptoStream reader = new CryptoStream(from, decryptor, CryptoStreamMode.Read);
                        decrypted = new byte[valueBytes.Length];
                        decryptedByteCount = reader.Read(decrypted, 0, decrypted.Length);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex);
                        return String.Empty;
                    }

                    cipher.Clear();
                }

                return Encoding.UTF8.GetString(decrypted, 0, decryptedByteCount);
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }
    }
}
