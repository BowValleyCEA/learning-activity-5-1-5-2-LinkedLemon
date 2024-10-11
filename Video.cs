using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game1401_la_5
{
    internal class Video
    {
        private string _name;
        private int _id;
        private string _genre;
        private int _length;
        private DateTime _timeRented;

        public Video(string name, int id, string genre, int length)
        {
            _name = name;
            _id = id;
            _genre = genre;
            _length = length;
        }

        public void SetTimeRented()
        {
            _timeRented = DateTime.Now;
        }

        public TimeSpan Returned() //tape was returned method
        {
            TimeSpan timeOut;
            timeOut = DateTime.Now - _timeRented;
            return timeOut;
        }
    }
}
