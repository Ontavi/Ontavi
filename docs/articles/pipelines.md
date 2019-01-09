![Pipelines](/images/pipeline1.png)

# What is a pipeline?

A Pipeline is similar to a workflow; it is a series of tasks to execute upon one or more sets of data. The starting activity of a pipeline is the Trigger. The data output of a pipeline is provided to one or more Sinks. The steps in between to transform, manipulate, or enrich the data are called Middleware.

Middleware typically accept input data and generate some sort of output. This data is made available to other middleware further in the pipeline by using Variables. Variables must have a Schema in the pipeline definition to describe the structure of the data.

Each middleware has a list of inputs and outputs. Inputs and outputs have a name (e.g. *source*, *query*, or *containerName*) defined by the middleware's creator. Typically, input and output types are well known; however, sometimes the structure of outputs is dependent on how the middleware is configured, such as SQL query resultsets.

Pipelines fully support **extract, transform, load (ETL)** workloads of very large sizes. Large datasets are supported by streaming chunks of data at a time through middleware instead of the entire dataset. In the future, this will also allow the Ontavi engine to parallelize larger pipelines across multiple agents for CPU-bound work.

Additionally, pipelines also fully support **transactional, streaming messages** that are smaller but higher in volume. Ontavi pipelines execute near the speed of native C# and middleware is optimized for performance.

## A simple example

The following example is a relatively simple pipeline that demonstrates the core functionality of Ontavi.

[!code-yaml[storage-to-sql.yml](../../samples/yaml/storage-to-sql.yml)]

# Triggers

# Middleware

# Schemas

# Sinks

