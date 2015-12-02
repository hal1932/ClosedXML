﻿
using System.Collections.Generic;

namespace ClosedXML.Excel
{
    public interface IXLPicture
    {
        string FilePath { get; set; }

        string Name { get; set; }
        string Description { get; set; }

        int WidthPx { get; set; }
        int HeightPx { get; set; }

        XLPictureType Type { get; set; }

        bool CanUserChangeAspect { get; set; }
        bool CanUserCrop { get; set; }
        bool CanUserMove { get; set; }
        bool CanUserResize { get; set; }
        bool CanUserRotate { get; set; }
        bool CanUserSelect { get; set; }

        IEnumerable<IXLMarker> GetMarkers();
    }

    public interface IXLPictures : IEnumerable<IXLPicture>
    {
        void Add(IXLPicture picture);
    }
}
