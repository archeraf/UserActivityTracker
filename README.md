# 🔎 GitHub User Activity CLI


A **CLI application** to fetch and display the public activities of a user on **GitHub**.  
The project was developed with a focus on **good architecture practices** and **external API consumption**.

---

## ✨ Features
- Fetch public events of any GitHub user.
- Display event types and creation dates.
- Architecture organized in **layers (Domain, Application, Infrastructure, CLI)**.
- Uses `System.Text.Json` for data serialization.

---

## 📂 Project Structure

<img width="284" height="636" alt="image" src="https://github.com/user-attachments/assets/58920c10-e255-4e64-a45e-a373892d6f86" />

---

## 🛠️ Technologies Used

- **C# 12**  
- **.NET Runtime** (pure C# base, no ASP.NET Core)  
- **System.Net.Http** for HTTP requests  
- **System.Text.Json** for serialization/deserialization  

---

## 📝 Applied Concepts

1. **Dependency Injection**  
   - Use of the dependency injection pattern to **decouple components**, facilitating testing and maintenance.  
   - Example: injecting `HttpClient` and using interfaces like `IGithubApiClient`.

2. **Object-Oriented Programming (OOP)**  
   - Modeling domain entities (`Event`, `Commit`, `Author`, `Actor`, `Repository`, `Payload`) as **classes**, promoting **encapsulation** and **code reuse**.

3. **Separation of Concerns**  
   - Structuring the project into **distinct layers**: domain entities, application services, infrastructure, and presentation layer (CLI).

4. **Interface Abstraction**  
   - Defining **contracts** (`IGithubApiClient`) to allow multiple implementations and facilitate testability.

5. **JSON Serialization/Deserialization**  
   - Using `[JsonPropertyName]` to map class properties to **JSON fields** returned by the GitHub API.

6. **Asynchronous Operations**  
   - Using **async/await** for HTTP calls, improving **performance** and **scalability**.

---

## 📌 Next Steps

- Implement result pagination.  
- Support exporting results to a JSON file.  
- Add unit tests.  
- Create binaries for Linux/Mac/Windows using `dotnet publish`.  

