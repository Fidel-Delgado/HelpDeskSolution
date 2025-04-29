using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoporteTI.Domain.Enums
{
    public enum StatusTicket
    {
        New = 1,
        InProgress = 2,
        Resolved = 3,
        Closed = 4,
        Pending = 5,
        Reopened = 6
    }
}
