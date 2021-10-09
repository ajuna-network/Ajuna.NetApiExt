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
using Ajuna.NetApi.Model.Types.Primitive;
using System;
using System.Collections.Generic;


namespace Ajuna.NetApi.Model.PalletStaking
{
    
    
    /// <summary>
    /// >> 351 - Composite[pallet_staking.EraRewardPoints]
    /// </summary>
    public sealed class EraRewardPoints : BaseType
    {
        
        /// <summary>
        /// >> total
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _total;
        
        /// <summary>
        /// >> individual
        /// </summary>
        private Ajuna.NetApi.Model.Base.BTreeMap _individual;
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 Total
        {
            get
            {
                return this._total;
            }
            set
            {
                this._total = value;
            }
        }
        
        public Ajuna.NetApi.Model.Base.BTreeMap Individual
        {
            get
            {
                return this._individual;
            }
            set
            {
                this._individual = value;
            }
        }
        
        public override string TypeName()
        {
            return "EraRewardPoints";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Total.Encode());
            result.AddRange(Individual.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Total = new Ajuna.NetApi.Model.Types.Primitive.U32();
            Total.Decode(byteArray, ref p);
            Individual = new Ajuna.NetApi.Model.Base.BTreeMap();
            Individual.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
