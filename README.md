# Race Condition in C# Property Access

This repository demonstrates a race condition that can occur in C# when multiple threads access a property without proper synchronization.  The `BuggyProperty.cs` file shows the problematic code, while `FixedProperty.cs` provides a corrected version.

**Problem:** The `Value` property lacks thread safety.  Multiple threads reading and writing to this property concurrently can lead to data corruption and unpredictable behavior.

**Solution:** The corrected version uses a `lock` statement to ensure exclusive access to the property, preventing race conditions.