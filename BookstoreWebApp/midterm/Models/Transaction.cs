﻿using System;
using System.Collections.Generic;

namespace midterm.Models
{
    public partial class Transaction
    {
        public int TransactionId { get; set; }
        public int BookId { get; set; }
        public int CustomerId { get; set; }
        public DateTime CheckedOutDate { get; set; }
        public DateTime DueDate { get; set; }
        public string CheckedIn { get; set; } = null!;

        public virtual Book Book { get; set; } = null!;
        public virtual Customer Customer { get; set; } = null!;
    }
}
