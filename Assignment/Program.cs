using System.Collections.Generic;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //for detailed explanation see README file.
            //if you cannot find it it means i havent uploaded it yet
            //if you need help or have any questions about anyting
            //or you need this in excel file as VBA
            //contact me at mycakmakk@gmail.com
            //i have used this code for Long Island Rail Road and found 269 trains.
            //since this is a heuristic method developed by me, it does not guarantee
            //to be optimal. But it gives a solution which is nice.
            List<Trip> tripSet = new List<Trip>();

            //insert your tripset here
            //right here

            int availabilityTime;
            //holds the current station of current train.
            int currentStation;
            //trains need some time after a trip for some reasons like cleaning
            //set this time according to your problem
            int waitingTimeAfterTrip = 10;
            int trainNo = 0;
            int assignedTrips = 0;
            int numberOfTrips = tripSet.Count;

            while (assignedTrips < numberOfTrips)
            {
                //create the next train and initialize values
                trainNo++;
                availabilityTime = 0;
                currentStation = 0;

                for (int i = 0; i < numberOfTrips; i++)
                {
                    //for the first trip
                    if (currentStation == 0 && tripSet[i].assignedTrainNumber == 0)
                    {
                        //assigning the trip to a train
                        tripSet[i].assignedTrainNumber = trainNo;
                        //setting availability time
                        availabilityTime = tripSet[i].endTime + waitingTimeAfterTrip;
                        //updating current station of the train
                        currentStation = tripSet[i].to;
                    }
                    //conditions: trip is not assigned, train is ready, train is in departing station of that trip
                    else if (tripSet[i].assignedTrainNumber == 0 && availabilityTime <= tripSet[i].endTime && currentStation == tripSet[i].from)
                    {
                        //inside of if is the same
                        tripSet[i].assignedTrainNumber = trainNo;
                        availabilityTime = tripSet[i].endTime + waitingTimeAfterTrip;
                        currentStation = tripSet[i].to;
                    }
                }
            }
        }
    }
}
