using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Enter the key");
        string key = Console.ReadLine();
        if (key == "")
        {
            DocumentWorker worker = new DocumentWorker();
            worker.OpenDocument();
            worker.EditDocument();
            worker.SaveDocument();
        }
        else if (key == "pro")
        {
            ProDocumentWorker worker = new ProDocumentWorker();
            worker.OpenDocument();
            worker.EditDocument();
            worker.SaveDocument();
        }
        else if (key == "exp")
        {
            ExpertDocumentWorker worker = new ExpertDocumentWorker();
            worker.OpenDocument();
            worker.EditDocument();
            worker.SaveDocument();
        }
        else
        {
            Console.WriteLine("Key not supported");
        }
    }
}
class DocumentWorker
{
    public virtual void OpenDocument()
    {
        Console.WriteLine("Документ відкритий");
    }
    public virtual void EditDocument()
    {
        Console.WriteLine("Редагування документа у версії Про");
    }
    public virtual void SaveDocument()
    {
        Console.WriteLine("Збереження документа у версії Про"); 
    }
}
class ProDocumentWorker : DocumentWorker
{
    public override void EditDocument()
    {
        Console.WriteLine("Документ відредаговано");
    }
    public override void SaveDocument() 
    {
        Console.WriteLine("Документ збережено у старому форматі, збереження в інших форматах є у версії Експерт");
    }
}
class ExpertDocumentWorker : ProDocumentWorker
{
    public override void SaveDocument()
    {
        Console.WriteLine("Документ збережений у новому форматі");
    }
}