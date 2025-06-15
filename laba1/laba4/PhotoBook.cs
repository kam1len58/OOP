namespace WorkFour;

class PhotoBook
{
    private int _numPages { get; set; }

    public int GetNumberPages => _numPages;


    public PhotoBook()
    {
        _numPages = 16;
    }

    public PhotoBook(int numPages)
    {
        _numPages = numPages;
    }
}
