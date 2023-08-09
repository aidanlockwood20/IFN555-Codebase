/*
 1. Open the app with a welcome message, prompting the user to write a message
 2. Check to make sure the message is short enough (i.e. that it is within 140 characters)
 3. Tell the user the message has been posted
 */

namespace Twitter;

class Program
{
    static void Main(string[] args)
    {
        string userTweet;
        int userTweetLength;
        int tweetMessageLength = 3;
        bool userTweetIncorrectLength = true;

        while (userTweetIncorrectLength)
        {
            Console.WriteLine("Welcome to Twitter :)");
            Console.WriteLine("Write your message!");

            userTweet = Console.ReadLine();
            userTweetLength = userTweet.Length;

            if (userTweetLength > tweetMessageLength)
            {
                Console.WriteLine("Post is invalid. Message is too long.");
                Console.WriteLine("Please ensure your message is within 140 characters");
            }
            else
            {
                Console.WriteLine("Tweet Posted");
                Console.WriteLine("You wrote '{0}'", userTweet);
                userTweetIncorrectLength = false;
            }
        }
    }
}

