using Visitor.DocumentDometrain.Elements;

namespace Visitor.DocumentDometrain.Visitors;

public interface IDocumentVisitor
{
    void Visit(TitleElement element);
    void Visit(SubtitleElement element);
    void Visit(ContentElement element);
}