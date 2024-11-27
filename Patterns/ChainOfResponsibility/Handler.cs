namespace Patterns.ChainOfResponsibility;

public abstract class Handler {
    protected Handler? Next;
    public void SetNext(Handler handler) => Next = handler;
    public abstract void HandleRequest(string request);
}