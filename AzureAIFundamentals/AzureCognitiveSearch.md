## Introduction to Azure Cognitive Search
### Overview
- Knowledge mining is the term used to describe solutions that involve extracting information from large volumes of often unstructured data.
- One of these knowledge mining solutions is Azure Cognitive Search, a cloud search service that has tools for building user-managed indexes.
- The indexes can be used for internal only use, or to enable searchable content on public-facing internet assets.

### Use of AI
- Azure Cognitive Search can utilize the built-in AI capabilities of Azure Cognitive Services such as...
    - image processing,
    - content extraction,
    - natural language processing
- The product's AI capabilities makes it possible to...
    - index previously unsearchable documents
    - extract and surface insights from large amounts of data quickly

### Features
- `Data from any source`
    - Accepts data from any source provided in JSON format, with auto crawling support for selected data sources in Azure
- `Full text search and analysis`
    - Full text search capabilities supporting both simple query and full **Lucene** query syntax.
- `AI powered search`
    - Cognitive AI capabilities built in for image and text analysis from raw content.
- `Multi-lingual`
- `Geo-enabled`
- `Configurable user experience`
    - Features to improve user experience: _autocomplete_, _autosuggest_, _pagination_, _hit highlighting_

### Use a skillset to define an enrichment pipeline
- AI enrichment refers to embedded image and natural language processing in a pipeline that extracts text and information from content that can't otherwise be indexed for full text search.
- AI processing is achieved by adding and combining skills in a skillset.
- A skillset defines the operations that extract and enrich data to make it searchable.
- These AI skills can be either built-in skills, such as 
    - text translation
    - Optical Character Recognition (OCR)
- or custom skills that you provide.
### Built in skills
- Natural language processing skills: with these skills, unstructured text is mapped as searchable and filterable fields in an index.
- Some examples include:
    - Key Phrase Extraction: uses a pre-trained model to detect important phrases based on term placement, linguistic rules, proximity to other terms, and how unusual the term is within the source data.
    - Text Translation Skill: uses a pre-trained model to translate the input text into various languages for normalization or localization use cases.
- Image processing skills: creates text representations of image content, making it searchable using the query capabilities of Azure Cognitive Search.
- Some examples include:
    - Image Analysis Skill: uses an image detection algorithm to identify the content of an image and generate a text description.
    - Optical Character Recognition Skill: allows you to extract printed or handwritten text from images, such as photos of street signs and products, as well as from documents—invoices, bills, financial reports, articles, and more.
### Understanding Indexes
- A index is a persistent collection of JSON documents and other content used to enable search functionality.
- The documents within an index can be thought of as rows in a table, each document is a single unit of searchable data in the index.

### Use an indexer to build an index
- In order to index the documents in Azure Storage, they need to be exported from their original file type to JSON.
- In order to export data in any format to JSON, and load it into an index, we use an indexer.

- To create search documents, you can either...
    - generate JSON documents with application code or 
    - use Azure's indexer to export incoming documents into JSON.

- Create and load JSON documents into an index with two approaches:
    1. `Push method`: JSON data is pushed into a search index via either the REST API or the .NET SDK. Pushing data has the most flexibility as it has no restrictions on the data source type, location, or frequency of execution.
    1. `Pull method`: Search service indexers can pull data from popular Azure data sources, and if necessary, export that data into JSON if it isn't already in that format.

### Making changes to an index
- You have to drop and recreate indexes if you need to make changes to field definitions.
- Adding new fields is supported, with all existing documents having null values.
- You'll find it faster using a code-based approach to iterate your designs, as working in the portal requires the index to be deleted, recreated, and the schema details to be manually filled out.
- An approach to updating an index without affecting your users is to create a new index under a different name.
    - You can use the same indexer and data source.
    - After importing data, you can switch your app to use the new index.

### Persist enriched data in a knowledge store
- A knowledge store is persistent storage of enriched content.
- The purpose of a knowledge store is to store the data generated from AI enrichment in a container.
- For example, you may want to save the results of an AI skillset that generates captions from images.
- A knowledge store can contain one or more of three types of projection of the extracted data:
    1. Table projections are used to structure the extracted data in a relational schema for querying and visualization
    1. Object projections are JSON documents that represent each data entity
    1. File projections are used to store extracted images in JPG format

### Create an index in the Azure portal
- Supported data sources include:
    - Cosmos DB (SQL API)
    - Azure SQL (database, managed instance, and SQL Server on an Azure VM)
    - Azure Storage (Blob Storage, Table Storage, ADLS Gen2)

### Query data in an Azure Cognitive Search index
- [OData language overview for $filter, $orderby, and $select in Azure Cognitive Search](https://learn.microsoft.com/en-us/azure/search/query-odata-filter-orderby-syntax)

### Exercise - [Explore knowledge mining](https://microsoftlearning.github.io/AI-900-AIFundamentals/instructions/05-create-cognitive-search-solution.html)
- Create Azure resources
- Extract data from a data source
- Enrich data with AI skills
- Use Azure’s indexer in the Azure portal
- Query your search index
- Review results saved to a Knowledge Store
