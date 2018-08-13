﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace NAPS2.Scan.Wia
{
    public class BackgroundWiaTransfer : IWiaTransfer
    {
        public Stream Transfer(int pageNumber, WiaBackgroundEventLoop eventLoop, string format)
        {
            // The console shouldn't spawn new forms, so use the silent transfer method.
            return eventLoop.GetSync(wia => WiaApi.Transfer(wia, format, false));
        }
    }
}