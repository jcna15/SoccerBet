using Microsoft.AspNetCore.Http;
using SoccerBet.Web.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace SoccerBet.Web.Models
{
    public class TeamViewModel : TeamEntity
    {
        [Display(Name = "Logo")]
        public IFormFile LogoFile { get; set; }

    }

}
