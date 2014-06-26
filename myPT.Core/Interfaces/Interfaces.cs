using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Interfaces
{
    public class Interfaces
    {
        interface IMainView
        {
            List<IProgram> Programs { get; set; }

            event EventHandler SettingsClicked;
            event EventHandler AddProgramClicked;
            event EventHandler TimelineClicked;
            event EventHandler ItemSelected;
        }

        interface ITimelineView
        {
            List<IHistoryItem> History { get; set; }

            event EventHandler BackClicked;
            event EventHandler ItemSelected;
            event EventHandler AddClicked;
        }

        interface IChildScreen
        {
            event EventHandler BackClicked;
        }

        interface IProgramView : IChildScreen
        {
            IProgram Program { get; set; }
        }

        interface IProgramUpdateView : IProgramView
        {
            event EventHandler AddSetClicked;
            event EventHandler AddExerciseClicked;
        }

        interface IProgramReadView : IProgramView
        {
            event EventHandler CloneClicked;
            event EventHandler StartSessionClicked;
        }

        interface IExerciseView : IChildScreen
        {
            IExercise Exercise { get; set; }
        }

        interface IExerciseCreateView : IExerciseView
        {
            event EventHandler AddFieldClicked;
        }

        interface ISessionView : IChildScreen
        {
            ISession Session { get; set; }
        }

        interface ISessionCreateView : ISessionView
        {
            event EventHandler AchievementValueChanged;
            event EventHandler StartSessionClicked;
        }

        interface INoteView : IChildScreen
        {
            INote Note { get; set; }

            event EventHandler DeleteNoteClicked;
        }

        interface IProgram
        {
            String Name { get; set; }
            List<IExercise> Exercises { get; set; }
            Boolean CanEdit { get; set; }
        }

        interface IHistoryItem
        {
            String Id { get; set; }
            DateTime Date { get; set; }
            String Summary { get; set; }
        }

        interface INote : IHistoryItem { }

        interface ISession : IHistoryItem
        {
            String Id { get; set; }
            DateTime StartTime { get; set; }
            DateTime EndTime { get; set; }
            List<IActivity> Activities { get; set; }
        }

        interface IExercise
        {
            String Id { get; set; }
            Dictionary<String, object> Properties { get; set; }
        }

        interface IActivity : IExercise
        {
            String Id { get; set; }
            object Achievement { get; set; }
        }

        interface IDataModel
        {
            List<IProgram> GetPrograms();
            List<ISession> GetSessions();
            List<IHistoryItem> GetHistory();

            object GetItem(Type type, string id);
        }
    }
}
