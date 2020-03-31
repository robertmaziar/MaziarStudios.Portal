using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaziarStudios.Portal.Web.Models
{
    public class EventArtist
    {
        public int EventId { get; set; }
        public Event Event { get; set; }
        public string ArtistId { get; set; }
        public ApplicationUser Artist { get; set; }
    }
}
