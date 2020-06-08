namespace Algorithms
{
    public interface IKey
    {
        string PublicKeyPath { get; set; }
        string PrivateKeyPath { get; set; }
        string Email { get; set; }
        string Password { get; set; }
    }

    public class Key : IKey
    {
        public string PublicKeyPath { get; set; }
        public string PrivateKeyPath { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public Key()
        { }
    }
}
