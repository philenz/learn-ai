### [Create conversational AI solutions](https://learn.microsoft.com/en-us/training/paths/create-conversational-ai-solutions/)
#### Considerations for responsible AI
- Ten guidelines for developers of conversational AI solutions.
    1. Articulate the purpose of your bot and take special care if your bot will support consequential use cases.
    1. Be `transparent about the fact that you use bots` as part of your product or service.
    1. Ensure a seamless `hand-off to a human` where the human-bot exchange leads to interactions that exceed the bot's competence.
    1. Design your bot so that it respects relevant `cultural norms` and guards against misuse.
    1. Ensure your bot is `reliable`.
    1. Ensure your bot `treats people fairly`.
    1. Ensure your bot respects `user privacy`.
    1. Ensure your bot handles `data securely`.
    1. Ensure your bot is `accessible`.
    1. Accept `responsibility` for your bots operation and how it affects people.

#### Bot Framework SDK
- Bot solutions on Microsoft Azure are supported by the following technologies:
    - `Azure Bot Service`. A cloud service that enables bot delivery through one or more channels, and integration with other services.
    - `Bot Framework Service`. A component of Azure Bot Service that provides a REST API for handling bot activities.
    - `Bot Framework SDK`. A set of tools and libraries for end-to-end bot development that abstracts the REST interface, enabling bot development in a range of programming languages.

#### Bot templates
- `Empty Bot` - a basic bot skeleton.
- `Echo Bot` - a simple "hello world" sample in which the bot responds to messages by echoing the message text back to the user.
- `Core Bot` - a more comprehensive bot that includes common bot functionality, such as integration with the `Language Understanding service`.

#### Bot application classes and logic
- The template bots are based on the Bot class defined in the Bot Framework SDK, which is used to implement the logic in your bot that receives and interprets user input, and responds appropriately.
- Additionally, bots make use of an `Adapter class` that handles communication with the user's channel.
- Conversations in a bot are composed of `activities`, which represent events such as a user joining a conversation or a message being received.
- These activities occur within the context of a `turn`, a two-way exchange between the user and bot.
- The Bot Framework Service notifies your bot's adapter when an activity occurs in a channel by calling its `Process Activity` method, and the adapter creates a context for the turn and calls the bot's `Turn Handler` method to invoke the appropriate logic for the activity.

#### Testing with the Bot Framework Emulator
- The Bot Framework Emulator is an application that enables you to run your bot local or remote web applications and connect to it from an interactive web chat interface that you can use to test your bot.

#### Implement activity handlers and dialogs
- The Bot Framework SDK provides classes that can help you build bots that manage conversations using:
    - `Activity handlers`: Event methods that you can override to handle different kinds of activities.
    - `Dialogs`: More complex patterns for handling stateful, multi-turn conversations.
- Activity handler methods include a parameter for the `turn context`, which you can use to access relevant information.
    - For example, the activity handler for a message received activity includes the text of the message.
- A `component dialog` is a dialog that can contain other dialogs, defined in its dialog set. Often, the initial dialog in the component dialog is a `waterfall dialog`, which defines a sequential series of steps to guide the conversation.
- An `adaptive dialog` is another kind of container dialog in which the flow is more flexible, allowing for interruptions, cancellations, and context switches at any point in the conversation.
    - In this style of conversation, the bot initiates a root dialog, which contains a flow of actions (which can include branches and loops), and triggers that can be initiated by actions or by a recognizer.

#### Deploy a bot
1. Register an Azure app
1. Create a bot application service
1. Prepare your bot for deployment
1. Deploy your bot as a web app

#### Exercise - Create a bot with the Bot Framework SDK
- https://microsoftlearning.github.io/AI-102-AIEngineer/Instructions/13-bot-framework.html

#### Bot Framework Emulator
- Follow the instructions at https://github.com/Microsoft/BotFramework-Emulator/blob/master/README.md to download and install the latest stable version of the Bot Framework Emulator for your operating system.

#### Bot Framework Composer
- Install from https://docs.microsoft.com/en-us/composer/install-composer.
- Bot Framework Composer is a visual designer that lets you quickly and easily build sophisticated conversational bots without writing code.
- The composer is an `open-source` tool that presents a visual canvas for building bots.
- It uses the latest SDK features so you can build complex bots with relative ease.
- 3 ways to build a bot...
   1. Power Virtual Agents
   1. Bot Framework Composer
   1. Bot Framework SDK
- Composer advantages...
   - enables saving of pieces of data to various scopes to remember things between dialogs or sessions
   - test your bot directly inside Composer via embedded Web Chat
   - easy to manage interruptions / adaptive dialogs

#### Speech
- You can design your bot to take advantage of speech input and output.
- Using speech will require your bot to interact with the `Azure AI Speech service` to transcribe the spoken word to text, for actions by the bot, and then synthesize the text responses to speech as the output.

#### Cards
- Cards allow you to present your users with various visual, audio, and/or selectable messages and help to assist conversation flow.
- Cards are programmable objects containing standardized collections of rich user controls.
- An advantage of cards is that they are recognized across a wide range of channels.
- Examples of cards include:
   - `Adaptive cards`: An open card exchange format rendered as a JSON object. Typically used for cross-channel deployment of cards. Cards adapt to the look and feel of each host channel.
   - `Audio cards`: A card that can play audio files. This card could be helpful in a bot that interacts with users who have visual impairments.
   - `Animation cards`: This type of card can play animated GIFs or short video files, for example to depict actions or status indicators.
   - `Hero cards`: A card that contains a single large image, one or more buttons, and text. Typically used to visually highlight a potential user selection.
   - `Thumbnail cards`: A card that contains a single thumbnail image, one or more buttons, and text. Typically used to visually highlight the buttons for a potential user selection.
   - `SignIn card`: A card that enables a bot to request that a user sign-in. It typically contains text and one or more buttons that the user can select to initiate the sign-in process.
   - `Video card`: A card that can play videos. Typically used to open a URL and stream an available video.

#### Response generation
- Bot Framework Composer uses _language generator (lg)_ to generate responses to user input.
- e.g: `Hello ${user.name}, welcome to ${bot.name}`