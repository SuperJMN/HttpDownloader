using System.Reactive.Subjects;

namespace HttpDownloader
{
    public class DownloadProgress : IDownloadProgress
    {
        public ISubject<double> Percentage { get; set; } = new BehaviorSubject<double>(double.NaN);
        public ISubject<long> BytesDownloaded { get; set; } = new BehaviorSubject<long>(0L);
    }
}