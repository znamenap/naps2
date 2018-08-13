﻿using System;
using System.Collections.Generic;
using System.Linq;

#if WINDOWS

namespace NAPS2.Scan.Wia
{
    using WIA;

    public class WiaState
    {
        public WiaState(Device device, Item item)
        {
            Item = item;
            Device = device;
        }

        public Device Device { get; }

        public Item Item { get; }
    }
}

#endif
