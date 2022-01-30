using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module18_FinalProject
{
    internal class YoutubeManager
    {
        Command _downloadAction;
        Command _displayInfoAction;

        public void SetDownloadAction(Command command)
        {
            _downloadAction = command;
        }


        public void SetDisplayInfoAction(Command command)
        {
            _displayInfoAction = command;
        }

        public void DownloadVidio(string videoId)
        {
            _downloadAction.Run(videoId);
        }


        public void DisplayVidioInfo(string videoId)
        {
            _displayInfoAction.Run(videoId);
        }
    }
}
