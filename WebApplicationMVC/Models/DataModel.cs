using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationMVC.Models
{
    public class DataModel
    {

        public class Tags
        {
            public string CourseType { get; set; }
            public string Distance { get; set; }
            public string Going { get; set; }
            public string Runners { get; set; }
            public string MeetingCode { get; set; }
            public string TrackCode { get; set; }
            public string Sport { get; set; }
        }

        public class Tags2
        {
            public string participant { get; set; }
            public string name { get; set; }
        }

        public class Selection
        {
            public string Id { get; set; }
            public double Price { get; set; }
            public Tags2 Tags { get; set; }
        }

        public class Tags3
        {
            public string Places { get; set; }
            public string type { get; set; }
        }

        public class Market
        {
            public string Id { get; set; }
            public List<Selection> Selections { get; set; }
            public Tags3 Tags { get; set; }
        }

        public class Tags4
        {
            public string Weight { get; set; }
            public string Drawn { get; set; }
            public string Jockey { get; set; }
            public string Number { get; set; }
            public string Trainer { get; set; }
        }

        public class Participant
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public Tags4 Tags { get; set; }
        }

        public class RawData
        {
            public string FixtureName { get; set; }
            public string Id { get; set; }
            public DateTime StartTime { get; set; }
            public int Sequence { get; set; }
            public Tags Tags { get; set; }
            public List<Market> Markets { get; set; }
            public List<Participant> Participants { get; set; }
        }

        public class RootObject 
        {
            public string FixtureId { get; set; }
            public DateTime Timestamp { get; set; }
            public RawData RawData { get; set; }
        }
    }
}
