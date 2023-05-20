interface IEnumerable2<T> {

    IEnumerator2<T> GetEnumerator();

    void ForEach2(Action<T> someAction);
}