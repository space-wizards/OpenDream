﻿using System.Collections.Generic;

namespace OpenDreamShared.Interface {
    public class MacroSetDescriptor {
        public string Name;
        public List<MacroDescriptor> Macros;

        public MacroSetDescriptor(string name, List<MacroDescriptor> macros) {
            Name = name;
            Macros = macros;
        }
    }

    public class MacroDescriptor : ElementDescriptor {
        [InterfaceAttribute("command")]
        public string Command;

        public MacroDescriptor() : base(null) { }
    }
}
