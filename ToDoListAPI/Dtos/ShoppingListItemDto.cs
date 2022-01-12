﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoListAPI.Dtos
{
    public class ShoppingListItemDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool Checked { get; set; }
    }
}
