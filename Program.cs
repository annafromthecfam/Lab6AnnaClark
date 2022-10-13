void StackNoParams()
{
    int a;
    long b;
    float c;
    double d;
    decimal e;
}

void StackWithParams(int a, int b, int c)
{

}

void StackWithHeap(int a, int b, int c, string d)
{
    int f;
    long g;
    int[] h;
}

void StackOver(long a)
{
    StackOver(472874932);
}

StackNoParams();
Console.WriteLine("StackNoParams has executed.");
Console.ReadKey();

StackWithParams(12, 24, 53);
Console.WriteLine("StackWithParams has executed.");
Console.ReadKey();

StackWithHeap(53, 23, 74832, "Pizza");
Console.WriteLine("StackWithHeap has executed.");
Console.ReadKey();

StackOver(2535);