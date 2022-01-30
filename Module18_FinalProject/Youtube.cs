using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;

namespace Module18_FinalProject
{
    internal class Youtube
    {
        YoutubeClient _youtubeClient;

        public Youtube()
        {
            _youtubeClient = new YoutubeClient();
        }

        public async void DisplayVideoInfo(string videoId)
        {
            var video = await _youtubeClient.Videos.GetAsync(videoId);
            Console.WriteLine($"Видео:\n {video.Title}");
            Console.WriteLine();
            Console.WriteLine($"Описание:\n {video.Description}");
            Console.WriteLine();
            Console.WriteLine($"Дата загрузки:\n {video.UploadDate}");
            Console.WriteLine();
            Console.WriteLine($"Автор:\n {video.Author}");
            Console.WriteLine("");
        }

        public async ValueTask DownloadVideo(string videoId)
        {
            var manifest = await _youtubeClient.Videos.Streams.GetManifestAsync(videoId);
            var streamInfo = manifest.GetVideoStreams().OrderBy(s => s.Size).First();
            
            Console.WriteLine("Загрузка видео...");
            await _youtubeClient.Videos.Streams.DownloadAsync(streamInfo, Path.Combine(AppDomain.CurrentDomain.BaseDirectory, Guid.NewGuid().ToString()) + ".mp4");
        }

    }
}
