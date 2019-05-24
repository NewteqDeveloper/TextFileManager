# TextFileManager
This is a library written in c# that will help you easily read and write text files

# Using the library
There are 4 simple steps that you need to follow to use the library

1. Create a new FileReader or FileOutputer with the constructor
    * There is only one constructor that takes in the file name
2. Open the file by calling OpenFile()
3. If you are reading a file use ReadLine(), if you are writting to a file use WriteLine() or Write()
4. Close the file using CloseFile()

## FileReader
This object is used to read lines from a file

## FileOutputer
This object is used to write lines or write text (without adding a new line character) to a file

# Exceptions
An exception will be thrown if you try to read or write to the file before it has been opened.
This can be found in the [FileNotOpenException Class] (https://github.com/Sanity1123/TextFileManager/blob/master/TextFileManager/FileNotOpenException.cs)
