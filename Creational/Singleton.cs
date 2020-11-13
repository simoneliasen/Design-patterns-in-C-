class Singleton {
    private static Singleton instance; // SHould instance be underlined eg. _instance? should this be set as readonly?

    public static Singleton GetInstance()
    {
        if (instance == null)
            instance = new Singleton();

        return instance;
    }

}