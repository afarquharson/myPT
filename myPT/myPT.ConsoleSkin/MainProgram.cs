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
using myPT.Core.Implementation.Model;

namespace myPT.ConsoleSkin
{
    public class MainProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------ myPT -----");

            var myNavCommands = new Dictionary<string, CommandKey>
            {
                {"tl", CommandKey.TopLeft},
                {"tr", CommandKey.TopRight},
                {"ll", CommandKey.LowerLeft},
                {"lr", CommandKey.LowerRight},
            };

            var myProxy = new DummyProxy();
            var myModel = new DataModel(myProxy);
            var myNav = new Navigator();
            var myNavData = new NavigationData()
            {
                ToScreen = Command.Home,
                Model = myModel
            };
            IView myView = null;
            myView = myNav.Navigate(myNavData);
            PrintScreen(myView);
            string line = null;
            Console.WriteLine("Enter tl, tr, ll, lr or a [x] number to naviagte, CTRL+Z to exit:");
            do 
            {
                line = Console.ReadLine();
                long lineNumber;
                try
                {
                    lineNumber = Convert.ToInt64(line);
                    //Get the GUID of the selected item
                    var guid = myView.List.ToArray()[lineNumber].Key;
                    myNavData = myView.Execute(CommandKey.ItemSelect, new[] { guid });
                }
                catch 
                {
                    myNavData = myView.Execute(myNavCommands[line], new[] { String.Empty });
                }
                
                myView = myNav.Navigate(myNavData);
                PrintScreen(myView);
            } while (line != null);

            Console.Read(); //pause
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
            var GuidPad = "                                    ";
            var result = new List<string>();
            //Add top buttons and screen title
            result.Add("==============================================================");
            result.Add(String.Format("{0}[tl]\t\t{1}:{2}\t{3}[tr]",view.State.Commands[CommandKey.TopLeft].ToString(), view.GetType().Name, view.State.StateValue.ToString(), view.State.Commands[CommandKey.TopRight].ToString()));
            result.Add("--------------------------------------------------------------");
            //Add List content
            int count = 0;
            foreach (var i in view.List)
            {
                var index = view.State.Commands[CommandKey.ItemSelect] != Command.None ? count.ToString() : String.Empty;
                result.Add(String.Format("{0}: {1} \t[{2}]",i.Key.Length < 2 ? GuidPad : i.Key,i.Value,i.Key.Length < 2 ? String.Empty : index));
                count++;
            }
            result.Add("--------------------------------------------------------------");
            //Add bottom buttons
            result.Add(String.Format("{0}[ll]\t\t\t\t\t{1}[lr]", view.State.Commands[CommandKey.LowerLeft].ToString(), view.State.Commands[CommandKey.LowerRight].ToString()));
            result.Add("==============================================================");
            return result;
        }
    }
}
