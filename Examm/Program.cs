using System;


public class Program
{
    public static void Main()
    {
        Matrix matrix = new Matrix(3, 4);


        matrix[0, 0] = -1; matrix[0, 1] = 2; matrix[0, 2] = -3; matrix[0, 3] = 4;
        matrix[1, 0] = 5; matrix[1, 1] = -6; matrix[1, 2] = -7; matrix[1, 3] = 8;
        matrix[2, 0] = -9; matrix[2, 1] = 10; matrix[2, 2] = -11; matrix[2, 3] = 12;

        Console.WriteLine("Сума вiд’ємних елементiв непарних стовпцiв: " + matrix.Sum());
    }
}

public class Matrix
{
    private int[,] array;
    private int rows;
    private int cols;


    public Matrix(int rows, int cols)
    {
        this.rows = rows;
        this.cols = cols;
        array = new int[rows, cols];
    }


    public int Rows
    {
        get { return rows; }
    }

    public int Columns
    {
        get { return cols; }
    }


    public int this[int row, int col]
    {
        get
        {
            if (row >= 0 && row < rows && col >= 0 && col < cols)
            {
                return array[row, col];
            }
            else
            {
                throw new IndexOutOfRangeException("Індекс поза межами масиву.");
            }
        }
        set
        {
            if (row >= 0 && row < rows && col >= 0 && col < cols)
            {
                array[row, col] = value;
            }
            else
            {
                throw new IndexOutOfRangeException("Індекс поза межами масиву.");
            }
        }
    }


    public int Sum()
    {
        int sum = 0;
        for (int j = 1; j < cols; j += 2)
        {
            for (int i = 0; i < rows; i++)
            {
                if (array[i, j] < 0)
                {
                    sum += array[i, j];
                }
            }
        }
        return sum;
    }
}
