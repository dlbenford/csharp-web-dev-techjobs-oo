using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestSettingJobId()
        {
            Job job1 = new Job();
            Job job2 = new Job();

            Assert.AreNotEqual(job1, job2);
            Assert.AreEqual(job1.Id, 5);
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {

            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.AreEqual(job1.Id, 2);
            Assert.AreEqual(job1.Name, "Product tester");
            Assert.AreEqual(job1.EmployerName.Value, "ACME");
            Assert.AreEqual(job1.EmployerLocation.Value, "Desert");
            Assert.AreEqual(job1.JobType.Value, "Quality control");
            Assert.AreEqual(job1.JobCoreCompetency.Value, "Persistence");
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job job2 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.IsFalse(job1.Equals(job2));
        }

        [TestMethod]
        public void TooStringTest()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            string testString = job1.ToString();
            Assert.AreEqual($"\n" +
                $"ID: 7\n" +
                $"Name: Product tester\n" +
                $"Employer: ACME\n" +
                $"Location: Desert\n" +
                $"Position Type: Quality control\n" +
                $"Core Competency: Persistence\n", testString);
        }

        [TestMethod]
        public void DataNotAvailableTest()
        {
            Job job1 = new Job("Product tester", new Employer("ACME"), new Location("Data Not Available"), new PositionType("Quality control"), new CoreCompetency("Persistence"));

            string testString = job1.ToString();
            Assert.AreEqual(
                $"\n" +
                $"ID: 1\n" +
                $"Name: Product tester\n" +
                $"Employer: ACME\n" +
                $"Location: Data Not Available\n" +
                $"Position Type: Quality control\n" +
                $"Core Competency: Persistence\n", testString);
        }


    }
}
