# Semantic Kernel Image Chat API

This project is a **.NET 9 Web API** that utilizes **Semantic Kernel** to analyze an uploaded image and generate chat-based responses based on its content.

## Features
- Upload images for analysis
- Process images and extract meaningful information
- Generate AI-powered text responses based on image content
- Leverage **Semantic Kernel** for intelligent conversation generation

## Prerequisites
- **.NET 9 SDK**
- **Docker (optional)**
- **Semantic Kernel**

## Setup Instructions
### 1. Clone the repository
```bash
git clone https://github.com/your-repo.git
cd your-repo
```

### 2. Install dependencies
```bash
dotnet restore
```

### 3. Run the project
```bash
dotnet run
```

### 4. Run with Docker
```bash
docker build -t semantic-kernel-image-chat .
docker run -p 5000:5000 semantic-kernel-image-chat
```

## API Usage

### Upload an Image
**Endpoint:** `POST /ImageToTextt`

**Headers:**
```json
{
  "Content-Type": "multipart/form-data"
}
```

**Body:**
```json
{
  "file": "image.jpg"
}
```

### Example Query
If you upload an image and ask:

![11](https://github.com/user-attachments/assets/d575ee9a-4859-4d60-a875-b574db230913)


```text
hello, what is this photo?
```

The API might respond with:
```json
{
  "description": "The image you provided is a diagram that illustrates the basic topology of a space-based architecture. This type of architecture is used in computing to manage and distribute data across multiple processing units efficiently. The diagram includes several components:

1. **Processing Units:** Each contains one or more components that utilize an in-memory data grid for fast data access and caching.
2. **In-Memory Data Grid:** Provides high performance data storage within RAM that allows rapid access and manipulation.
3. **Data Replication Engine:** Ensures data consistency and reliability by replicating data across different nodes or processing units.
4. **Virtualized Middleware:** A layer that abstracts the underlying hardware and software to provide services such as messaging, data sharing, and processing capabilities which are represented by Messaging Grid, Data Grid, and Processing Grid respectively.
5. **Database:** A data storage system that interacts with data readers and writers.
6. **Deployment Manager:** Manages the deployment of applications or services across the processing grid.

This diagram is typical in system design and architecture documentation, describing how different components interact and work together to achieve scalable and resilient computing environments."
}
```

## Support
If you encounter any issues, please report them in the Issues section of the repository.
