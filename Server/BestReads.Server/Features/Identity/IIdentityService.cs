using BestReads.Server.Data.Models;

namespace BestReads.Server.Features.Identity
{
    public interface IIdentityService
    {
        string GenerateJwtToken(string userId, string userName, string secret);
    }
}
