using congress_sucks.Data.Models;
using congress_sucks.Domains;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace congress_sucks.Pages
{
    public class ArticleModel : PageModel
    {
        [Parameter]
        public int postId {get;set;}
        private readonly ILogger<IndexModel> Logger;
        private IPostDomain? PostDomain { get; set; }
        public BlogPost BlogPost { get; set; } = new();

        public ArticleModel(ILogger<IndexModel> logger, IPostDomain postDomain)
        {
            PostDomain = postDomain;
            Logger = logger;
        }

        public async void OnGetAsync(int postId)
        {
            BlogPost = await PostDomain.GetBlogPostAsync(postId).ConfigureAwait(false);
        }
    }
}
