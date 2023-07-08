using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace LoginPage.DB.WriteAndReadFromJson
{
    public class WriteToJson
    {
        public void WriteToJsons<T>(List<T> input, string GenericFileName)
        {
            try
            {
                string fileName = JsonHelper.GetPath(GenericFileName);
                string jsonString = JsonSerializer.Serialize(input);

                using (StreamWriter write = new StreamWriter(fileName))
                {
                    write.Write(jsonString);
                }
            }
            catch (System.Exception ex)
            {

                throw ex;
            }
        } 
    }
}
