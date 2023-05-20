public class Enumerator2<T> : IEnumerator2<T>
{
    private readonly T?[] _localContentArray;

    public Enumerator2(T[] contentArray)
    {
        // Array.Resize(ref _localContentArray, contentArray.Length + 1);
        _localContentArray = new T?[contentArray.Length + 1];
        for (int i = 0; i < contentArray.Length; i++) _localContentArray[i] = contentArray[i];
    }

    private int Index { get; set; }

    public T? Current => _localContentArray[Index];

    public bool MoveNext()
    {
        Index++;
        if (Current == null ) {
            return false;
        }
        return true;
    }

    public void Reset()
    {
        throw new NotImplementedException();
    }
}