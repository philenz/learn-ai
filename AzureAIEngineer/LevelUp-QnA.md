### [Building a question answering solution](https://learn.microsoft.com/en-us/training/paths/build-qna-solution/)
- The `Language` service includes a question answering capability, which enables you to define a knowledge base of question and answer pairs that can be queried using natural language input.
- The knowledge base can be published to a REST endpoint and consumed by client applications, commonly `bots`.
- The knowledge base can be created from existing sources, including:
    - Web sites containing frequently asked question `(FAQ) documentation`.
    - Files containing `structured text`, such as `brochures` or `user guides`.
    - Built-in `chit chat` question and answer pairs that encapsulate common conversational exchanges.
- A question answering knowledge base is a form of language model.
- The two services are complementary, and you can use them together to create a bot that can answer questions and engage in conversation.
- Use the `Language Studio` `web interface` to define and manage a knowledge base.
- When you define a follow-up prompt for `multi-turn conversation`, you can link to an existing answer in the knowledge base or define a new answer specifically for the follow-up.
    - You can also restrict the linked answer so that it is only ever displayed in the context of the multi-turn conversation initiated by the original question.
- You can test your knowledge base interactively in Language Studio, submitting questions and reviewing the answers that are returned.
- When you are happy with the performance of your knowledge base, you can deploy it to a REST endpoint.
- Sample response from a REST question...
    ```json
    {
        "answers": [
            {
                "questions": [
                    "How can I cancel a reservation?"
                ],
                "answer": "Call us on 555 123 4567 to cancel a reservation.",
                "confidenceScore": 1.0,
                "id": 1,
                "source": "https://margies-travel.com/faq",
                "metadata": {},
                "dialog": {
                    "isContextOnly": false,
                    "prompts": []
                }
            }
        ]
    }
    ```

#### Improve question answering performance
- After creating and testing a knowledge base, you can improve its performance...
    1. with active learning... 
        1. implicit feedback
        1. explicit feedback
    1. by defining synonyms
        - useful when question submitted by users might include multiple different words to mean the same thing

