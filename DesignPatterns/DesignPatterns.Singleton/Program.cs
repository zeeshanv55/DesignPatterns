// SINGLETON PATTERN
// Useful when only a single instance of a class is required
// Different from static as static is always lazily instantiated, this behaviour cannot be changed. We can control instantiation in singletons
// We can implement interfaces on singletons, we cannot do that on static

namespace DesignPatterns.Singleton
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    interface ISingleton
    {
        int GetInstanceCount();
    }

    sealed class Singleton : ISingleton
    {
        private static int instanceCount = 0;

        private static Singleton instance = null;

        private static object lockObject = new object();

        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        System.Threading.Thread.Sleep(200);
                        instance = new Singleton();
                        instanceCount++;
                    }
                }
            }

            return instance;
        }

        private Singleton()
        {
            
        }

        public int GetInstanceCount()
        {
            return instanceCount;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var singletonInstantiationTasks = new Task[1000000];
            var singletons = new List<Singleton>();
            for (var i = 0; i < singletonInstantiationTasks.Length; i++)
            {
                singletonInstantiationTasks[i] = new Task(() => { singletons.Add(Singleton.GetInstance()); });
                singletonInstantiationTasks[i].Start();
            }

            Task.WaitAll(singletonInstantiationTasks);

            Console.WriteLine(singletons.ElementAt(singletons.Count - 1).GetInstanceCount());

            Console.ReadKey();
        }
    }
}
