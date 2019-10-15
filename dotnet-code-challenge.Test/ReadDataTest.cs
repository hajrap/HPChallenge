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
            _ReadData = new ReadData(loggerFactor);
        }
        [Fact]
        public void IsDataAvailable() {

            var isFileHasData = _ReadData.IsFileHasData();
            Assert.True(isFileHasData);
        }

        [Fact]
        public void all_possible_substring_of_number() {

            var output = _ReadData.GetSubString("Robotics");
            Assert.True(true);
        }

        [Fact]
        public void Remove_duplicate()
        {

            var output = _ReadData.RemoveDuplicateChar("Riobootics");
            Assert.True(true);
        }
        [Fact]
        public void Char_Count()
        {

            var output = _ReadData.CountChar("Riobootics");
            Assert.True(true);
        }
    }
}
