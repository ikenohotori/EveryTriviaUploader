using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using System;

namespace EveryTriviaFunc
{
    public class Function
    {
        [FunctionName("Function")]
        public void Run([TimerTrigger("*/10 * * * * *")]TimerInfo myTimer, ILogger log)
        {
            log.LogInformation("開始");

            try
            {
                // 今日のテーマを取得
                log.LogInformation("テーマ取得開始");
                //var newsText = new GetNews().Handle();
                log.LogInformation("テーマ取得完了");

                // 解説テキストを作成
                log.LogInformation("テキスト作成開始");
                //var scriptText = new GenerateSoshinaText().Handle(newsText);
                log.LogInformation("テキスト作成完了");

                // 音声ファイルを作成
                log.LogInformation("音声作成開始");
                //var audioPath = new GenerateAudioFile().Handle(scriptText);
                log.LogInformation("音声作成完了");

                // 動画に変換
                log.LogInformation("動画変換開始");
                //var videoPath = new ConvertAudioToVideo().Handle(audioPath);
                log.LogInformation("動画変換完了");

                // 動画をアップロード
                log.LogInformation("動画アップロード開始");
                //new UploadVideo().Handle(videoPath);
                log.LogInformation("動画アップロード完了");

                log.LogInformation("成功");
            }
            catch (Exception ex)
            {
                log.LogError("失敗");
                log.LogError(ex.Message);
            }
        }
    }
}
