﻿namespace Glovebox.Components.Drivers {
    public class LedDriver {
        public enum Display : byte {
            On,
            Off,
        }

        public enum BlinkRate : byte {
            Off,
            Fast,
            Medium,
            Slow,
        }
    }
}
