namespace WorkFour;

public class PhotoBookTest
{
    static void Main(string[] args)
    {
        PhotoBook book = new PhotoBook();
        Console.WriteLine(book.GetNumberPages);
        PhotoBook photoBook = new PhotoBook(24);
        Console.WriteLine(photoBook.GetNumberPages);
        Console.WriteLine(new BigPhotoBook().Page);
        BigPhotoBookInit bigPhotoBookInit = new BigPhotoBookInit { Page = 64 };
        Console.WriteLine(bigPhotoBookInit.Page);
    }
}
