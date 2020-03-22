// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: valid.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Protocol {

  /// <summary>Holder for reflection information generated from valid.proto</summary>
  public static partial class ValidReflection {

    #region Descriptor
    /// <summary>File descriptor for valid.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ValidReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cgt2YWxpZC5wcm90bxIIcHJvdG9jb2waDGhlYWRlci5wcm90byJFCgtHZXRW",
            "YWxpZFJlcRIjCgZoZWFkZXIYASABKAsyEy5wcm90b2NvbC5SZXFIZWFkZXIS",
            "EQoJVmFsaWRUeXBlGAIgASgFIkMKC0dldFZhbGlkQWNrEiMKBmhlYWRlchgB",
            "IAEoCzITLnByb3RvY29sLkFja0hlYWRlchIPCgdWYWxpZElkGAIgASgJIlcK",
            "DkNoZWNrVXNlcklkUmVxEiMKBmhlYWRlchgBIAEoCzITLnByb3RvY29sLlJl",
            "cUhlYWRlchINCgV2YWx1ZRgCIAEoCRIRCgljaGVja1R5cGUYAyABKAUiNQoO",
            "Q2hlY2tVc2VySWRBY2sSIwoGaGVhZGVyGAEgASgLMhMucHJvdG9jb2wuQWNr",
            "SGVhZGVyYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Protocol.HeaderReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Protocol.GetValidReq), global::Protocol.GetValidReq.Parser, new[]{ "Header", "ValidType" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Protocol.GetValidAck), global::Protocol.GetValidAck.Parser, new[]{ "Header", "ValidId" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Protocol.CheckUserIdReq), global::Protocol.CheckUserIdReq.Parser, new[]{ "Header", "Value", "CheckType" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Protocol.CheckUserIdAck), global::Protocol.CheckUserIdAck.Parser, new[]{ "Header" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GetValidReq : pb::IMessage<GetValidReq> {
    private static readonly pb::MessageParser<GetValidReq> _parser = new pb::MessageParser<GetValidReq>(() => new GetValidReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetValidReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Protocol.ValidReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetValidReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetValidReq(GetValidReq other) : this() {
      header_ = other.header_ != null ? other.header_.Clone() : null;
      validType_ = other.validType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetValidReq Clone() {
      return new GetValidReq(this);
    }

    /// <summary>Field number for the "header" field.</summary>
    public const int HeaderFieldNumber = 1;
    private global::Protocol.ReqHeader header_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Protocol.ReqHeader Header {
      get { return header_; }
      set {
        header_ = value;
      }
    }

    /// <summary>Field number for the "ValidType" field.</summary>
    public const int ValidTypeFieldNumber = 2;
    private int validType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int ValidType {
      get { return validType_; }
      set {
        validType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetValidReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetValidReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Header, other.Header)) return false;
      if (ValidType != other.ValidType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (header_ != null) hash ^= Header.GetHashCode();
      if (ValidType != 0) hash ^= ValidType.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (header_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Header);
      }
      if (ValidType != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(ValidType);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (header_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Header);
      }
      if (ValidType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(ValidType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetValidReq other) {
      if (other == null) {
        return;
      }
      if (other.header_ != null) {
        if (header_ == null) {
          Header = new global::Protocol.ReqHeader();
        }
        Header.MergeFrom(other.Header);
      }
      if (other.ValidType != 0) {
        ValidType = other.ValidType;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (header_ == null) {
              Header = new global::Protocol.ReqHeader();
            }
            input.ReadMessage(Header);
            break;
          }
          case 16: {
            ValidType = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class GetValidAck : pb::IMessage<GetValidAck> {
    private static readonly pb::MessageParser<GetValidAck> _parser = new pb::MessageParser<GetValidAck>(() => new GetValidAck());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetValidAck> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Protocol.ValidReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetValidAck() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetValidAck(GetValidAck other) : this() {
      header_ = other.header_ != null ? other.header_.Clone() : null;
      validId_ = other.validId_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetValidAck Clone() {
      return new GetValidAck(this);
    }

    /// <summary>Field number for the "header" field.</summary>
    public const int HeaderFieldNumber = 1;
    private global::Protocol.AckHeader header_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Protocol.AckHeader Header {
      get { return header_; }
      set {
        header_ = value;
      }
    }

    /// <summary>Field number for the "ValidId" field.</summary>
    public const int ValidIdFieldNumber = 2;
    private string validId_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ValidId {
      get { return validId_; }
      set {
        validId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetValidAck);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetValidAck other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Header, other.Header)) return false;
      if (ValidId != other.ValidId) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (header_ != null) hash ^= Header.GetHashCode();
      if (ValidId.Length != 0) hash ^= ValidId.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (header_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Header);
      }
      if (ValidId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(ValidId);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (header_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Header);
      }
      if (ValidId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ValidId);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetValidAck other) {
      if (other == null) {
        return;
      }
      if (other.header_ != null) {
        if (header_ == null) {
          Header = new global::Protocol.AckHeader();
        }
        Header.MergeFrom(other.Header);
      }
      if (other.ValidId.Length != 0) {
        ValidId = other.ValidId;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (header_ == null) {
              Header = new global::Protocol.AckHeader();
            }
            input.ReadMessage(Header);
            break;
          }
          case 18: {
            ValidId = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///检查用户名、deviceCode、phone是否可用
  /// </summary>
  public sealed partial class CheckUserIdReq : pb::IMessage<CheckUserIdReq> {
    private static readonly pb::MessageParser<CheckUserIdReq> _parser = new pb::MessageParser<CheckUserIdReq>(() => new CheckUserIdReq());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CheckUserIdReq> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Protocol.ValidReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CheckUserIdReq() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CheckUserIdReq(CheckUserIdReq other) : this() {
      header_ = other.header_ != null ? other.header_.Clone() : null;
      value_ = other.value_;
      checkType_ = other.checkType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CheckUserIdReq Clone() {
      return new CheckUserIdReq(this);
    }

    /// <summary>Field number for the "header" field.</summary>
    public const int HeaderFieldNumber = 1;
    private global::Protocol.ReqHeader header_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Protocol.ReqHeader Header {
      get { return header_; }
      set {
        header_ = value;
      }
    }

    /// <summary>Field number for the "value" field.</summary>
    public const int ValueFieldNumber = 2;
    private string value_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Value {
      get { return value_; }
      set {
        value_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "checkType" field.</summary>
    public const int CheckTypeFieldNumber = 3;
    private int checkType_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CheckType {
      get { return checkType_; }
      set {
        checkType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CheckUserIdReq);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CheckUserIdReq other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Header, other.Header)) return false;
      if (Value != other.Value) return false;
      if (CheckType != other.CheckType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (header_ != null) hash ^= Header.GetHashCode();
      if (Value.Length != 0) hash ^= Value.GetHashCode();
      if (CheckType != 0) hash ^= CheckType.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (header_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Header);
      }
      if (Value.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Value);
      }
      if (CheckType != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(CheckType);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (header_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Header);
      }
      if (Value.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Value);
      }
      if (CheckType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(CheckType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CheckUserIdReq other) {
      if (other == null) {
        return;
      }
      if (other.header_ != null) {
        if (header_ == null) {
          Header = new global::Protocol.ReqHeader();
        }
        Header.MergeFrom(other.Header);
      }
      if (other.Value.Length != 0) {
        Value = other.Value;
      }
      if (other.CheckType != 0) {
        CheckType = other.CheckType;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (header_ == null) {
              Header = new global::Protocol.ReqHeader();
            }
            input.ReadMessage(Header);
            break;
          }
          case 18: {
            Value = input.ReadString();
            break;
          }
          case 24: {
            CheckType = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class CheckUserIdAck : pb::IMessage<CheckUserIdAck> {
    private static readonly pb::MessageParser<CheckUserIdAck> _parser = new pb::MessageParser<CheckUserIdAck>(() => new CheckUserIdAck());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CheckUserIdAck> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Protocol.ValidReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CheckUserIdAck() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CheckUserIdAck(CheckUserIdAck other) : this() {
      header_ = other.header_ != null ? other.header_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CheckUserIdAck Clone() {
      return new CheckUserIdAck(this);
    }

    /// <summary>Field number for the "header" field.</summary>
    public const int HeaderFieldNumber = 1;
    private global::Protocol.AckHeader header_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Protocol.AckHeader Header {
      get { return header_; }
      set {
        header_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CheckUserIdAck);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CheckUserIdAck other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Header, other.Header)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (header_ != null) hash ^= Header.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (header_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Header);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (header_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Header);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CheckUserIdAck other) {
      if (other == null) {
        return;
      }
      if (other.header_ != null) {
        if (header_ == null) {
          Header = new global::Protocol.AckHeader();
        }
        Header.MergeFrom(other.Header);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            if (header_ == null) {
              Header = new global::Protocol.AckHeader();
            }
            input.ReadMessage(Header);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
