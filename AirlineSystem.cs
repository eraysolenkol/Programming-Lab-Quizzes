using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Quiz2 {
    class AirlineSystem {
        private bool[] seats = new bool[10];
        
        public AirlineSystem() {
            for (int i = 0; i < seats.Length; i++) {
                seats[i] = false;
            }
        }

        private void printFirstClassSeats() {
            for (int i = 0; i < 5; i++) {
                Console.WriteLine($"Seat {i + 1} is {(seats[i] ? "full" : "empty")}");
            }
        }

        private void printEconomySeats() {
            for (int i = 5; i < 10; i++) {
                Console.WriteLine($"Seat {i + 1} is {(seats[i] ? "full" : "empty")}");
            }
        }

        private bool isFirstClassSeatsFull() {
            for (int i = 0; i < 5; i++) {
                if (seats[i] == false) {
                    return false;
                }
            }
            return true;
        }

        private bool isEconomySeatsFull() {
            for (int i = 5; i < 10; i++) {
                if (seats[i] == false) {
                    return false;
                } 
            }
            return true;
        }

        private void selectFirstClassSeat() {
            int seatNumber;
            printFirstClassSeats();
            Console.Write("Choose your seat number = ");
            seatNumber = int.Parse(Console.ReadLine());
            if (seatNumber <= 5 && seatNumber >= 1) {
                assignSeat(seatNumber);
            } else {
                Console.WriteLine("Your seat number should be in 1-5");
            }
        }

        private void selectEconomySeat() {
            int seatNumber;
            printEconomySeats();
            Console.Write("Choose your seat number = ");
            seatNumber = int.Parse(Console.ReadLine());
            if (seatNumber <= 10 && seatNumber >= 6) {
                assignSeat(seatNumber);
            } else {
                Console.WriteLine("Your seat number should be in 6-10");
            }
        }

        private void assignSeat(int seatNumber) {
            if (seats[seatNumber - 1] == false) {
                seats[seatNumber - 1] = true;
                Console.WriteLine("Have a joyful experience!");
            } else {
                Console.WriteLine("Sorry the seat is full");
            }
        }

        private void cancelTicket(int seatNumber) {
            if (seatNumber >= 1 && seatNumber <= 10) {
                if (!seats[seatNumber - 1]) {
                    Console.WriteLine("Seat is already empty.");
                    return;
                }
                seats[seatNumber - 1] = false;
                Console.WriteLine("The ticket is cancelled.");
            } else {
                Console.WriteLine("Your seat number is not between 1-10");
            }
        }


        public void selection() {
            int checkOtherClass;
            int airplaneClass;
            Console.WriteLine("Please type 1 for First Class and Please type 2 for Economy, 3 for the canceling the ticket.");
            airplaneClass = int.Parse(Console.ReadLine());
            if (airplaneClass == 1) {
                if (isFirstClassSeatsFull()) {
                    Console.WriteLine("Sorry of the first class seats are full.");
                    Console.WriteLine("If you want to check economy class seats type 1 otherwise 2");
                    checkOtherClass = int.Parse(Console.ReadLine());
                    if (checkOtherClass == 1) {
                        if (isEconomySeatsFull()) {
                            Console.WriteLine("All the first class seats are full.Next flight leaves in 3 hours.");
                        } else {
                            selectEconomySeat();
                        }                
                    }

                    else if (checkOtherClass == 2) {
                        Console.WriteLine("Next flight leaves in 3 hours.");
                    } else {
                        Console.WriteLine("Unassigned selection, please type 1 or 2");
                    }
                } else {
                    selectFirstClassSeat();
                }
                
            } else if (airplaneClass == 2) {
                if (isEconomySeatsFull()) {
                    Console.WriteLine("Sorry of the economy class seats are full.");
                    Console.WriteLine("If you want to check first class seats type 1 otherwise 2");
                    checkOtherClass = int.Parse(Console.ReadLine());
                    if (checkOtherClass == 1) {
                        if (isFirstClassSeatsFull()) {
                            Console.WriteLine("All the first class seats are full.Next flight leaves in 3 hours.");
                        } else {
                            selectFirstClassSeat();
                        }
                      
                    } else if (checkOtherClass == 2) {
                        Console.WriteLine("Next flight leaves in 3 hours.");
                    } else {
                        Console.WriteLine("Unassigned selection, please type 1 or 2");
                    }
                } else {
                    selectEconomySeat();
                }
            } 
            else if (airplaneClass == 3) {
                int seatNumber;
                Console.Write("Please enter your seat number to cancel = ");
                seatNumber = int.Parse(Console.ReadLine());
                cancelTicket(seatNumber);
            }
        }


    }
}
