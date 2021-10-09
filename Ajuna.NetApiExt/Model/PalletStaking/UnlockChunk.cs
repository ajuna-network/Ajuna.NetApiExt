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


namespace Ajuna.NetApi.Model.PalletStaking
{
    
    
    /// <summary>
    /// >> 347 - Composite[pallet_staking.UnlockChunk]
    /// </summary>
    public sealed class UnlockChunk : BaseType
    {
        
        /// <summary>
        /// >> value
        /// </summary>
        private BaseCom<Ajuna.NetApi.Model.Types.Primitive.U128> _value;
        
        /// <summary>
        /// >> era
        /// </summary>
        private BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32> _era;
        
        public BaseCom<Ajuna.NetApi.Model.Types.Primitive.U128> Value
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
        
        public BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32> Era
        {
            get
            {
                return this._era;
            }
            set
            {
                this._era = value;
            }
        }
        
        public override string TypeName()
        {
            return "UnlockChunk";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Value.Encode());
            result.AddRange(Era.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Value = new BaseCom<Ajuna.NetApi.Model.Types.Primitive.U128>();
            Value.Decode(byteArray, ref p);
            Era = new BaseCom<Ajuna.NetApi.Model.Types.Primitive.U32>();
            Era.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
