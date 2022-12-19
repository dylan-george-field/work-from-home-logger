﻿using System;

namespace wfh_log_wpf.Models
{
    public class LogEntry
    {
        public DateTime Time { get; set; } = DateTime.Now.ToLocalTime();
        public string ConnectedNetwork { get; set; }
        public bool IsWorkingFromHome { get; set; } = false;

        public LogEntry(bool isWorkingFromHome, string connectedNetwork)
        {
            IsWorkingFromHome = isWorkingFromHome;
            ConnectedNetwork = connectedNetwork;
        }

        public override string ToString()
        {
            var text = IsWorkingFromHome ? "You were working from home ✔" : "You were not working from home ❌";

            return Time.ToLongDateString() + ": " + text;
        }
    }
}
