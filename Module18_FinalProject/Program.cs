using System;
using System.Threading.Tasks;

namespace Module18_FinalProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StartAsync().GetAwaiter().GetResult();
        }

        public static async Task StartAsync()
        {
            YoutubeManager youtubeManager = new YoutubeManager();
            Youtube youtube = new Youtube();

            youtubeManager.SetDownloadAction(new DownloadAction(youtube));
            youtubeManager.SetDisplayInfoAction(new DisplayInfoAction(youtube));

            while (true)
            {
                Console.WriteLine("Введите url video или exit для выхода");
                string urlVideo = Console.ReadLine();

                if (urlVideo.ToLower() == "exit")
                {
                    return;
                }

                try
                {
                    youtubeManager.DisplayVidioInfo(urlVideo);
                    await youtube.DownloadVideo(urlVideo);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine("Конец");
            }
        }
    }
}
