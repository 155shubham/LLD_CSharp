Here are Top 20 C# Low-Level Design (LLD) / system design interview questions, focused on object-oriented design, clean architecture, and real-world implementation:

🔹 Core LLD + OOP Design Questions
0. File system

1. Design a Parking Lot System

Support different vehicle types
Parking slots allocation
Ticket generation and pricing


2. Design a Library Management System

Books, members, issuing/returning
Handling reservations and overdue fines


3. Design a URL Shortener (like Bitly)

Short code generation
Redirection logic
Collision handling


4. Design a File System

Files and directories hierarchy
CRUD operations
Permissions


5. Design a Logging Framework

Different log levels (Info, Debug, Error)
Pluggable output (console, DB, file)
Async logging


6. Design a Cache System (LRU Cache)

Fixed size cache
Eviction policy
Thread-safe access


7. Design a Notification System

Multiple channels (Email, SMS, Push)
Template handling
Retry mechanism


8. Design a Payment Processing System

Multiple payment methods
Transaction state management
Retry & failure handling


9. Design an Elevator System

Multiple elevators
Scheduling requests
Optimization logic


10. Design a Chat Application

Users, messages, channels
Online/offline handling
Message delivery states


🔹 C# Specific Design Questions
11. Design Dependency Injection Container

Service registration
Lifetime management (Singleton, Scoped, Transient)
Constructor injection


12. Implement Repository Pattern + Unit of Work

Generic repository
Transaction handling


13. Design Middleware Pipeline (like ASP.NET Core)

Request pipeline
Chaining handlers


14. Design a Rate Limiter

Fixed window / sliding window
Per-user throttling


15. Design a Configuration Management System

Reloadable configs
Environment-based configs


🔹 Concurrency / Threading (Important in LLD)
16. Design a Thread-safe Singleton

Lazy initialization
Double-check locking


17. Implement Producer-Consumer System

Queue handling
Thread synchronization


18. Design a Job Scheduler

Delayed and recurring jobs
Priority handling


🔹 Design Patterns Oriented Questions
19. Design a Pluggable Strategy System

Example: Payment gateway selection
Runtime behavior change


20. Design an Observer-based Event System

Event publisher/subscriber
Loose coupling


🔹 Bonus: How to Answer These in Interviews
When solving C# LLD questions:
✅ Always cover:

Class diagrams / entities
Interfaces and abstractions
SOLID principles
Design patterns used
Thread safety (if applicable)
Error handling

✅ Mention C# features:

async/await
Task
IEnumerable / IQueryable
Interfaces & DI
Concurrent collections