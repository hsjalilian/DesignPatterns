namespace FacadePattern.Single;
public class SingleFacade
{
    private FileManager _fileMnager;
    private ImageConvertor _imageConvertor;

    public SingleFacade()
    {
        _fileMnager = new FileManager();
        _imageConvertor = new ImageConvertor();
    }

    public string ConvertImageFileToText(string path)
    {
        var data = _fileMnager.ReadFile(path);
        return _imageConvertor.ConvertByteToText(data);
    }
}
