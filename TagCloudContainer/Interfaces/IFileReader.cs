using TagCloudContainer.Result;

namespace TagCloudContainer.Interfaces
{
    public interface IFileReader
    {
        Result<string> ReadFile(string path);
        string TxtRead(string path);
        string DocRead(string path);
    }
}
