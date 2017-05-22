using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskListModels
{
    class Building
    {
        // Room varible here decide on data structure later. leaning either dictionary could be an array or list?
        Room[] rooms;
        //*
        /* the building identification usually a number, but could go by a different name.
        /* this is why a string instead of an int. The building id is unique to each building
        /* in an organization. 
        */
        public string buildingID { get; private set; }

    }

    class Room
    {
        //*
        /* the room identification usually a number, but could go by a different name.
        /* this is why a string instead of an int. The room id is unique to each room. 
        */
        public string roomID { get; private set; }
    }
}
