
using Visitor.DocumentDometrain.Elements;
using Visitor.DocumentDometrain.Visitors;

List<IDocumentElement> elements = new List<IDocumentElement>
{
    new TitleElement("Title"),
    new SubtitleElement("Subtitle"),
    new ContentElement("Content element"),
    new SubtitleElement("Another subtitle")
};

Console.WriteLine("Text format: WORD");
TextDocumentVisitor textDocumentVisitor = new TextDocumentVisitor();

foreach (var element in elements)
{
    element.Accept(textDocumentVisitor);
}

Console.WriteLine("Text format: MARKDOWN");
MarkdownDocumentVisitor markdownDocumentVisitor = new MarkdownDocumentVisitor();

foreach (var element in elements)
{
    element.Accept(markdownDocumentVisitor);
}