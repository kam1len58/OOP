namespace Laba4;

class PhotoBook
{
    private int numPages { get; set; }

    public int GetNumberPages
    {
        get { return numPages; }
    }

    public PhotoBook()
    {
        numPages = 16;
    }

    public PhotoBook(int _numPages)
    {
        numPages = _numPages;
    }
}
