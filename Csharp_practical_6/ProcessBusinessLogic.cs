using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_practical_6
{
    public class ProcessBusinessLogic
    {
        public event EventHandler? ProcessComplete;

        public void StartProcess()
        {
            Console.WriteLine("Process Started...Wait For Completion....");
            Thread.Sleep(3000);
            OnProcessComplete(EventArgs.Empty); 
        }

        protected virtual void OnProcessComplete(EventArgs e)
        {
            if (ProcessComplete != null)
            {
                ProcessComplete(this, e);
            }
        }
    }
}
