using myPT.Core.Common;
using myPT.Core.Implementation.View;
using myPT.Core.Interfaces.Model;
using myPT.Core.Interfaces.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.ConsoleSkin
{
    public class MainProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------ myPT -----");

            var myProxy = new DummyProxy();
            var myModel = new myPT.Core.Implementation.Model.DataModel(myProxy);

            //Home view
            var myHomeView = new myPT.Core.Implementation.View.HomeView();
            var myNavData = new NavigationData()
            {
                Key = NavigateKey.ToHome,
                Model = myModel
            };
            myHomeView.Load(myNavData);
            PrintScreen(myHomeView);

            //Program view
            var myProgramView = new ProgramView();
            myNavData.Key = NavigateKey.ToProgramUpdate;
            myNavData.ToItem = myProxy.Programs.First().Key;
            myProgramView.Load(myNavData);
            PrintScreen(myProgramView);

            myProgramView = new ProgramView();
            myNavData.Key = NavigateKey.ToProgramCreate;
            myNavData.ToItem = myProxy.Programs.First().Key;
            myProgramView.Load(myNavData);
            PrintScreen(myProgramView);

            //Session view
            var mySessionView = new SessionView();
            myNavData.Key = NavigateKey.ToSessionReadOnly;
            myNavData.ToItem = myProxy.Sessions.First().Key;
            mySessionView.Load(myNavData);
            PrintScreen(mySessionView);

            mySessionView = new SessionView();
            myNavData.Key = NavigateKey.ToSessionCreate;
            myNavData.ToItem = myProxy.Sessions.First().Key;
            mySessionView.Load(myNavData);
            PrintScreen(mySessionView);

            //Exercise view
            var myExerciseView = new ExerciseView();
            myNavData.Key = NavigateKey.ToExerciseUpdate;
            myNavData.ToItem = "4";
            myNavData.FromItem = myProxy.Programs.First().Key;
            myExerciseView.Load(myNavData);
            PrintScreen(myExerciseView);

            myExerciseView = new ExerciseView();
            myNavData.Key = NavigateKey.ToExerciseCreate;
            myNavData.ToItem = "4";
            myNavData.FromItem = myProxy.Programs.First().Key;
            myExerciseView.Load(myNavData);
            PrintScreen(myExerciseView);

            //Activity view
            var myActivityView = new ActivityView();
            myNavData.Key = NavigateKey.ToActivityReadOnly;
            myNavData.ToItem = myProxy.Sessions.First().Value.Activities.First().Value.GUID;
            myNavData.FromItem = myProxy.Sessions.First().Value.GUID;
            myActivityView.Load(myNavData);
            PrintScreen(myActivityView);

            myActivityView = new ActivityView();
            myNavData.Key = NavigateKey.ToActivityUpdate;
            myNavData.ToItem = myProxy.Sessions.First().Value.Activities.First().Value.GUID;
            myNavData.FromItem = myProxy.Sessions.First().Value.GUID;
            myActivityView.Load(myNavData);
            PrintScreen(myActivityView);

            //Note view
            var myNoteView = new NoteView();
            myNavData.Key = NavigateKey.ToNote;
            myNavData.ToItem = "1";
            myNavData.FromItem = String.Empty;
            myNoteView.Load(myNavData);
            PrintScreen(myNoteView);

            //Timeline view
            var myTimelineView = new TimelineView();
            myNavData.Key = NavigateKey.ToTimeline;
            myNavData.ToItem = String.Empty;
            myNavData.FromItem = String.Empty;
            myTimelineView.Load(myNavData);
            PrintScreen(myTimelineView);

            Console.Read(); //pause
        }

        static void PrintAll(IView view, IProxy proxy, IDataModel model)
        {

        }

        static void PrintScreen(IView view)
        {
            Console.WriteLine();
            foreach (var l in RenderScreen(view))
            {
                Console.WriteLine(l);
            }
            Console.WriteLine();
        }

        static List<string> RenderScreen(IView view)
        {
            var result = new List<string>();
            //Add top buttons and screen title
            result.Add("==============================================================");
            result.Add(String.Format("{0}  \t\t{1}:{2} \t{3}",view.State.TopLeft, view.GetType().Name, view.State.StateValue.ToString(), view.State.TopRight));
            result.Add("--------------------------------------------------------------");
            //Add List content
            foreach (var i in view.List)
            {
                result.Add(String.Format("{0}: {1}",i.Key,i.Value));
            }
            result.Add("--------------------------------------------------------------");
            //Add bottom buttons
            result.Add(String.Format("{0}   \t\t\t       {1}", view.State.LowerLeft, view.State.LowerRight));
            result.Add("==============================================================");
            return result;
        }
    }
}
