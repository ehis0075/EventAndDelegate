using System;

namespace DelegateAndEvent
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Video 1"};
            var videoEncoder = new VideoEncoder();  //publisher
            var mailService = new MailService();  // subscriber
            var messageService = new MessageService(); // subscriber

            // we need to do the subscription before calling the encode method
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;
            //VideoEncoded behind the scenes is a list of pointers to method
            

            videoEncoder.Encode(video);
        }
    }

    
    
}
