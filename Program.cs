namespace task2;
/*
 *Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
 * Потрібно:
 * Створити клас AbstractHandler. У тілі класу створити методи void Open(), void Create(),
 * void Change(), void Save(). Створити похідні класи XMLHandler, TXTHandler, DOCHandler
 * від базового класу AbstractHandler. Написати програму, яка виконуватиме визначення
 * документа і для кожного формату мають бути методи відкриття, створення, редагування,
 * збереження певного формату документа.
 */
class Program
{
    static void Main(string[] args)
    {
        AbstractHandler docHandler = new DOCHandler("File DOC");
        AbstractHandler txtHandler = new TXTHandler("File TXT");
        AbstractHandler xmlHandler = new XMLHandler("File XML");
        
        
    }
}