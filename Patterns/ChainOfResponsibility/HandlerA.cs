namespace Patterns.ChainOfResponsibility;

public class HandlerA : Handler{
    public override void HandleRequest(string request) {
        if (request == "A") {
            Console.WriteLine("A Processes Request");
            return;
        }

        if (Next is not null) {
            Next.HandleRequest(request);
            return;
        }

        Console.WriteLine("Request not valid!");
    }
}