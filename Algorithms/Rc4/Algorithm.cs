using System;
using System.Security.Cryptography;
using System.Text;

namespace Algorithms
{
    public interface IRc4
    {
        void ImportKey(string password);
        string Encrypt(string raw);
        string Decrypt(string encrypted);
    }

    public class Rc4 : IRc4
    {
        private string _password;

        public Rc4()
        { }

        public void ImportKey(string password)
        {
            _password = password;
        }

        public string Encrypt(string plaintext)
        {
            try
            {
                AesCryptoServiceProvider aesService = new AesCryptoServiceProvider();
                ICryptoTransform transformation = GenerateCryptoTransform(aesService, true);

                byte[] convertedPlaintext = Encoding.UTF8.GetBytes(plaintext);
                byte[] transformedPlaintext = transformation.TransformFinalBlock(
                    convertedPlaintext, 0, convertedPlaintext.Length);

                return Convert.ToBase64String(transformedPlaintext);
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        public string Decrypt(string ciphertext)
        {
            try
            {
                AesCryptoServiceProvider aesService = new AesCryptoServiceProvider();
                ICryptoTransform transformation = GenerateCryptoTransform(aesService, false);

                byte[] convertedCiphertext = Convert.FromBase64String(ciphertext);
                byte[] transformedCiphertext = transformation.TransformFinalBlock(
                    convertedCiphertext, 0, convertedCiphertext.Length);

                return Encoding.UTF8.GetString(transformedCiphertext);
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        private ICryptoTransform GenerateCryptoTransform(
            AesCryptoServiceProvider aesService, bool isEncrypted)
        {
            aesService.Mode = CipherMode.CBC;
            aesService.Padding = PaddingMode.PKCS7;

            Rfc2898DeriveBytes spec = new Rfc2898DeriveBytes(
                Encoding.UTF8.GetBytes(_password), 
                Encoding.UTF8.GetBytes("SALT_VALUE"), 65536);
            byte[] key = spec.GetBytes(16);

            aesService.IV = Encoding.UTF8.GetBytes("IV_VALUE_16_BYTE");
            aesService.Key = key;

            if (isEncrypted)
                return aesService.CreateEncryptor();

            return aesService.CreateDecryptor();
        }
    }
}
