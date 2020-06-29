using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace  cSharpTarot.Models
{
    public class Appointment
    {
        // Primary Key for Appointment
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("Name")]
        [JsonProperty("Name")]
        public string AppointmentName { get; set; }
        public DateTime Time { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }
        public string Focus { get; set; }
    }
}