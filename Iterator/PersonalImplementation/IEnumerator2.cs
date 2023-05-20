public interface IEnumerator2<T>
{
    public T? Current { get; }
    
    public bool MoveNext();

    public void Reset();
}