![Ontavi](https://github.com/Ontavi/Ontavi/raw/master/docs/images/mark-big.png)
# What is Ontavi?

Ontavi is an integration engine and runtime that sits on top of the .NET Standard. Designed to run in .NET Core or .NET Framework, Ontavi supports both Linux and Windows. 

Ontavi runs workflows called Pipelines that execute a series of Middleware, parsing and transforming data until it reaches a Sink. Pipelines are started via a Trigger, support branching, and send can send data to multiple Sinks. 

Ontavi supports a number of system connections out of the box, like cloud storage (Amazon S3, Azure Blob Storage, Google Cloud Storage), Microsoft SQL Server, Oracle, MySQL/MariaDB, NoSQL databases (such as Redis, MongoDB, and Cassandra), AMQP servers, HTTP, and more. 

If there's a system that Ontavi cannot talk to natively, teams can use the Ontavi SDK (or fork the engine) to write custom connectors.

## What problems does Ontavi aim to solve?

**Ontavi is designed to support both streaming and batch data integration needs.** This includes large, batch-oriented processing and small, transactional data streams. 

Ontavi can handle both and provide you and your team with a **consistent development process** for both types of pipelines while allowing you to customize the engine as much or as little as you require.

## What problems does Ontavi NOT aim to solve?

**Ontavi is not a data repository.** The only data that Ontavi contains are metadata used to run the engine and pipeline data in flight, used for fault recovery.

**Ontavi does not have source control management for your pipelines.** We expose an API and CLI to deploy pipelines artifacts to the engine, but you should use your own SCM (such as Git) to version your source files. Adding Ontavi to your CI/CD process is as simple as executing a script.

# Who is behind Ontavi?

Ontavi was started by Will Graham, a software engineer in Charlotte, NC. After years of working with various integration tools, we felt there was a gap in the market for flexible, powerful, and *performant* integration engines. With decades of data integration experience on the team, Ontavi was born.

# Why open source?

Simple: We have jobs. We have families. We are passionate about integration and feel like the market deserves a better product. We feel that the .NET ecosystem has evolved to a point where a project such as this being open source is acceptable. And most importantly, we recognize that the community can help make Ontavi the best it can be.
