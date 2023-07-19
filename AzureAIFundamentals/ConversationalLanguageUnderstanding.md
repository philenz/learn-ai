## Create a language model with Conversational Language Understanding
- On Microsoft Azure, conversational language understanding is supported through the **Language Service**.
- To work with Conversational Language Understanding, you need to take into account three core concepts:
    1. `utterances`
    1. `entities`
    1. `intents`

Intent|Utterance|Entity
-|-|-
TurnOn|"Switch the fan on"|fan (device)
||"Turn the light on"|light (device)
||"Turn on the light"|light (device)
CheckWeather|"What is the weather for today?"|today (datetime)
||"Give me the weather forecast"||
||"What is the forecast for Paris?"|Paris (location)
||"What will the weather be like in Seattle tomorrow?"|Seattle (location), tomorrow (datetime)
None|"What is the meaning of life?"||
||"Is this thing on?"||

- Use the `None` intent to capture utterances that don't match any of the other intents.

### Using Azure resoures
1. Create an authoring resource
1. Use it to train a Conversational Language Understanding application by...
    1. Creating a model
    1. Adding intents
    1. Adding utterances
    1. Adding entities
    1. Training the model
    1. Testing the model

### Creating entities
There are four types of entities:
1. `Machine-Learned`: Learned by your model during training from context in the sample utterances you provide.
1. `List`: Defined as a hierarchy of lists and sublists.
    - For example, you might define a list of colors, with sublists for primary colors, secondary colors, and so on.
1. `RegEx`: defined as a regular expression that describes a pattern.
1. `Pattern.any`: Entities that are used with patterns to define complex entities that may be hard to extract from sample utterances.

### Exercise
- [Explore language understanding](https://microsoftlearning.github.io/AI-900-AIFundamentals/instructions/04c-conversational-language-understanding.html)
