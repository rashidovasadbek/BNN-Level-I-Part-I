int ball = 0;
var test = new string[] {
    "1.Quyish qaysi tarafdan chiqadi ?",
    "2.Oy qanaqa shakilda ?",
    "3.Odamning nechta qo'li bo'ladi ?",
    "4.Tovuq birinchi paydo bo'lganmi yoki tuxum ?",
    "5.Osmon qanaqa rangda ?"
};
var correctAnswer = new string[] { "g'arb", "yumaloq", "ikkita", "tovuq","ko'k" };
var wrongAnswer = new string[] { "sharq", "tortburchak", "uchta", "tuxum","qizil"};
var saveAnswer = new string[5];
var savewrongAnswer = new string[5];
var savewronganswerOftest = new string[5];


for(int i = 0; i < test.Length; i++)
{
    Console.WriteLine("Question:");
    Console.WriteLine(test[i]);
    Console.WriteLine("A)"+correctAnswer[i]);
    Console.WriteLine("B)"+wrongAnswer[i]+"\n");
    Console.Write("User:");
    var choose = Console.ReadLine();
    Console.Write("\n");
    
    switch (choose)
    {
        case "A": saveAnswer[i] = correctAnswer[i]; break;
        case "B": saveAnswer[i] = wrongAnswer[i]; break;
        default:
            Console.WriteLine("Invalid choose");break;
    
    }
}

for (int i = 0; i < saveAnswer.Length; i++)
{
    if (saveAnswer[i].Equals(correctAnswer[i]))
    {
        ball += 2;
    }
    else if (saveAnswer[i].Equals(wrongAnswer[i]))
    {
        savewrongAnswer[i] = saveAnswer[i];
        savewronganswerOftest[i] = test[i];
    }
}
Console.WriteLine("ball: " + ball);
Console.WriteLine("Invalid Answers:\n");

for(int i = 0;i < savewronganswerOftest.Length; i++)
{
    if (savewronganswerOftest[i] != null)
    {
        Console.Write("Question:");
        Console.WriteLine(savewronganswerOftest[i]);
        Console.Write("Answer:");
        Console.WriteLine(savewrongAnswer[i]);
    }
   
    
}