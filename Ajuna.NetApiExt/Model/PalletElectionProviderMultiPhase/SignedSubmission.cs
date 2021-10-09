//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi.Model.PalletElectionProviderMultiPhase;
using Ajuna.NetApi.Model.SpCore;
using Ajuna.NetApi.Model.Types.Base;
using Ajuna.NetApi.Model.Types.Primitive;
using System;
using System.Collections.Generic;


namespace Ajuna.NetApi.Model.PalletElectionProviderMultiPhase
{
    
    
    /// <summary>
    /// >> 343 - Composite[pallet_election_provider_multi_phase.signed.SignedSubmission]
    /// </summary>
    public sealed class SignedSubmission : BaseType
    {
        
        /// <summary>
        /// >> who
        /// </summary>
        private Ajuna.NetApi.Model.SpCore.AccountId32 _who;
        
        /// <summary>
        /// >> deposit
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U128 _deposit;
        
        /// <summary>
        /// >> raw_solution
        /// </summary>
        private Ajuna.NetApi.Model.PalletElectionProviderMultiPhase.RawSolution _rawSolution;
        
        /// <summary>
        /// >> reward
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U128 _reward;
        
        public Ajuna.NetApi.Model.SpCore.AccountId32 Who
        {
            get
            {
                return this._who;
            }
            set
            {
                this._who = value;
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
        
        public Ajuna.NetApi.Model.PalletElectionProviderMultiPhase.RawSolution RawSolution
        {
            get
            {
                return this._rawSolution;
            }
            set
            {
                this._rawSolution = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U128 Reward
        {
            get
            {
                return this._reward;
            }
            set
            {
                this._reward = value;
            }
        }
        
        public override string TypeName()
        {
            return "SignedSubmission";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Who.Encode());
            result.AddRange(Deposit.Encode());
            result.AddRange(RawSolution.Encode());
            result.AddRange(Reward.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Who = new Ajuna.NetApi.Model.SpCore.AccountId32();
            Who.Decode(byteArray, ref p);
            Deposit = new Ajuna.NetApi.Model.Types.Primitive.U128();
            Deposit.Decode(byteArray, ref p);
            RawSolution = new Ajuna.NetApi.Model.PalletElectionProviderMultiPhase.RawSolution();
            RawSolution.Decode(byteArray, ref p);
            Reward = new Ajuna.NetApi.Model.Types.Primitive.U128();
            Reward.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}