using static Singleton.Naive.Singleton;

Parallel.For(0, 100, _ =>
{
    var singleton = Instance;
});