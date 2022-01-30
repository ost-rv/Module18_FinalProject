using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module18_FinalProject
{
    abstract internal class Command
    {
        public abstract void Run(string videoUrl);
        public abstract void Cancel();
    }
}
