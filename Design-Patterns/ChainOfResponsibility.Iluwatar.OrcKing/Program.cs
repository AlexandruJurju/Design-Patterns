using ChainOfResponsibility.Iluwatar.OrcKing;

var king = new OrcKing();
king.MakeRequest(new Request(RequestType.DefendCastle, "defend the castle"));
king.MakeRequest(new Request(RequestType.TorturePrisoner, "torture prisoner"));
king.MakeRequest(new Request(RequestType.CollectTaxes, "collect taxes"));