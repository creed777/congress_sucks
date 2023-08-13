using congress_sucks.Data.Models;

namespace congress_sucks.Repositories
{
    public interface IPostRepository
    {
        Task<BlogPost> GetBlogPostAsync(int postId);
        Task<List<BlogPost>> GetNewestPostsAsync();
        Task<bool> CreateBlogPostAsync(BlogPost post);
    }
}
