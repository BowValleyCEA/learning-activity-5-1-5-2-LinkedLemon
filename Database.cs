using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game1401_la_5
{
    internal class Database
    {
        List<Video> totalVideoList = new List<Video>();
        List<User> totalUserList = new List<User>();


        public void UserInput()
        {
            // ask what the user wants to do
            // 1. add new user
            // 2. add new video
            // 3. rent tape to user
            // 4. search inventory
            // 5. exit the program
            //put all in a while loop till exit is called
        }

        private void AddNewVideo()
        {
            // instatniate a new video in here then add it to the list to keep track
        }

        private void AddNewUser()
        {
            // create new user and add it to the list
        }

        private void RentVideo()
        {
            // ask user for username and video id
            // take video out of list and add it to the current rented tapes on user
            // remove tape from total video list
        }

        private void ReturnVideo()
        {
            //take user id returning from and take from their current videos and remove it 
            // add video to user past videos
            // add video back to total list
        }

        private void SeachForVideo(string userSearch)
        {
            // go through current video list and search for input from user
            // if is in database diplay the tape and all its info
            // else display if the tape is or is not avalible
        }

        private void ShowAllUsersAndTheirVideos()
        {
            // grab all users and if they have tapes in their list display them all underneath user in semi detail
        }

    }
}
