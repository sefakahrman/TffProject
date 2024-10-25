using Tff.ConsoleUI.Models;
using Tff.ConsoleUI.Repsitory;
using Tff.ConsoleUI.Service;

/******************************************************/

TeamService teamService = new TeamService();

var takim = new Team
{
    Id = 5,
    Name = "Trabzonspor",
    Since = new DateTime(1908, 5, 3)
};

var takim2 = new Team
{
    Id = 7,
    Name = "Bursaspor",
    Since = new DateTime(1920, 5, 3)
};

//Methods -> Add Team
Console.WriteLine(teamService.Add(takim2));

//Methods -> Remove Team
Console.WriteLine(teamService.Delete(1)+"\n");

//Methods -> Update Team
teamService.Update(2,takim);
Console.WriteLine(teamService.GetById(takim.Id)+"\n");

//Update Team NotFound Exception
Console.WriteLine(teamService.Update(4,takim)+ "\n");

//Methods -> GetById Team
Console.WriteLine(teamService.GetById(2)+"\n");

//All Teams
BaseRepository.Teams.ForEach(p => Console.WriteLine(p));


