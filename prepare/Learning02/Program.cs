using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
    }
    public class Job
    {
        public string _company;
        public string _jobTitle;
        public int _startYear;
        public int _endYear;

        public void Display()
        {
            Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
        }
    }
    public class Resume
    {
        public string _name;
        public List<Job> _jobs = new List<Job>();

        public Resume()
        {
            _jobs.Add(new Job { _jobTitle = "Dishwasher", _company = "Cubby's Pizza", _startYear = 2022, _endYear = 2023 });
            _jobs.Add(new Job { _jobTitle = "Baker", _company = "Crumbl", _startYear = 2023, _endYear = 2023 });
            _jobs.Add(new Job { _jobTitle = "Physical Therapy Aide", _company = "BSMART", _startYear = 2025, _endYear = 2025  });
            _jobs.Add(new Job { _jobTitle = "Dishwasher", _company = "University Food Services", _startYear = 2025, _endYear = 2027});
        }
        public void Display()
        {
            Console.WriteLine($"Name: {_name}");
            Console.WriteLine("Jobs:");

            foreach (Job job in _jobs)
            {
                job.Display();
            }
        }
    }
        

    
}   
