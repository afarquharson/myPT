using myPT.Core.Common;
using myPT.Core.Implementation;
using myPT.Core.Implementation.View;
using myPT.Core.Interfaces.Model;
using myPT.Core.Interfaces.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using myPT.Core.Interfaces;

namespace myPT.ConsoleSkin
{
    public class MainProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------ myPT -----");

            var myProxy = new DummyProxy();
            var myModel = new myPT.Core.Implementation.Model.DataModel(myProxy);
            var myNav = new myPT.Core.Implementation.Navigator();

            PrintAll(myProxy, myModel, myNav);

            Console.Read(); //pause
        }

        static void PrintAll(IProxy proxy, IDataModel model, INavigator nav)
        {
            //Home view
            var myNavData = new NavigationData()
            {
                ToScreen = Command.Home,
                Model = model
            };
            PrintScreen(nav.Navigate(myNavData));

            //Program view
            myNavData.ToScreen = Command.ProgramUpdate;
            myNavData.ToItem = proxy.Programs.First().Key;
            PrintScreen(nav.Navigate(myNavData));

            myNavData.ToScreen = Command.ProgramCreate;
            myNavData.ToItem = proxy.Programs.First().Key;
            PrintScreen(nav.Navigate(myNavData));

            //Session view
            myNavData.ToScreen = Command.SessionReadOnly;
            myNavData.ToItem = proxy.Sessions.First().Key;
            PrintScreen(nav.Navigate(myNavData));

            myNavData.ToScreen = Command.SessionCreate;
            myNavData.ToItem = proxy.Sessions.First().Key;
            PrintScreen(nav.Navigate(myNavData));

            //Exercise view
            myNavData.ToScreen = Command.ExerciseUpdate;
            myNavData.ToItem = "4";
            myNavData.FromItem = proxy.Programs.First().Key;
            PrintScreen(nav.Navigate(myNavData));

            myNavData.ToScreen = Command.ExerciseCreate;
            myNavData.ToItem = "4";
            myNavData.FromItem = proxy.Programs.First().Key;
            PrintScreen(nav.Navigate(myNavData));

            //Activity view
            myNavData.ToScreen = Command.ActivityReadOnly;
            myNavData.ToItem = proxy.Sessions.First().Value.Activities.First().Value.GUID;
            myNavData.FromItem = proxy.Sessions.First().Value.GUID;
            PrintScreen(nav.Navigate(myNavData));

            myNavData.ToScreen = Command.ActivityUpdate;
            myNavData.ToItem = proxy.Sessions.First().Value.Activities.First().Value.GUID;
            myNavData.FromItem = proxy.Sessions.First().Value.GUID;
            PrintScreen(nav.Navigate(myNavData));

            //Note view
            myNavData.ToScreen = Command.Note;
            myNavData.ToItem = "1";
            myNavData.FromItem = String.Empty;
            PrintScreen(nav.Navigate(myNavData));

            //Timeline view
            myNavData.ToScreen = Command.Timeline;
            myNavData.ToItem = String.Empty;
            myNavData.FromItem = String.Empty;
            PrintScreen(nav.Navigate(myNavData));
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
            result.Add(String.Format("{0}\t\t{1}:{2}\t{3}",view.State.Commands[CommandKey.TopLeft].ToString(), view.GetType().Name, view.State.StateValue.ToString(), view.State.Commands[CommandKey.TopRight].ToString()));
            result.Add("--------------------------------------------------------------");
            //Add List content
            int count = 0;
            foreach (var i in view.List)
            {
                result.Add(String.Format("{0}: {1} \t[{2}]",i.Key,i.Value, count++));
            }
            result.Add("--------------------------------------------------------------");
            //Add bottom buttons
            result.Add(String.Format("{0}\t\t\t\t\t{1}", view.State.Commands[CommandKey.LowerLeft].ToString(), view.State.Commands[CommandKey.LowerRight].ToString()));
            result.Add("==============================================================");
            return result;
        }
    }
}
