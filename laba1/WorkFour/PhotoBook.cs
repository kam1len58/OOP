namespace WorkFour;

class PhotoBook
{
    private int _numPages;

    public int NumberPages => _numPages;

    public PhotoBook()
    {
        _numPages = 16;
    }

    public PhotoBook(int numPages)
    {
        _numPages = numPages;
    }
}
