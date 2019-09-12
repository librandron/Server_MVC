using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Server_MVC.ViewModel
{
    public class PartyParticipantsViewModel
    {
        public List<string> Participants { get; set; }
        public string PartyName { get; set; }
        public int PartyId { get; set; }
    }
}