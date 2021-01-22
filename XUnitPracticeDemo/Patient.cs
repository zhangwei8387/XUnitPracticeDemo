using System;
using System.Collections.Generic;

namespace XUnitPracticeDemo
{
    public class Patient: Person
    {
        public Patient()
        {
            IsNew = true;
            bloodSugar = 5.0f;
            history = new List<string>() {
                "感冒",
                "发烧",
                "水痘",
                "腹泻"
            };
        }

        public string FullName => $"{FirstName} {LastName}";
        public int HeartBeatRate { get; set; }
        public bool IsNew { get; set; }

        private float bloodSugar;
        private List<string> history;

        public float BloodSugar { get => bloodSugar; set => bloodSugar = value; }

        public List<string> History { get => history; set => history = value; }

        public void IncreaseHeartBeatRate()
        {
            HeartBeatRate = CalculateHeartBeatRate() + 2;
        }

        private int CalculateHeartBeatRate()
        {
            var random = new Random();
            return random.Next(1, 100);
        }

        public void BeCalled(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException(nameof(name));
            Console.WriteLine($"{name} was be called.");
        }
    }
}