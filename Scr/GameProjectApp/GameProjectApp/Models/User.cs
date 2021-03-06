﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameProjectApp.Models
{
    public class User
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Guid InGameId { get; set; }
        public bool NewGameContent { get; set; }

        public User(string id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}