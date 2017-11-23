using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FightGame
{
    public class StarWarsPeople
    {
        public List<Person> results { get; set; }
        public StarWarsPeople DeserializeObject { get; internal set; }
    }

    public class Person
    {
        internal string gender;
        internal string name;

        [JsonProperty("name")]
        public string PlayerName { get; set; }

        [JsonProperty("gender")]
        public string PlayerGender { get; set; }
    }
}
