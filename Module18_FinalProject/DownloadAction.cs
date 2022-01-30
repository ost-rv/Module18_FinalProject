using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Module18_FinalProject
{
    internal class DownloadAction : Command
    {
        Youtube _youtube;
        public DownloadAction(Youtube youtube)
        {
            _youtube = youtube;
        }

        public async override void Run(string videoUrl)
        {
            await _youtube.DownloadVideo(videoUrl);
        }

        public override void Cancel()
        {
            throw new NotImplementedException();
        }
    }
}
