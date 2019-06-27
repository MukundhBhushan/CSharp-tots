using System;

namespace cSharpBasic
{
    class Indexer
    {
       string[] names = new string[5];
       public string this[int i] 
       {
            get
            {
                return names[i];
            } 
            set 
            {
                names[i]=value;
            }
        } 
    }
    class baseClass
    {
       static void Main(string[] args)
        {
            Indexer objIndex = new Indexer();
            objIndex[0] = "Tim";
            objIndex[1] = "Jill";

            for(int i = 0; i<2; i++)
            {
                System.Console.WriteLine(objIndex[i]);
            } 
        } 
    }
}