namespace TDDMicroExercises.TurnTicketDispenser
{
    public  class TurnNumberSequence : ITurnNumberSequence
    {
        internal static readonly ITurnNumberSequence GlobalTurnNumberSequence = new TurnNumberSequence();

        private  int _turnNumber = 0;

        public  int GetNextTurnNumber()
        {
            return _turnNumber++;
        }
    }
}
