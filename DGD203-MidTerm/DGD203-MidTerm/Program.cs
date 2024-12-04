
//i used chatgpt for this

using System;
using System.Collections.Generic;

class SpacePizzaDeliveryGame
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Space Pizza Delivery!");

        // Step 1: Ask for the player's name
        Console.Write("What's your name? ");
        string playerName = Console.ReadLine();
        Console.WriteLine($"Nice to meet you, {playerName}! Let's begin the adventure.\n");

        // Step 2: Define the questions
        List<Question> questions = new List<Question>
        {
            new Question("What is your favorite type of spacecraft?",
                new Dictionary<string, string>
                {
                    {"a", "Fighter Jet"},
                    {"b", "Cargo Ship"},
                    {"c", "Explorer"}
                }),
            new Question("What is your priority as a space pizza delivery pilot?",
                new Dictionary<string, string>
                {
                    {"a", "Speed"},
                    {"b", "Customer Satisfaction"},
                    {"c", "Exploration"}
                }),
            new Question("What type of pizza topping is most important to deliver?",
                new Dictionary<string, string>
                {
                    {"a", "Pepperoni"},
                    {"b", "Extra Cheese"},
                    {"c", "Mushrooms"}
                }),
            new Question("What would you do if pirates attacked your delivery route?",
                new Dictionary<string, string>
                {
                    {"a", "Fight back"},
                    {"b", "Try to negotiate"},
                    {"c", "Escape at full speed"}
                })
        };

        // Step 3: Ask the questions and collect answers
        Dictionary<int, string> answers = new Dictionary<int, string>();
        for (int i = 0; i < questions.Count; i++)
        {
            Console.WriteLine($"Q{i + 1}: {questions[i].Text}");
            foreach (var choice in questions[i].Choices)
            {
                Console.WriteLine($"  {choice.Key}: {choice.Value}");
            }

            Console.Write("Your choice: ");
            string answer = Console.ReadLine().ToLower();
            while (!questions[i].Choices.ContainsKey(answer))
            {
                Console.Write("Invalid choice. Please select a valid option: ");
                answer = Console.ReadLine().ToLower();
            }

            answers[i] = answer;
            Console.WriteLine();
        }

        // Step 4: Make a remark based on answers
        Console.WriteLine("Great job completing the questions! Here's what we think of your answers:");

        if (answers[0] == "a" && answers[1] == "a")
        {
            Console.WriteLine($"You seem like a speed enthusiast, {playerName}! Fighter jets and speed are your top priorities.");
        }
        else if (answers[2] == "b" && answers[3] == "c")
        {
            Console.WriteLine($"Cheese is life, isn't it, {playerName}? Escaping from pirates just to deliver that cheesy goodness sounds about right!");
        }
        else
        {
            Console.WriteLine($"You're quite versatile, {playerName}. A true adventurer who thinks on their feet!");
        }

        Console.WriteLine("Thanks for playing Space Pizza Delivery!");
    }
}

class Question
{
    public string Text { get; }
    public Dictionary<string, string> Choices { get; }

    public Question(string text, Dictionary<string, string> choices)
    {
        Text = text;
        Choices = choices;
    }
}
