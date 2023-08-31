### [Extract text from images and documents](https://learn.microsoft.com/en-us/training/paths/extract-text-from-images-documents/)
#### Read Text in Images and Documents with the Azure AI Vision Service
- The Azure AI Vision service offers two APIs that you can use to read text.
    1. **The Read API**:
        - Use this API to read `small to large volumes of text from images and PDF documents`.
        - This API uses a newer model than the OCR API, resulting in greater accuracy.
        - The Read API can read `printed text in multiple languages`, and `handwritten text in English`.
        - The initial function call returns an `asynchronous` operation ID, which must be used in a subsequent call to retrieve the results.
    1. **The Image Analysis API**:
        - Currently still in `preview`, with reading text functionality added version 4.0.
        - Use this API to read `small amounts of text` from images.
        - Returns contextual information, including line number and position.
        - Results are returned immediately (`synchronous`) from a single function call.
        - Has `functionality for analyzing images past extracting text`, including detecting content (such as brands, faces, and domain-specific content), describing or categorizing an image, generating thumbnails and more.
- Results of the Read API...
    - broken down by page,
    - then line,
    - and then word.
    - Additionally, the text values are included at both the line and word levels
#### Extract data from forms with Azure Document Intelligence Module
- Azure Document Intelligence is composed of the following services:
    1. `Document analysis models`: which take an input of `JPEG`, `PNG`, `PDF`, and `TIFF` files and return a JSON file with the location of text in bounding boxes, text content, tables, selection marks (also known as checkboxes or radio buttons), and document structure.
    1. `Prebuilt models`: which detect and extract information from document images and return the extracted data in a structured JSON output. Azure Document Intelligence currently supports prebuilt models for several forms, including:
        - W-2 forms
        - Invoices
        - Receipts
        - ID documents
        - Business cards
    1. `Custom models`: custom models extract data from forms specific to your business. Custom models can be `trained through the Azure Document Intelligence Studio`.
- Azure Document Intelligence works on input documents that meet these requirements:
    1. Format must be JPG, PNG, BMP, PDF (text or scanned), or TIFF.
    1. The file size must be less than 500 MB for paid (S0) tier and 4 MB for free (F0) tier.
    1. Image dimensions must be between 50 x 50 pixels and 10000 x 10000 pixels.
    1. The total size of the training data set must be 500 pages or less.