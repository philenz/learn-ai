# [John Savill AI-102 Study Cram](https://www.youtube.com/watch?v=I7fdWafTcPY)
## Overview
- [Whiteboard](https://raw.githubusercontent.com/johnthebrit/CertificationMaterials/main/whiteboards/AI-102-Whiteboard.png)
- AI...
    1. Decision making
    2. Speech
    3. Vision
    4. Language
- AI > Machine learning (ML) > Data Science (DS)
    - AI: Decision making
    - ML: Data and algorithms to train prediction models
    - DS: Analyse data
    - Lots of Layers below AI
## 20 x Azure AI Services
1. Azure OpenAI account
1. Cognitive search
1. Computer vision
1. Face API
1. Custom vision
1. Speech service
1. Language service
1. Translator
1. Form recognizer
1. Bot services
1. Video analyzer
1. Anomoly detector
1. Content moderator
1. Health Insights
1. Personalizer
1. Metrics advisor
1. Immersive reader
1. Content safety
1. Language understanding
1. QnA maker
- Can combine services using a `Azure AI services multi-service account`
    - single endpoint
    - single key
    - no free tier
## Machine Learning
1. Azure Machine Learning
1. Azure Synapse Analytics
## Chapters
#### 37:12 - Network protection
- AI service endpoint has its own firewall
#### 39:15 - REST API and SDK
- [Examples](https://github.com/MicrosoftLearning/AI-102-AIEngineer/tree/master/01-getting-started/C-Sharp)
#### 44:40 - Pricing and monitoring
- Transaction pricing
- Set alerts based on current spend or forecasted spend
- Set alerts based on metrics
#### 49:53 - Deploying to containers
- May need to deploy your model on-premises/locally
- Can do so [using containers](https://learn.microsoft.com/en-us/azure/ai-services/cognitive-services-container-support)
- Pull AI service images from https://mcr.microsoft.com/
- Still needs internet to accept eula, billing, set api key
#### 57:08 - Visual Perception services
- `Image Analysis`: description, tags, categories, objects with bounds, thumbnail, confidence score, content moderation
- `Video Analysis`: facial recognition, OCR, speech, topics, sentiment, labels, content moderation, scene segmentation
- `Image Classification`: train a model to classify images, multi-label possible
- `Object Detection`
- `Facial Analysis`: 
    - face service can do detection/verification, remembering a face for 24 hours
    - face service can do recognition for specific faces
- `OCR`:
    - `Read API` for processing mass input such as books
    - `Image Analysis API` for small inputs
#### 1:11:03 - Language Understanding
##### Learned
- `CLU`: Intent: Utterences [entity]: train -> test -> deploy -> review
- `Custom named entities`: data.labels [json]
- `Custom text classification`: single vs multi-label
  - `Recall`: how many of the actual positives our model identified
  - `Precision`: how many of the items we identified were actually positive
##### Pre-configuration
- Summarization
- PI Detection

#### 1:21:01 - Question answering and text analysis
- `Q&A`: Create a knowledge base, with input from a variety of sources
  - e.g.: file, faq, chit-chat
- `Text analysis`: sentiment, key phrases, language detection, named entity recognition, entity linking
#### 1:25:41 - Translation
- Language detection
- One-to-many translation
- Transliteration
#### 1:27:36 - Speech services
- Speech to text
- Text to speech
- SSML = `Speech synthesis markup language`
#### 1:31:43 - Speech translation
- 2 Klingons!
- `Synthesize translations`
  - event-based if 1 input lang and one output lang
  - otherwise run manually
#### 1:34:28 - Decision making
- Anomaly detection
- Content personalization
- Content moderation
#### 1:37:03 - Forms recognizer and other pre-built
- Form recognizer
  - jpeg,png,pdf,tiff (500mb max)
  - prebuilt vs custom model
  - forms recognizer studio
- Metrics advisor
- Video analyzer for media
- Immersive reader
#### 1:41:51 - Bot service
1. Azure Bot Service
1. Bot framework service (REST)
1. Bot framework SDK (C#)
   - implement activity handlers etc
   - local bot framework emulator
#### 1:45:28 - Cognitive search
- Ingest -> index -> enrich
- Data sources...
  - Blob
  - Cosmos DB
  - SQL
  - `Azure Data Factory`
- Tiers
   - Free / Basic / Standard / Storage Optimized
- Structure
   - Have a number of `Replicas`, which are copies of your indexes
   - Each of which has the same number of `Partitions`
   - `Search Units` = `Replicas` * `Partitions` (max = 36)
- 99.9% availability guaranteed where...
    - `Replicas` >= 2 for read-only workloads
    - `Partitions` >= 2 for read-write workloads
- Enrichment comes from a `skillset`
    - Can do a `projection` of a skillset into a knowledge store
    - Can create a `custom skill` to do your own enrichment
- Lucene under the covers!
#### 1:55:42 - Azure OpenAI services
- LLMs (e.g.: GPT-3.5/4, DALL-E, Embeddings)
- H-U-G-E effort and expense to train
- We PROMPT the model with a question
- We get an INFERENCE back
- We want the prompt we give to be GROUNDED first
    - Can add data from upload, blob, or `cognitive search index`
    - WOW!
