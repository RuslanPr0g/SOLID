using System;

namespace InterfaceSegregation
{
    class Camera : IPhoto
    {
        public void TakePhoto()
        {
            Console.WriteLine("Photo using camera");
        }
    }
}
