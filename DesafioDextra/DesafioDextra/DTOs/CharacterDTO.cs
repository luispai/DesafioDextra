﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioDextra.DTOs
{
    public class CharacterDTO
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}
