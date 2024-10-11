using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game1401_la_5
{
    internal class User
    {
        private string _name;
        private int _id;
        private List<Video> _currentRentedVideos = new List<Video>();
        private List<Video> _previousRentals = new List<Video>();

        public User(string name, int id)
        {
            _name = name;   
            _id = id;
        }

        public void RentVideo(Video videoToRent)
        {
            _currentRentedVideos.Add(videoToRent);

        }

        public void ReturnVideo(Video videoToReturn)
        {
            if (!_currentRentedVideos.Remove(videoToReturn))
            {
                Console.WriteLine("video did not exitst");
            }
            else
            {
                _previousRentals.Add(videoToReturn);
            }
        }
    }
}
