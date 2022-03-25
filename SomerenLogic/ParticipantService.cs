using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class ParticipantService
    {
        ParticipantDao participantdb;

        public ParticipantService()
        {
            participantdb = new ParticipantDao();
        }

        public List<Participant> GetParticipants()
        {
            List<Participant> participants = participantdb.GetAllParticipants();
            return participants;
        }

        public void AddParticipant(Participant participant)
        {
            participantdb.Add(participant);
        }

        public void DeleteParticipant(Participant participant)
        {
            participantdb.Delete(participant);
        }

    }
}
