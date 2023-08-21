## [Process and translate text with Azure Cognitive Services](https://learn.microsoft.com/en-us/training/paths/process-translate-text-azure-cognitive-services/)

### Process Text
- The Language service is designed to help you extract information from text. It provides functionality that you can use for:
  - `Language detection` - determining the language in which text is written.
  - `Key phrase extraction` - identifying important words and phrases in the text that indicate the main points.
  - `Sentiment analysis` - quantifying how positive or negative the text is.
  - `Named entity recognition` - detecting references to entities, including people, locations, time periods, organizations, and more.
  - `Entity linking` - identifying specific entities by providing reference `links to Wikipedia` articles.
- ``` dotnet add package Azure.AI.TextAnalytics --version 5.3.0```

#### Detect language
- The Language Detection API evaluates text input and, for each document submitted, returns language identifiers with a `score indicating the strength of the analysis`.
- The Language service recognizes up to `120 languages`.
- Document size must be `under 5,120 characters`.
- The size limit is per document and each collection is restricted to `1,000 items` (IDs).
- Optionally, you can provide a `countryHint` to improve prediction performance.
- If language can't be detected...
    ```json
    "detectedLanguages": [
      {
        "name": "(Unknown)",
        "iso6391Name": "(Unknown)",
        "score": "NaN"
      }
    ]
    ```

#### Extract key phrases
- Key phrase extraction works best for larger documents (the `maximum size that can be analyzed is 5,120 characters`).
- Response...
    ```json
    {
      "documents": [
        {
          "id": "1",
          "keyPhrases": [
            "change",
            "world"
          ]
        }
      ],
      "errors": []
    }
    ```

#### Analyse sentiment
- Sentence sentiment is based on confidence scores for `positive`, `negative`, and `neutral` classification values between 0 and 1.

- Overall document sentiment is based on sentences:
  - If all sentences are neutral, the overall sentiment is neutral.
  - If sentence classifications include only positive and neutral, the overall sentiment is positive.
  - If the sentence classifications include only negative and neutral, the overall sentiment is negative.
  - If the sentence classifications include positive and negative, the overall sentiment is mixed.

#### Extract entities
- Named Entity Recognition identifies entities that are mentioned in the text.
- Entities are grouped into categories and subcategories, for example:
  - Person
  - Location
  - DateTime
  - Organization
  - Address
  - Email
  - URL
- [Supported Named Entity Recognition (NER) entity categories and entity types](https://learn.microsoft.com/en-us/azure/ai-services/language-service/named-entity-recognition/concepts/named-entity-categories?tabs=ga-api)

#### Extract linked entities
- Entity linking can be used to `disambiguate entities of the same name` by referencing an article in a knowledge base.
- `Wikipedia provides the knowledge base` for the Text Analytics service. Specific article links are determined based on entity context within the text.

### Translate Text
- The Translator Service provides an API for translating text between `90 supported languages`.
- The Translator service provides a multilingual text translation API that you can use for:
  - Language detection
  - One-to-many translation
  - Script transliteration (converting text from its native script to an alternative script)

#### Translate options
- `Word alignment` is the process of identifying the words in the source text that correspond to the words in the translated text.
- `Sentence length` of the translated text can be included in the response.
- `Profanity filtering`
  - NoAction: Profanities are translated along with the rest of the text.
  - Deleted: Profanities are omitted in the translation.
  - Marked: Replaced with asterisks.

#### Define custom translations
- Use the `Custom Translator portal` to...
  1. Create a workspace linked to your Translator resource
  1. Create a project
  1. Upload training data files
  1. Train a model
  1. Switch from the default model to the custom model

