public class Enumerator2 : IEnumerator2
{
    private readonly int?[] _localContentArray;

    public Enumerator2(int[] contentArray)
    {
        Array.Resize(ref _localContentArray, contentArray.Length + 1);
        for (int i = 0; i < contentArray.Length; i++) _localContentArray[i] = contentArray[i];
    }

    private int Index { get; set; }

    public int? Current => _localContentArray[Index];

    public bool MoveNext()
    {
        Index++;
        return Current != null;
    }

    public void Reset()
    {
        throw new NotImplementedException();
    }
}