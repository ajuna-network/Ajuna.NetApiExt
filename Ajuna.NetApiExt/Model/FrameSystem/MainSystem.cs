//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi.Model.Extrinsics;
using Ajuna.NetApi.Model.FrameSupport;
using Ajuna.NetApi.Model.FrameSystem;
using Ajuna.NetApi.Model.Meta;
using Ajuna.NetApi.Model.PrimitiveTypes;
using Ajuna.NetApi.Model.SpArithmetic;
using Ajuna.NetApi.Model.SpCore;
using Ajuna.NetApi.Model.SpRuntime;
using Ajuna.NetApi.Model.Types;
using Ajuna.NetApi.Model.Types.Base;
using Ajuna.NetApi.Model.Types.Primitive;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace Ajuna.NetApi.Model.FrameSystem
{
    
    
    public sealed class SystemStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        public SystemStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("System", "Account"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(Ajuna.NetApi.Model.SpCore.AccountId32), typeof(Ajuna.NetApi.Model.FrameSystem.AccountInfo)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("System", "ExtrinsicCount"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Ajuna.NetApi.Model.Types.Primitive.U32)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("System", "BlockWeight"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Ajuna.NetApi.Model.FrameSupport.PerDispatchClass)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("System", "AllExtrinsicsLen"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Ajuna.NetApi.Model.Types.Primitive.U32)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("System", "BlockHash"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(Ajuna.NetApi.Model.Types.Primitive.U32), typeof(Ajuna.NetApi.Model.PrimitiveTypes.H256)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("System", "ExtrinsicData"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(Ajuna.NetApi.Model.Types.Primitive.U32), typeof(BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8>)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("System", "Number"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Ajuna.NetApi.Model.Types.Primitive.U32)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("System", "ParentHash"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Ajuna.NetApi.Model.PrimitiveTypes.H256)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("System", "Digest"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Ajuna.NetApi.Model.SpRuntime.Digest)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("System", "Events"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(BaseVec<Ajuna.NetApi.Model.FrameSystem.EventRecord>)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("System", "EventCount"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Ajuna.NetApi.Model.Types.Primitive.U32)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("System", "EventTopics"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(Ajuna.NetApi.Model.PrimitiveTypes.H256), typeof(BaseVec<BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32,Ajuna.NetApi.Model.Types.Primitive.U32>>)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("System", "LastRuntimeUpgrade"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Ajuna.NetApi.Model.FrameSystem.LastRuntimeUpgradeInfo)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("System", "UpgradedToU32RefCount"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Ajuna.NetApi.Model.Types.Primitive.Bool)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("System", "UpgradedToTripleRefCount"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Ajuna.NetApi.Model.Types.Primitive.Bool)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("System", "ExecutionPhase"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Ajuna.NetApi.Model.FrameSystem.EnumPhase)));
        }
        
        /// <summary>
        /// >> AccountParams
        ///  The full account information for a particular account ID.
        /// </summary>
        public static string AccountParams(Ajuna.NetApi.Model.SpCore.AccountId32 key)
        {
            return RequestGenerator.GetStorage("System", "Account", Ajuna.NetApi.Model.Meta.Storage.Type.Map, new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new Ajuna.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> Account
        ///  The full account information for a particular account ID.
        /// </summary>
        public async Task<Ajuna.NetApi.Model.FrameSystem.AccountInfo> Account(Ajuna.NetApi.Model.SpCore.AccountId32 key, CancellationToken token)
        {
            string parameters = SystemStorage.AccountParams(key);
            return await _client.GetStorageAsync<Ajuna.NetApi.Model.FrameSystem.AccountInfo>(parameters, token);
        }
        
        /// <summary>
        /// >> ExtrinsicCountParams
        ///  Total extrinsics count for the current block.
        /// </summary>
        public static string ExtrinsicCountParams()
        {
            return RequestGenerator.GetStorage("System", "ExtrinsicCount", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> ExtrinsicCount
        ///  Total extrinsics count for the current block.
        /// </summary>
        public async Task<Ajuna.NetApi.Model.Types.Primitive.U32> ExtrinsicCount(CancellationToken token)
        {
            string parameters = SystemStorage.ExtrinsicCountParams();
            return await _client.GetStorageAsync<Ajuna.NetApi.Model.Types.Primitive.U32>(parameters, token);
        }
        
        /// <summary>
        /// >> BlockWeightParams
        ///  The current weight for the block.
        /// </summary>
        public static string BlockWeightParams()
        {
            return RequestGenerator.GetStorage("System", "BlockWeight", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> BlockWeight
        ///  The current weight for the block.
        /// </summary>
        public async Task<Ajuna.NetApi.Model.FrameSupport.PerDispatchClass> BlockWeight(CancellationToken token)
        {
            string parameters = SystemStorage.BlockWeightParams();
            return await _client.GetStorageAsync<Ajuna.NetApi.Model.FrameSupport.PerDispatchClass>(parameters, token);
        }
        
        /// <summary>
        /// >> AllExtrinsicsLenParams
        ///  Total length (in bytes) for all extrinsics put together, for the current block.
        /// </summary>
        public static string AllExtrinsicsLenParams()
        {
            return RequestGenerator.GetStorage("System", "AllExtrinsicsLen", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> AllExtrinsicsLen
        ///  Total length (in bytes) for all extrinsics put together, for the current block.
        /// </summary>
        public async Task<Ajuna.NetApi.Model.Types.Primitive.U32> AllExtrinsicsLen(CancellationToken token)
        {
            string parameters = SystemStorage.AllExtrinsicsLenParams();
            return await _client.GetStorageAsync<Ajuna.NetApi.Model.Types.Primitive.U32>(parameters, token);
        }
        
        /// <summary>
        /// >> BlockHashParams
        ///  Map of block numbers to block hashes.
        /// </summary>
        public static string BlockHashParams(Ajuna.NetApi.Model.Types.Primitive.U32 key)
        {
            return RequestGenerator.GetStorage("System", "BlockHash", Ajuna.NetApi.Model.Meta.Storage.Type.Map, new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Ajuna.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> BlockHash
        ///  Map of block numbers to block hashes.
        /// </summary>
        public async Task<Ajuna.NetApi.Model.PrimitiveTypes.H256> BlockHash(Ajuna.NetApi.Model.Types.Primitive.U32 key, CancellationToken token)
        {
            string parameters = SystemStorage.BlockHashParams(key);
            return await _client.GetStorageAsync<Ajuna.NetApi.Model.PrimitiveTypes.H256>(parameters, token);
        }
        
        /// <summary>
        /// >> ExtrinsicDataParams
        ///  Extrinsics data for the current block (maps an extrinsic's index to its data).
        /// </summary>
        public static string ExtrinsicDataParams(Ajuna.NetApi.Model.Types.Primitive.U32 key)
        {
            return RequestGenerator.GetStorage("System", "ExtrinsicData", Ajuna.NetApi.Model.Meta.Storage.Type.Map, new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Ajuna.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> ExtrinsicData
        ///  Extrinsics data for the current block (maps an extrinsic's index to its data).
        /// </summary>
        public async Task<BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8>> ExtrinsicData(Ajuna.NetApi.Model.Types.Primitive.U32 key, CancellationToken token)
        {
            string parameters = SystemStorage.ExtrinsicDataParams(key);
            return await _client.GetStorageAsync<BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8>>(parameters, token);
        }
        
        /// <summary>
        /// >> NumberParams
        ///  The current block number being processed. Set by `execute_block`.
        /// </summary>
        public static string NumberParams()
        {
            return RequestGenerator.GetStorage("System", "Number", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> Number
        ///  The current block number being processed. Set by `execute_block`.
        /// </summary>
        public async Task<Ajuna.NetApi.Model.Types.Primitive.U32> Number(CancellationToken token)
        {
            string parameters = SystemStorage.NumberParams();
            return await _client.GetStorageAsync<Ajuna.NetApi.Model.Types.Primitive.U32>(parameters, token);
        }
        
        /// <summary>
        /// >> ParentHashParams
        ///  Hash of the previous block.
        /// </summary>
        public static string ParentHashParams()
        {
            return RequestGenerator.GetStorage("System", "ParentHash", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> ParentHash
        ///  Hash of the previous block.
        /// </summary>
        public async Task<Ajuna.NetApi.Model.PrimitiveTypes.H256> ParentHash(CancellationToken token)
        {
            string parameters = SystemStorage.ParentHashParams();
            return await _client.GetStorageAsync<Ajuna.NetApi.Model.PrimitiveTypes.H256>(parameters, token);
        }
        
        /// <summary>
        /// >> DigestParams
        ///  Digest of the current block, also part of the block header.
        /// </summary>
        public static string DigestParams()
        {
            return RequestGenerator.GetStorage("System", "Digest", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> Digest
        ///  Digest of the current block, also part of the block header.
        /// </summary>
        public async Task<Ajuna.NetApi.Model.SpRuntime.Digest> Digest(CancellationToken token)
        {
            string parameters = SystemStorage.DigestParams();
            return await _client.GetStorageAsync<Ajuna.NetApi.Model.SpRuntime.Digest>(parameters, token);
        }
        
        /// <summary>
        /// >> EventsParams
        ///  Events deposited for the current block.
        /// 
        ///  NOTE: This storage item is explicitly unbounded since it is never intended to be read
        ///  from within the runtime.
        /// </summary>
        public static string EventsParams()
        {
            return RequestGenerator.GetStorage("System", "Events", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> Events
        ///  Events deposited for the current block.
        /// 
        ///  NOTE: This storage item is explicitly unbounded since it is never intended to be read
        ///  from within the runtime.
        /// </summary>
        public async Task<BaseVec<Ajuna.NetApi.Model.FrameSystem.EventRecord>> Events(CancellationToken token)
        {
            string parameters = SystemStorage.EventsParams();
            return await _client.GetStorageAsync<BaseVec<Ajuna.NetApi.Model.FrameSystem.EventRecord>>(parameters, token);
        }
        
        /// <summary>
        /// >> EventCountParams
        ///  The number of events in the `Events<T>` list.
        /// </summary>
        public static string EventCountParams()
        {
            return RequestGenerator.GetStorage("System", "EventCount", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> EventCount
        ///  The number of events in the `Events<T>` list.
        /// </summary>
        public async Task<Ajuna.NetApi.Model.Types.Primitive.U32> EventCount(CancellationToken token)
        {
            string parameters = SystemStorage.EventCountParams();
            return await _client.GetStorageAsync<Ajuna.NetApi.Model.Types.Primitive.U32>(parameters, token);
        }
        
        /// <summary>
        /// >> EventTopicsParams
        ///  Mapping between a topic (represented by T::Hash) and a vector of indexes
        ///  of events in the `<Events<T>>` list.
        /// 
        ///  All topic vectors have deterministic storage locations depending on the topic. This
        ///  allows light-clients to leverage the changes trie storage tracking mechanism and
        ///  in case of changes fetch the list of events of interest.
        /// 
        ///  The value has the type `(T::BlockNumber, EventIndex)` because if we used only just
        ///  the `EventIndex` then in case if the topic has the same contents on the next block
        ///  no notification will be triggered thus the event might be lost.
        /// </summary>
        public static string EventTopicsParams(Ajuna.NetApi.Model.PrimitiveTypes.H256 key)
        {
            return RequestGenerator.GetStorage("System", "EventTopics", Ajuna.NetApi.Model.Meta.Storage.Type.Map, new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new Ajuna.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> EventTopics
        ///  Mapping between a topic (represented by T::Hash) and a vector of indexes
        ///  of events in the `<Events<T>>` list.
        /// 
        ///  All topic vectors have deterministic storage locations depending on the topic. This
        ///  allows light-clients to leverage the changes trie storage tracking mechanism and
        ///  in case of changes fetch the list of events of interest.
        /// 
        ///  The value has the type `(T::BlockNumber, EventIndex)` because if we used only just
        ///  the `EventIndex` then in case if the topic has the same contents on the next block
        ///  no notification will be triggered thus the event might be lost.
        /// </summary>
        public async Task<BaseVec<BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32,Ajuna.NetApi.Model.Types.Primitive.U32>>> EventTopics(Ajuna.NetApi.Model.PrimitiveTypes.H256 key, CancellationToken token)
        {
            string parameters = SystemStorage.EventTopicsParams(key);
            return await _client.GetStorageAsync<BaseVec<BaseTuple<Ajuna.NetApi.Model.Types.Primitive.U32,Ajuna.NetApi.Model.Types.Primitive.U32>>>(parameters, token);
        }
        
        /// <summary>
        /// >> LastRuntimeUpgradeParams
        ///  Stores the `spec_version` and `spec_name` of when the last runtime upgrade happened.
        /// </summary>
        public static string LastRuntimeUpgradeParams()
        {
            return RequestGenerator.GetStorage("System", "LastRuntimeUpgrade", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> LastRuntimeUpgrade
        ///  Stores the `spec_version` and `spec_name` of when the last runtime upgrade happened.
        /// </summary>
        public async Task<Ajuna.NetApi.Model.FrameSystem.LastRuntimeUpgradeInfo> LastRuntimeUpgrade(CancellationToken token)
        {
            string parameters = SystemStorage.LastRuntimeUpgradeParams();
            return await _client.GetStorageAsync<Ajuna.NetApi.Model.FrameSystem.LastRuntimeUpgradeInfo>(parameters, token);
        }
        
        /// <summary>
        /// >> UpgradedToU32RefCountParams
        ///  True if we have upgraded so that `type RefCount` is `u32`. False (default) if not.
        /// </summary>
        public static string UpgradedToU32RefCountParams()
        {
            return RequestGenerator.GetStorage("System", "UpgradedToU32RefCount", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> UpgradedToU32RefCount
        ///  True if we have upgraded so that `type RefCount` is `u32`. False (default) if not.
        /// </summary>
        public async Task<Ajuna.NetApi.Model.Types.Primitive.Bool> UpgradedToU32RefCount(CancellationToken token)
        {
            string parameters = SystemStorage.UpgradedToU32RefCountParams();
            return await _client.GetStorageAsync<Ajuna.NetApi.Model.Types.Primitive.Bool>(parameters, token);
        }
        
        /// <summary>
        /// >> UpgradedToTripleRefCountParams
        ///  True if we have upgraded so that AccountInfo contains three types of `RefCount`. False
        ///  (default) if not.
        /// </summary>
        public static string UpgradedToTripleRefCountParams()
        {
            return RequestGenerator.GetStorage("System", "UpgradedToTripleRefCount", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> UpgradedToTripleRefCount
        ///  True if we have upgraded so that AccountInfo contains three types of `RefCount`. False
        ///  (default) if not.
        /// </summary>
        public async Task<Ajuna.NetApi.Model.Types.Primitive.Bool> UpgradedToTripleRefCount(CancellationToken token)
        {
            string parameters = SystemStorage.UpgradedToTripleRefCountParams();
            return await _client.GetStorageAsync<Ajuna.NetApi.Model.Types.Primitive.Bool>(parameters, token);
        }
        
        /// <summary>
        /// >> ExecutionPhaseParams
        ///  The execution phase of the block.
        /// </summary>
        public static string ExecutionPhaseParams()
        {
            return RequestGenerator.GetStorage("System", "ExecutionPhase", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> ExecutionPhase
        ///  The execution phase of the block.
        /// </summary>
        public async Task<Ajuna.NetApi.Model.FrameSystem.EnumPhase> ExecutionPhase(CancellationToken token)
        {
            string parameters = SystemStorage.ExecutionPhaseParams();
            return await _client.GetStorageAsync<Ajuna.NetApi.Model.FrameSystem.EnumPhase>(parameters, token);
        }
    }
    
    public sealed class SystemCalls
    {
        
        /// <summary>
        /// >> fill_block
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method FillBlock(Ajuna.NetApi.Model.SpArithmetic.Perbill ratio)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(ratio.Encode());
            return new Method(0, "System", 0, "fill_block", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> remark
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Remark(BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8> remark)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(remark.Encode());
            return new Method(0, "System", 1, "remark", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_heap_pages
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method SetHeapPages(Ajuna.NetApi.Model.Types.Primitive.U64 pages)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(pages.Encode());
            return new Method(0, "System", 2, "set_heap_pages", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_code
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method SetCode(BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8> code)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(code.Encode());
            return new Method(0, "System", 3, "set_code", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_code_without_checks
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method SetCodeWithoutChecks(BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8> code)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(code.Encode());
            return new Method(0, "System", 4, "set_code_without_checks", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_changes_trie_config
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method SetChangesTrieConfig(BaseOpt<Ajuna.NetApi.Model.SpCore.ChangesTrieConfiguration> changes_trie_config)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(changes_trie_config.Encode());
            return new Method(0, "System", 5, "set_changes_trie_config", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_storage
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method SetStorage(BaseVec<BaseTuple<BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8>,BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8>>> items)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(items.Encode());
            return new Method(0, "System", 6, "set_storage", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> kill_storage
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method KillStorage(BaseVec<BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8>> keys)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(keys.Encode());
            return new Method(0, "System", 7, "kill_storage", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> kill_prefix
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method KillPrefix(BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8> prefix, Ajuna.NetApi.Model.Types.Primitive.U32 subkeys)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(prefix.Encode());
            byteArray.AddRange(subkeys.Encode());
            return new Method(0, "System", 8, "kill_prefix", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> remark_with_event
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method RemarkWithEvent(BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8> remark)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(remark.Encode());
            return new Method(0, "System", 9, "remark_with_event", byteArray.ToArray());
        }
    }
    
    /// <summary>
    /// >> ExtrinsicSuccess
    /// An extrinsic completed successfully. \[info\]
    /// </summary>
    public sealed class EventExtrinsicSuccess : BaseTuple<Ajuna.NetApi.Model.FrameSupport.DispatchInfo>
    {
    }
    
    /// <summary>
    /// >> ExtrinsicFailed
    /// An extrinsic failed. \[error, info\]
    /// </summary>
    public sealed class EventExtrinsicFailed : BaseTuple<Ajuna.NetApi.Model.SpRuntime.EnumDispatchError, Ajuna.NetApi.Model.FrameSupport.DispatchInfo>
    {
    }
    
    /// <summary>
    /// >> CodeUpdated
    /// `:code` was updated.
    /// </summary>
    public sealed class EventCodeUpdated : BaseTuple
    {
    }
    
    /// <summary>
    /// >> NewAccount
    /// A new \[account\] was created.
    /// </summary>
    public sealed class EventNewAccount : BaseTuple<Ajuna.NetApi.Model.SpCore.AccountId32>
    {
    }
    
    /// <summary>
    /// >> KilledAccount
    /// An \[account\] was reaped.
    /// </summary>
    public sealed class EventKilledAccount : BaseTuple<Ajuna.NetApi.Model.SpCore.AccountId32>
    {
    }
    
    /// <summary>
    /// >> Remarked
    /// On on-chain remark happened. \[origin, remark_hash\]
    /// </summary>
    public sealed class EventRemarked : BaseTuple<Ajuna.NetApi.Model.SpCore.AccountId32, Ajuna.NetApi.Model.PrimitiveTypes.H256>
    {
    }
    
    public enum SystemErrors
    {
        
        /// <summary>
        /// >> InvalidSpecName
        /// The name of specification does not match between the current runtime
        /// and the new runtime.
        /// </summary>
        InvalidSpecName,
        
        /// <summary>
        /// >> SpecVersionNeedsToIncrease
        /// The specification version is not allowed to decrease between the current runtime
        /// and the new runtime.
        /// </summary>
        SpecVersionNeedsToIncrease,
        
        /// <summary>
        /// >> FailedToExtractRuntimeVersion
        /// Failed to extract the runtime version from the new runtime.
        /// 
        /// Either calling `Core_version` or decoding `RuntimeVersion` failed.
        /// </summary>
        FailedToExtractRuntimeVersion,
        
        /// <summary>
        /// >> NonDefaultComposite
        /// Suicide called when the account has non-default composite data.
        /// </summary>
        NonDefaultComposite,
        
        /// <summary>
        /// >> NonZeroRefCount
        /// There is a non-zero reference count preventing the account from being purged.
        /// </summary>
        NonZeroRefCount,
    }
}