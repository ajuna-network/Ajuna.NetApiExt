//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi.Model.SpCore;
using Ajuna.NetApi.Model.Types.Base;
using Ajuna.NetApi.Model.Types.Primitive;
using System;
using System.Collections.Generic;


namespace Ajuna.NetApi.Model.PalletRecovery
{
    
    
    /// <summary>
    /// >> 454 - Composite[pallet_recovery.RecoveryConfig]
    /// </summary>
    public sealed class RecoveryConfig : BaseType
    {
        
        /// <summary>
        /// >> delay_period
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _delayPeriod;
        
        /// <summary>
        /// >> deposit
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U128 _deposit;
        
        /// <summary>
        /// >> friends
        /// </summary>
        private BaseVec<Ajuna.NetApi.Model.SpCore.AccountId32> _friends;
        
        /// <summary>
        /// >> threshold
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U16 _threshold;
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 DelayPeriod
        {
            get
            {
                return this._delayPeriod;
            }
            set
            {
                this._delayPeriod = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U128 Deposit
        {
            get
            {
                return this._deposit;
            }
            set
            {
                this._deposit = value;
            }
        }
        
        public BaseVec<Ajuna.NetApi.Model.SpCore.AccountId32> Friends
        {
            get
            {
                return this._friends;
            }
            set
            {
                this._friends = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U16 Threshold
        {
            get
            {
                return this._threshold;
            }
            set
            {
                this._threshold = value;
            }
        }
        
        public override string TypeName()
        {
            return "RecoveryConfig";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(DelayPeriod.Encode());
            result.AddRange(Deposit.Encode());
            result.AddRange(Friends.Encode());
            result.AddRange(Threshold.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            DelayPeriod = new Ajuna.NetApi.Model.Types.Primitive.U32();
            DelayPeriod.Decode(byteArray, ref p);
            Deposit = new Ajuna.NetApi.Model.Types.Primitive.U128();
            Deposit.Decode(byteArray, ref p);
            Friends = new BaseVec<Ajuna.NetApi.Model.SpCore.AccountId32>();
            Friends.Decode(byteArray, ref p);
            Threshold = new Ajuna.NetApi.Model.Types.Primitive.U16();
            Threshold.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
