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
using Ajuna.NetApi.Model.Meta;
using Ajuna.NetApi.Model.PalletVesting;
using Ajuna.NetApi.Model.SpCore;
using Ajuna.NetApi.Model.SpRuntime;
using Ajuna.NetApi.Model.Types;
using Ajuna.NetApi.Model.Types.Base;
using Ajuna.NetApi.Model.Types.Primitive;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace Ajuna.NetApi.Model.PalletVesting
{
    
    
    public sealed class VestingStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        public VestingStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Vesting", "Vesting"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                            Ajuna.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, typeof(Ajuna.NetApi.Model.SpCore.AccountId32), typeof(Ajuna.NetApi.Model.FrameSupport.BoundedVec)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Vesting", "StorageVersion"), new System.Tuple<Ajuna.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Ajuna.NetApi.Model.PalletVesting.EnumReleases)));
        }
        
        /// <summary>
        /// >> VestingParams
        ///  Information regarding the vesting of a given account.
        /// </summary>
        public static string VestingParams(Ajuna.NetApi.Model.SpCore.AccountId32 key)
        {
            return RequestGenerator.GetStorage("Vesting", "Vesting", Ajuna.NetApi.Model.Meta.Storage.Type.Map, new Ajuna.NetApi.Model.Meta.Storage.Hasher[] {
                        Ajuna.NetApi.Model.Meta.Storage.Hasher.BlakeTwo128Concat}, new Ajuna.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> Vesting
        ///  Information regarding the vesting of a given account.
        /// </summary>
        public async Task<Ajuna.NetApi.Model.FrameSupport.BoundedVec> Vesting(Ajuna.NetApi.Model.SpCore.AccountId32 key, CancellationToken token)
        {
            string parameters = VestingStorage.VestingParams(key);
            return await _client.GetStorageAsync<Ajuna.NetApi.Model.FrameSupport.BoundedVec>(parameters, token);
        }
        
        /// <summary>
        /// >> StorageVersionParams
        ///  Storage version of the pallet.
        /// 
        ///  New networks start with latest version, as determined by the genesis build.
        /// </summary>
        public static string StorageVersionParams()
        {
            return RequestGenerator.GetStorage("Vesting", "StorageVersion", Ajuna.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> StorageVersion
        ///  Storage version of the pallet.
        /// 
        ///  New networks start with latest version, as determined by the genesis build.
        /// </summary>
        public async Task<Ajuna.NetApi.Model.PalletVesting.EnumReleases> StorageVersion(CancellationToken token)
        {
            string parameters = VestingStorage.StorageVersionParams();
            return await _client.GetStorageAsync<Ajuna.NetApi.Model.PalletVesting.EnumReleases>(parameters, token);
        }
    }
    
    public sealed class VestingCalls
    {
        
        /// <summary>
        /// >> vest
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Vest()
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            return new Method(28, "Vesting", 0, "vest", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> vest_other
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method VestOther(Ajuna.NetApi.Model.SpRuntime.EnumMultiAddress target)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(target.Encode());
            return new Method(28, "Vesting", 1, "vest_other", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> vested_transfer
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method VestedTransfer(Ajuna.NetApi.Model.SpRuntime.EnumMultiAddress target, Ajuna.NetApi.Model.PalletVesting.VestingInfo schedule)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(target.Encode());
            byteArray.AddRange(schedule.Encode());
            return new Method(28, "Vesting", 2, "vested_transfer", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> force_vested_transfer
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method ForceVestedTransfer(Ajuna.NetApi.Model.SpRuntime.EnumMultiAddress source, Ajuna.NetApi.Model.SpRuntime.EnumMultiAddress target, Ajuna.NetApi.Model.PalletVesting.VestingInfo schedule)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(source.Encode());
            byteArray.AddRange(target.Encode());
            byteArray.AddRange(schedule.Encode());
            return new Method(28, "Vesting", 3, "force_vested_transfer", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> merge_schedules
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method MergeSchedules(Ajuna.NetApi.Model.Types.Primitive.U32 schedule1_index, Ajuna.NetApi.Model.Types.Primitive.U32 schedule2_index)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(schedule1_index.Encode());
            byteArray.AddRange(schedule2_index.Encode());
            return new Method(28, "Vesting", 4, "merge_schedules", byteArray.ToArray());
        }
    }
    
    /// <summary>
    /// >> VestingUpdated
    /// The amount vested has been updated. This could indicate a change in funds available.
    /// The balance given is the amount which is left unvested (and thus locked).
    /// \[account, unvested\]
    /// </summary>
    public sealed class EventVestingUpdated : BaseTuple<Ajuna.NetApi.Model.SpCore.AccountId32, Ajuna.NetApi.Model.Types.Primitive.U128>
    {
    }
    
    /// <summary>
    /// >> VestingCompleted
    /// An \[account\] has become fully vested.
    /// </summary>
    public sealed class EventVestingCompleted : BaseTuple<Ajuna.NetApi.Model.SpCore.AccountId32>
    {
    }
    
    public enum VestingErrors
    {
        
        /// <summary>
        /// >> NotVesting
        /// The account given is not vesting.
        /// </summary>
        NotVesting,
        
        /// <summary>
        /// >> AtMaxVestingSchedules
        /// The account already has `MaxVestingSchedules` count of schedules and thus
        /// cannot add another one. Consider merging existing schedules in order to add another.
        /// </summary>
        AtMaxVestingSchedules,
        
        /// <summary>
        /// >> AmountLow
        /// Amount being transferred is too low to create a vesting schedule.
        /// </summary>
        AmountLow,
        
        /// <summary>
        /// >> ScheduleIndexOutOfBounds
        /// An index was out of bounds of the vesting schedules.
        /// </summary>
        ScheduleIndexOutOfBounds,
        
        /// <summary>
        /// >> InvalidScheduleParams
        /// Failed to create a new schedule because some parameter was invalid.
        /// </summary>
        InvalidScheduleParams,
    }
}