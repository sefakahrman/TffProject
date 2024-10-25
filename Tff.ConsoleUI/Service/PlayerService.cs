using System.Net;
using Tff.ConsoleUI.Exceptions;
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
            Message = "Oyuncu Eklendi",
            StatusCode = HttpStatusCode.OK,
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

    private ReturnModel<Player> ReturnModelOfException(Exception ex)
    {


        if (ex.GetType() == typeof(NotFoundException))
        {
            return new ReturnModel<Player>
            {
                Data = null,
                Message = ex.Message,
                Success = false,
                StatusCode = HttpStatusCode.NotFound
            };
        }

        if (ex.GetType() == typeof(ValidationException))
        {
            return new ReturnModel<Player>
            {
                Data = null,
                Message = ex.Message,
                Success = false,
                StatusCode = HttpStatusCode.BadRequest
            };
        }


        return new ReturnModel<Player>
        {
            Data = null,
            Message = ex.Message,
            Success = false,
            StatusCode = HttpStatusCode.InternalServerError
        };


    }
}
