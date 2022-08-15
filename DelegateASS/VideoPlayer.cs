using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateASS
{
    /// <summary>
    /// delegate method that will be passed as parameters into the main method
    /// </summary>
    internal class VideoPlayer
    {
        public delegate void Duration(int scenesSeen);
        public static void MovieWatch(Duration durt)
        {
            for (int i = 0; i < 7236; i++)
            {
                var scenesSeen = i.ToString();
                durt(i);
            }
        }
    }
}
