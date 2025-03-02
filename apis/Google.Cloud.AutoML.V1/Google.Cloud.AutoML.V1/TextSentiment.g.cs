// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/automl/v1/text_sentiment.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.AutoML.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/automl/v1/text_sentiment.proto</summary>
  public static partial class TextSentimentReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/automl/v1/text_sentiment.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TextSentimentReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Citnb29nbGUvY2xvdWQvYXV0b21sL3YxL3RleHRfc2VudGltZW50LnByb3Rv",
            "EhZnb29nbGUuY2xvdWQuYXV0b21sLnYxGhxnb29nbGUvYXBpL2Fubm90YXRp",
            "b25zLnByb3RvGitnb29nbGUvY2xvdWQvYXV0b21sL3YxL2NsYXNzaWZpY2F0",
            "aW9uLnByb3RvIiwKF1RleHRTZW50aW1lbnRBbm5vdGF0aW9uEhEKCXNlbnRp",
            "bWVudBgBIAEoBSKgAgoeVGV4dFNlbnRpbWVudEV2YWx1YXRpb25NZXRyaWNz",
            "EhEKCXByZWNpc2lvbhgBIAEoAhIOCgZyZWNhbGwYAiABKAISEAoIZjFfc2Nv",
            "cmUYAyABKAISGwoTbWVhbl9hYnNvbHV0ZV9lcnJvchgEIAEoAhIaChJtZWFu",
            "X3NxdWFyZWRfZXJyb3IYBSABKAISFAoMbGluZWFyX2thcHBhGAYgASgCEhcK",
            "D3F1YWRyYXRpY19rYXBwYRgHIAEoAhJhChBjb25mdXNpb25fbWF0cml4GAgg",
            "ASgLMkcuZ29vZ2xlLmNsb3VkLmF1dG9tbC52MS5DbGFzc2lmaWNhdGlvbkV2",
            "YWx1YXRpb25NZXRyaWNzLkNvbmZ1c2lvbk1hdHJpeEK+AQoaY29tLmdvb2ds",
            "ZS5jbG91ZC5hdXRvbWwudjFCElRleHRTZW50aW1lbnRQcm90b1ABWjxnb29n",
            "bGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Nsb3VkL2F1dG9t",
            "bC92MTthdXRvbWyqAhZHb29nbGUuQ2xvdWQuQXV0b01MLlYxygIWR29vZ2xl",
            "XENsb3VkXEF1dG9NbFxWMeoCGUdvb2dsZTo6Q2xvdWQ6OkF1dG9NTDo6VjFi",
            "BnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Cloud.AutoML.V1.ClassificationReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AutoML.V1.TextSentimentAnnotation), global::Google.Cloud.AutoML.V1.TextSentimentAnnotation.Parser, new[]{ "Sentiment" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.AutoML.V1.TextSentimentEvaluationMetrics), global::Google.Cloud.AutoML.V1.TextSentimentEvaluationMetrics.Parser, new[]{ "Precision", "Recall", "F1Score", "MeanAbsoluteError", "MeanSquaredError", "LinearKappa", "QuadraticKappa", "ConfusionMatrix" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Contains annotation details specific to text sentiment.
  /// </summary>
  public sealed partial class TextSentimentAnnotation : pb::IMessage<TextSentimentAnnotation>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TextSentimentAnnotation> _parser = new pb::MessageParser<TextSentimentAnnotation>(() => new TextSentimentAnnotation());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TextSentimentAnnotation> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AutoML.V1.TextSentimentReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TextSentimentAnnotation() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TextSentimentAnnotation(TextSentimentAnnotation other) : this() {
      sentiment_ = other.sentiment_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TextSentimentAnnotation Clone() {
      return new TextSentimentAnnotation(this);
    }

    /// <summary>Field number for the "sentiment" field.</summary>
    public const int SentimentFieldNumber = 1;
    private int sentiment_;
    /// <summary>
    /// Output only. The sentiment with the semantic, as given to the
    /// [AutoMl.ImportData][google.cloud.automl.v1.AutoMl.ImportData] when populating the dataset from which the model used
    /// for the prediction had been trained.
    /// The sentiment values are between 0 and
    /// Dataset.text_sentiment_dataset_metadata.sentiment_max (inclusive),
    /// with higher value meaning more positive sentiment. They are completely
    /// relative, i.e. 0 means least positive sentiment and sentiment_max means
    /// the most positive from the sentiments present in the train data. Therefore
    ///  e.g. if train data had only negative sentiment, then sentiment_max, would
    /// be still negative (although least negative).
    /// The sentiment shouldn't be confused with "score" or "magnitude"
    /// from the previous Natural Language Sentiment Analysis API.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Sentiment {
      get { return sentiment_; }
      set {
        sentiment_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TextSentimentAnnotation);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TextSentimentAnnotation other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Sentiment != other.Sentiment) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Sentiment != 0) hash ^= Sentiment.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Sentiment != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Sentiment);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Sentiment != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(Sentiment);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Sentiment != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Sentiment);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TextSentimentAnnotation other) {
      if (other == null) {
        return;
      }
      if (other.Sentiment != 0) {
        Sentiment = other.Sentiment;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            Sentiment = input.ReadInt32();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            Sentiment = input.ReadInt32();
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// Model evaluation metrics for text sentiment problems.
  /// </summary>
  public sealed partial class TextSentimentEvaluationMetrics : pb::IMessage<TextSentimentEvaluationMetrics>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TextSentimentEvaluationMetrics> _parser = new pb::MessageParser<TextSentimentEvaluationMetrics>(() => new TextSentimentEvaluationMetrics());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TextSentimentEvaluationMetrics> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.AutoML.V1.TextSentimentReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TextSentimentEvaluationMetrics() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TextSentimentEvaluationMetrics(TextSentimentEvaluationMetrics other) : this() {
      precision_ = other.precision_;
      recall_ = other.recall_;
      f1Score_ = other.f1Score_;
      meanAbsoluteError_ = other.meanAbsoluteError_;
      meanSquaredError_ = other.meanSquaredError_;
      linearKappa_ = other.linearKappa_;
      quadraticKappa_ = other.quadraticKappa_;
      confusionMatrix_ = other.confusionMatrix_ != null ? other.confusionMatrix_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TextSentimentEvaluationMetrics Clone() {
      return new TextSentimentEvaluationMetrics(this);
    }

    /// <summary>Field number for the "precision" field.</summary>
    public const int PrecisionFieldNumber = 1;
    private float precision_;
    /// <summary>
    /// Output only. Precision.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float Precision {
      get { return precision_; }
      set {
        precision_ = value;
      }
    }

    /// <summary>Field number for the "recall" field.</summary>
    public const int RecallFieldNumber = 2;
    private float recall_;
    /// <summary>
    /// Output only. Recall.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float Recall {
      get { return recall_; }
      set {
        recall_ = value;
      }
    }

    /// <summary>Field number for the "f1_score" field.</summary>
    public const int F1ScoreFieldNumber = 3;
    private float f1Score_;
    /// <summary>
    /// Output only. The harmonic mean of recall and precision.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float F1Score {
      get { return f1Score_; }
      set {
        f1Score_ = value;
      }
    }

    /// <summary>Field number for the "mean_absolute_error" field.</summary>
    public const int MeanAbsoluteErrorFieldNumber = 4;
    private float meanAbsoluteError_;
    /// <summary>
    /// Output only. Mean absolute error. Only set for the overall model
    /// evaluation, not for evaluation of a single annotation spec.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float MeanAbsoluteError {
      get { return meanAbsoluteError_; }
      set {
        meanAbsoluteError_ = value;
      }
    }

    /// <summary>Field number for the "mean_squared_error" field.</summary>
    public const int MeanSquaredErrorFieldNumber = 5;
    private float meanSquaredError_;
    /// <summary>
    /// Output only. Mean squared error. Only set for the overall model
    /// evaluation, not for evaluation of a single annotation spec.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float MeanSquaredError {
      get { return meanSquaredError_; }
      set {
        meanSquaredError_ = value;
      }
    }

    /// <summary>Field number for the "linear_kappa" field.</summary>
    public const int LinearKappaFieldNumber = 6;
    private float linearKappa_;
    /// <summary>
    /// Output only. Linear weighted kappa. Only set for the overall model
    /// evaluation, not for evaluation of a single annotation spec.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float LinearKappa {
      get { return linearKappa_; }
      set {
        linearKappa_ = value;
      }
    }

    /// <summary>Field number for the "quadratic_kappa" field.</summary>
    public const int QuadraticKappaFieldNumber = 7;
    private float quadraticKappa_;
    /// <summary>
    /// Output only. Quadratic weighted kappa. Only set for the overall model
    /// evaluation, not for evaluation of a single annotation spec.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float QuadraticKappa {
      get { return quadraticKappa_; }
      set {
        quadraticKappa_ = value;
      }
    }

    /// <summary>Field number for the "confusion_matrix" field.</summary>
    public const int ConfusionMatrixFieldNumber = 8;
    private global::Google.Cloud.AutoML.V1.ClassificationEvaluationMetrics.Types.ConfusionMatrix confusionMatrix_;
    /// <summary>
    /// Output only. Confusion matrix of the evaluation.
    /// Only set for the overall model evaluation, not for evaluation of a single
    /// annotation spec.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.AutoML.V1.ClassificationEvaluationMetrics.Types.ConfusionMatrix ConfusionMatrix {
      get { return confusionMatrix_; }
      set {
        confusionMatrix_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TextSentimentEvaluationMetrics);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TextSentimentEvaluationMetrics other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Precision, other.Precision)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Recall, other.Recall)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(F1Score, other.F1Score)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(MeanAbsoluteError, other.MeanAbsoluteError)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(MeanSquaredError, other.MeanSquaredError)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(LinearKappa, other.LinearKappa)) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(QuadraticKappa, other.QuadraticKappa)) return false;
      if (!object.Equals(ConfusionMatrix, other.ConfusionMatrix)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Precision != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Precision);
      if (Recall != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Recall);
      if (F1Score != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(F1Score);
      if (MeanAbsoluteError != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MeanAbsoluteError);
      if (MeanSquaredError != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MeanSquaredError);
      if (LinearKappa != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(LinearKappa);
      if (QuadraticKappa != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(QuadraticKappa);
      if (confusionMatrix_ != null) hash ^= ConfusionMatrix.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Precision != 0F) {
        output.WriteRawTag(13);
        output.WriteFloat(Precision);
      }
      if (Recall != 0F) {
        output.WriteRawTag(21);
        output.WriteFloat(Recall);
      }
      if (F1Score != 0F) {
        output.WriteRawTag(29);
        output.WriteFloat(F1Score);
      }
      if (MeanAbsoluteError != 0F) {
        output.WriteRawTag(37);
        output.WriteFloat(MeanAbsoluteError);
      }
      if (MeanSquaredError != 0F) {
        output.WriteRawTag(45);
        output.WriteFloat(MeanSquaredError);
      }
      if (LinearKappa != 0F) {
        output.WriteRawTag(53);
        output.WriteFloat(LinearKappa);
      }
      if (QuadraticKappa != 0F) {
        output.WriteRawTag(61);
        output.WriteFloat(QuadraticKappa);
      }
      if (confusionMatrix_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(ConfusionMatrix);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Precision != 0F) {
        output.WriteRawTag(13);
        output.WriteFloat(Precision);
      }
      if (Recall != 0F) {
        output.WriteRawTag(21);
        output.WriteFloat(Recall);
      }
      if (F1Score != 0F) {
        output.WriteRawTag(29);
        output.WriteFloat(F1Score);
      }
      if (MeanAbsoluteError != 0F) {
        output.WriteRawTag(37);
        output.WriteFloat(MeanAbsoluteError);
      }
      if (MeanSquaredError != 0F) {
        output.WriteRawTag(45);
        output.WriteFloat(MeanSquaredError);
      }
      if (LinearKappa != 0F) {
        output.WriteRawTag(53);
        output.WriteFloat(LinearKappa);
      }
      if (QuadraticKappa != 0F) {
        output.WriteRawTag(61);
        output.WriteFloat(QuadraticKappa);
      }
      if (confusionMatrix_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(ConfusionMatrix);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Precision != 0F) {
        size += 1 + 4;
      }
      if (Recall != 0F) {
        size += 1 + 4;
      }
      if (F1Score != 0F) {
        size += 1 + 4;
      }
      if (MeanAbsoluteError != 0F) {
        size += 1 + 4;
      }
      if (MeanSquaredError != 0F) {
        size += 1 + 4;
      }
      if (LinearKappa != 0F) {
        size += 1 + 4;
      }
      if (QuadraticKappa != 0F) {
        size += 1 + 4;
      }
      if (confusionMatrix_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ConfusionMatrix);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TextSentimentEvaluationMetrics other) {
      if (other == null) {
        return;
      }
      if (other.Precision != 0F) {
        Precision = other.Precision;
      }
      if (other.Recall != 0F) {
        Recall = other.Recall;
      }
      if (other.F1Score != 0F) {
        F1Score = other.F1Score;
      }
      if (other.MeanAbsoluteError != 0F) {
        MeanAbsoluteError = other.MeanAbsoluteError;
      }
      if (other.MeanSquaredError != 0F) {
        MeanSquaredError = other.MeanSquaredError;
      }
      if (other.LinearKappa != 0F) {
        LinearKappa = other.LinearKappa;
      }
      if (other.QuadraticKappa != 0F) {
        QuadraticKappa = other.QuadraticKappa;
      }
      if (other.confusionMatrix_ != null) {
        if (confusionMatrix_ == null) {
          ConfusionMatrix = new global::Google.Cloud.AutoML.V1.ClassificationEvaluationMetrics.Types.ConfusionMatrix();
        }
        ConfusionMatrix.MergeFrom(other.ConfusionMatrix);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 13: {
            Precision = input.ReadFloat();
            break;
          }
          case 21: {
            Recall = input.ReadFloat();
            break;
          }
          case 29: {
            F1Score = input.ReadFloat();
            break;
          }
          case 37: {
            MeanAbsoluteError = input.ReadFloat();
            break;
          }
          case 45: {
            MeanSquaredError = input.ReadFloat();
            break;
          }
          case 53: {
            LinearKappa = input.ReadFloat();
            break;
          }
          case 61: {
            QuadraticKappa = input.ReadFloat();
            break;
          }
          case 66: {
            if (confusionMatrix_ == null) {
              ConfusionMatrix = new global::Google.Cloud.AutoML.V1.ClassificationEvaluationMetrics.Types.ConfusionMatrix();
            }
            input.ReadMessage(ConfusionMatrix);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 13: {
            Precision = input.ReadFloat();
            break;
          }
          case 21: {
            Recall = input.ReadFloat();
            break;
          }
          case 29: {
            F1Score = input.ReadFloat();
            break;
          }
          case 37: {
            MeanAbsoluteError = input.ReadFloat();
            break;
          }
          case 45: {
            MeanSquaredError = input.ReadFloat();
            break;
          }
          case 53: {
            LinearKappa = input.ReadFloat();
            break;
          }
          case 61: {
            QuadraticKappa = input.ReadFloat();
            break;
          }
          case 66: {
            if (confusionMatrix_ == null) {
              ConfusionMatrix = new global::Google.Cloud.AutoML.V1.ClassificationEvaluationMetrics.Types.ConfusionMatrix();
            }
            input.ReadMessage(ConfusionMatrix);
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
