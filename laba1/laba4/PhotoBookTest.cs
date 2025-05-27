namespace laba4;

public class PhotoBookTest
{
    static void Main(string[] args)
    {
        PhotoBook book = new PhotoBook();
        Console.WriteLine(book.GetNumberPages());
        PhotoBook photoBook = new PhotoBook(24);
        Console.WriteLine(photoBook.GetNumberPages());
        Console.WriteLine(new BigPhotoBook().Page);
    }
}
