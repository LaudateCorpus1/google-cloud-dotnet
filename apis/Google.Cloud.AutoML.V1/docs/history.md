# Version history

## Version 2.5.0, released 2022-01-17

### Bug fixes

- Proto field markdown comment for the display_name field in annotation_payload.proto to point the correct public v1/ version ([commit c26a158](https://github.com/googleapis/google-cloud-dotnet/commit/c26a15832ac35576ec09cf8f54e18170443dd8bf))
- Add back java_multiple_files option to the text_sentiment.proto to match with the previous published version of text_sentiment proto ([commit c26a158](https://github.com/googleapis/google-cloud-dotnet/commit/c26a15832ac35576ec09cf8f54e18170443dd8bf))
- **BREAKING CHANGE** One of the fields now have field_behavior as REQUIRED in cloud/automl/v1 service definition. ([commit b1398f1](https://github.com/googleapis/google-cloud-dotnet/commit/b1398f19035a33d46b0574b486aaf6d80fe86b6e))

### New features

- Publish updated protos for cloud/automl/v1 service ([commit b1398f1](https://github.com/googleapis/google-cloud-dotnet/commit/b1398f19035a33d46b0574b486aaf6d80fe86b6e))

## Version 2.4.0, released 2021-12-07

- [Commit f182ed9](https://github.com/googleapis/google-cloud-dotnet/commit/f182ed9): docs: fix docstring formatting

## Version 2.3.0, released 2021-08-19

- [Commit ac367e2](https://github.com/googleapis/google-cloud-dotnet/commit/ac367e2): feat: Regenerate all APIs to support self-signed JWTs

## Version 2.2.0, released 2021-05-25

No API surface changes; just dependency updates.

## Version 2.1.0, released 2020-10-07

- [Commit 0790924](https://github.com/googleapis/google-cloud-dotnet/commit/0790924): fix: Add gRPC compatibility constructors
- [Commit 0ca05f5](https://github.com/googleapis/google-cloud-dotnet/commit/0ca05f5): chore: Regenerate all APIs using protoc 3.13 and Grpc.Tools 2.31
- [Commit 6bde7a3](https://github.com/googleapis/google-cloud-dotnet/commit/6bde7a3): docs: Regenerate all APIs with service comments in client documentation
- [Commit f83bdf1](https://github.com/googleapis/google-cloud-dotnet/commit/f83bdf1): fix: Regenerate all APIs with generator changes (fixes timeouts)
- [Commit 947a573](https://github.com/googleapis/google-cloud-dotnet/commit/947a573): docs: Regenerate all clients with more explicit documentation
- [Commit 3e2a816](https://github.com/googleapis/google-cloud-dotnet/commit/3e2a816): docs: Remove raw html from proto comments as this breaks client library documentation generators.

In addition, dependencies have been updated.

## Version 2.0.0, released 2020-03-17

No API surface changes compared with 2.0.0-beta01, just dependencies
and implementation changes.

## Version 2.0.0-beta01, released 2020-03-05

This is the first prerelease targeting GAX v3. Please see the
[breaking changes guide](https://cloud.google.com/dotnet/docs/reference/help/breaking-gax2)
for details of changes to both GAX and code generation.

## Version 1.0.0, released 2019-12-10

First GA release. No API surface changes since 1.0.0-beta03.

## Version 1.0.0-beta03, released 2019-11-07

- [Commit 1c275a8](https://github.com/googleapis/google-cloud-dotnet/commit/1c275a8): Removed ImageInputConfig
- [Commit fda30ff](https://github.com/googleapis/google-cloud-dotnet/commit/fda30ff): New RPCs, with supporting classes and properties:
  - GetAnnotationSpec
  - DeployModel
  - ExportModel
  - UndeployModel
  - BatchPredict

## Version 1.0.0-beta02, released 2019-10-08

- [Commit fb2b456](https://github.com/googleapis/google-cloud-dotnet/commit/fb2b456): Modifies long-running operations to give them response/metadata types

## Version 1.0.0-beta01, released 2019-09-24

- [Commit ba7dfdd](https://github.com/googleapis/google-cloud-dotnet/commit/ba7dfdd): First generation of AutoML

