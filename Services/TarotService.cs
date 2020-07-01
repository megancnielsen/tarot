using MongoDB.Driver;
using System.Linq;
using System.Collections.Generic;
using cSharpTarot.Models;

namespace cSharpTarot.Services
{
    public class TarotService
    {
        private readonly IMongoCollection<Appointment> _appointments;
        public TarotService(ITarotDbSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _appointments = database.GetCollection<Appointment>(settings.TarotCollectionName);
        }
        public List<Appointment> Get() => _appointments.Find(apt => true).ToList();
        public Appointment Get(string Id) => _appointments.Find<Appointment>(apt => apt.Id == Id).FirstOrDefault();
        public Appointment Create(Appointment appointment)
        {
            _appointments.InsertOne(appointment);
            return appointment;
        }
        public void Update(string Id, Appointment Appt) => _appointments.ReplaceOne(apt => apt.Id == Id, Appt);
        public void Remove(Appointment Appt) => _appointments.DeleteOne(apt => apt.Id == Appt.Id);
        public void Remove(string Id) => _appointments.DeleteOne(apt => apt.Id == Id);
    }
}