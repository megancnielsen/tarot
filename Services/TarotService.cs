using MongoDB.Driver;
using System.Linq;
using System.Collections.Generic;
using cSharpTarot.Models;

namespace cSharpTarot.Services
{
    public class TarotService
    {
        private readonly IMongoCollection<Appointment> Appointments;
        public TarotService(ITarotDbSettings settings)
        {
            MongoClient Client = new MongoClient(settings.ConnectionString);
            IMongoDatabase Database = Client.GetDatabase(settings.DatabaseName);
            Appointments = Database.GetCollection<Appointment>(settings.TarotCollectionName);
        }
        public List<Appointment> Get() => Appointments.Find(apt => true).ToList();
        public Appointment Get(string Id) => Appointments.Find<Appointment>(apt => apt.Id == Id).FirstOrDefault();
        public Appointment Create(Appointment Appointment)
        {
            Appointments.InsertOne(Appointment);
            return Appointment;
        }
        public void Update(string Id, Appointment Appt) => Appointments.ReplaceOne(apt => apt.Id == Id, Appt);
        public void Remove(Appointment Appt) => Appointments.DeleteOne(apt => apt.Id == Appt.Id);
        public void Remove(string Id) => Appointments.DeleteOne(apt => apt.Id == Id);
    }
}