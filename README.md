# Bestseller

This is a bestseller fork of MassTransit.
Primarily used and managed by @BESTSELLER/digital-media-marketing for the [StorM project](https://backstage.k8s.bestcorp.net/catalog/default/system/storm)

For now, these packages will be manually packed and pushed to the GitHub nuget repository

# MassTransit

MassTransit is a _free, open-source_ distributed application framework for .NET. MassTransit makes it easy to create applications and services that leverage message-based, loosely-coupled asynchronous communication for higher availability, reliability, and scalability.

![Mass Transit](https://avatars2.githubusercontent.com/u/317796?s=200&v=4 "Mass Transit")

MassTransit is Apache 2.0 licensed.

## Documentation

Get started by [reading through the documentation](https://masstransit-project.com/).

## Build Status

| Branch        |                                                                                                Status                                                                                                |
| ------------- | :--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------: |
| master        |    [![master](https://github.com/MassTransit/MassTransit/actions/workflows/build.yml/badge.svg?branch=master&event=push)](https://github.com/MassTransit/MassTransit/actions/workflows/build.yml)    |
| develop       |   [![develop](https://github.com/MassTransit/MassTransit/actions/workflows/build.yml/badge.svg?branch=develop&event=push)](https://github.com/MassTransit/MassTransit/actions/workflows/build.yml)   |
| documentation | [![documentation](https://github.com/MassTransit/MassTransit/actions/workflows/docs.yml/badge.svg?branch=develop&event=push)](https://github.com/MassTransit/MassTransit/actions/workflows/docs.yml) |

## MassTransit NuGet Packages

| Package Name                                                    | .NET | .NET Standard | .NET Framework |
| --------------------------------------------------------------- | :--: | :-----------: | :------------: |
| **Main**                                                        |      |               |                |
| [MassTransit][masstransit.nuget]                                | 6.0  |   2.0, 2.1    |     4.6.1      |
| [MassTransit.Abstractions][masstransitabstractions.nuget]       | 6.0  |   2.0, 2.1    |     4.6.1      |
| [MassTransit.Newtonsoft][masstransitnewtonsoft.nuget]           | 6.0  |      2.0      |     4.6.1      |
| **Other**                                                       |      |               |                |
| [MassTransit.Analyzers][analyzers.nuget]                        |      |      2.0      |                |
| [MassTransit.Templates][templates.nuget]                        | 5.0  |               |                |
| [MassTransit.SignalR][signalr.nuget]                            | 6.0  |               |     4.6.1      |
| [MassTransit.Interop.NServiceBus][masstransitnservicebus.nuget] | 6.0  |      2.0      |     4.6.1      |
| [MassTransit.TestFramework][testframework.nuget]                | 6.0  |   2.0, 2.1    |     4.6.1      |
| **Monitoring**                                                  |      |               |                |
| [MassTransit.Prometheus][prometheus.nuget]                      | 6.0  |      2.0      |     4.6.2      |
| **Persistence**                                                 |      |               |                |
| [MassTransit.Azure.Cosmos][cosmos.nuget]                        | 6.0  |   2.0, 2.1    |     4.6.1      |
| [MassTransit.Azure.Storage][azurestorage.nuget]                 | 6.0  |   2.0, 2.1    |     4.6.1      |
| [MassTransit.Azure.Table][azuretable.nuget]                     | 6.0  |   2.0, 2.1    |     4.6.1      |
| [MassTransit.Dapper][dapper.nuget]                              | 6.0  |   2.0, 2.1    |     4.6.1      |
| [MassTransit.DynamoDb][dynamodb.nuget]                          | 6.0  |      2.0      |     4.6.1      |
| [MassTransit.EntityFrameworkCore][efcore.nuget]                 | 6.0  |      2.0      |                |
| [MassTransit.EntityFramework][ef.nuget]                         |      |      2.1      |     4.6.1      |
| [MassTransit.Marten][marten.nuget]                              | 6.0  |   2.0, 2.1    |     4.6.1      |
| [MassTransit.MongoDb][mongodb.nuget]                            | 6.0  |   2.0, 2.1    |     4.6.1      |
| [MassTransit.NHibernate][nhibernate.nuget]                      | 6.0  |   2.0, 2.1    |     4.6.1      |
| [MassTransit.Redis][redis.nuget]                                | 6.0  |   2.0, 2.1    |     4.6.1      |
| **Scheduling**                                                  |      |               |                |
| [MassTransit.Hangfire][hangfire.nuget]                          | 6.0  |   2.0, 2.1    |     4.6.1      |
| [MassTransit.Quartz][quartz.nuget]                              | 6.0  |   2.0, 2.1    |     4.6.1      |
| **Transports**                                                  |      |               |                |
| [MassTransit.ActiveMQ][activemq.nuget]                          | 6.0  |   2.0, 2.1    |     4.6.1      |
| [MassTransit.AmazonSQS][amazonsqs.nuget]                        | 6.0  |      2.0      |     4.6.1      |
| [MassTransit.Azure.ServiceBus.Core][azuresbcore.nuget]          | 6.0  |   2.0, 2.1    |     4.6.1      |
| [MassTransit.Grpc][grpc.nuget]                                  | 6.0  |   2.0, 2.1    |     4.6.1      |
| [MassTransit.RabbitMQ][rabbitmq.nuget]                          | 6.0  |   2.0, 2.1    |     4.6.1      |
| [MassTransit.WebJobs.EventHubs][eventhubs.nuget]                | 6.0  |   2.0, 2.1    |     4.6.1      |
| [MassTransit.WebJobs.ServiceBus][azurefunc.nuget]               | 6.0  |   2.0, 2.1    |     4.6.1      |
| **Riders**                                                      |      |               |                |
| [MassTransit.Kafka][kafka.nuget]                                | 6.0  |   2.0, 2.1    |     4.6.1      |
| [MassTransit.EventHub][eventhub.nuget]                          | 6.0  |   2.0, 2.1    |     4.6.1      |

## Discord

Get help live at the MassTransit Discord server.

[![alt Join the conversation](https://img.shields.io/discord/682238261753675864.svg "Discord")](https://discord.gg/rNpQgYn)

## GitHub Issues

**Pay attention**

Please do not open an issue on GitHub, unless you have spotted an actual bug in MassTransit.

Use [GitHub Discussions](https://github.com/MassTransit/MassTransit/discussions) to ask questions, bring up ideas, or other general items. Issues are not the place for questions, and will either be converted to a discussion or closed.

This policy is in place to avoid bugs being drowned out in a pile of sensible suggestions for future
enhancements and calls for help from people who forget to check back if they get it and so on.

## Building from Source

1.  Install the latest [.NET 6 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/6.0)
2.  Clone the source down to your machine<br/>
    ```bash
    git clone https://github.com/MassTransit/MassTransit.git
    ```
3.  Run `dotnet build`

## Contributing

1.  Turn off `autocrlf`
    ```bash
    git config core.autocrlf false
    ```
2.  Hack!
3.  Make a pull request

# REQUIREMENTS

-   .NET 6 SDK

# CREDITS

Logo Design by _The Agile Badger_

[masstransit.nuget]: https://www.nuget.org/packages/MassTransit
[masstransitabstractions.nuget]: https://www.nuget.org/packages/MassTransit.Abstractions
[masstransitnewtonsoft.nuget]: https://www.nuget.org/packages/MassTransit.Newtonsoft
[masstransitnservicebus.nuget]: https://www.nuget.org/packages/MassTransit.Interop.NServiceBus
[analyzers.nuget]: https://www.nuget.org/packages/MassTransit.Analyzers
[templates.nuget]: https://www.nuget.org/packages/MassTransit.Templates
[signalr.nuget]: https://www.nuget.org/packages/MassTransit.SignalR
[testframework.nuget]: https://www.nuget.org/packages/MassTransit.TestFramework
[prometheus.nuget]: https://www.nuget.org/packages/MassTransit.Prometheus
[cosmos.nuget]: https://www.nuget.org/packages/MassTransit.Azure.Cosmos
[azurestorage.nuget]: https://www.nuget.org/packages/MassTransit.Azure.Storage
[azuretable.nuget]: https://www.nuget.org/packages/MassTransit.Azure.Table
[dapper.nuget]: https://www.nuget.org/packages/MassTransit.DapperIntegration
[dynamodb.nuget]: https://www.nuget.org/packages/MassTransit.DynamoDb
[efcore.nuget]: https://www.nuget.org/packages/MassTransit.EntityFrameworkCore
[ef.nuget]: https://www.nuget.org/packages/MassTransit.EntityFramework
[marten.nuget]: https://www.nuget.org/packages/MassTransit.Marten
[mongodb.nuget]: https://www.nuget.org/packages/MassTransit.MongoDb
[nhibernate.nuget]: https://www.nuget.org/packages/MassTransit.NHibernate
[redis.nuget]: https://www.nuget.org/packages/MassTransit.Redis
[hangfire.nuget]: https://www.nuget.org/packages/MassTransit.Hangfire
[quartz.nuget]: https://www.nuget.org/packages/MassTransit.Quartz
[activemq.nuget]: https://www.nuget.org/packages/MassTransit.ActiveMQ
[amazonsqs.nuget]: https://www.nuget.org/packages/MassTransit.AmazonSQS
[azuresbcore.nuget]: https://www.nuget.org/packages/MassTransit.Azure.ServiceBus.Core
[grpc.nuget]: https://www.nuget.org/packages/MassTransit.Grpc
[rabbitmq.nuget]: https://www.nuget.org/packages/MassTransit.RabbitMQ
[eventhubs.nuget]: https://www.nuget.org/packages/MassTransit.WebJobs.EventHubs
[azurefunc.nuget]: https://www.nuget.org/packages/MassTransit.WebJobs.ServiceBus
[kafka.nuget]: https://www.nuget.org/packages/MassTransit.Kafka
[eventhub.nuget]: https://www.nuget.org/packages/MassTransit.EventHub
