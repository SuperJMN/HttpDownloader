﻿using System.IO;
using System.Reactive.Subjects;
using System.Threading.Tasks;

namespace HttpDownloader
{
    public interface IHttpDownloader
    {
        Task Download(string url, string path, IDownloadProgress progressObserver = null,
            Subject<long> written = null, int timeout = 30);

        Task<Stream> GetStream(string url, IDownloadProgress progress = null, int timeout = 30);
    }
}