# 📷 Semantic Kernel Image Chat API

This project is an advanced **.NET 9 Web API** powered by **Semantic Kernel**, designed to analyze uploaded images and generate intelligent, context-aware responses based on their content. It enables users to interact with images dynamically, extracting valuable insights and engaging in meaningful conversations about the visual content.

---
## 🚀 Key Features
- **Smart Image Analysis** – Upload an image and receive a detailed AI-generated description.
- **Conversational AI** – Ask questions about the image, and get intelligent responses powered by **Semantic Kernel**.
- **Fast & Scalable** – Optimized for high-performance processing with .NET 9 and efficient AI-driven computations.
- **Extensible & Modular** – Easily integrable into other applications or AI-driven systems.

---
## 📌 Use Case
Imagine you upload a **complex architectural diagram** and ask:
![11](https://github.com/user-attachments/assets/53e7d28e-5fb5-4313-a282-1505271c0511)

**"Hello, what is this photo?"**

The system will analyze the image and return an AI-generated response, such as:

> *"The image you provided is a diagram illustrating the basic topology of a space-based architecture. This architecture is designed to manage and distribute data efficiently across multiple processing units, ensuring scalability and fault tolerance. It consists of components such as in-memory data grids, messaging grids, processing nodes, and distributed databases."*

This capability is particularly useful for:
- **Software Architects** – Understanding system blueprints and technical diagrams.
- **Engineers & Researchers** – Extracting insights from complex schematics.
- **Educational Purposes** – Assisting students and professionals in learning and documentation.

---
## 🛠️ Prerequisites
- **.NET 9 SDK**
- **Docker (optional, for containerized deployment)**
- **Semantic Kernel** (installed as a package in the project)

---
## 🔧 Setup Instructions
### 1️⃣ Clone the Repository
```bash
git clone https://github.com/your-repo.git
cd your-repo
```

### 2️⃣ Install Dependencies
```bash
dotnet restore
```

### 3️⃣ Run the Project
```bash
dotnet run
```

### 4️⃣ Run with Docker
```bash
docker build -t semantic-kernel-image-chat .
docker run -p 5000:5000 semantic-kernel-image-chat
```

---
## 🎯 API Usage
### 📤 Upload an Image
**Endpoint:** `POST /api/image-chat`

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

### 🗨️ Example Query & Response
**User Input:**
```text
hello, what is this photo?
```

**API Response:**
```json
{
  "description": "The image you provided is a diagram that illustrates the basic topology of a space-based architecture. This type of architecture is used in computing to manage and distribute data across multiple processing units efficiently. The diagram includes several components:

1. **Processing Units:** Each contains one or more components that utilize an in-memory data grid for fast data access and caching.
2. **In-Memory Data Grid:** Provides high-performance data storage within RAM that allows rapid access and manipulation.
3. **Data Replication Engine:** Ensures data consistency and reliability by replicating data across different nodes or processing units.
4. **Virtualized Middleware:** A layer that abstracts the underlying hardware and software to provide services such as messaging, data sharing, and processing capabilities which are represented by Messaging Grid, Data Grid, and Processing Grid respectively.
5. **Database:** A data storage system that interacts with data readers and writers.
6. **Deployment Manager:** Manages the deployment of applications or services across the processing grid.

This diagram is typical in system design and architecture documentation, describing how different components interact and work together to achieve scalable and resilient computing environments."
}
```

---
## 🤝 Support & Contributions
If you encounter any issues, feel free to open an **Issue** on the repository. Contributions, improvements, and feature suggestions are always welcome! 🚀
