namespace singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DbClass1 db1 = new DbClass1();
            DbClass2 db2 = new DbClass2();
            db1.PrintDbInfo();
            db2.PrintDbInfo();
        }
    }
}