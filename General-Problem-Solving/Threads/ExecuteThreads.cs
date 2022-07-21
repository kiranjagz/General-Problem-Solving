using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static General_Problem_Solving.Program;

namespace General_Problem_Solving.Threads
{
    static class ExecuteThreads
    {
        public static void Execute()
        {
            Thread t1 = new Thread(new Racer("1").Run);
            Thread t2 = new Thread(new Racer("2").Run);
            Thread t3 = new Thread(new Racer("3").Run);
            Thread t4 = new Thread(new Racer("4").Run);
            Thread t5 = new Thread(new Racer("5").Run);

            t5.Start();
            t3.Start();
            t1.Start();
            t3.Join();
            t2.Start();
            t1.Join();
            t4.Start();
            t2.Join();
            t4.Join();
            t5.Join();
        }
    }
}
