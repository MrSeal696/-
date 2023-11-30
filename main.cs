using System;

class IndexerExample
{
    private double[] data = { 1.1, 2.2, 3.3, 4.4, 5.5 };
    public double this[int index]
    {
        get
        {
            if (index >= 0 && index < data.Length)
                return data[index];
            else
                throw new IndexOutOfRangeException("Index is out of range");
        }
        set
        {
            if (index >= 0 && index < data.Length)
                data[index] = value;
            else
                throw new IndexOutOfRangeException("Index is out of range");
        }
    }

    public double this[double index]
    {
        get
        {
            int roundedIndex = (int)Math.Round(index);
            return this[roundedIndex];
        }
    }

    static void Main()
    {
        IndexerExample example = new IndexerExample();

        Console.WriteLine(example[2]);

        Console.WriteLine(example[4.51]);

        example[1] = 99.9;
        Console.WriteLine(example[1]); 
    }
}
