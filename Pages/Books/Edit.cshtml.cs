using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using wt_lab5_5razor_strelchonok.Data;
using wt_lab5_5razor_strelchonok.Models;

namespace wt_lab5_5razor_strelchonok.Pages.Books;

public class EditModel : PageModel
{
    [BindProperty]
    public Book Book { get; set; } = new();

    public IActionResult OnGet(int id)
    {
        var book = BookStore.Books.FirstOrDefault(b => b.Id == id);
        if (book == null)
            return NotFound();
        Book = book;
        return Page();
    }

    public IActionResult OnPost()
    {
        if (!ModelState.IsValid)
            return Page();

        var existing = BookStore.Books.FirstOrDefault(b => b.Id == Book.Id);
        if (existing == null)
            return NotFound();

        existing.Title = Book.Title;
        existing.Author = Book.Author;
        existing.Genre = Book.Genre;
        existing.Year = Book.Year;
        existing.Pages = Book.Pages;
        existing.IsAvailable = Book.IsAvailable;

        return RedirectToPage("./Index");
    }
}