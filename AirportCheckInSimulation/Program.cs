using System;

namespace AirportCheckInSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var economyQueue = new PassengerQueue();
            var businessQueue = new PassengerQueue();

            // Add 100 economy passengers
            for (int i = 0; i < 100; i++)
            {
                economyQueue.Enqueue(new Passenger("Economy"));
            }

            // Add 20 business passengers
            for (int i = 0; i < 20; i++)
            {
                businessQueue.Enqueue(new Passenger("Business"));
            }

            // Simulate the check-in process
            int totalEconomyTime = SimulateCheckIn(
                economyQueue, 5, 10);
            int totalBusinessTime = SimulateCheckIn(businessQueue, 5, 7);

            // Display the result
            Console.WriteLine($"Total time for economy class: {totalEconomyTime} minutes");
            Console.WriteLine($"Total time for business class: {totalBusinessTime} minutes");
            Console.WriteLine($"Total time for the whole flight: {totalEconomyTime + totalBusinessTime} minutes");
        }

        private static int SimulateCheckIn(PassengerQueue businessQueue, int v1, int v2)
        {
            throw new NotImplementedException();
        }

        // (SimulateCheckIn method as defined above)
    }

    internal class PassengerQueue
    {
        public PassengerQueue()
        {
        }

        internal void Enqueue(Passenger passenger)
        {
            throw new NotImplementedException();
        }
    }

    class Passenger
    {
        private string v;

        public Passenger(string v)
        {
            this.v = v;
        }
    }
}
