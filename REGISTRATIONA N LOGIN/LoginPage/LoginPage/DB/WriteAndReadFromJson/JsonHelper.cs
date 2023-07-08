using System;
using System.IO;

namespace LoginPage.DB.WriteAndReadFromJson
{
    public class JsonHelper
    {
        public static string GetPath(string fileName)
        {
            string currentDir = Environment.CurrentDirectory;
            string filePath = Path.Combine(currentDir, "DB", "JsonFiles", fileName);

            if (File.Exists(filePath))
            {
                return filePath;
            }

            try
            {
                FileInfo fileInfo = new FileInfo(filePath);

                using (FileStream filestream = fileInfo.Create())

                    return fileInfo.FullName;
            }
            catch (System.Exception ex)
            {

                throw ex;
            }
        }
    }
}
