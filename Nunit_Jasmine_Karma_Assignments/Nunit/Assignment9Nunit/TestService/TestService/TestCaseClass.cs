using NUnit.Framework;
using Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using static Service.MethodClass;

namespace TestService
{
    [TestFixture]
    public class TestCaseClass
    {
        private MethodClass _service;
        [SetUp]
        public void Setup()
        {
            _service = new MethodClass();
        }

        // Test Case 1
       [Test]
       public void CheckDataListAge()
        {
            var result = _service.GetUserData();
            Assert.That(result, Has
                .Count.EqualTo(6)
                .And.Exactly(6).Property("Age").GreaterThan(20)
                );
        }




        // Test CAse 2
        [Test]
        public void Check_Name_In_DataList()
        {
            var result = _service.GetUserData();
            Assert.That(result, Has
                .Some.Property("Name").EqualTo("Tony Stark"));        
        }


        // Test Case 3
        [Test]
        public void Check_Address()
        {
            var result = _service.GetUserData();
            Assert.That(result, Has
                .Count.EqualTo(6)
                .And.No.Some.Property("Address").EqualTo("India"));
        }
       

        // Test Case 4
        [Test]
        public void Equal_Vs_Equivalent()
        {
            var a = new List<int> { 1, 3, 5 };
            var b = new List<int> { 5, 3, 1 };
            Assert.That(a, Is.Not.EqualTo(b));
            Assert.That(b, Is.EquivalentTo(a));
        
        }

        // Test Case 5
        [Test]
        [Obsolete]
        public void Mapping_In_List()
        {
            Assert.That(List.Map(new List<string>() { "1", "22", "333" }).Property("Length"), Is.EqualTo(new List<int>() { 1, 2, 3 }));
            
        }




        [TearDown]
        public void CleanUpAfterTest()
        {
            //REngineExecutionContext.ClearLog();
        }

        [OrderedTest(0)]
        public void Test1() { }

        [OrderedTest(1)]
        public void Test2() { }

        [OrderedTest(2)]
        public void Test3() { }

        [TestCaseSource(sourceName: "TestSource")]
        public void MainTest(TestStructure test)
        {
            test.Test();
        }

        public static IEnumerable<TestCaseData> TestSource
        {
            get
            {
                var assembly = Assembly.GetExecutingAssembly();
                Dictionary<int, List<MethodInfo>> methods = assembly
                    .GetTypes()
                    .SelectMany(x => x.GetMethods())
                    .Where(y => y.GetCustomAttributes().OfType<OrderedTestAttribute>().Any())
                    .GroupBy(z => z.GetCustomAttribute<OrderedTestAttribute>().Order)
                    .ToDictionary(gdc => gdc.Key, gdc => gdc.ToList());

                foreach (var order in methods.Keys.OrderBy(x => x))
                {
                    foreach (var methodInfo in methods[order])
                    {
                        MethodInfo info = methodInfo;
                        yield return new TestCaseData(
                            new TestStructure
                            {
                                Test = () =>
                                {
                                    object classInstance = Activator.CreateInstance(info.DeclaringType, null);
                                    info.Invoke(classInstance, null);
                                }
                            }).SetName(methodInfo.Name);
                    }
                }
            }
        }

        [Test]
        public void CustomConstraint_Lower()
        {
            string value = "tony";

            Assert.That(value, Is.IsLower(value));
        }


        
        
    }



}
