using System;

public class Keys
{
    public static string ProKey { get; } = "Pro";
    public static string ExpKey { get; } = "Exp";
}

class DocumentWorker
{
    public virtual void OpenDocument()
    {
        Console.WriteLine("Документ открыт");
    }

    public virtual void EditDocument()
    {
        Console.WriteLine("Доступно редактирование документа в Pro версии ");
    }

    public virtual void SaveDocument()
    {
        Console.WriteLine("Доступно сохранение документа в Pro версии");
    }
}

class ProDocumentWorker : DocumentWorker
{
    public override void EditDocument()
    {
        Console.WriteLine("Документ был отредактирован");
    }

    public override void SaveDocument()
    {
        Console.WriteLine("Документ сохранен в старом формате, сохранение в других форматах доступно в экспертной версии");
    }
}

class ExpertDocumentWorker : ProDocumentWorker
{
    public override void SaveDocument()
    {
        Console.WriteLine("Документ сохранен в новом формате");
    }
}

class lab_02_3
{
    static void Main()
    {
        bool enterKey = false; 

        Console.WriteLine("Вы хотите ввести ключ? (yes/no):");
        string choice = Console.ReadLine();

        if (choice.ToLower() == "yes")
        {
            enterKey = true;
        }

        DocumentWorker docWorker;

        if (enterKey)
        {
            do
            {
                Console.WriteLine("Введите ключ (pro/exp):");
                string key = Console.ReadLine();

                if (key == Keys.ProKey)
                {
                    docWorker = new ProDocumentWorker();
                }
                else if (key == Keys.ExpKey)
                {
                    docWorker = new ExpertDocumentWorker();
                }
                else
                {
                    Console.WriteLine("Недопустимый ключ. Пожалуйста, попробуйте снова.");
                    docWorker = null;
                }
            } while (docWorker == null);
        }
        else
        {
            docWorker = new DocumentWorker();
        }

        docWorker.OpenDocument();
        docWorker.EditDocument();
        docWorker.SaveDocument();
    }
}