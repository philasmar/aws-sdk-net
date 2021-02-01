# Open Feature Requests for the AWS SDK for .NET

This is a list of feature requests which come in as github issues. When they
come in, we will usually [tag them][tag] as feature requests, close them and
add them to this list.

Please refer to the individual issues to discuss or plus-one them.

[tag]: https://github.com/aws/aws-sdk-net/labels/Feature%20Request

#### Enable use of KMS keys for S3 Client encryption

Currently the ```AmazonS3EncryptionClient``` does not support the use of 
KMS-managed customer-master keys for use with client-side encryption.

See [GitHub Issue #272](https://github.com/aws/aws-sdk-net/issues/272)

#### Expose ConsumedCapacity and pagination within DynamoDB OPM

Add support to DynamoDB Object Persistence Model to retrieve ConsumedCapacity
for operations, as well as support for manually paginating Query and Scan results.
Current API does not support these natively and users must call the low-level
client to do this.

See [GitHub Issue #271](https://github.com/aws/aws-sdk-net/issues/271)

#### Support environment variable config for default region 

Add ability to configure the default region using environment variables. 
This makes it easier to have the entire AWS config in environment variables 
instead of mixing application config files and env vars.

See [GitHub Issue #265](https://github.com/aws/aws-sdk-net/issues/265)

#### Support for alternative HTTP clients

For some platforms, it would be useful to have the SDK use a different
underlying HTTP client (such as
[ModernHttpClient](https://github.com/paulcbetts/ModernHttpClient) for iOS and
Android) to make requests.

See [GitHub Issue #254](https://github.com/aws/aws-sdk-net/issues/254)

#### Add multi-file/directory upload capability to the Xamarin SDK

See [GitHub Issue #239](https://github.com/aws/aws-sdk-net/issues/239)

#### Allow Overriding of HTTP method for APIs which accept multiple methods

Some APIs (such as ```CloudSearchDomain.Search```) can accept
both ```GET``` and ```POST``` requests. Allow the user to select which
method is used, and whether the parameters go in the query string or body.

See [GitHub Issue #235](https://github.com/aws/aws-sdk-net/issues/235)

#### Expose the functionality of ```FallbackCredentialsFactory``` as public

See [GitHub Issue #206](https://github.com/aws/aws-sdk-net/issues/206)

#### Add a progress callback for ```UploadDirectoryAsync```

To facilitate taking an action after the upload of each file in a directory
when using the TransferUtility, add the ability to call a callback after
each file is successfully uploaded.

See [GitHub Issue #165](https://github.com/aws/aws-sdk-net/issues/165)

#### Add an Equals operator to the DynamoDB ```AttributeValue``` class

The class in question is ```Amazon.DynamoDBv2.Model.AttributeValue```, which
is a generated partial class.

See [GitHub Issue #163](https://github.com/aws/aws-sdk-net/issues/163)

#### Expand the types that the DynamoDB ```AttributeValue``` can be constructed from

The class in question is ```Amazon.DynamoDBv2.Model.AttributeValue```, which
is a generated partial class.

See [GitHub Issue #146](https://github.com/aws/aws-sdk-net/issues/146)

#### Support Mono as a first-class SDK platform

See [GitHub Issue #100](https://github.com/aws/aws-sdk-net/issues/100)

#### Transaction library for DynamoDB

Similar to the [transaction library in Java](https://aws.amazon.com/blogs/aws/dynamodb-transaction-library/)

See [GitHub Issue #25](https://github.com/aws/aws-sdk-net/issues/25)

#### Add support for Xamarin.Mac

See [Github Issue #307](https://github.com/aws/aws-sdk-net/issues/307)

#### Make exception types defined in the SDK serializable

See [Github Issue #296](https://github.com/aws/aws-sdk-net/issues/296)

#### Unity - Webgl Support

See [Github Issue #362](https://github.com/aws/aws-sdk-net/issues/326)

#### Unity - Windows 8 & Win Store support

See [Github Issue #67](https://github.com/aws/aws-sdk-unity/issues/67)

#### Cognito Sync Manager - Add support for Sync Success callback

See [Github Issue #51](https://github.com/aws/aws-sdk-unity/issues/51)

#### Unity - Get information regarding number of bytes downloaded

See [Github Issue #68](https://github.com/aws/aws-sdk-unity/issues/68)

#### Unity - Add support for Unity Editor

See [Github Issue #37](https://github.com/aws/aws-sdk-unity/issues/37)

#### Cognito Sync - Object mapper support

See [Github Issue #33](https://github.com/aws/aws-sdk-unity/issues/33)

#### Cognito User Pools for Unity SDK

See [Github Issue #369](https://github.com/aws/aws-sdk-unity/issues/369)

#### DynamoDb DocumentModel difficult to create stubs

See [Github Issue #604](https://github.com/aws/aws-sdk-net/issues/604)

#### Add interfaces for classes with internal constructors as returned by IDynamoDBContext methods

See [Github Issue #632](https://github.com/aws/aws-sdk-net/issues/632)

#### AWS SDK (Unity) Support for Windows Store (Hololens)

See [Github Issue #337](https://github.com/aws/aws-sdk-net/issues/337)

#### Support AmazonS3EncryptionClient in PCL

Currently the ```AmazonS3EncryptionClient``` is not supported on the
PCL platform. This is low-priority, as the PCL platform may be going
away in the future.

See [GitHub Issue #292](https://github.com/aws/aws-sdk-net/issues/292)

#### Refactor and make signing code public, for direct use by SDK consumers.

See [GitHub Issue #397](https://github.com/aws/aws-sdk-net/issues/397)

#### Support SAML profiles in .NET Core

See [GitHub Issue #496](https://github.com/aws/aws-sdk-net/issues/496)

#### ASP.NET Data Protection Support

See [GitHub Issue #371](https://github.com/aws/aws-sdk-net/issues/371)

#### Add settings to appsettings.json

See GitHub Issues [#656](https://github.com/aws/aws-sdk-net/issues/656) and [#624](https://github.com/aws/aws-sdk-net/issues/624)

#### Return list of DynamoDBContext batch-operation unprocessed objects

See [GitHub Issue #623](https://github.com/aws/aws-sdk-net/issues/623)

#### Support AES/GCM/NoPadding content encryption in the AmazonS3EncryptionClient (.NET 3.5/4.5 only)

See [GitHub Issue #748](https://github.com/aws/aws-sdk-net/issues/748)