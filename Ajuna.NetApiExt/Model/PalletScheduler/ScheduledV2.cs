//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi.Model.NodeRuntime;
using Ajuna.NetApi.Model.Types.Base;
using Ajuna.NetApi.Model.Types.Primitive;
using System;
using System.Collections.Generic;


namespace Ajuna.NetApi.Model.PalletScheduler
{
    
    
    /// <summary>
    /// >> 454 - Composite[pallet_scheduler.ScheduledV2]
    /// </summary>
    public sealed class ScheduledV2 : BaseType
    {
        
        /// <summary>
        /// >> maybe_id
        /// </summary>
        private BaseOpt<BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8>> _maybeId;
        
        /// <summary>
        /// >> priority
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U8 _priority;
        
        /// <summary>
        /// >> call
        /// </summary>
        private Ajuna.NetApi.Model.NodeRuntime.EnumNodeCall _call;
        
        /// <summary>
        /// >> maybe_periodic
        /// </summary>
        private BaseOpt<BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32,Ajuna.NetApi.Model.Types.Primitive.U32>> _maybePeriodic;
        
        /// <summary>
        /// >> origin
        /// </summary>
        private Ajuna.NetApi.Model.NodeRuntime.EnumOriginCaller _origin;
        
        public BaseOpt<BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8>> MaybeId
        {
            get
            {
                return this._maybeId;
            }
            set
            {
                this._maybeId = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U8 Priority
        {
            get
            {
                return this._priority;
            }
            set
            {
                this._priority = value;
            }
        }
        
        public Ajuna.NetApi.Model.NodeRuntime.EnumNodeCall Call
        {
            get
            {
                return this._call;
            }
            set
            {
                this._call = value;
            }
        }
        
        public BaseOpt<BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32,Ajuna.NetApi.Model.Types.Primitive.U32>> MaybePeriodic
        {
            get
            {
                return this._maybePeriodic;
            }
            set
            {
                this._maybePeriodic = value;
            }
        }
        
        public Ajuna.NetApi.Model.NodeRuntime.EnumOriginCaller Origin
        {
            get
            {
                return this._origin;
            }
            set
            {
                this._origin = value;
            }
        }
        
        public override string TypeName()
        {
            return "ScheduledV2";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(MaybeId.Encode());
            result.AddRange(Priority.Encode());
            result.AddRange(Call.Encode());
            result.AddRange(MaybePeriodic.Encode());
            result.AddRange(Origin.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            MaybeId = new BaseOpt<BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8>>();
            MaybeId.Decode(byteArray, ref p);
            Priority = new Ajuna.NetApi.Model.Types.Primitive.U8();
            Priority.Decode(byteArray, ref p);
            Call = new Ajuna.NetApi.Model.NodeRuntime.EnumNodeCall();
            Call.Decode(byteArray, ref p);
            MaybePeriodic = new BaseOpt<BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32,Ajuna.NetApi.Model.Types.Primitive.U32>>();
            MaybePeriodic.Decode(byteArray, ref p);
            Origin = new Ajuna.NetApi.Model.NodeRuntime.EnumOriginCaller();
            Origin.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
