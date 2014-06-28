using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using myPT.Core.Interfaces.Model;
using myPT.Core.Implementation.Model;
using myPT.Core.Common;
using System.Linq;

namespace UnitTest
{
    [TestClass]
    public class XMLWriterTest
    {
        List<IProgram> Programs;
        Writer _underTest;

        String pName = "TestProgramName";
        String pId = "ProgramId";
        String eId = "ExerciseId";
        String eDescription = "TestDescription";

        [TestInitialize]
        public void Setup()
        {
            Programs = new List<IProgram>
            {
                new Program 
                {
                    Name = pName,
                    Id = pId,
                    Exercises = new List<List<Set>>
                    {
                        new List<Set> 
                        {
                            { 
                                new Set 
                                {
                                    Activities = new List<IExercise> 
                                    {
                                        new Exercise 
                                        {
                                            Id = eId,
                                            Detail = new Dictionary<ExerciseFieldKey, string> 
                                            {
                                                {ExerciseFieldKey.Description, eDescription}
                                            }
                                        }
                                    },
                                    Reps = 2
                                }
                            }
                        }
                    }
                }
            };
        }

        [TestMethod]
        public void WriteReadProgramListTest()
        {
            _underTest = new Writer();

            _underTest.Write<List<IProgram>>("WriteReadProgramListTest", Programs);
            var result = _underTest.Read<List<IProgram>>("WriteReadProgramListTest");

            Assert.IsNotNull(result);
            Assert.AreEqual(result.Count, Programs.Count);
            Assert.AreEqual(result.First().Name, Programs.First().Name);
            //.. etc
        }
    }
}
