using System;
using System.Collections.Generic;
using System.Text;

namespace dotnet_code_challenge
{
   public class WolferhamptonRace
    {
        public string FixtureId { get; set; }
        public string Timestamp { get; set; }
        public RawData RawData { get; set; }
    }

    public class RawData
    {
        public string FixtureName { get; set; }
        public string Id { get; set; }
        public string StartTime { get; set; }
        public int Sequence { get; set; }
        public Tags Tags { get; set; }
        public List<Market> Markets { get; set; }
        public List<Participant> Participants{ get; set; }
    }

    public class Participant
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public List<dynamic> Tags { get; set; }
    }

    public class Market
    {
        public string Id { get; set; }
        public List<Selection> Selections { get; set; }
        public List<dynamic> Tags { get; set; }
    }

    public class Selection
    {
        public string Id { get; set; }
        public string Price { get; set; }
        public List<dynamic> Tags { get; set; }
    }

    public class Tags
    {
        public string CourseType { get; set; }
        public string Distance { get; set; }
        public string Going { get; set; }
        public int Runners { get; set; }
        public string MeetingCode { get; set; }
        public string TrackCode { get; set; }
        public string Sport { get; set; }
    }
}
