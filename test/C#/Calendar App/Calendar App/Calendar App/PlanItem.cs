using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar_App
{
    public class PlanItem
    {
        private DateTime date;

        public DateTime Date { get => date; set => date = value; }

        private string job;

        public string Job { get => job; set => job = value; }

        private Point FromTime;

        public Point FromTime1 { get => FromTime; set => FromTime = value; }
        
        private Point ToTime;

        public Point ToTime1 { get => ToTime; set => ToTime = value; }

        private string Status;

        public string Status1 { get => Status; set => Status = value; }

        public static List<string> ListStatus = new List<string> { "DONE", "DOING", "COMING", "MISSED" };
        
    }

    public enum EPlanItem
    {
        DONE,
        DOING,
        COMING,
        MISSED
    }

}
