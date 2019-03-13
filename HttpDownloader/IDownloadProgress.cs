using System.Reactive.Subjects;

namespace HttpDownloader
{
    public interface IDownloadProgress
    {
        ISubject<double> Percentage { get; set; }
        ISubject<long> BytesDownloaded { get; set; }
    }
}