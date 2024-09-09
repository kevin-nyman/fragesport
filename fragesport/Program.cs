using System.Collections;

public class Quiz {
    private string question;
    private Dictionary<string, bool> answer = new Dictionary<string, bool>();
    public Quiz(string question) {
        this.question = question; 

    }

    public bool Ask() {
        Console.WriteLine(question + "\n");
        foreach(string key in answer.Keys) {
            Console.WriteLine(key);
        }
        while(true) {
            Console.Write("\nAnswer: ");
            string input = Console.ReadLine();
            if (answer.ContainsKey(input)) {
                return answer[input];
        } else {
            Console.WriteLine("typdae one of the alternatives...");
            }


        }
    }

    public void AddAnswer(string john, bool istrue) {
        answer.Add(john, istrue);
        
    }
}

public class Program {
    public static void Main() {
        var question_1 = new Quiz("hello test");

        question_1.AddAnswer("boobies", true);
        question_1.AddAnswer("boo2", false);
        bool result = question_1.Ask();
        Console.WriteLine($"The result is: {result}");
    }
}




