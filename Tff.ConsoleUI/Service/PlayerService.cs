using Tff.ConsoleUI.Models;
using Tff.ConsoleUI.Models.ReturnModels;
using Tff.ConsoleUI.Repsitory;

namespace Tff.ConsoleUI.Service;
public class PlayerService : IPlayerService
{
    PlayerRepository playerRepository = new PlayerRepository();

    public ReturnModel<Player> Add(Player player)
    {
        playerRepository.Add(player);
        return new ReturnModel<Player>
        {
            Data = player,
            Message = "Player Eklendi",
            StatusCode = System.Net.HttpStatusCode.OK,
            Success = true
        };
    }

    public ReturnModel<Player> Delete(Guid id)
    {
        throw new NotImplementedException();
    }

    public ReturnModel<List<Player>> GetAll()
    {
        throw new NotImplementedException();
    }

    public ReturnModel<Player> GetById(int id)
    {
        throw new NotImplementedException();
    }

    public ReturnModel<Player> Update(Guid id, Player player)
    {
        throw new NotImplementedException();
    }
}
