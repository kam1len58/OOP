namespace WorkFour;

class PhotoBookTest
{
    public static void Test()
    {
        PhotoBook book = new PhotoBook();
        Console.WriteLine(book.NumberPages);
        PhotoBook photoBook = new PhotoBook(24);
        Console.WriteLine(photoBook.NumberPages);
        Console.WriteLine(new BigPhotoBook().Page);
        BigPhotoBookInit bigPhotoBookInit = new BigPhotoBookInit { Page = 64 };
        Console.WriteLine(bigPhotoBookInit.Page);
    }
}
