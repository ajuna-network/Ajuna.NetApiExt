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


namespace Ajuna.NetApi.Model.FrameSupport
{
    
    
    /// <summary>
    /// >> 7 - Composite[frame_support.weights.PerDispatchClassT1]
    /// </summary>
    public sealed class PerDispatchClassT1 : BaseType
    {
        
        /// <summary>
        /// >> normal
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U64 _normal;
        
        /// <summary>
        /// >> operational
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U64 _operational;
        
        /// <summary>
        /// >> mandatory
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U64 _mandatory;
        
        public Ajuna.NetApi.Model.Types.Primitive.U64 Normal
        {
            get
            {
                return this._normal;
            }
            set
            {
                this._normal = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U64 Operational
        {
            get
            {
                return this._operational;
            }
            set
            {
                this._operational = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U64 Mandatory
        {
            get
            {
                return this._mandatory;
            }
            set
            {
                this._mandatory = value;
            }
        }
        
        public override string TypeName()
        {
            return "PerDispatchClassT1";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Normal.Encode());
            result.AddRange(Operational.Encode());
            result.AddRange(Mandatory.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Normal = new Ajuna.NetApi.Model.Types.Primitive.U64();
            Normal.Decode(byteArray, ref p);
            Operational = new Ajuna.NetApi.Model.Types.Primitive.U64();
            Operational.Decode(byteArray, ref p);
            Mandatory = new Ajuna.NetApi.Model.Types.Primitive.U64();
            Mandatory.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
