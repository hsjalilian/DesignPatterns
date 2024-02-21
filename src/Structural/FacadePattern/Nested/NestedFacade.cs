namespace FacadePattern.Nested;
public class NestedFacade
{
    private ImageConvertor _imageConvertor;

    public NestedFacade()
    {
        _imageConvertor = new ImageConvertor();
    }

    public string ConvertImageFileToText(string path)
    {
        return _imageConvertor.ConvertByteToText(path);
    }
}
