using congress_sucks.Data.Models;

namespace congress_sucks.Domains
{
    public interface IPostDomain
    {
        Task<List<BlogPost>> GetGetNewestPostsAsync();
    }
}
