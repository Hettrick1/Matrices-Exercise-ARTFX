using System.Runtime.InteropServices;

double[,] matrice1 = new double[3, 3];
matrice1[0, 0] = 1;
matrice1[0, 1] = 0;
matrice1[0, 2] = 0;
matrice1[1, 0] = 0;
matrice1[1, 1] = 1;
matrice1[1, 2] = 0;
matrice1[2, 0] = 0;
matrice1[2, 1] = 0;
matrice1[2, 2] = 1;

double[,] matrice2 = new double[3, 3];
matrice2[0, 0] = 1;
matrice2[0, 1] = 0;
matrice2[0, 2] = 0;
matrice2[1, 0] = 0;
matrice2[1, 1] = 1;
matrice2[1, 2] = 0;
matrice2[2, 0] = 0;
matrice2[2, 1] = 0;
matrice2[2, 2] = 1;

Console.Write("matrice 1 : \n\n");

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(matrice1[j, i] + "\t");
    }
    Console.Write('\n');
}

Console.Write("\nmatrice 1 set : \n\n");

double[] vector = new double[3];

vector[0] = 5;
vector[1] = 1;
vector[2] = 3;

matrice1[0, 0] = 5;
matrice1[0, 1] = 7;
matrice1[0, 2] = 9;
matrice1[1, 0] = 1;
matrice1[1, 1] = 3;
matrice1[1, 2] = 12;
matrice1[2, 0] = 1;
matrice1[2, 1] = 5;
matrice1[2, 2] = 9;

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(matrice1[j, i] + "\t");
    }
    Console.Write('\n');
}

Console.Write("\nmatrice 1 * vector 1 : \n\n");

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        double multiple = matrice1[j, i] * vector[j];
        Console.Write(multiple + "\t");
    }
    Console.Write('\n');
}

matrice2[0, 0] = 15;
matrice2[0, 1] = 9;
matrice2[0, 2] = 11;
matrice2[1, 0] = 8;
matrice2[1, 1] = 3;
matrice2[1, 2] = 2;
matrice2[2, 0] = 14;
matrice2[2, 1] = 7;
matrice2[2, 2] = 1;

Console.Write("\nmatrice 2 : \n\n");

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(matrice2[j, i] + "\t");
    }
    Console.Write('\n');
}

Console.Write("\nmatrice 1 * matrice 2 : \n\n");

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        double multiple = matrice1[j, i] * matrice2[i, j];
        Console.Write(multiple + "\t");
    }
    Console.Write('\n');
}