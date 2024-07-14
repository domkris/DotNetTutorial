# Singleton Pattern

## Overview

The Singleton Pattern ensures that a class has only one instance and provides a global point of access to it. 
This pattern is useful in scenarios where exactly one object is needed to coordinate actions across a system.

## Concurrency Issues

When implemented naively, the Singleton Pattern can cause concurrency issues in a multi-threaded environment.
Multiple threads might create multiple instances simultaneously. 
Unsynchronized access to mutable state can lead to data corruption or inconsistent states.
Fix:

1. **Eager Initialization**: Create the Singleton instance at the time of class loading. This approach avoids race conditions since the instance is created before any thread accesses it
2. **Thread-Safe Lazy Initialization:**: Use locking to ensure that only one thread can enter the critical section where the instance is created.
3. **Double-Check Locking:**: A performance optimization that reduces the overhead of acquiring a lock by first checking if the instance is created before locking.
4. **.NET Lazy Type:**: Utilize the Lazy< T > type provided by .NET, which handles lazy initialization and is thread-safe by default.

