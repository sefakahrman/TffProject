using Tff.ConsoleUI.Models;
using Tff.ConsoleUI.Models.ReturnModels;

namespace Tff.ConsoleUI.Service;

public interface ITeamService
{
    ReturnModel<Team> Add(Team team);
    ReturnModel<Team> Update(int id,Team team);
    ReturnModel<Team> Delete(int id);
    ReturnModel<Team> GetById(int id);
    ReturnModel<List<Team>> GetAll();
}
//CRUD