using System;

namespace Stack_Overflow_Post
{
    public class Post
    {     
        public String Title { get; set; }
        public String Description { get; set; }

        public DateTime Date_Time_Of_Creation { get; set; }

        public int Vote_Value { get; private set; }


        public Post()
        {
            createPost();
            votingOptions();
            displayPost();
        }
        public void createPost()
        {
            System.Console.Write("Please enter a title for your post: ");
            Title = Console.ReadLine();

            System.Console.WriteLine("Please enter a post description:");
            Description = Console.ReadLine();

            Date_Time_Of_Creation = DateTime.Now;

        }
        public void upVote(){ Vote_Value++; }

        public void downVote(){ Vote_Value--; }

        public void votingOptions()
        {

            String response = "y";
            System.Console.WriteLine("Would you like to vote on a post? y|n");
            response = Console.ReadLine();


            if(response.ToLower() != "y" || response.ToLower() != "n")
            {

                System.Console.WriteLine("1. Up vote\n2. Down vote");
                int ans = Convert.ToInt32(Console.ReadLine());
                if(ans == 1){upVote();}
                else if(ans == 2){ downVote();}

            }
        }
        public void displayPost()
        {
            System.Console.WriteLine("\n");
            System.Console.WriteLine("Title: {0}\nDescription: {1}\nTime of creation: {2}\nVote value: {3}", 
                                    Title, Description, Date_Time_Of_Creation, Vote_Value);
        }

    }
}
