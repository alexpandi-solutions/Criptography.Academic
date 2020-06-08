using System.Collections.Generic;
using System.IO;

namespace Utils.Filesystem
{
    public interface IFileManager
    {
        void InitializePgp();
        void Register(string filePath);
        void PgpEraseFootprint();
    }

    public class FileManager : IFileManager
    {
        private readonly IList<FileStream> _path = new List<FileStream>();

        public FileManager()
        { }

        public void InitializePgp()
        {
            Directory.CreateDirectory("C:\\TEMP\\App.Pgp\\inputs");
            Directory.CreateDirectory("C:\\TEMP\\App.Pgp\\results");
            Directory.CreateDirectory("C:\\TEMP\\App.Pgp\\keys");
        }

        public void Register(string filePath)
        {
            if (!string.IsNullOrEmpty(filePath) && !string.IsNullOrWhiteSpace(filePath))
            {
                _path.Add(Create(filePath));
            }
        }

        public void PgpEraseFootprint()
        {
            Directory.Delete("C:\\TEMP\\App.Pgp", true);
        }

        private FileStream Create(string filePath)
        {
            if (!File.Exists(filePath))
            {
                var file = File.Create(filePath);
                file.Close();
                return file;
            }
            else
            {
                File.Delete(filePath);
                var file = File.Create(filePath);
                file.Close();
                return file;
            }
        }
    }
}