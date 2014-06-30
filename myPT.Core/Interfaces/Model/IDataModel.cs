using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Interfaces.Model
{
    interface IDataModel
    {
        List<IProgram> Programs { get; set; }
        List<ISession> Sessions { get; set; }
        List<IHistoryItem> History { get; set; }

        IHistoryItem GetHistoryItem(string id);
        ISession GetSession(string id);
        IProgram GetProgram(string id);
        IExercise GetExercise(bool isSession, string parentID, string ExerciseID);

        void SaveAll();
        void LoadAll();
    }
}
