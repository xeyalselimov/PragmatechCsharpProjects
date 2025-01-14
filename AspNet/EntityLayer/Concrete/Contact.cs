﻿using System;

namespace EntityLayer.Concrete
{
    public class Contact
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; }
    }
}
