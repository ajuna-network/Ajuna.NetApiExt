//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi.Model.PalletIdentity;
using Ajuna.NetApi.Model.Types.Base;
using System;
using System.Collections.Generic;


namespace Ajuna.NetApi.Model.FrameSupport
{
    
    
    /// <summary>
    /// >> 439 - Composite[frame_support.storage.bounded_vec.BoundedVecT12]
    /// </summary>
    public sealed class BoundedVecT12 : BaseType
    {
        
        /// <summary>
        /// >> value
        /// </summary>
        private BaseVec<BaseOpt<Ajuna.NetApi.Model.PalletIdentity.RegistrarInfo>> _value;
        
        public BaseVec<BaseOpt<Ajuna.NetApi.Model.PalletIdentity.RegistrarInfo>> Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }
        
        public override string TypeName()
        {
            return "BoundedVecT12";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Value.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Value = new BaseVec<BaseOpt<Ajuna.NetApi.Model.PalletIdentity.RegistrarInfo>>();
            Value.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}