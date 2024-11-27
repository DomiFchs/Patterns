namespace Patterns.ChainOfResponsibility;

public class HandlerB : Handler{
    public override void HandleRequest(string request) {
        if (request == "B") {
            Console.WriteLine("B Processes Request");
            return;
        }

        if (Next is not null) {
            Next.HandleRequest(request);
            return;
        }

        Console.WriteLine("Request not valid!");
    }
}