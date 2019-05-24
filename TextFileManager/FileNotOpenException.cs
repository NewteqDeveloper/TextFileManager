using System;

namespace TextFileManager
{
    public class FileNotOpenException : Exception
    {
        private const string ErrorMsg = "Please open the file before trying to perform this action";

        public FileNotOpenException()
            : base (ErrorMsg)
        {
            
        }

    }
}
