﻿using System;

namespace SmartStore.Services.Media
{
    public sealed class MediaFileNotFoundException : SmartException
    {
        public MediaFileNotFoundException(string path)
            : base($"Media file {path} does not exist.")
        {
        }
    }

    public sealed class MediaFolderNotFoundException : SmartException
    {
        public MediaFolderNotFoundException(string path)
            : base($"Media folder {path} does not exist.")
        {
        }
    }

    public sealed class DuplicateMediaFileException : SmartException
    {
        public DuplicateMediaFileException(string fullPath)
            : base($"File {fullPath} already exists.")
        {
        }
    }

    public sealed class NotSameAlbumException : SmartException
    {
        public NotSameAlbumException(string path1, string path2)
            : base($"The file operation requires that the destination path belongs to the source album. Source: {path1}, Destination: {path2}.")
        {
        }
    }
}
