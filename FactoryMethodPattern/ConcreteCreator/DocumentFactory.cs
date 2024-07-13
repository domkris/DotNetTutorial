using FactoryMethodPattern.ConcreteProduct;
using FactoryMethodPattern.ProductInterface;

namespace FactoryMethodPattern.ConcreteCreator
{
    public enum DocumentType
    {
        PDF,
        Word
    }
    public class DocumentFactory
    {
        public IDocument Create(DocumentType type)
        {
            return type switch
            {
                DocumentType.PDF => new PdfDocument(),
                DocumentType.Word => new WordDocument(),
                _ => throw new ArgumentException("Invalid type"),
            };
        }
    }
}
