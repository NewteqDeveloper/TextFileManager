using System.IO;

namespace TextFileManager
{
    public class FileOutputer
    {

        private StreamWriter _streamWriter;
        private readonly string _fileName;
        private bool _isFileOpen;

        public FileOutputer(string fileName)
        {
            _fileName = fileName;
        }

        public void OpenFile()
        {
            if (_isFileOpen) return;
            _streamWriter = new StreamWriter(_fileName);
            _isFileOpen = true;
        }

        public void CloseFile()
        {
            if (!_isFileOpen) return;
            _streamWriter.Close();
            _isFileOpen = false;
        }

        public void WriteLine(string line)
        {
            if (!_isFileOpen)
            {
                throw new FileNotOpenException();
            }
            
            _streamWriter.WriteLine(line);
        }

        public void Write(string message)
        {
            if (!_isFileOpen)
            {
                throw new FileNotOpenException();
            }

            _streamWriter.Write(message);
        }

    }
}
