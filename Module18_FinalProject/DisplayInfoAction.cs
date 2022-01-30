using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module18_FinalProject
{
    internal class DisplayInfoAction : Command
    {
        Youtube _youtube;
        
        public DisplayInfoAction(Youtube youtube)
        {
            _youtube = youtube;
        }

        public override void Run(string videoUrl)
        {
            _youtube.DisplayVideoInfo(videoUrl);
        }

        public override void Cancel()
        {
            throw new NotImplementedException();
        }
    }
}
