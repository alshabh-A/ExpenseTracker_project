﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker.Models
{
    public static class Session
    {
        public static User CurrentUser { get; set; }
    }
}
