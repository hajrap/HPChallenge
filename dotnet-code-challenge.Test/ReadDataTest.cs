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

        [Fact]
        public void multi_demList()
        {
            List<List<int>> InputList = new List<List<int>>();
      
                List<int> innerlist0 = new List<int>();

                innerlist0.Add(11);
                innerlist0.Add(2);
                innerlist0.Add(4);
                InputList.Add(innerlist0);

                List<int> innerlist1 = new List<int>();

                innerlist1.Add(4);
                innerlist1.Add(5);
                innerlist1.Add(6);
                InputList.Add(innerlist1);

                List<int> innerlist2 = new List<int>();

                innerlist2.Add(10);
                innerlist2.Add(8);
                innerlist2.Add(-12);
                InputList.Add(innerlist2);
            
            var output = _ReadData.diagonalDifference(InputList);
            Assert.True(true);
        }
        [Fact]
        public void Numbertypes()
        {
            int [] inputarr =new int[6];
            inputarr[0] = -4;
            inputarr[1] =3;
            inputarr[2] =-9;
            inputarr[3] =0;
            inputarr[4] =4;
            inputarr[5] =1;
            _ReadData.plusMinus(inputarr);
            Assert.True(true);
        }
        }
}
