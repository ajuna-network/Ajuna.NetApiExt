//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi.Model.Base;
using Ajuna.NetApi.Model.Types.Base;
using System;
using System.Collections.Generic;


namespace Ajuna.NetApi.Model.SpCore
{
    
    
    /// <summary>
    /// >> 529 - Composite[sp_core.ecdsa.Signature]
    /// </summary>
    public sealed class Signature : BaseType
    {
        
        /// <summary>
        /// >> value
        /// </summary>
        private Ajuna.NetApi.Model.Base.Arr65U8 _value;
        
        public Ajuna.NetApi.Model.Base.Arr65U8 Value
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
            return "Signature";
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
            Value = new Ajuna.NetApi.Model.Base.Arr65U8();
            Value.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
