using System;

namespace Bexs.infrastructure.Util
{
    public class CsvManager
    {
        public CsvManager(string filePath)
        {
            AssertionConcern.AssertArgumentNotEmpty(filePath, "Please inform path of file");

            FilePath = filePath;
        }

        public string FilePath { get; set; }


        public void Read() 
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
