using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace dotnet_code_challenge.Test
{
 
   public class ReadDataTest
    {
        private ReadData _ReadData;
     
        public ReadDataTest() {
            var serviceProvider = new ServiceCollection()
                .AddLogging()
                .BuildServiceProvider();
            var loggerFactor = serviceProvider.GetService<ILoggerFactory>();
          _ReadData = new ReadData (loggerFactor);
        }
        [Fact]
        public void IsDataAvailable() {

           var isFileHasData= _ReadData.IsFileHasData();
            Assert.Equal("True", isFileHasData.ToString());
        }
    }
}
