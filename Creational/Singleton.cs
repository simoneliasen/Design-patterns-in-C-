// Non-thread-safe Singleton.
class Singleton {
    private static Singleton _instance; // Underscore to mark it as private to class

    // Empty constructor inserted as best practice, for later overloading from third party eg.?
    // Empty constructor to enable initialization for static class?
    // Static vs non-static constructors?
    private PatternA()
    {
    }

    public static Singleton GetInstance()
    {
        if (_instance == null)
            _instance = new Singleton();

        return _instance;
    }
}

// Thread-safe Singleton





/*
Description:
- Global acess to class with only one instance.


Singleton Applications:
- Database connection
- API Token

Pros:
- Ensure that there is only one instance.
- Acess it globally.

Cons:
- Goes against the Single-resposibility principle. 
- Can hide elements, making it harder to test.
- Multithreading can possibly break the pattern.


*/