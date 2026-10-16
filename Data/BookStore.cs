using wt_lab5_5razor_strelchonok.Models;

namespace wt_lab5_5razor_strelchonok.Data;

public static class BookStore
{
    public static List<Book> Books { get; } = new()
    {
        new Book { Id = 1, Title = "Преступление и наказание", Author = "Ф. М. Достоевский",
                   Genre = "Роман", Year = 1866, Pages = 672, IsAvailable = true },
        new Book { Id = 2, Title = "Война и мир", Author = "Л. Н. Толстой",
                   Genre = "Роман-эпопея", Year = 1869, Pages = 1274, IsAvailable = true },
        new Book { Id = 3, Title = "Мастер и Маргарита", Author = "М. А. Булгаков",
                   Genre = "Мистика", Year = 1967, Pages = 480, IsAvailable = false },
        new Book { Id = 4, Title = "Герой нашего времени", Author = "М. Ю. Лермонтов",
                   Genre = "Роман", Year = 1846, Pages = 224, IsAvailable = true },
        new Book { Id = 5, Title = "Евгений Онегин", Author = "А. С. Пушкин",
                   Genre = "Роман в стихах", Year = 1833, Pages = 320, IsAvailable = false }
    };
}