using Microsoft.AspNetCore.Mvc.RazorPages;
using congress_sucks.Domains;
using congress_sucks.Data.Models;

namespace congress_sucks.Pages
{
    public class EditModel : PageModel
    {
        public BlogPost NewBlogPost { get; set; } = new();
        public IPostDomain? PostDomain { get; set; }

        public EditModel(IPostDomain postDomain)
        {
            PostDomain = postDomain;
        }
        public void OnGet()
        {
            
        }

        public async Task OnPostAsync()
        {
            NewBlogPost.Title = Request.Form["Title"];
            NewBlogPost.Tags = Request.Form["Tags"];
            NewBlogPost.Post = Request.Form["Post"];
            NewBlogPost.Updated = DateTime.UtcNow;

            await PostDomain!.CreateBlogPostAsync(NewBlogPost);
        }
    }
}
