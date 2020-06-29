using Bexs.Utils.CsvMapper;
using Bexs.Utils.CsvModels;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bexs.Utils
{
    public class CsvManager<T>
    {
        public string FilePath { get; set; }
        public CsvManager(string filePath)
        {
            AssertionConcern.AssertArgumentNotEmpty(filePath, "Please inform path of file");

            FilePath = filePath;
        }

        public IEnumerable<StretchModel> Read()
        {
            IEnumerable<StretchModel> result;
            try
            {
                using (var reader = new StreamReader(FilePath))
                using (var csv = new CsvReader(reader, CultureInfo.CurrentCulture))
                {
                    csv.Configuration.RegisterClassMap<StretchCsvMap>();
                    csv.Configuration.HasHeaderRecord = false;
                    result = csv.GetRecords<StretchModel>().ToList();                   
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }

    }
}
