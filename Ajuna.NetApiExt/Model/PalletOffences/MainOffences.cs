//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Ajuna.NetApi.Model.Base;
using Ajuna.NetApi.Model.Extrinsics;
using Ajuna.NetApi.Model.Meta;
using Ajuna.NetApi.Model.PrimitiveTypes;
using Ajuna.NetApi.Model.SpStaking;
using Ajuna.NetApi.Model.Types;
using Ajuna.NetApi.Model.Types.Base;
using Ajuna.NetApi.Model.Types.Primitive;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace Ajuna.NetApi.Model.PalletOffences
{
    
    
    public sealed class OffencesStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        public OffencesStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Offences", "Reports"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(Ajuna.NetApi.Model.PrimitiveTypes.H256), typeof(Ajuna.NetApi.Model.SpStaking.OffenceDetails)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Offences", "ConcurrentReportsIndex"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat,
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(BaseTuple<Ajuna.NetApi.Model.Base.Arr16U8,BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8>>), typeof(BaseVec<Ajuna.NetApi.Model.PrimitiveTypes.H256>)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Offences", "ReportsByKindIndex"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, typeof(Ajuna.NetApi.Model.Base.Arr16U8), typeof(BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8>)));
        }
        
        /// <summary>
        /// >> ReportsParams
        ///  The primary structure that holds all offence records keyed by report identifiers.
        /// </summary>
        public static string ReportsParams(Ajuna.NetApi.Model.PrimitiveTypes.H256 key)
        {
            return RequestGenerator.GetStorage("Offences", "Reports", Ajuna.NetApi.Model.Meta.Storage.Type.Map, new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Ajuna.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> Reports
        ///  The primary structure that holds all offence records keyed by report identifiers.
        /// </summary>
        public async Task<Ajuna.NetApi.Model.SpStaking.OffenceDetails> Reports(Ajuna.NetApi.Model.PrimitiveTypes.H256 key, CancellationToken token)
        {
            string parameters = OffencesStorage.ReportsParams(key);
            return await _client.GetStorageAsync<Ajuna.NetApi.Model.SpStaking.OffenceDetails>(parameters, token);
        }
        
        /// <summary>
        /// >> ConcurrentReportsIndexParams
        ///  A vector of reports of the same kind that happened at the same time slot.
        /// </summary>
        public static string ConcurrentReportsIndexParams(BaseTuple<Ajuna.NetApi.Model.Base.Arr16U8,BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8>> key)
        {
            return RequestGenerator.GetStorage("Offences", "ConcurrentReportsIndex", Ajuna.NetApi.Model.Meta.Storage.Type.Map, new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat,
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Ajuna.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> ConcurrentReportsIndex
        ///  A vector of reports of the same kind that happened at the same time slot.
        /// </summary>
        public async Task<BaseVec<Ajuna.NetApi.Model.PrimitiveTypes.H256>> ConcurrentReportsIndex(BaseTuple<Ajuna.NetApi.Model.Base.Arr16U8,BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8>> key, CancellationToken token)
        {
            string parameters = OffencesStorage.ConcurrentReportsIndexParams(key);
            return await _client.GetStorageAsync<BaseVec<Ajuna.NetApi.Model.PrimitiveTypes.H256>>(parameters, token);
        }
        
        /// <summary>
        /// >> ReportsByKindIndexParams
        ///  Enumerates all reports of a kind along with the time they happened.
        /// 
        ///  All reports are sorted by the time of offence.
        /// 
        ///  Note that the actual type of this mapping is `Vec<u8>`, this is because values of
        ///  different types are not supported at the moment so we are doing the manual serialization.
        /// </summary>
        public static string ReportsByKindIndexParams(Ajuna.NetApi.Model.Base.Arr16U8 key)
        {
            return RequestGenerator.GetStorage("Offences", "ReportsByKindIndex", Ajuna.NetApi.Model.Meta.Storage.Type.Map, new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.Twox64Concat}, new Ajuna.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> ReportsByKindIndex
        ///  Enumerates all reports of a kind along with the time they happened.
        /// 
        ///  All reports are sorted by the time of offence.
        /// 
        ///  Note that the actual type of this mapping is `Vec<u8>`, this is because values of
        ///  different types are not supported at the moment so we are doing the manual serialization.
        /// </summary>
        public async Task<BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8>> ReportsByKindIndex(Ajuna.NetApi.Model.Base.Arr16U8 key, CancellationToken token)
        {
            string parameters = OffencesStorage.ReportsByKindIndexParams(key);
            return await _client.GetStorageAsync<BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8>>(parameters, token);
        }
    }
    
    public sealed class OffencesCalls
    {
    }
    
    /// <summary>
    /// >> Offence
    /// There is an offence reported of the given `kind` happened at the `session_index` and
    /// (kind-specific) time slot. This event is not deposited for duplicate slashes.
    /// \[kind, timeslot\].
    /// </summary>
    public sealed class EventOffence : BaseTuple<Ajuna.NetApi.Model.Base.Arr16U8, BaseVec<Ajuna.NetApi.Model.Types.Primitive.U8>>
    {
    }
}
