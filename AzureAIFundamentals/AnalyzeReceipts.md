## Analyze receipts with the Form Recognizer service
- Currently the pre-built receipt model is designed to recognize common receipts, in English, that are common to the USA.
- Examples are receipts used at restaurants, retail locations, and gas stations.
- The model is able to extract key information from the receipt slip:
    - time of transaction
    - date of transaction
    - merchant information
    - taxes paid
    - receipt totals
    - other pertinent information that may be present on the receipt
    - all text on the receipt is recognized and returned as well
- Use the following guidelines to get the best results when using a custom model.
    - Images must be JPEG, PNG, BMP, PDF, or TIFF formats
    - File size must be less than 50 MB
    - Image size between 50 x 50 pixels and 10000 x 10000 pixels
    - For PDF documents, no larger than 17 inches x 17 inches
    - There is a free tier subscription plan for the receipt model along with paid subscriptions.
        - For the free tier, only the first two pages will be processed when passing in PDF or TIFF formatted documents.

### Exercise: [Explore form recognition](https://microsoftlearning.github.io/AI-900-AIFundamentals/instructions/03e-analyze-receipts.html)
