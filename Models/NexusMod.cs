﻿using System;
using System.Collections.Generic;
using JetBrains.Annotations;
using MHR_Editor.Common.Models;

namespace MHR_Editor.Models;

public interface INexusMod {
    string                  Name     { get; set; }
    [CanBeNull] string      Filename { get; set; }
    string                  Desc     { get; set; }
    string                  Version  { get; set; }
    IEnumerable<string>     Files    { get; set; }
    Action<List<RszObject>> Action   { get; set; }
}

public interface INexusModVariant : INexusMod {
    string NameAsBundle { get; set; }
}

public struct NexusMod : INexusMod {
    public string                  Name     { get; set; }
    public string                  Filename { get; set; }
    public string                  Desc     { get; set; }
    public string                  Version  { get; set; }
    public IEnumerable<string>     Files    { get; set; }
    public Action<List<RszObject>> Action   { get; set; }

    public static NexusMod FromVariant(NexusModVariant variant) {
        return new() {
            Name     = variant.Name,
            Filename = variant.Filename,
            Version  = variant.Version,
            Files    = variant.Files,
            Action   = variant.Action
        };
    }
}

public struct NexusModVariant : INexusModVariant {
    public string                  Name         { get; set; }
    public string                  Filename     { get; set; }
    public string                  Desc         { get; set; }
    public string                  Version      { get; set; }
    public IEnumerable<string>     Files        { get; set; }
    public Action<List<RszObject>> Action       { get; set; }
    public string                  NameAsBundle { get; set; }
}

public static class NexusModExtensions {
    public static T SetName<T>(this T nexusMod, string name) where T : INexusMod {
        nexusMod.Name = name;
        return nexusMod;
    }

    public static T SetFilename<T>(this T nexusMod, string filename) where T : INexusMod {
        nexusMod.Filename = filename;
        return nexusMod;
    }

    public static T SetDesc<T>(this T nexusMod, string desc) where T : INexusMod {
        nexusMod.Desc = desc;
        return nexusMod;
    }

    public static T SetVersion<T>(this T nexusMod, string version) where T : INexusMod {
        nexusMod.Version = version;
        return nexusMod;
    }

    public static T SetFiles<T>(this T nexusMod, IEnumerable<string> files) where T : INexusMod {
        nexusMod.Files = files;
        return nexusMod;
    }

    public static T SetAction<T>(this T nexusMod, Action<List<RszObject>> action) where T : INexusMod {
        nexusMod.Action = action;
        return nexusMod;
    }

    public static T SetNameAsBundle<T>(this T nexusMod, string nameAsBundle) where T : INexusModVariant {
        nexusMod.NameAsBundle = nameAsBundle;
        return nexusMod;
    }
}