using System;
using System.Collections.Generic;
using System.Text;

namespace V.Domain.Identity.Entities.Abstraction
{
    public interface IUserLockout
    {
        DateTimeOffset? LockoutEnd { get; set; }
        bool LockoutEnabled { get; set; }
        int AccessFailedCount { get; set; }
    }
}
