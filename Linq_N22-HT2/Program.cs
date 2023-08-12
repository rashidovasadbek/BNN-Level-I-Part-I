ReviewList<IReview> reviewList = new ReviewList<IReview>();
//reviewList.GetOverallReview();
Review review = new Review(1,5,"salom");
Review review1 = new Review(2,5,"Alik");
Review review2 = new Review(3, 5,"olma");
Review review3 = new Review(4,5,"o'rik");
Review review4 = new Review(5, 1,"Baxor");
CrashReport crashReport = new CrashReport(6,5,"bob","");
CrashReport crashReport1 = new CrashReport(7,5,"G'ayrat","");
CrashReport crashReport2 = new CrashReport(8,5,"Kamol","");

reviewList.Add(review);
reviewList.Add(review1);
reviewList.Add(review2);
reviewList.Add(review3);
reviewList.Add(review4);

reviewList._reviews.Add(review);
reviewList._reviews.Add(review1);
reviewList._reviews.Add(review2);
reviewList._reviews.Add(review3);
reviewList._reviews.Add(review4);
reviewList._reviews.Add(crashReport);
reviewList._reviews.Add(crashReport1);
reviewList._reviews.Add(crashReport2);


//GetRevievni tekshirish
//Console.WriteLine(reviewList.GetReview(2));

//updateni  tekshirish
/*foreach(var item in reviewList._reviews)
    Console.WriteLine(item);

reviewList.Update(2, 5, "tohir");
Console.WriteLine();

foreach(var item in reviewList._reviews)
    Console.WriteLine(item);
*/

//Removeni tekshirish
/*foreach (var item in reviewList._reviews)
    Console.WriteLine(item);

reviewList.Remove(review);
Console.WriteLine();

foreach (var item in reviewList._reviews)
    Console.WriteLine(item);
*/

reviewList.GetOverallReview();