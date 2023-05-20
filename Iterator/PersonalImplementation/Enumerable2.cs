class Enumerable2<T> : IEnumerable2<T>
{
    private T[] _content = new T[1];
    private int nbOfElements = 0;

    public void Push(T a)
    {
        if (nbOfElements >= _content.Length)
        {
            var tempArray = new T[this._content.Length * 2];
            for (int i = 0; i < this._content.Length; i++)
            {
                tempArray[i] = this._content[i];
            }
            this._content = tempArray;
        }

        _content[nbOfElements] = a;
        nbOfElements++;
    }

    public void PrintContent()
    {
        for (int i = 0; i < _content.Length; i++)
        {
            System.Console.Write(_content[i].ToString() + " ");
        }
        System.Console.WriteLine();
    }

    public void ForEach2(Action<T> someAction)
    {
        var enumerator = this.GetEnumerator();

        do 
        {
            var value = enumerator.Current;
            someAction((T)value);

        } while (enumerator.MoveNext());

    }

    public IEnumerator2<T> GetEnumerator()
    {
        return new Enumerator2<T>(this._content);
    }

}
