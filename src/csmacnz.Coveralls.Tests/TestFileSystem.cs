using System.Collections.Generic;

namespace csmacnz.Coveralls.Tests
{
    public class TestFileSystem : IFileSystem
    {
        private readonly Dictionary<string, string> _files = new Dictionary<string, string>();

        public string TryLoadFile(string filePath)
        {
            if (_files.ContainsKey(filePath))
            {
                return _files[filePath];
            }
            return null;
        }

        public void AddFile(string path, string contents)
        {
            _files[path] = contents;
        }
    }
}