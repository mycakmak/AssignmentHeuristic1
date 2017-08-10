# AssignmentHeuristic1
This is an heuristic solution code for an assignment problem for trains and trips.
Since this is a heuristic solution this does not guarantee optimality.
for any issue please do not hesitate to contact with me at mycakmakk@gmail.com or yusuf.cakmak@ug.bilkent.edu.tr

Why does this heuristic even exist?
Original project is done in excel for Bilkent University IE 469 Course Term Project.
This code is here for you to give insight about the problem.

What is the problem?
We are given some train, bus, plane or any other trips. We are required to use minimum number of vehicles. Given information are
trip ID, departing station, destination, departing time, arriving time. Trains are required to be cleaned, so you have a train needs
to wait 10 minutes after a trip.

How does the heuristic work?
It starts with creating a train. That train is assigned to the next available trip. Then the next one. Until the end of the trips.

What to do?
Sorting trains according to departing time makes heuristic give a better solution.

What can you do to improve this heuristic?
If you analyze the given solution to your problem, you will see that there will be trains that does only a few trips.
Adding some dummy trips to the tripSet might improve the solution by increasing the efficiency of trains.
There might be any other improvements you can think of.

Hope you benefit.
