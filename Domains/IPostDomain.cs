using congress_sucks.Data.Models;

namespace congress_sucks.Domains
{
    public interface IPostDomain
    {
        Task<List<BlogPost>> GetGetNewestPostsAsync();
        Task<BlogPost> GetBlogPostAsync(int postId);
        Task<bool> CreateBlogPostAsync(BlogPost post);
    }
}
