using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab5_5razor_strelchonok.Data;
using wt_lab5_5razor_strelchonok.Models;

namespace wt_lab5_5razor_strelchonok.Pages.Books;

public class DetailsModel : PageModel
{
    public Book? Book { get; set; }

    public IActionResult OnGet(int id)
    {
        Book = BookStore.Books.FirstOrDefault(b => b.Id == id);
        if (Book == null)
            return NotFound();
        return Page();
    }
}