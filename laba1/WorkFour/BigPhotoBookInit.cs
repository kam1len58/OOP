namespace WorkFour;

class BigPhotoBookInit : PhotoBook
{
    public int Page { get; private set; }

    public BigPhotoBookInit(int page)
    {
        Page = page;
    }
}
