using System;

namespace S2_Ex4
{
    public class Patient
    {
        private int numberInQueue;
        private WaitingRoom wr;
        private bool ok;

        public Patient(WaitingRoom wr)
        {
            ok = false;
            this.wr = wr;
            wr.NumberChange += ReactToNumber;
            this.numberInQueue = this.wr.DrawNumber();
            Console.Out.WriteLine("Patient " + numberInQueue + " enters waiting room");
        }

        public void ReactToNumber(int ticketNumber)
        {
            if (ok)
            {
                return;
            }
            Console.Out.WriteLine("Ding!");
            Console.Out.WriteLine("Patient " + numberInQueue + " looks up");
            if (numberInQueue == ticketNumber)
            {
                Console.Out.WriteLine("Patient " + numberInQueue + " goes to the doctor's office");
                ok = true;
            }
            else
                Console.Out.WriteLine("Patient " + numberInQueue + " goes back to looking at phone");
        }
    }
}