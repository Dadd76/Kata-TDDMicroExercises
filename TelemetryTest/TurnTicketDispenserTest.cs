using System;
using NUnit.Framework;
using TDDMicroExercises.TurnTicketDispenser;

namespace TDDMicroExercisesUnitTest
{
    [TestFixture]
    public class TurnTicketDispenserTest
    {
        [Test]
        public void CheckThatTwoConsecutiveTicketFromTheSameTicketDispenserAreDifferent()
        {
            TicketDispenser tDispense = new TicketDispenser();
            TurnTicket tTicket =  tDispense.GetTurnTicket();
            TurnTicket tTicket2 = tDispense.GetTurnTicket();

            Assert.That(tTicket.TurnNumber < tTicket2.TurnNumber);
        }

        [Test]
        public void CheckThatTwoConsecutiveTicketFromTwoTicketDispenserAreDifferent()
        {
            TicketDispenser tDispense_1 = new TicketDispenser();
            TicketDispenser tDispense_2 = new TicketDispenser();


            TurnTicket tTicket = tDispense_1.GetTurnTicket();
            TurnTicket tTicket2 = tDispense_2.GetTurnTicket();

            Assert.That(tTicket.TurnNumber != tTicket2.TurnNumber);
        }


        public static class teststatic
        {
            static int nb = 0;

            public static void increment()
            {
                nb++;
            }

        }
    }
}
