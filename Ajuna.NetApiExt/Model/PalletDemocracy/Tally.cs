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


namespace Ajuna.NetApi.Model.PalletDemocracy
{
    
    
    /// <summary>
    /// >> 383 - Composite[pallet_democracy.types.Tally]
    /// </summary>
    public sealed class Tally : BaseType
    {
        
        /// <summary>
        /// >> ayes
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U128 _ayes;
        
        /// <summary>
        /// >> nays
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U128 _nays;
        
        /// <summary>
        /// >> turnout
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U128 _turnout;
        
        public Ajuna.NetApi.Model.Types.Primitive.U128 Ayes
        {
            get
            {
                return this._ayes;
            }
            set
            {
                this._ayes = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U128 Nays
        {
            get
            {
                return this._nays;
            }
            set
            {
                this._nays = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U128 Turnout
        {
            get
            {
                return this._turnout;
            }
            set
            {
                this._turnout = value;
            }
        }
        
        public override string TypeName()
        {
            return "Tally";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Ayes.Encode());
            result.AddRange(Nays.Encode());
            result.AddRange(Turnout.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Ayes = new Ajuna.NetApi.Model.Types.Primitive.U128();
            Ayes.Decode(byteArray, ref p);
            Nays = new Ajuna.NetApi.Model.Types.Primitive.U128();
            Nays.Decode(byteArray, ref p);
            Turnout = new Ajuna.NetApi.Model.Types.Primitive.U128();
            Turnout.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
