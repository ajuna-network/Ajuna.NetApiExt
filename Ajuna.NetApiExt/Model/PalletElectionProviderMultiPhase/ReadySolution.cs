//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi.Model.Base;
using Ajuna.NetApi.Model.PalletElectionProviderMultiPhase;
using Ajuna.NetApi.Model.SpCore;
using Ajuna.NetApi.Model.SpNposElections;
using Ajuna.NetApi.Model.Types.Base;
using System;
using System.Collections.Generic;


namespace Ajuna.NetApi.Model.PalletElectionProviderMultiPhase
{
    
    
    /// <summary>
    /// >> 335 - Composite[pallet_election_provider_multi_phase.ReadySolution]
    /// </summary>
    public sealed class ReadySolution : BaseType
    {
        
        /// <summary>
        /// >> supports
        /// </summary>
        private BaseVec<BaseTuple<Ajuna.NetApi.Model.SpCore.AccountId32,Ajuna.NetApi.Model.SpNposElections.Support>> _supports;
        
        /// <summary>
        /// >> score
        /// </summary>
        private Ajuna.NetApi.Model.Base.Arr3U128 _score;
        
        /// <summary>
        /// >> compute
        /// </summary>
        private Ajuna.NetApi.Model.PalletElectionProviderMultiPhase.EnumElectionCompute _compute;
        
        public BaseVec<BaseTuple<Ajuna.NetApi.Model.SpCore.AccountId32,Ajuna.NetApi.Model.SpNposElections.Support>> Supports
        {
            get
            {
                return this._supports;
            }
            set
            {
                this._supports = value;
            }
        }
        
        public Ajuna.NetApi.Model.Base.Arr3U128 Score
        {
            get
            {
                return this._score;
            }
            set
            {
                this._score = value;
            }
        }
        
        public Ajuna.NetApi.Model.PalletElectionProviderMultiPhase.EnumElectionCompute Compute
        {
            get
            {
                return this._compute;
            }
            set
            {
                this._compute = value;
            }
        }
        
        public override string TypeName()
        {
            return "ReadySolution";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Supports.Encode());
            result.AddRange(Score.Encode());
            result.AddRange(Compute.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Supports = new BaseVec<BaseTuple<Ajuna.NetApi.Model.SpCore.AccountId32,Ajuna.NetApi.Model.SpNposElections.Support>>();
            Supports.Decode(byteArray, ref p);
            Score = new Ajuna.NetApi.Model.Base.Arr3U128();
            Score.Decode(byteArray, ref p);
            Compute = new Ajuna.NetApi.Model.PalletElectionProviderMultiPhase.EnumElectionCompute();
            Compute.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}