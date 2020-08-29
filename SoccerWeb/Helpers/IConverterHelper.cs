using SoccerBet.Web.Data.Entity;
using SoccerBet.Web.Models;

namespace SoccerBet.Web.Helpers
{
    public interface IConverterHelper
    {
        TeamEntity ToTeamEntity(TeamViewModel model, string path, bool isNew);

        TeamViewModel ToTeamViewModel(TeamEntity teamEntity);
    }
}

