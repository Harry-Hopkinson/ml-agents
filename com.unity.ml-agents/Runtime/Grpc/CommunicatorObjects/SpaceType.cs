// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: mlagents_envs/communicator_objects/space_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Unity.MLAgents.CommunicatorObjects {

  /// <summary>Holder for reflection information generated from mlagents_envs/communicator_objects/space_type.proto</summary>
  internal static partial class SpaceTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for mlagents_envs/communicator_objects/space_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SpaceTypeReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
            "CjNtbGFnZW50c19lbnZzL2NvbW11bmljYXRvcl9vYmplY3RzL3NwYWNlX3R5",
            "cGUucHJvdG8SFGNvbW11bmljYXRvcl9vYmplY3RzKi4KDlNwYWNlVHlwZVBy",
            "b3RvEgwKCGRpc2NyZXRlEAASDgoKY29udGludW91cxABQiWqAiJVbml0eS5N",
            "TEFnZW50cy5Db21tdW5pY2F0b3JPYmplY3RzYgZwcm90bzM="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Unity.MLAgents.CommunicatorObjects.SpaceTypeProto), }, null));
    }
    #endregion

  }
  #region Enums
  internal enum SpaceTypeProto {
    [pbr::OriginalName("discrete")] Discrete = 0,
    [pbr::OriginalName("continuous")] Continuous = 1,
  }

  #endregion

}

#endregion Designer generated code
