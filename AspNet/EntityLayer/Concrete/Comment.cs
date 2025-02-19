﻿using System;

namespace EntityLayer.Concrete
{
    public class Comment
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; }

        public int Score { get; set; }

    }
}
