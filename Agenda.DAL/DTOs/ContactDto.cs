using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Agenda.Models;

namespace Agenda.DAL.DTOs
{
    public class ContactDto
    {
        public Guid Id { get; set; }
        public TypeContact TypeContact { get; set; }
        public string Contact { get; set; }
        public bool Favorite { get; set; }
    }
}
