class Enumerable2 : IEnumerable2
{
    private int[] _content = new int[1];
    private int nbOfElements = 0;

    public void Push(int a)
    {
        if (nbOfElements >= _content.Length)
        {
            var tempArray = new int[this._content.Length * 2];
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

    public void ForEach2(Action<int> someAction)
    {
        var enumerator = this.GetEnumerator();

        do 
        {
            var value = enumerator.Current;
            someAction(value ?? -1);

        } while (enumerator.MoveNext());

    }

    public IEnumerator2 GetEnumerator()
    {
        return new Enumerator2(this._content);
    }

}
