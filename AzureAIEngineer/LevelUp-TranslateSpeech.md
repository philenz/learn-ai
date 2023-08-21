## [Translate speech with the speech service](https://learn.microsoft.com/en-nz/training/modules/translate-speech-speech-service/)
- ``` dotnet add package Microsoft.CognitiveServices.Speech --version 1.28.0```
### Translate speech to text
- The pattern for speech `translation` using the Speech SDK is `similar` to speech `recognition`,
  - with the addition of information about the source and target languages for translation
- Use a `SpeechTranslationConfig` object to encapsulate the information required to connect to your Speech resource. Specifically, its location and key.
- The `SpeechTranslationConfig` object is also used to specify the speech recognition language (the language in which the input speech is spoken) and the target languages into which it should be translated.
- Optionally, use an `AudioConfig` to define the input source for the audio to be transcribed. By default, this is the default system microphone, but you can also specify an audio file.
- Use the `SpeechTranslationConfig`, and `AudioConfig` to create a `TranslationRecognizer` object. This object is a proxy client for the Speech service translation API.

### Synthesize translations
- The TranslationRecognizer returns translated transcriptions of spoken input - essentially translating audible speech to text.
- You can also synthesize the translation as speech to create speech-to-speech translation solutions. There are two ways you can accomplish this.
1. **Event-based synthesis**
   - When you want to perform 1:1 translation (translating from one source language into a single target language), you can use event-based synthesis to capture the translation as an audio stream.
1. **Manual synthesis**
   - Manual synthesis is an alternative approach to event-based synthesis that doesn't require you to implement an event handler. You can use manual synthesis to generate audio translations for one or more target languages
   - Manual synthesis of translations is essentially just the combination of two separate operations in which you:
      1. Use a TranslationRecognizer to translate spoken input into text transcriptions in one or more target languages.
      1. Iterate through the Translations dictionary in the result of the translation operation, using a SpeechSynthesizer to synthesize an audio stream for each language.

### Speech service supports:
- `Speech to text`: An API that enables speech recognition in which your application can accept spoken input.
- `Text to speech`: An API that enables speech synthesis in which your application can provide spoken output.
- `Speech Translation`: An API that you can use to translate spoken input into multiple languages.
- `Speaker Recognition`: An API that enables your application to recognize individual speakers based on their voice.
- `Intent Recognition`: An API that integrates with the Language Understanding service to determine the semantic meaning of spoken input.
- The Speech service supports speech recognition through two REST APIs:
  1. The Speech to text API, which is the primary way to perform speech recognition.
  1. The Speech to text `Short Audio API`, which is optimized for short streams of audio (`up to 60 seconds`).
- You can also use the Speech to text API for batch transcription, transcribing multiple audio files to text as a batch operation.
- Use a `SpeechConfig` object to encapsulate the information required to connect to your Speech resource. Specifically, its location and key.
- Optionally, use an `AudioConfig` to define the input source for the audio to be transcribed. By default, this is the default system microphone, but you can also specify an audio file.
Use the `SpeechConfig` and `AudioConfig` to create a `SpeechRecognizer` object. This object is a proxy client for the Speech to text API.

### Use the text to speech API
- The pattern for implementing speech synthesis is similar to that of speech recognition
- Similarly to Speech to text APIs, the Speech service offers two REST APIs for speech synthesis:
  1. The Text to speech API, which is the primary way to perform speech synthesis.
  1. The Text to speech `Long Audio API`, which is designed to support batch operations that convert large volumes of text to audio - for example to generate an audio-book from the source text.

### Configure audio format and voices
#### Audio format
- Depending on your specific needs, you can choose a format based on the required:
  - Audio file type
  - Sample-rate
  - Bit-depth

#### Voices
- The Speech service provides multiple voices that you can use to personalize your speech-enabled applications. There are two kinds of voice that you can use:
  1. `Standard voices` - synthetic voices created from audio samples.
  1. `Neural voices` - more natural sounding voices created using deep neural networks.
- Voices are identified by names that indicate a locale and a person's name - for example en-GB-George.

### Speech Synthesis Markup Language (SSML)
- ```speechSynthesizer.SpeakSsmlAsync(ssml_string);```
- Offers greater control over how the spoken output sounds, enabling you to:
  1. Specify a `speaking style`, such as "excited" or "cheerful" when using a neural voice.
  1. Insert `pauses or silence`.
  1. Specify `phonemes` (phonetic pronunciations), for example to pronounce the text "SQL" as "sequel".
  1. Adjust the `prosody` of the voice (affecting the pitch, timbre, and speaking rate).
  1. Use `common "say-as" rules`, for example to specify that a given string should be expressed as a date, time, telephone number, or other form.
  1. Insert `recorded speech or audio`, for example to include a standard recorded message or simulate background noise.
