﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioDextra.Entities
{
    public class Event
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public string CharacterId { get; set; }
    }
}
