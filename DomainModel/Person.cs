﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainModel
{
    [Table("People")]
    public class Person : IdentityUser
    {
        public string Adress { get; set; }

    }
}
