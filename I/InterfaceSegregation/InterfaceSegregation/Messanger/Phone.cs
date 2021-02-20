using System;

namespace InterfaceSegregation
{
    class Phone : ICall, IPhoto, IVideo, IWeb
    {
        public void Call()
        {
            Console.WriteLine("Call");
        }
        public void TakePhoto()
        {
            Console.WriteLine("Photo using phone");
        }
        public void MakeVideo()
        {
            Console.WriteLine("Make video");
        }
        public void BrowseInternet()
        {
            Console.WriteLine("Serf inet");
        }
    }
}
