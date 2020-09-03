//-----------------------------------------------------------------------------
// Runtime: 248ms
// Memory Usage: 31.8 MB
// Link: https://leetcode.com/submissions/detail/327830218/
//-----------------------------------------------------------------------------

using System;

namespace LeetCode
{
    public class TrafficLight
    {
        private int currentRoadId = 1;

        public TrafficLight()
        {

        }

        public void CarArrived(
            int carId,         // ID of the car
            int roadId,        // ID of the road the car travels on. Can be 1 (road A) or 2 (road B)
            int direction,     // Direction of the car
            Action turnGreen,  // Use turnGreen() to turn light to green on current road
            Action crossCar    // Use crossCar() to make car cross the intersection
        )
        {
            if (roadId != currentRoadId)
            {
                turnGreen();
                currentRoadId = roadId;
            }
            crossCar();
        }
    }
}
