//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi.Model.Types.Base;
using Ajuna.NetApi.Model.Types.Primitive;
using System;
using System.Collections.Generic;


namespace Ajuna.NetApi.Model.PalletIdentity
{
    
    
    public enum Judgement
    {
        
        Unknown,
        
        FeePaid,
        
        Reasonable,
        
        KnownGood,
        
        OutOfDate,
        
        LowQuality,
        
        Erroneous,
    }
    
    /// <summary>
    /// >> 280 - Variant[pallet_identity.types.Judgement]
    /// </summary>
    public sealed class EnumJudgement : BaseEnumExt<Judgement, BaseVoid, Ajuna.NetApi.Model.Types.Primitive.U128, BaseVoid, BaseVoid, BaseVoid, BaseVoid, BaseVoid>
    {
    }
}
