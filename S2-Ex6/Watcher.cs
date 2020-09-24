using System;

namespace S2_Ex6
{
    public class Watcher
    {
        private Bird birdy;
        private bool isDeaf;
        public Watcher(Bird birdy)
        {
            this.birdy = birdy;
            this.isDeaf = false;
            birdy.ObserveBird += ReactToBird;
        }
        
        public Watcher(Bird birdy, bool isDeaf)
        {
            this.birdy = birdy;
            this.isDeaf = true;
            birdy.ObserveBird += ReactToBird;
        }

        public void ReactToBird(string text)
        {
            if (isDeaf)
            {
                Console.Out.Write("Deaf watcher: ");
                if (text == "Bird sings" || text == "Bird talks like a human")
                {
                    Console.Out.WriteLine("...");
                }
                else
                {
                    GetRandomReaction();
                }
            }
            else
            {
                Console.Out.Write("Watcher: ");
                GetRandomReaction();
            }
        }
        
        private void GetRandomReaction()
        {
            string[] reactions = {"Ooh!", "How nice!", "Would you look at that!", "Impressive!"};
            Random radRandom = new Random();
            Console.Out.WriteLine(reactions[radRandom.Next(reactions.Length)]);
        }
    }
}