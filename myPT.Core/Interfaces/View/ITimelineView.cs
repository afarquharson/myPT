﻿using myPT.Core.Interfaces.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myPT.Core.Interfaces.View
{
    interface ITimelineView
    {
        List<IHistoryItem> History { get; set; }

        event EventHandler BackClicked;
        event EventHandler ItemSelected;
        event EventHandler AddClicked;
    }
}
