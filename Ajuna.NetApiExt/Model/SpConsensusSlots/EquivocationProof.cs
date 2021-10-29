//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi.Model.SpConsensusBabe;
using Ajuna.NetApi.Model.SpConsensusSlots;
using Ajuna.NetApi.Model.SpRuntime;
using Ajuna.NetApi.Model.Types.Base;
using System;
using System.Collections.Generic;


namespace Ajuna.NetApi.Model.SpConsensusSlots
{
    
    
    /// <summary>
    /// >> 126 - Composite[sp_consensus_slots.EquivocationProof]
    /// </summary>
    public sealed class EquivocationProof : BaseType
    {
        
        /// <summary>
        /// >> offender
        /// </summary>
        private Ajuna.NetApi.Model.SpConsensusBabe.Public _offender;
        
        /// <summary>
        /// >> slot
        /// </summary>
        private Ajuna.NetApi.Model.SpConsensusSlots.Slot _slot;
        
        /// <summary>
        /// >> first_header
        /// </summary>
        private Ajuna.NetApi.Model.SpRuntime.Header _firstHeader;
        
        /// <summary>
        /// >> second_header
        /// </summary>
        private Ajuna.NetApi.Model.SpRuntime.Header _secondHeader;
        
        public Ajuna.NetApi.Model.SpConsensusBabe.Public Offender
        {
            get
            {
                return this._offender;
            }
            set
            {
                this._offender = value;
            }
        }
        
        public Ajuna.NetApi.Model.SpConsensusSlots.Slot Slot
        {
            get
            {
                return this._slot;
            }
            set
            {
                this._slot = value;
            }
        }
        
        public Ajuna.NetApi.Model.SpRuntime.Header FirstHeader
        {
            get
            {
                return this._firstHeader;
            }
            set
            {
                this._firstHeader = value;
            }
        }
        
        public Ajuna.NetApi.Model.SpRuntime.Header SecondHeader
        {
            get
            {
                return this._secondHeader;
            }
            set
            {
                this._secondHeader = value;
            }
        }
        
        public override string TypeName()
        {
            return "EquivocationProof";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Offender.Encode());
            result.AddRange(Slot.Encode());
            result.AddRange(FirstHeader.Encode());
            result.AddRange(SecondHeader.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Offender = new Ajuna.NetApi.Model.SpConsensusBabe.Public();
            Offender.Decode(byteArray, ref p);
            Slot = new Ajuna.NetApi.Model.SpConsensusSlots.Slot();
            Slot.Decode(byteArray, ref p);
            FirstHeader = new Ajuna.NetApi.Model.SpRuntime.Header();
            FirstHeader.Decode(byteArray, ref p);
            SecondHeader = new Ajuna.NetApi.Model.SpRuntime.Header();
            SecondHeader.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
