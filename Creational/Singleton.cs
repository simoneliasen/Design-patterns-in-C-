
// Simple Singleton implementation - Not-thread safe.
class Singleton {
    private static Singleton instance; // Should instance be underlined eg. _instance? should this be set as readonly?

    // Is it necessary to declare an empty instance property?
    private PatternA()
    {
    }

    public static Singleton GetInstance()
    {
        if (instance == null)
            instance = new Singleton();

        return instance;
    }

}

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