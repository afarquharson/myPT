using myPT.Core.Common;
using myPT.Core.Implementation.Model;
using myPT.Core.Interfaces.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.ConsoleSkin
{
    public class DummyProxy : IProxy
    {
        private Program _program;
        private Exercise _exercise;
        private HistoryItem _item;
        private Session _session;
        private SessionFactory _sessionFactory;

        private GUIDMaker _maker;

        public DummyProxy()
        {
            _maker = new GUIDMaker();
            _sessionFactory = new SessionFactory();

            _item = new HistoryItem();
                _item.GUID = _maker.GetGUID();
                _item.Summary = "A new Note for today";
                _item.Date = DateTime.Today.Date;

            _exercise = new Exercise()
            {
                GUID = _maker.GetGUID(),
                Detail = new Dictionary<ExerciseFieldKey, string>
                {
                    {ExerciseFieldKey.Description, "My Exercise"},
                    {ExerciseFieldKey.MaxReps, "2"}
                }
            };

            _program = new Program()
            {
                Name = "My Program",
                GUID = _maker.GetGUID(),
                Exercises = new ExerciseTreeItem()
            };
            _program.Exercises.Reps = 2;
            _program.Exercises.Children = new List<ExerciseTreeItem>
            {
                new ExerciseTreeItem()
                {
                    Reps = 2,
                    Exercises = new Dictionary<string,IExercise>()
                    {
                        {_maker.GetGUID(), _exercise},
                        {_maker.GetGUID(), _exercise}
                    }
                },
                new ExerciseTreeItem()
                {
                    Reps = 1,
                    Exercises = new Dictionary<string,IExercise>()
                    {
                        {_maker.GetGUID(), _exercise}
                    }
                }
            };
                
            _session = (Session)_sessionFactory.GetSession(_program);
        }

        public Dictionary<string, IProgram> Programs
        {
            get
            {
                return new Dictionary<string, IProgram>
                {
                    {_program.GUID, _program}
                };
            }
            set
            {
                
            }
        }

        public Dictionary<string, ISession> Sessions
        {
            get
            {
                return new Dictionary<string, ISession>
                {
                    {_session.GUID, _session}
                };
            }
            set
            {
                
            }
        }

        public Dictionary<string, IHistoryItem> History
        {
            get
            {
                return new Dictionary<string, IHistoryItem>
                {
                    {_item.GUID, _item}
                };
            }
            set
            {
                
            }
        }
    }
}
