namespace dotnet_code_challenge
{
    public interface IReadData
    {
        dynamic FileData { get; set; }
        string FilePath { get; set; }
        char FileType { get; set; }
        void GetFileData();
        bool IsFileHasData();
    }
}