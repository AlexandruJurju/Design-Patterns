﻿namespace ChainOfResponsibility;

public class SquirrelHandler : AbstractHandler
{
    public override object? Handle(object request)
    {
        if (request.ToString() == "Nut")
        {
            return $"Squirrel: I'll eat the {request}\n";
        }

        return base.Handle(request);
    }
}