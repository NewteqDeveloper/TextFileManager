using System.IO;

namespace TextFileManager
{
    public class FileReader
    {

        private StreamReader _streamReader;
        private readonly string _fileName;
        private bool _isFileOpen;

        public FileReader(string fileName)
        {
            _fileName = fileName;
            _isFileOpen = false;
        }

        public void OpenFile()
        {
            if (_isFileOpen) return;
            _streamReader = new StreamReader(_fileName);
            _isFileOpen = true;
        }

        public void CloseFile()
        {
            if (!_isFileOpen) return;
            _streamReader.Close();
            _isFileOpen = false;
        }

        public string ReadLine()
        {
            IsFileOpen();

            var line = _streamReader.ReadLine();
            //after ?? will be returned if line is null
            return line ?? string.Empty;
        }

        private void IsFileOpen()
        {
            if (!_isFileOpen)
            {
                throw new FileNotOpenException();
            }
        }

        public void ResetFilePosition()
        {
            IsFileOpen();
            
            _streamReader.BaseStream.Position = 0;
            _streamReader.DiscardBufferedData();
        }

    }
}
