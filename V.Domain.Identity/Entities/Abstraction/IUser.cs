using System;
using System.Collections.Generic;
using System.Text;
using V.Domain.Base.Entities.Abstraction;

namespace V.Domain.Identity.Entities.Abstraction
{
    public interface IUser<TKey> : IEntity<TKey>
    {
        string UserName { get; set; }
        string Email { get; set; }
        string PasswordHash { get; set; }
        string PhoneNumber { get; set; }
        bool PhoneNumberConfirmed { get; set; }
        bool TwoFactorEnabled { get; set; }
    }
}
