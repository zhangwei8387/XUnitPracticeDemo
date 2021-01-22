using System;
using System.Collections.Generic;
using Xunit;
using Xunit.Abstractions;

namespace XUnitPracticeDemo.Test
{
    [Collection("Long Time Task Collection")]
    public class PatientShould : IDisposable
    {
        private readonly ITestOutputHelper output;
        private readonly LongTimeTaskFixture fixture;
        private readonly Patient _patient;
        private readonly LongTimeTask longTimeTask;

        public PatientShould(ITestOutputHelper output, LongTimeTaskFixture fixture)
        {
            this.output = output;
            this.fixture = fixture;
            output.WriteLine("正在创建新的Patient！");
            _patient = new Patient();
            longTimeTask = fixture.Task;
        }

        [Fact]
        [Trait("Category","New")]
        public void HaveHeartBeatWhenNew()
        {
            //var patient = new Patient();

            Assert.True(_patient.IsNew);
        }
        [Fact]
        [Trait("Category", "Name")]
        public void HaveCorrectFullName()
        {


            _patient.FirstName = "Nick";
            _patient.LastName = "Carter";
            

            var fullName = _patient.FullName;

            Assert.Equal("Nick Carter", fullName);
            Assert.StartsWith("Nick", fullName);
            Assert.EndsWith("Carter", fullName);
            Assert.Contains("ck Car", fullName);
            Assert.NotEqual("NICK CARTER", fullName);
            Assert.Matches(@"^[A-Z][a-z]*\s[A-Z][a-z]*", fullName);


        }
        [Fact]
        public void HaveDefaultBloodSugarWhenCreated()
        {
            var p = _patient;
            var bloodsugar = p.BloodSugar;
            Assert.Equal(5.0f, bloodsugar);
            Assert.InRange(bloodsugar, 3.9f, 6.1f);
        }
        [Fact]
        public void NotHaveNameByDefault()
        {
            var p = _patient;
            Assert.Null(p.FirstName);
            Assert.NotNull(p.FullName);
        }

        [Fact]
        public void HaveNameValue()
        {
            var p = new Patient()
            {
                LastName = "Brian",
                FirstName ="Neo"
            };
            Assert.NotNull(p.FullName);
        }
        [Fact]
        public void HaveHadAColdBefore()
        {
            var p = _patient;
            output.WriteLine("这里是一个log!!!");

            Assert.Contains("感冒", p.History);
            // Predicate 基于什么特点
            Assert.Contains(p.History, x => x.StartsWith("水"));

            Assert.DoesNotContain("心脏病", p.History);
          
            Assert.All(p.History, x => Assert.True(x.Length >= 2));

           

        }
        [Fact]
        public void BeAPerson()
        {
            var patient = _patient;
          //  var patient2 = new Patient();
            var patient2 = patient;

            Assert.IsType<Patient>(patient);
            Assert.IsNotType<string>(patient);

            Assert.IsAssignableFrom<Person>(patient);
             Assert.Same(patient2, patient);
           // Assert.NotSame(patient2, patient);
        }

        [Fact]
        public void  HaveExceptionWhenCalledWithoutName()
        {
            var p = _patient;

            //   p.BeCalled(null);

            ArgumentNullException ex = Assert.Throws<ArgumentNullException>(() => p.BeCalled(null));

            Assert.Equal("name", ex.ParamName);
        }

        [Fact(Skip ="这是一个无用的测试！")]
        public void NoUserdTest()
        {

        }

        public void Dispose()
        {
            output.WriteLine("Execute dispose!");
        }
    }
}
