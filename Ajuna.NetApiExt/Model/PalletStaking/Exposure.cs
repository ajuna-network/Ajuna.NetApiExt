//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi.Model.PalletStaking;
using Ajuna.NetApi.Model.Types.Base;
using Ajuna.NetApi.Model.Types.Primitive;
using System;
using System.Collections.Generic;


namespace Ajuna.NetApi.Model.PalletStaking
{
    
    
    /// <summary>
    /// >> 62 - Composite[pallet_staking.Exposure]
    /// </summary>
    public sealed class Exposure : BaseType
    {
        
        /// <summary>
        /// >> total
        /// </summary>
        private BaseCom<Ajuna.NetApi.Model.Types.Primitive.U128> _total;
        
        /// <summary>
        /// >> own
        /// </summary>
        private BaseCom<Ajuna.NetApi.Model.Types.Primitive.U128> _own;
        
        /// <summary>
        /// >> others
        /// </summary>
        private BaseVec<Ajuna.NetApi.Model.PalletStaking.IndividualExposure> _others;
        
        public BaseCom<Ajuna.NetApi.Model.Types.Primitive.U128> Total
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
        
        public BaseCom<Ajuna.NetApi.Model.Types.Primitive.U128> Own
        {
            get
            {
                return this._own;
            }
            set
            {
                this._own = value;
            }
        }
        
        public BaseVec<Ajuna.NetApi.Model.PalletStaking.IndividualExposure> Others
        {
            get
            {
                return this._others;
            }
            set
            {
                this._others = value;
            }
        }
        
        public override string TypeName()
        {
            return "Exposure";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Total.Encode());
            result.AddRange(Own.Encode());
            result.AddRange(Others.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Total = new BaseCom<Ajuna.NetApi.Model.Types.Primitive.U128>();
            Total.Decode(byteArray, ref p);
            Own = new BaseCom<Ajuna.NetApi.Model.Types.Primitive.U128>();
            Own.Decode(byteArray, ref p);
            Others = new BaseVec<Ajuna.NetApi.Model.PalletStaking.IndividualExposure>();
            Others.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
