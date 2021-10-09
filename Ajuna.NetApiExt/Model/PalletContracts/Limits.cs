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
    /// >> 409 - Composite[pallet_contracts.schedule.Limits]
    /// </summary>
    public sealed class Limits : BaseType
    {
        
        /// <summary>
        /// >> event_topics
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _eventTopics;
        
        /// <summary>
        /// >> stack_height
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _stackHeight;
        
        /// <summary>
        /// >> globals
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _globals;
        
        /// <summary>
        /// >> parameters
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _parameters;
        
        /// <summary>
        /// >> memory_pages
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _memoryPages;
        
        /// <summary>
        /// >> table_size
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _tableSize;
        
        /// <summary>
        /// >> br_table_size
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _brTableSize;
        
        /// <summary>
        /// >> subject_len
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _subjectLen;
        
        /// <summary>
        /// >> call_depth
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _callDepth;
        
        /// <summary>
        /// >> payload_len
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _payloadLen;
        
        /// <summary>
        /// >> code_len
        /// </summary>
        private Ajuna.NetApi.Model.Types.Primitive.U32 _codeLen;
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 EventTopics
        {
            get
            {
                return this._eventTopics;
            }
            set
            {
                this._eventTopics = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 StackHeight
        {
            get
            {
                return this._stackHeight;
            }
            set
            {
                this._stackHeight = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 Globals
        {
            get
            {
                return this._globals;
            }
            set
            {
                this._globals = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 Parameters
        {
            get
            {
                return this._parameters;
            }
            set
            {
                this._parameters = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 MemoryPages
        {
            get
            {
                return this._memoryPages;
            }
            set
            {
                this._memoryPages = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 TableSize
        {
            get
            {
                return this._tableSize;
            }
            set
            {
                this._tableSize = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 BrTableSize
        {
            get
            {
                return this._brTableSize;
            }
            set
            {
                this._brTableSize = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 SubjectLen
        {
            get
            {
                return this._subjectLen;
            }
            set
            {
                this._subjectLen = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 CallDepth
        {
            get
            {
                return this._callDepth;
            }
            set
            {
                this._callDepth = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 PayloadLen
        {
            get
            {
                return this._payloadLen;
            }
            set
            {
                this._payloadLen = value;
            }
        }
        
        public Ajuna.NetApi.Model.Types.Primitive.U32 CodeLen
        {
            get
            {
                return this._codeLen;
            }
            set
            {
                this._codeLen = value;
            }
        }
        
        public override string TypeName()
        {
            return "Limits";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(EventTopics.Encode());
            result.AddRange(StackHeight.Encode());
            result.AddRange(Globals.Encode());
            result.AddRange(Parameters.Encode());
            result.AddRange(MemoryPages.Encode());
            result.AddRange(TableSize.Encode());
            result.AddRange(BrTableSize.Encode());
            result.AddRange(SubjectLen.Encode());
            result.AddRange(CallDepth.Encode());
            result.AddRange(PayloadLen.Encode());
            result.AddRange(CodeLen.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            EventTopics = new Ajuna.NetApi.Model.Types.Primitive.U32();
            EventTopics.Decode(byteArray, ref p);
            StackHeight = new Ajuna.NetApi.Model.Types.Primitive.U32();
            StackHeight.Decode(byteArray, ref p);
            Globals = new Ajuna.NetApi.Model.Types.Primitive.U32();
            Globals.Decode(byteArray, ref p);
            Parameters = new Ajuna.NetApi.Model.Types.Primitive.U32();
            Parameters.Decode(byteArray, ref p);
            MemoryPages = new Ajuna.NetApi.Model.Types.Primitive.U32();
            MemoryPages.Decode(byteArray, ref p);
            TableSize = new Ajuna.NetApi.Model.Types.Primitive.U32();
            TableSize.Decode(byteArray, ref p);
            BrTableSize = new Ajuna.NetApi.Model.Types.Primitive.U32();
            BrTableSize.Decode(byteArray, ref p);
            SubjectLen = new Ajuna.NetApi.Model.Types.Primitive.U32();
            SubjectLen.Decode(byteArray, ref p);
            CallDepth = new Ajuna.NetApi.Model.Types.Primitive.U32();
            CallDepth.Decode(byteArray, ref p);
            PayloadLen = new Ajuna.NetApi.Model.Types.Primitive.U32();
            PayloadLen.Decode(byteArray, ref p);
            CodeLen = new Ajuna.NetApi.Model.Types.Primitive.U32();
            CodeLen.Decode(byteArray, ref p);
            TypeSize = p - start;
        }
    }
}
