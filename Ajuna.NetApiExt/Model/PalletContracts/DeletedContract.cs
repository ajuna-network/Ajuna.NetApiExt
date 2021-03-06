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


namespace Ajuna.NetApi.Model.PalletContracts
{
    
    
    /// <summary>
    /// >> 407 - Composite[pallet_contracts.storage.DeletedContract]
    /// </summary>
    public sealed class DeletedContract : BaseType
    {
        
        /// <summary>
        /// >> trie_id
        /// </summary>
        private BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8> _trieId;
        
        public BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8> TrieId
        {
            get
            {
                return this._trieId;
            }
            set
            {
                this._trieId = value;
            }
        }
        
        public override string TypeName()
        {
            return "DeletedContract";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(TrieId.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            TrieId = new BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8>();
            TrieId.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
