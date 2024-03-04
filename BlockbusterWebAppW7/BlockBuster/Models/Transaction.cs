﻿using System;
using System.Collections.Generic;

namespace BlockBuster.Models
{
    public partial class Transaction
    {
        public int TransactionId { get; set; }
        public int MovieId { get; set; }
        public int CustomerId { get; set; }
        public DateTime CheckedOutDate { get; set; }
        public DateTime DueDate { get; set; }
        public string CheckedIn { get; set; } = null!;

        public virtual Customer Customer { get; set; } = null!;
        public virtual Movie Movie { get; set; } = null!;
    }
}
