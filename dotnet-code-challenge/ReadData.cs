using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Text;

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
            dynamic data=JsonConvert.DeserializeObject<WolferhamptonRace>(System.IO.File.ReadAllText(@"C:\Repo\HPchallenge\dotnet-code-challenge\FeedData\Wolferhampton_Race1.json"));
            Console.WriteLine("Read file data!");
            if (data == null)
                return false;
            else
                return ((Newtonsoft.Json.Linq.JContainer)data).HasValues;
        }
        public ReadData(ILoggerFactory loggerFactor) {
            _logger = loggerFactor.CreateLogger<ReadData>();
        }

        public dynamic GetSubString(string inputString) {
            ArrayList outputStrings = new ArrayList();
            if (!string.IsNullOrEmpty(inputString)) {
                int n = inputString.Length;
                

                for (int i = 0; i < n; i++) {
                    
             
                    for (int j = n-i; j  > 0; j--)
                    {
                        outputStrings.Add(inputString.Substring(i, j));

                    }
                }

            }
            return outputStrings;
        }

        public dynamic RemoveDuplicateChar(string inputString)
        {
            StringBuilder str = new StringBuilder();
            if (!string.IsNullOrEmpty(inputString))
            {
                
                char[] inputstrArray = inputString.ToCharArray();
                
                int n = inputstrArray.Length;
                
                for (int i = 0; i < n; i++) {
                    int iCount = 0;
                    char[] subStringArray = str.ToString().ToCharArray();
                    for (int j = 0; j < subStringArray.Length; j++) {
                        if (inputstrArray[i] == inputstrArray[j]) {
                            iCount++;
                            break;
                        }
                    
                    }
                    if (iCount == 0)
                    {
                        str.Append(inputstrArray[i]);
                    }
                }
        
            }
            return str.ToString();
        }

        public dynamic CountChar(string inputString)
        {
            ArrayList charCount = new ArrayList();
            if (!string.IsNullOrEmpty(inputString))
            {

                char[] inputstrArray = inputString.ToCharArray();

                int n = inputstrArray.Length;

                for (int i = 0; i < n; i++)
                {
                    int iCount = 0;
                    
                    for (int j = 0; j < n; j++)
                    {
                        if (inputstrArray[i] == inputstrArray[j])
                        {
                            iCount++;
                 
                        }

                    }
                    var item = new { charater = inputstrArray[i], Count = iCount };
                    if (!charCount.Contains(item)) 
                    {
                       
                        charCount.Add(item);
                    }
                }

            }
            return charCount;
        }
    }

 
}
