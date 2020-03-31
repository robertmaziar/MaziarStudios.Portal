using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaziarStudios.Portal.Web.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string ClientId { get; set; }
        public ApplicationUser Client { get; set; }
        public string Title { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public virtual ICollection<EventArtist> EventArtists { get; set; }
    }
}
