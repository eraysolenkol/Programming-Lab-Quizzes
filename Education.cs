using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Quiz1 {
    class Education {

        private int number1;
        private int number2;

        private string[] correctMesssages = { "Excellent!", "Very good!", "Nice work!", "Keep up the good work!" };
        private string[] incorrectMessages = { "No. Please try again.", "Wrong. Try once more.", "Don't give up!", "No. Keep trying." };
        Random random = new Random();
        

        private int getRandomNumber() {
            return random.Next(1, 10);
        }

        private void askQuestion() {
            Console.WriteLine($"How much is {number1} times {number2}? (Enter -1 to exit)");
        }

        private string getRandomMessage(bool isCorrect) {
            int messageNumber = random.Next(1, 5);
            string[] messages = isCorrect ? correctMesssages : incorrectMessages;
            switch (messageNumber) {
                case 1:
                    return messages[0];
                case 2:
                    return messages[1];
                case 3:
                    return messages[2];
                case 4:
                    return messages[3];
                default:
                    break;
            }
            return "";
        }

        private bool checkAnswer(int input) {
            int answer = number1 * number2;
            if (answer == input) {
                return true;
            }
            return false;
        }

        private void selectNumbers() {
            number1 = getRandomNumber();
            number2 = getRandomNumber();
        }

        public void start() {
            selectNumbers();
            int input;
 
            while (true) {
                askQuestion();
                input = int.Parse(Console.ReadLine());
                bool isCorrect = checkAnswer(input);
                string randomMessage = getRandomMessage(isCorrect);
                if (input == -1) {
                    return;
                }
                else if (isCorrect) {
                    Console.WriteLine(randomMessage);
                    selectNumbers();
                } else {
                    Console.WriteLine(randomMessage);
                }

            }
        }


    }
}
