//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi.Model.PrimitiveTypes;
using Ajuna.NetApi.Model.SpCore;
using Ajuna.NetApi.Model.Types.Base;
using Ajuna.NetApi.Model.Types.Primitive;
using System;
using System.Collections.Generic;


namespace Ajuna.NetApi.Model.PalletAuthorship
{
    
    
    public enum UncleEntryItem
    {
        
        InclusionHeight,
        
        Uncle,
    }
    
    /// <summary>
    /// >> 323 - Variant[pallet_authorship.UncleEntryItem]
    /// </summary>
    public sealed class EnumUncleEntryItem : BaseEnumExt<UncleEntryItem, Ajuna.NetApi.Model.Types.Primitive.U32, BaseTuple<Ajuna.NetApi.Model.PrimitiveTypes.H256, BaseOpt<Ajuna.NetApi.Model.SpCore.AccountId32>>>
    {
    }
}
