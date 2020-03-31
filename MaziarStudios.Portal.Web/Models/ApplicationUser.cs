using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaziarStudios.Portal.Web.Models
{
    public class ApplicationUser : IdentityUser
    {
        public virtual ICollection<EventArtist> EventArtists { get; set; }
    }
}
