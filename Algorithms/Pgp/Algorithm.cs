using PgpCore;
using System;
using Utils.Filesystem;

namespace Algorithms
{
    public interface IPgp
    {
        string GenerateKeyPair(string email, string password);
        void LoadInput(string fileName);
        void LoadKeys(string fileName);
        void UpdatePublicKey(string publicKeyPath);
        void UpdatePrivateKey(string privateKeyPath);
        void UpdatePlaintext(string plaintextPath);
        void UpdateCiphertext(string ciphertextPath);
        string Encrypt(string password);
        string Decrypt(string password);
        void Unload();
    }

    public class Pgp : IPgp
    {
        private readonly PGP _pgp = new PGP();
        private readonly IKey _key = new Key();
        private readonly IFileManager _file = new FileManager();
        private string _fileName;
        private string _plaintextFilePath;
        private readonly string _plaintextFilePathBase = "C:\\TEMP\\App.Pgp\\inputs";
        private string _signedFilePath;
        private readonly string _signedFilePathBase = "C:\\TEMP\\App.Pgp\\results";

        public Pgp()
        {
            _file.InitializePgp();
        }

        public string GenerateKeyPair(string email, string password)
        {
            _key.Email = email;
            _key.Password = password;

            try
            {
                _pgp.GenerateKey(
                    @_key.PublicKeyPath,
                    @_key.PrivateKeyPath,
                    _key.Email,
                    _key.Password);
                return string.Empty;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public void LoadInput(string fileName)
        {
            _fileName = fileName;

            _plaintextFilePath = _plaintextFilePathBase + "\\" + _fileName + ".txt";
            _file.Register(_plaintextFilePath);
        }

        public void LoadKeys(string fileName)
        {
            _fileName = fileName;

            _key.PublicKeyPath = "C:\\TEMP\\App.Pgp\\keys\\" + fileName + "_PUBKEY.asc";
            _key.PrivateKeyPath = "C:\\TEMP\\App.Pgp\\keys\\" + fileName + "_PRVKEY.asc";

            _file.Register(_key.PublicKeyPath);
            _file.Register(_key.PrivateKeyPath);
        }

        public void UpdatePublicKey(string publicKeyPath)
        {
            _key.PublicKeyPath = publicKeyPath;
        }

        public void UpdatePrivateKey(string privateKeyPath)
        {
            _key.PrivateKeyPath = privateKeyPath;
        }

        public void UpdatePlaintext(string plaintextPath)
        {
            _plaintextFilePath = plaintextPath;
        }

        public void UpdateCiphertext(string ciphertextPath)
        {
            _signedFilePath = ciphertextPath;
        }

        public string Encrypt(string password)
        {
            try
            {
                _signedFilePath = _signedFilePathBase + "\\" + 
                    _fileName + "_SIGNED.pgp";
                _file.Register(_signedFilePath);

                _pgp.EncryptFileAndSign(
                   @_plaintextFilePath,
                   @_signedFilePath,
                   @_key.PublicKeyPath,
                   @_key.PrivateKeyPath,
                   password,
                   true,
                   true);
                return string.Empty;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public string Decrypt(string password)
        {
            string unsignedFilePath = _signedFilePathBase + "\\" + _fileName + "_UNSIGNED.txt";
            _file.Register(unsignedFilePath);

            try
            {
                _pgp.DecryptFileAndVerify(
                @_signedFilePath,
                @unsignedFilePath,
                @_key.PublicKeyPath,
                @_key.PrivateKeyPath,
                password);
                return string.Empty;
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }

        public void Unload()
        {
            _file.PgpEraseFootprint();
        }
    }
}
