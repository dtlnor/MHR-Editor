﻿using System.Diagnostics.CodeAnalysis;
using System.IO;
using MHR_Editor.Common.Models;

namespace MHR_Editor.Common.Structs;

[SuppressMessage("ReSharper", "UnusedAutoPropertyAccessor.Global")]
public class Int2 : RszObject, IViaType {
    public int X { get; set; }
    public int Y { get; set; }

    public void Read(BinaryReader reader) {
        X = reader.ReadInt32();
        Y = reader.ReadInt32();
    }
}