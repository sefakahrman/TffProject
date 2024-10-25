
using Tff.ConsoleUI.Models;
using Tff.ConsoleUI.Models.ReturnModels;

namespace Tff.ConsoleUI.Service;

public interface IPlayerService
{
    ReturnModel<Player> Add(Player player);
    ReturnModel<Player> Delete(Guid id);
    ReturnModel<Player> Update(Guid id, Player player);
    ReturnModel<List<Player>> GetAll();
    ReturnModel<Player> GetById(int id);
}
