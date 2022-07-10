﻿using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using MHR_Editor.Common;
using MHR_Editor.Common.Attributes;
using MHR_Editor.Common.Data;
using MHR_Editor.Common.Models.List_Wrappers;
using MHR_Editor.Generated.Models;

namespace MHR_Editor.Models.Structs;

[SuppressMessage("ReSharper", "InconsistentNaming")]
[SuppressMessage("ReSharper", "UnusedMember.Global")]
[SuppressMessage("ReSharper", "ClassNeverInstantiated.Global")]
[SuppressMessage("ReSharper", "UnusedType.Global")]
public partial class Snow_equip_OtOverwearRecipeUserData_Param : ICraftingCost {
    [SortOrder(50)]
    public string Name => DataHelper.CAT_DOG_ARMOR_NAME_LOOKUP[Global.locale].TryGet(Id);

    [SortOrder(int.MaxValue)]
    public string Description => DataHelper.CAT_DOG_ARMOR_DESC_LOOKUP[Global.locale].TryGet(Id);

    public override string ToString() {
        return Name;
    }

    [DisplayName("")]
    public ObservableCollection<DataSourceWrapper<uint>> ItemIdList {
        get => RequiredItem;
        set => RequiredItem = value;
    }

    [DisplayName("")]
    public ObservableCollection<GenericWrapper<uint>> ItemNumList {
        get => RequiredNum;
        set => RequiredNum = value;
    }
}