﻿using System;

namespace ProjectName.Core.Domain.Entities
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
    }
}