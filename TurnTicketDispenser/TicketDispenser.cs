namespace TDDMicroExercises.TurnTicketDispenser
{
    public class TicketDispenser
    {
        ITurnNumberSequence turnNumberSequence;

        public TicketDispenser() : this(TurnNumberSequence.GlobalTurnNumberSequence)
        {

        }

        public TicketDispenser(ITurnNumberSequence turnNumberSequence)
        {
            this.turnNumberSequence = turnNumberSequence;
        }

        public TurnTicket GetTurnTicket()
        {
            int newTurnNumber = turnNumberSequence.GetNextTurnNumber();

            var newTurnTicket = new TurnTicket(newTurnNumber);

            return newTurnTicket;
        }





    }
}
