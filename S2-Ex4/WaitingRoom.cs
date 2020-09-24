using System;
using System.Threading;

namespace S2_Ex4
{
    public class WaitingRoom
    {
        public Action<int> NumberChange;    
        private int currentNumber;
        private int ticketCount;

        public WaitingRoom()
        {
            this.currentNumber = 0;
            this.ticketCount = 0;
        }

        public void RunWaitingRoom()
        {
            while (currentNumber < ticketCount)
            {
                NumberChange?.Invoke(currentNumber);
                currentNumber++;
            }
            Console.Out.WriteLine("Patient number " + currentNumber + " can now enter");
            Thread.Sleep(1500);
        }

        public int DrawNumber()
        {
            ticketCount++;
            return ticketCount;
        }
    }
}