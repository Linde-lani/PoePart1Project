using System;
using System.Collections;

namespace PoePart1
{
    public class userInterface
    {
        //Global variable decleration
        private string userName = string.Empty;
        private string userQuestion = string.Empty;

        //Constructor
        public userInterface()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("////////////////////////");

            Console.ForegroundColor= ConsoleColor.Red;
            Console.WriteLine("Welcome to the AI ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("////////////////////////");

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Chatbot:-> ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Please enter your name.");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("You:-> ");
            Console.ResetColor();

            userName = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Chatbot:-> ");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Hello "+ userName +", how can I assist you today?");

            do
            {
                

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(userName +":-> ");
                Console.ResetColor();
                userQuestion = Console.ReadLine();

                response(userQuestion);
            } while (userQuestion != "exit");
            


        }//End of constructor
        

        //Response method
        private void response(string asked)
        {
            //If user didn't type exit, these responses will be displayed
            if (asked != "exit")
            {

                //Array list decleration to store the responses
                ArrayList question = new ArrayList();

                //Array list decleration to store common words that will be ignored
                ArrayList ignore = new ArrayList();


                //These are the stored responses
                question.Add("Chatbot:-> Be vigilant and suspicious");
                question.Add("Chatbot:-> Use strong passwords and two-factor authentication");
                question.Add("Chatbot:-> Keep your software and security tools up to date");
                question.Add("Chatbot:-> Never click on suspicious links or download attachments");
                question.Add("Chatbot:-> You can ask me me about cyber-security related questions");
                question.Add("Chatbot:-> My purpose is to inform you about cyber-security awareness");
                question.Add("Chatbot:-> You can ask me about how to browse safely");
                question.Add("Chatbot:-> Protect your accounts from phishing by using multi-factor authentication");
                question.Add("Chatbot:-> Phishing attacks almost always have some type of grammar error,so be on the lookout for that");
                question.Add("Chatbot:-> Watch out for 'Allow Notifications' pop-ups when browsing");
                question.Add("Chatbot:-> Avoid browsing websites that spam you with ads");
                question.Add("Chatbot:-> Installing antivirus software and keeping it updated helps with miniizing cyber-attacks ");
                question.Add("Chatbot:-> Use unique and different passwords for every login");
                question.Add("Chatbot:-> It's best to use a VPN when browsing so hackers may not track you");
                question.Add("Chatbot:-> Use different email addresses for different kinds of accounts");
                

                //These words will be ignored,they're not needed
                ignore.Add("tell");
                ignore.Add("what");
                ignore.Add("who");
                ignore.Add("are");
                ignore.Add("you");
                ignore.Add("is");
                ignore.Add("me");
                ignore.Add("about");






                //The split questions are stored in the 1D array
                string[] filteredQuestion = asked.Split(' ');//make sure there is 1 space

                //This array list will hold the words that are not ignored
                ArrayList correctFiltered = new ArrayList();


                //This will indicate if any relevant words are found
                Boolean found = false;

                //then display the answer using the for loop
                //This will check if each word is not contained in the ignore list
                for (int count = 0; count < filteredQuestion.Length; count++)
                {

                    //then final filter
                    if (!ignore.Contains(filteredQuestion[count]))
                    {

                        //then assign to true
                        found = true;

                        //If the non-ignored word is found then the word is added to correct_filtered
                        correctFiltered.Add(filteredQuestion[count]);
                    }

                }
                Boolean found_final = false;
                string message = "";
                //then check if it is found
                if (found)
                {


                    //then loop to show the asnwer
                    for (int counting = 0; counting < correctFiltered.Count; counting++)
                    {
                        //then display the answer
                        for (int count = 0; count < question.Count; count++)
                        {
                            //then finally display the found one
                            if (question[count].ToString().Contains(correctFiltered[counting].ToString()))
                            {
                                found_final = true;
                                //Output
                                message += question[count].ToString() + "\n";
                            }


                        }

                    }
                }


                if (found_final)
                {
                    Console.WriteLine(message);
                }

                else
                {
                    Console.WriteLine("Please search something related to cyber-security");
                }


            }

            else
            {
                //The displayed message when the user exits
                Console.WriteLine("Thank you for using the ChatbotAI, Goodbye");
                System.Environment.Exit(0);
            }//End of else
        }//End of response method
    }//End of class
    

}//End of namespace
