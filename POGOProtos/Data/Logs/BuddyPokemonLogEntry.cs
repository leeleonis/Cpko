// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: POGOProtos/Data/Logs/BuddyPokemonLogEntry.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Data.Logs {

  /// <summary>Holder for reflection information generated from POGOProtos/Data/Logs/BuddyPokemonLogEntry.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class BuddyPokemonLogEntryReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Data/Logs/BuddyPokemonLogEntry.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BuddyPokemonLogEntryReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Ci9QT0dPUHJvdG9zL0RhdGEvTG9ncy9CdWRkeVBva2Vtb25Mb2dFbnRyeS5w",
            "cm90bxIUUE9HT1Byb3Rvcy5EYXRhLkxvZ3MaIFBPR09Qcm90b3MvRW51bXMv",
            "UG9rZW1vbklkLnByb3RvIsABChRCdWRkeVBva2Vtb25Mb2dFbnRyeRJBCgZy",
            "ZXN1bHQYASABKA4yMS5QT0dPUHJvdG9zLkRhdGEuTG9ncy5CdWRkeVBva2Vt",
            "b25Mb2dFbnRyeS5SZXN1bHQSLwoKcG9rZW1vbl9pZBgCIAEoDjIbLlBPR09Q",
            "cm90b3MuRW51bXMuUG9rZW1vbklkEg4KBmFtb3VudBgDIAEoBSIkCgZSZXN1",
            "bHQSCQoFVU5TRVQQABIPCgtDQU5EWV9GT1VORBABYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Enums.PokemonIdReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Data.Logs.BuddyPokemonLogEntry), global::POGOProtos.Data.Logs.BuddyPokemonLogEntry.Parser, new[]{ "Result", "PokemonId", "Amount" }, null, new[]{ typeof(global::POGOProtos.Data.Logs.BuddyPokemonLogEntry.Types.Result) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class BuddyPokemonLogEntry : pb::IMessage<BuddyPokemonLogEntry> {
    private static readonly pb::MessageParser<BuddyPokemonLogEntry> _parser = new pb::MessageParser<BuddyPokemonLogEntry>(() => new BuddyPokemonLogEntry());
    public static pb::MessageParser<BuddyPokemonLogEntry> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Data.Logs.BuddyPokemonLogEntryReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public BuddyPokemonLogEntry() {
      OnConstruction();
    }

    partial void OnConstruction();

    public BuddyPokemonLogEntry(BuddyPokemonLogEntry other) : this() {
      result_ = other.result_;
      pokemonId_ = other.pokemonId_;
      amount_ = other.amount_;
    }

    public BuddyPokemonLogEntry Clone() {
      return new BuddyPokemonLogEntry(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private global::POGOProtos.Data.Logs.BuddyPokemonLogEntry.Types.Result result_ = global::POGOProtos.Data.Logs.BuddyPokemonLogEntry.Types.Result.UNSET;
    public global::POGOProtos.Data.Logs.BuddyPokemonLogEntry.Types.Result Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    /// <summary>Field number for the "pokemon_id" field.</summary>
    public const int PokemonIdFieldNumber = 2;
    private global::POGOProtos.Enums.PokemonId pokemonId_ = global::POGOProtos.Enums.PokemonId.Missingno;
    public global::POGOProtos.Enums.PokemonId PokemonId {
      get { return pokemonId_; }
      set {
        pokemonId_ = value;
      }
    }

    /// <summary>Field number for the "amount" field.</summary>
    public const int AmountFieldNumber = 3;
    private int amount_;
    public int Amount {
      get { return amount_; }
      set {
        amount_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as BuddyPokemonLogEntry);
    }

    public bool Equals(BuddyPokemonLogEntry other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Result != other.Result) return false;
      if (PokemonId != other.PokemonId) return false;
      if (Amount != other.Amount) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Result != global::POGOProtos.Data.Logs.BuddyPokemonLogEntry.Types.Result.UNSET) hash ^= Result.GetHashCode();
      if (PokemonId != global::POGOProtos.Enums.PokemonId.Missingno) hash ^= PokemonId.GetHashCode();
      if (Amount != 0) hash ^= Amount.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Result != global::POGOProtos.Data.Logs.BuddyPokemonLogEntry.Types.Result.UNSET) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Result);
      }
      if (PokemonId != global::POGOProtos.Enums.PokemonId.Missingno) {
        output.WriteRawTag(16);
        output.WriteEnum((int) PokemonId);
      }
      if (Amount != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Amount);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Result != global::POGOProtos.Data.Logs.BuddyPokemonLogEntry.Types.Result.UNSET) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Result);
      }
      if (PokemonId != global::POGOProtos.Enums.PokemonId.Missingno) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) PokemonId);
      }
      if (Amount != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Amount);
      }
      return size;
    }

    public void MergeFrom(BuddyPokemonLogEntry other) {
      if (other == null) {
        return;
      }
      if (other.Result != global::POGOProtos.Data.Logs.BuddyPokemonLogEntry.Types.Result.UNSET) {
        Result = other.Result;
      }
      if (other.PokemonId != global::POGOProtos.Enums.PokemonId.Missingno) {
        PokemonId = other.PokemonId;
      }
      if (other.Amount != 0) {
        Amount = other.Amount;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            result_ = (global::POGOProtos.Data.Logs.BuddyPokemonLogEntry.Types.Result) input.ReadEnum();
            break;
          }
          case 16: {
            pokemonId_ = (global::POGOProtos.Enums.PokemonId) input.ReadEnum();
            break;
          }
          case 24: {
            Amount = input.ReadInt32();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the BuddyPokemonLogEntry message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public static partial class Types {
      public enum Result {
        UNSET = 0,
        CANDY_FOUND = 1,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
