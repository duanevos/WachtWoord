﻿namespace WachtWoord.Models
{
    public class History
    {
        public int Id { get; set; }
        public string Password { get; set; }
        public DateTime DateChanged { get; set; }
        public Entry entry { get; set; }
    }
}
