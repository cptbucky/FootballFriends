﻿using Jumpers.Data.Contracts;

namespace Jumpers.Data.Entities.Access
{
    public partial class User : IUser
    {
        public int? Id { get { return UserId; } }
    }
}