using Tff.ConsoleUI.Models;
using Tff.ConsoleUI.Models.Enums;
using Tff.ConsoleUI.Repsitory;
using Tff.ConsoleUI.Service;

/******************************************************/

TeamService teamService = new TeamService();
PlayerService playerService = new PlayerService();

#region Teams

var team = new Team
{
    Id = 5,
    Name = "Trabzonspor",
    Since = new DateTime(1908, 5, 3)
};

var team2 = new Team
{
    Id = 7,
    Name = "Bursaspor",
    Since = new DateTime(1920, 5, 3)
};

//Methods
Console.WriteLine(teamService.Add(team2) + "\n");

Console.WriteLine(teamService.Delete(1)+"\n");

Console.WriteLine(teamService.Update(2, team) + "\n");

Console.WriteLine(teamService.GetById(team.Id)+"\n");

Console.WriteLine(teamService.Update(4,team)+ "\n"); //NotFoundException

Console.WriteLine(teamService.GetById(2)+"\n");

BaseRepository.Teams.ForEach(p => Console.WriteLine(p));

#endregion

#region Players

var playerNew = new Player
{
    Id = new Guid("{CC42AF7D-93C2-462E-9C2D-30ECD2803EC0}"),
    Age = 20,
    Name = "Sefa",
    Surname = "Kahraman",
    Number = "10",
    Branch = Branch.Futbol,
    MarketValue = 99000000,
    TeamId = 2,
    Gender = Gender.Male
};

Console.WriteLine("\n"+playerService.Add(playerNew));

#endregion


