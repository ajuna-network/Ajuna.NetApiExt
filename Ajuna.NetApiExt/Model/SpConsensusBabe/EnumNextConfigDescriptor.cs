//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi.Model.SpConsensusBabe;
using Ajuna.NetApi.Model.Types.Base;
using Ajuna.NetApi.Model.Types.Primitive;
using System;
using System.Collections.Generic;


namespace Ajuna.NetApi.Model.SpConsensusBabe
{
    
    
    public enum NextConfigDescriptor
    {
        
        V1,
    }
    
    /// <summary>
    /// >> 128 - Variant[sp_consensus_babe.digests.NextConfigDescriptor]
    /// </summary>
    public sealed class EnumNextConfigDescriptor : BaseEnumExt<NextConfigDescriptor, BaseTuple<BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U64,Ajuna.NetApi.Model.Types.Primitive.U64>, Ajuna.NetApi.Model.SpConsensusBabe.EnumAllowedSlots>>
    {
    }
}
