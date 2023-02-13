﻿using Microsoft.AspNetCore.Identity;

namespace ATSProServer.Domain.AppEntities.Identity
{
    public sealed class AppRole : IdentityRole<string>
    {
        public string Code { get; set; }
    }
}
