using System.Linq;

ParallelEnumerable.Range(0, 100)
    .ForAll(_ =>
    {
        Singleton.Naive.Singleton singleton = Singleton.Naive.Singleton.Instance;
    });