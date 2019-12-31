using System;
using System.Collections.Generic;
using System.Text;

namespace delegate_n_events
{
    class Counter
    {
        public delegate void Mydel();
        public event Mydel Myeve;
        public void Count()
        {
            for(int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
                if (i == 59)
                {
                    Myeve?.Invoke();
                }
            }
        }
    }
}
