using System.Numerics;

List<Team> teams = new List<Team>()
        {
            new Team() { Id = 1, ClubName = "Barselona", City = "Ispaniya" },
            new Team() { Id = 2, ClubName = "Real Madrid", City = "Ispaniya" },
            new Team() { Id = 3, ClubName = "Manchester City", City = "Angliya" },
            new Team() { Id = 4, ClubName = "Bavariya", City = "Germaniya" },
            new Team() { Id = 5, ClubName = "Nasaf", City = "Uzbekistan" },
            new Team() { Id = 6, ClubName = "Zenit", City = "Rossiya" },
};
List<Player> players = new List<Player>()
{
            new Player() { Id = 1, Name = "Messi", TeamId = 1, Level = 94},
            new Player() { Id = 2, Name = "Ronaldu", TeamId = 2, Level = 92},
            new Player() { Id = 3, Name = "Lewandowski", TeamId = 4, Level = 89},
            new Player() { Id = 4, Name = "De Bryune", TeamId = 3, Level = 88},
            new Player() { Id = 5, Name = "Neymar", TeamId = 1, Level = 90},
            new Player() { Id = 6, Name = "Suarez", TeamId = 1, Level = 88},
            new Player() { Id = 7, Name = "Haaland", TeamId = 3, Level = 86},
            new Player() { Id = 8, Name = "Myuller", TeamId = 4, Level = 84},
            new Player() { Id = 9, Name = "Bale", TeamId = 2, Level = 82},
            new Player() { Id = 10, Name = "Ismoilov", TeamId = 5, Level = 70},
            new Player() { Id = 11, Name = "Shomurodov", TeamId = 2, Level = 78},
            new Player() { Id = 12, Name = "Cherishev", TeamId = 2, Level = 78},
            new Player() { Id = 13, Name = "Vafoyev", TeamId = 2, Level = 78},
            new Player() { Id = 14, Name = "Denisov", TeamId = 2, Level = 78},
            new Player() { Id = 15, Name = "Latipov", TeamId = 2, Level = 78},
            new Player() { Id = 16, Name = "Jesus", TeamId = 2, Level = 78},
            new Player() { Id = 17, Name = "Genynrikh", TeamId = 2, Level = 78},
            new Player() { Id = 18, Name = "Modric", TeamId = 2, Level = 79},
            new Player() { Id = 19, Name = "Modric", TeamId = 5, Level = 67},
            new Player() { Id = 20, Name = "Modric", TeamId = 3, Level = 90},
            new Player() { Id = 21, Name = "Modric", TeamId = 2, Level = 88},
            new Player() { Id = 22, Name = "Modric", TeamId = 2, Level = 78},
        };

//Select
/*var result = players.Select(a => new { Name = a.Name, Leavel = a.Level });
foreach (var item in result)
{
    Console.WriteLine(item);
}*/

//Where
/*var resultA = players.Where(a => a.Name =="Ali");
foreach (var item in resultA)
{ Console.WriteLine(item.Name); }
*/

//OrderBy: 
/*var resultB = players.OrderBy(players => players.Level);
foreach (var player in resultB)
    Console.WriteLine(player.Level);*/
//OrderByDescending: 

/*var resultC = players.OrderByDescending(x => x.Level).ToList();
foreach (var player in resultC)
    Console.WriteLine(player.Level);*/
//ThenBy: 
/*var resultB = players.OrderBy(players => players.Name).ThenBy(players => players.Level).ToList();
foreach (var player in resultB)
    Console.WriteLine($"{player.Name}-{player.Level}");*/
//ThenByDescending: 
/*var resultE = players.Where(x=> x.Level > 60).OrderBy(x => x.Name).ThenByDescending(x => x.Level);
foreach (var player in resultE)
    Console.WriteLine(($"{player.Name}-{player.Level}"));*/
//Join: 
var resultD = teams.Join(players,
                           team => team.Id,
                           player => player.TeamId,
                           (teams, players) => new
                           {
                            ClubName = teams.ClubName,
                            Name = players.Name,
                            Level  = players.Level
                           });
resultD.ToList().ForEach(a =>Console.WriteLine($"Club: {a.ClubName.PadLeft(15)}" +
    $"Name: {a.Name.PadRight(15)}{a.Level}"));
//Aggregate: 

//GroupBy: 

//ToLookup:

//GroupJoin: 

//Reverse:

//All:

//Any: 

//Contains: 

//Distinct: 

//Except: 

//Union: 

//Intersect: 

//Count: 

//Sum:

//Average: 

//Min:

//Max:

//Take:

//Skip: 

//TakeWhile: 

//SkipWhile: 

//Concat: 

//Zip: 

//First: 

//FirstOrDefault: 

//Single: 

//SingleOrDefault: 

//ElementAt: 

//ElementAtOrDefault: 

//Last: 

//LastOrDefault: