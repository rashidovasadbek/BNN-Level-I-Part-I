var arr = new int[] { 1, 2, 3, 4, 4, 5, 5, 6 }; 
var sum3 = AggregationService.Sum(arr);
Console.WriteLine("Sum:"+sum3);
var Average = AggregationService.Average(arr);
Console.WriteLine("Average:"+ Average);
var max = AggregationService.Max(arr);
Console.WriteLine("Max:"+max);
var min = AggregationService.Min(arr);
Console.WriteLine("Min:"+min);
var incrementnum = 6;
var maxvalue = int.MaxValue;
var decrementnum = -10;
var minvalue = int.MinValue;
var increment = AggregationService.Increment(ref incrementnum);
Console.WriteLine("increament:"+increment);
var decrement= AggregationService.Decrement(ref decrementnum);
Console.WriteLine("decremwnet"+ decrement);

