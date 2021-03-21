using System;
using System.Threading;

namespace DelegateAndEvent
{
    class VideoEncoder
    {

        //define a delegate
        //public delegate void VideoEncoderEventHandler(object source, VideoEventArgs args);


        // define an event based on the delegate
        //VideoEncoded behind the scenes is a list of pointers to method
        public event EventHandler<VideoEventArgs> VideoEncoded;
        


        public void Encode(Video video)
        {

            Console.WriteLine("Encoding video....");
            Thread.Sleep(1000);

            // notify all subscribers
            OnVideoEncoded(video);
        }

        //raising the event, we need a method that is responsible for that
        protected virtual void OnVideoEncoded(Video video)
        {
            if(VideoEncoded != null)
                VideoEncoded(this, new VideoEventArgs() { Video = video});
        }
        
    }
}