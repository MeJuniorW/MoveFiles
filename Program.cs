using System;
using System.Linq;
using System.IO;
using System.Text;

namespace MoveFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string downloadPath = @"C:\Users\user\Downloads";  
            var downFiles = Directory.GetFiles(downloadPath, "*", SearchOption.TopDirectoryOnly);

            foreach (string file in downFiles)
            {
                
                var fileInfo = new FileInfo(file);
                var fileExten = fileInfo.Extension;
                bool isPicture = (fileExten == ".jpg") || (fileExten == ".jpeg") || (fileExten == ".png");
                bool isPDF = (fileExten == ".pdf");
                bool isDocument = (fileExten == ".doc") || (fileExten == ".docx");
                bool isExecutable = (fileExten == ".exe");
                bool isZipFolder = (fileExten == ".rar") || (fileExten == ".zip");
                bool isMusic = (fileExten == ".mp3");
                bool isVideo = (fileExten == ".mp4") || (fileExten == ".mkv") || (fileExten == ".avi");

                
                if (isPicture)
                {
                    string destFolder = @"C:\Users\user\Pictures\";
                    File.Move(file, $"{destFolder}{Path.GetFileName(file)}");
                }
                else if (isPDF)
                {
                    string destFolder = @"C:\Users\user\PDF\";
                    File.Move(file, $"{destFolder}{Path.GetFileName(file)}");
                }
                else if (isDocument)
                {
                    string destFolder = @"C:\Users\user\Documents\";
                    File.Move(file, $"{destFolder}{Path.GetFileName(file)}");
                }
                else if (isExecutable)
                {
                    string destFolder = @"C:\Users\user\Applications\";
                    File.Move(file, $"{destFolder}{Path.GetFileName(file)}");
                }
                else if (isZipFolder)
                {
                    string destFolder = @"C:\Users\user\ZipFolder\";
                    File.Move(file, $"{destFolder}{Path.GetFileName(file)}");
                }
                else if (isMusic)
                {
                    string destFolder = @"C:\Users\user\Music\";
                    File.Move(file, $"{destFolder}{Path.GetFileName(file)}");
                }
                else if (isVideo)
                {
                    string destFolder = @"C:\Users\user\Videos\";
                    File.Move(file, $"{destFolder}{Path.GetFileName(file)}");
                }
            }
        }
    }
}