using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;


namespace dotnet_code_challenge
{
    public class ReadData : IReadData
    {
        private ILogger<ReadData> _logger;

        public string FilePath { get; set; }
        public char FileType { get; set; }
        public dynamic FileData { get; set; }
        public void GetFileData()
        {
            Console.WriteLine("Read file data!");
        }
        public bool IsFileHasData()
        {
            dynamic data=JsonConvert.DeserializeObject<dynamic>(System.IO.File.ReadAllText(@"C:\Repo\HPchallenge\dotnet-code-challenge\FeedData\Wolferhampton_Race1.json"));
            Console.WriteLine("Read file data!");
            if (data == null)
                return false;
            else
                return ((Newtonsoft.Json.Linq.JContainer)data).HasValues;
        }
        public ReadData(ILoggerFactory loggerFactor) {
            _logger = loggerFactor.CreateLogger<ReadData>();
        }
    }
}
