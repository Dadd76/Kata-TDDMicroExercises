using System;
using System.Collections.Generic;
using System.Text;

namespace TDDMicroExercises.TurnTicketDispenser
{
    public interface ITurnNumberSequence
    {
        int GetNextTurnNumber();
    }
}
