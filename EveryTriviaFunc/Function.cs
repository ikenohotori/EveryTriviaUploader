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
            log.LogInformation("�J�n");

            try
            {
                // �����̃e�[�}���擾
                log.LogInformation("�e�[�}�擾�J�n");
                //var newsText = new GetNews().Handle();
                log.LogInformation("�e�[�}�擾����");

                // ����e�L�X�g���쐬
                log.LogInformation("�e�L�X�g�쐬�J�n");
                //var scriptText = new GenerateSoshinaText().Handle(newsText);
                log.LogInformation("�e�L�X�g�쐬����");

                // �����t�@�C�����쐬
                log.LogInformation("�����쐬�J�n");
                //var audioPath = new GenerateAudioFile().Handle(scriptText);
                log.LogInformation("�����쐬����");

                // ����ɕϊ�
                log.LogInformation("����ϊ��J�n");
                //var videoPath = new ConvertAudioToVideo().Handle(audioPath);
                log.LogInformation("����ϊ�����");

                // ������A�b�v���[�h
                log.LogInformation("����A�b�v���[�h�J�n");
                //new UploadVideo().Handle(videoPath);
                log.LogInformation("����A�b�v���[�h����");

                log.LogInformation("����");
            }
            catch (Exception ex)
            {
                log.LogError("���s");
                log.LogError(ex.Message);
            }
        }
    }
}
