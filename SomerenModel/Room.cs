﻿namespace SomerenModel
{
    public class Room
    {
      
        public string RoomBuilding { get; set; }  // building ex a or B
        public int RoomNumber { get; set; }     // RoomNumber, e.g. 206
        public int RoomCapacity { get; set; }   // number of beds, either 4, 6, 8, 12 or 16
        public string RoomType { get; set; }      //singular or dormitory
    }
}