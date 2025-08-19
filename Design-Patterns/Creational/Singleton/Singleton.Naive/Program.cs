ParallelEnumerable.Range(0, 100)
    .ForAll(_ =>
    {
        var singleton = Singleton.Naive.Singleton.Instance;
    });