ParallelEnumerable.Range(0, 100)
    .ForAll(_ =>
    {
        Singleton.ThreadSafe.Singleton singleton = Singleton.ThreadSafe.Singleton.Instance;
    });