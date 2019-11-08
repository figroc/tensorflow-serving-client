// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: tensorflow/core/framework/step_stats.proto

package org.tensorflow.framework;

public interface DeviceStepStatsOrBuilder extends
    // @@protoc_insertion_point(interface_extends:tensorflow.DeviceStepStats)
    com.google.protobuf.MessageOrBuilder {

  /**
   * <code>string device = 1;</code>
   * @return The device.
   */
  java.lang.String getDevice();
  /**
   * <code>string device = 1;</code>
   * @return The bytes for device.
   */
  com.google.protobuf.ByteString
      getDeviceBytes();

  /**
   * <code>repeated .tensorflow.NodeExecStats node_stats = 2;</code>
   */
  java.util.List<org.tensorflow.framework.NodeExecStats> 
      getNodeStatsList();
  /**
   * <code>repeated .tensorflow.NodeExecStats node_stats = 2;</code>
   */
  org.tensorflow.framework.NodeExecStats getNodeStats(int index);
  /**
   * <code>repeated .tensorflow.NodeExecStats node_stats = 2;</code>
   */
  int getNodeStatsCount();
  /**
   * <code>repeated .tensorflow.NodeExecStats node_stats = 2;</code>
   */
  java.util.List<? extends org.tensorflow.framework.NodeExecStatsOrBuilder> 
      getNodeStatsOrBuilderList();
  /**
   * <code>repeated .tensorflow.NodeExecStats node_stats = 2;</code>
   */
  org.tensorflow.framework.NodeExecStatsOrBuilder getNodeStatsOrBuilder(
      int index);

  /**
   * <pre>
   * Its key is thread id.
   * </pre>
   *
   * <code>map&lt;uint32, string&gt; thread_names = 3;</code>
   */
  int getThreadNamesCount();
  /**
   * <pre>
   * Its key is thread id.
   * </pre>
   *
   * <code>map&lt;uint32, string&gt; thread_names = 3;</code>
   */
  boolean containsThreadNames(
      int key);
  /**
   * Use {@link #getThreadNamesMap()} instead.
   */
  @java.lang.Deprecated
  java.util.Map<java.lang.Integer, java.lang.String>
  getThreadNames();
  /**
   * <pre>
   * Its key is thread id.
   * </pre>
   *
   * <code>map&lt;uint32, string&gt; thread_names = 3;</code>
   */
  java.util.Map<java.lang.Integer, java.lang.String>
  getThreadNamesMap();
  /**
   * <pre>
   * Its key is thread id.
   * </pre>
   *
   * <code>map&lt;uint32, string&gt; thread_names = 3;</code>
   */

  java.lang.String getThreadNamesOrDefault(
      int key,
      java.lang.String defaultValue);
  /**
   * <pre>
   * Its key is thread id.
   * </pre>
   *
   * <code>map&lt;uint32, string&gt; thread_names = 3;</code>
   */

  java.lang.String getThreadNamesOrThrow(
      int key);
}
