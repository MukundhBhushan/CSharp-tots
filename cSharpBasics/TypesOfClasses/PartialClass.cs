namespace PartialNameSpace
{
    partial class part
    {
        int a;
    }

    partial class part
    {
        int b;
    }
    partial class part
    {
        void print()
        {
            Console.Writeline($"{a},{b}");
        }
    }
}