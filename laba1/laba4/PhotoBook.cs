namespace laba4;

class PhotoBook
{
    private int numPages { get; set; }

    public int GetNumberPages()
    {
        return numPages;
    }

    public PhotoBook()
    {
        numPages = 16;
    }

    public PhotoBook(int page)
    {
        numPages = page;
    }
}
