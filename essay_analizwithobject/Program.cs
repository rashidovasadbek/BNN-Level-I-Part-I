using static System.Net.Mime.MediaTypeNames;
var test = new Document
{
    Content = "Lorem ipsum dolor sit amet consectetur adipisicing elit. " +
    "quaerat est quas commodi quibusdam labore, nihil doloribus quam temporibus inventore optio" +
    " expedita consectetur voluptatem QUIDEM nulla soluta earum. Numquam rem alias minima culpa iste" +
    " distinctio. Eum similique est consequuntur minus, odio nisi recusandae iure asperiores facere," +
    " reiciendis voluptate maiores! Repellat, dolorum",
    ball = 100
};

 
var analiz = new DocumentAnalyzer();
analiz.Analiz(test);

Console.WriteLine(test.ball);

public class DocumentAnalyzer
{
    public void Analiz(Document document)
    {
        Analiz500(document);
        repidwords(document);
        capital(document);
        upperwords(document);
        wordslenmore20(document);
    }
    
    public int Analiz500(Document document)
    {
      
        var words = document.Content.Split(' ');
        
        if (words.Length < 500) document.ball -= 5;
        
        return document.ball;
    }

    public int repidwords(Document document)
    {
        var wordscount1 = 0;
        var words1 = document.Content.Split(' ');
        for (int i = 0; i < words1.Length; i++)
        {
            for (int j = 1; j < words1[i].Length; j++)
            {
                bool check = words1[i].Contains(words1[j], StringComparison.OrdinalIgnoreCase);
                if (check)
                    wordscount1++;
            }
            if (words1.Length / 5 < wordscount1)
            {
                //Console.WriteLine(words[i]);
                document.ball -= 5;
                break;
            }

        }
        return document.ball;
    }
    
    public int capital(Document document)
    {
        var wordsA = document.Content.Split('.', '!');
        for (int i = 1; i < wordsA.Length - 1; i++)
        {
            bool checkA = Char.IsLower(wordsA[i].ToString(), 1);
            if (checkA)
            {
                //Console.WriteLine(wordsA[i][1]);
                document.ball -= 5;
            }
        }
        return document.ball;
    }

    public int upperwords(Document document)
    {
        var wordsB = document.Content.Split(' ');
        bool checkB = false;
        for (int i = 0; i < wordsB.Length; i++)
        {
            for (int j = 0; j < wordsB[i].Length - 1; j++)
            {
                //Console.Write(wordsB[i][j]);
                checkB = Char.IsUpper(wordsB[i], 1);
            }
            if (checkB)
            {
                document.ball -= 10;
            }
        }
        return document.ball;
    }

    public int wordslenmore20(Document document)
    {
        var wordsC = document.Content.Split('.');
        var countC = 1;
        for (int i = 0; i < wordsC.Length; i++)
        {
            for (var j = 0; j < wordsC[i].Length; j++)
            {
                if (wordsC[i][j] == ' ')
                {
                    countC++;
                }
            }
            if (countC > 20)
            {
                /* Console.WriteLine(countC);
                 Console.WriteLine(wordsC[i]);*/
                document.ball -= 20;
            }
            countC = 0;
        }
        return document.ball;
    }
    
    
}

public class Document
{
    public string Content;
    public int ball;
}
