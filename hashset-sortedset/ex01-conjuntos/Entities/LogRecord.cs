﻿namespace ex01_conjuntos.Entities
{
    internal class LogRecord
    {
        public string Username { get; set; }
        public DateTime Instant { get; set; }

        public LogRecord(string username, DateTime instant)
        {
            Username = username;
            Instant = instant;
        }

        public override int GetHashCode()
        {
            return Username.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (!(obj is LogRecord)) 
                return false;

            LogRecord other = (LogRecord)obj;
            return Username.Equals(other.Username);
        }
    }
}
