namespace Patterns.ChainOfResponsibility;

public class CORTest {

    public void Test() {
        var handlerA = new HandlerA();
        var handlerB = new HandlerB();
        
        handlerA.SetNext(handlerB);
        handlerA.HandleRequest("B");
    }
}