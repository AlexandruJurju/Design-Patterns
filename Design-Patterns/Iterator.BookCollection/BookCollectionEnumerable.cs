﻿using System.Collections;

namespace Iterator.BookCollection;

public class BookCollectionEnumerable : IEnumerable<string>
{
    private List<string> _titles = new();

    public void Add(string title)
    {
        _titles.Add(title);
    }
    
    public IEnumerator<string> GetEnumerator()
    {
        foreach (var title in _titles)
        {
            yield return title;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}