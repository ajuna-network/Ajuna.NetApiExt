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
using System;
using System.Collections.Generic;


namespace Ajuna.NetApi.Model.PalletBagsList
{
    
    
    /// <summary>
    /// >> 507 - Composite[pallet_bags_list.list.Bag]
    /// </summary>
    public sealed class Bag : BaseType
    {
        
        /// <summary>
        /// >> head
        /// </summary>
        private BaseOpt<Ajuna.NetApi.Model.SpCore.AccountId32> _head;
        
        /// <summary>
        /// >> tail
        /// </summary>
        private BaseOpt<Ajuna.NetApi.Model.SpCore.AccountId32> _tail;
        
        public BaseOpt<Ajuna.NetApi.Model.SpCore.AccountId32> Head
        {
            get
            {
                return this._head;
            }
            set
            {
                this._head = value;
            }
        }
        
        public BaseOpt<Ajuna.NetApi.Model.SpCore.AccountId32> Tail
        {
            get
            {
                return this._tail;
            }
            set
            {
                this._tail = value;
            }
        }
        
        public override string TypeName()
        {
            return "Bag";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Head.Encode());
            result.AddRange(Tail.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Head = new BaseOpt<Ajuna.NetApi.Model.SpCore.AccountId32>();
            Head.Decode(byteArray, ref p);
            Tail = new BaseOpt<Ajuna.NetApi.Model.SpCore.AccountId32>();
            Tail.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}