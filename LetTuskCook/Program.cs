using System;

namespace LetTuskCook
{
    class Program
    {
        static async Task Main(string[] args) 
        {
            List<Task> cuochi = new List<Task>();
            CPianoCottura pianoCottura = new CPianoCottura();

            for (int i = 0; i < 20; i++) 
            {
                CCuoco cuoco = new CCuoco(pianoCottura);
                cuochi.Add(cuoco.Cucina());
            }

            await Task.WhenAll(cuochi.ToArray());
        }
    }
}