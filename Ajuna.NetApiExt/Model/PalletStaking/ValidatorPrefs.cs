//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi.Model.SpArithmetic;
using Ajuna.NetApi.Model.Types.Base;
using Ajuna.NetApi.Model.Types.Primitive;
using System;
using System.Collections.Generic;


namespace Ajuna.NetApi.Model.PalletStaking
{
    
    
    /// <summary>
    /// >> 200 - Composite[pallet_staking.ValidatorPrefs]
    /// </summary>
    public sealed class ValidatorPrefs : BaseType
    {
        
        /// <summary>
        /// >> commission
        /// </summary>
        private BaseCom<Ajuna.NetApi.Model.SpArithmetic.Perbill> _commission;
        
        /// <summary>
        /// >> blocked
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.Bool _blocked;
        
        public BaseCom<Ajuna.NetApi.Model.SpArithmetic.Perbill> Commission
        {
            get
            {
                return this._commission;
            }
            set
            {
                this._commission = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.Bool Blocked
        {
            get
            {
                return this._blocked;
            }
            set
            {
                this._blocked = value;
            }
        }
        
        public override string TypeName()
        {
            return "ValidatorPrefs";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Commission.Encode());
            result.AddRange(Blocked.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Commission = new BaseCom<Ajuna.NetApi.Model.SpArithmetic.Perbill>();
            Commission.Decode(byteArray, ref p);
            Blocked = new Ajuna.NetApi.Model.Types.Primitive.Bool();
            Blocked.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}