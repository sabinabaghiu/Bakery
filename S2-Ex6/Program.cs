using System;

namespace S2_Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird bird = new Bird();
            Watcher w1 = new Watcher(bird);
            Watcher w2 = new Watcher(bird);
            Watcher w3 = new Watcher(bird, true);
            bird.RunBird();
        }
    }
}