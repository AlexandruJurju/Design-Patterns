using Visitor.DocumentDometrain.Visitors;

namespace Visitor.DocumentDometrain.Elements;

public interface IDocumentElement
{
    void Accept(IDocumentVisitor documentVisitor);
}