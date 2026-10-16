using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab5_5razor_strelchonok.Data;
using wt_lab5_5razor_strelchonok.Models;

namespace wt_lab5_5razor_strelchonok.Pages.Books;

public class CreateModel : PageModel
{
    [BindProperty]
    public Book Book { get; set; } = new();

    public void OnGet() { }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
            return Page();

        Book.Id = BookStore.Books.Any()
            ? BookStore.Books.Max(b => b.Id) + 1
            : 1;
        BookStore.Books.Add(Book);
        return RedirectToPage("./Index");
    }
}