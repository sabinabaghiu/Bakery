using System;
using System.Collections.Generic;
using System.Threading;

namespace S2_Ex6
{
    public class Bird
    {
        public Action<string> ObserveBird;
        public void RunBird()
        {
            while (true)
            {
                Console.Out.WriteLine("Bird flaps wings");
                ObserveBird?.Invoke("Bird flaps wings");
                Thread.Sleep(2000);
                Console.Out.WriteLine("Bird sings");
                ObserveBird?.Invoke("Bird sings");
                Thread.Sleep(1500);
                Console.Out.WriteLine("Bird flies in circles");
                ObserveBird?.Invoke("Bird flies in circles");
                Thread.Sleep(3000);
                Console.Out.WriteLine("Bird talks like a human");
                ObserveBird?.Invoke("Bird talks like a human");
            }
        }
    }
}