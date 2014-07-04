using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Common
{
    public enum Command
    {
        ActivityReadOnly,
        ActivityUpdate,
        ProgramCreate,
        ProgramUpdate,
        ExerciseCreate,
        ExerciseUpdate,
        SessionCreate,
        SessionReadOnly,
        Timeline,
        Note,
        Home,
        None,
        PreviousActivity, //This and below are 'self' navigations.
        NextActivity,
        AddSet,
        AddField,
        About,
        DeleteNote,
        AddExercise,
        CloneProgram,
        ViewHistoryItem,
        QuitSession
    }
}
