using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab5_5razor_strelchonok.Data;
using wt_lab5_5razor_strelchonok.Models;

namespace wt_lab5_5razor_strelchonok.Pages.Books;

public class IndexModel : PageModel
{
    public List<Book> Books { get; set; } = new();

    public void OnGet()
    {
        Books = BookStore.Books;
    }
}
