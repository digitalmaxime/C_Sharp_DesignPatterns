public interface IEnumerator2
{
    public int? Current { get; }
    
    public bool MoveNext();

    public void Reset();
}