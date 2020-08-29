using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace SoccerBet.Web.Helpers
{
    public interface IImageHelper
    {
        Task<string> UploadImageAsync(IFormFile imageFile, string folder);
    }
}
