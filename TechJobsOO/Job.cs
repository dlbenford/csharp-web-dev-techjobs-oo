using System;

namespace TechJobsOO
{
    public class Job
    {
        public int Id { get; }
        private static int nextId = 1;
        public string Value { get; set; }

        public string Name { get; set; }
        public Employer EmployerName { get; set; }
        public Location EmployerLocation { get; set; }
        public PositionType JobType { get; set; }
        public CoreCompetency JobCoreCompetency { get; set; }

        // TODO: Add the two necessary constructors.
        //Code a constructor to initialize the id field with a unique value. This constructor should take no parameters.
        public Job()
        {
            Id = nextId;
            nextId++;

        }
        //Code a second constructor that takes 5 parameters and assigns values to name, employerName, employerLocation, jobType, and jobCoreCompetency. Also, this constructor should call the first in order to initialize the id field.
        public Job(string name, Employer employerName, Location employerLocation, PositionType jobType, CoreCompetency jobCoreCompetency) : this()

        {
            Name = name;
            EmployerName = employerName;
            EmployerLocation = employerLocation;
            JobType = jobType;
            JobCoreCompetency = jobCoreCompetency;
            
        }

        // TODO: Generate Equals() and GetHashCode() methods.
        public override bool Equals(object obj)
        {
            return obj is Job job &&
                   Id == job.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            string Dna = "Data Not Available";
            if (Name == "")
            {
                Name = Dna;
            };

            if (EmployerName.Value == "")
            {
                EmployerName.Value = Dna;
            };

            if (EmployerLocation.Value == "")
            {
                EmployerLocation.Value = Dna;
            };

            if (JobType.Value == "")
            {
                JobType.Value =  Dna;
            };

            if (JobCoreCompetency.Value == "")
            {
                JobCoreCompetency.Value = Dna;
            }


                return
                    $"\n" +
                    $"ID: {Id}\n" +
                    $"Name: {Name}\n" +
                    $"Employer: {EmployerName.Value}\n" +
                    $"Location: {EmployerLocation.Value}\n" +
                    $"Position Type: {JobType.Value}\n" +
                    $"Core Competency: {JobCoreCompetency}\n";
           
        }
    }
}
