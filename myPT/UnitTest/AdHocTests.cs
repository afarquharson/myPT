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
    public class AdHocTests
    {
        List<IProgram> Programs;
        Writer _underTest;

        String pName = "TestProgramName";
        String pId = "ProgramId";
        String eId_Clone = "ExerciseId";
        String eId = "ExerciseId";
        String eDescription = "TestDescription";
        String eDescription_Clone = "TestDescription";

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
                                    Exercises = new List<IExercise> 
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

        [TestMethod]
        public void ExerciseEqualityTest()
        {
            Exercise a = new Exercise
            {
                Detail = new Dictionary<ExerciseFieldKey, string>
                {
                    {ExerciseFieldKey.Description, eDescription}
                },
                Id = eId
            };
            Exercise b = new Exercise
            {
                Detail = new Dictionary<ExerciseFieldKey, string>
                {
                    {ExerciseFieldKey.Description, eDescription_Clone}
                },
                Id = eId_Clone
            };
            Exercise c = new Exercise
            {
                Detail = new Dictionary<ExerciseFieldKey, string>
                {
                    {ExerciseFieldKey.Comment, "Comment"}
                },
                Id = "DifferentID"
            };
            Assert.IsTrue(a.Equals(b)); //clones are the same
            Assert.IsTrue(b.Equals(a)); //clones are the same - symmetrical 
            Assert.IsFalse(a.Equals(c)); //different exercise does not match clone a
            Assert.IsFalse(c.Equals(a)); //different exercise does not match clone b

            Exercise d = new Exercise
            {
                Detail = new Dictionary<ExerciseFieldKey, string>
                {
                    {ExerciseFieldKey.Achievement, "One"},
                    {ExerciseFieldKey.Description, "Two"},
                },
                Id = "dId"
            };
            Exercise e = new Exercise
            {
                Detail = new Dictionary<ExerciseFieldKey, string>
                {
                    {ExerciseFieldKey.Description, "Two"},
                    {ExerciseFieldKey.Achievement, "One"},
                },
                Id = "dId"
            };
            Exercise f = new Exercise
            {
                Detail = new Dictionary<ExerciseFieldKey, string>
                {
                    {ExerciseFieldKey.Description, "Two"},
                    {ExerciseFieldKey.Achievement, "One"},
                    {ExerciseFieldKey.Distance, "Three"},
                },
                Id = "dId"
            };
            Assert.IsFalse(d.Equals(e)); //Differently-sorted Dictionaries are different
            Assert.IsFalse(e.Equals(f)); //An extra element is difference
        }
    }
}
