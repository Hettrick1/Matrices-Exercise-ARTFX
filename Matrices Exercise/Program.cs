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

matrice2[0, 0] = 15;
matrice2[0, 1] = 9;
matrice2[0, 2] = 11;
matrice2[1, 0] = 8;
matrice2[1, 1] = 3;
matrice2[1, 2] = 2;
matrice2[2, 0] = 14;
matrice2[2, 1] = 7;
matrice2[2, 2] = 1;

Console.Write("\n matrice 1 set : \n\n");

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(matrice1[j, i] + "\t");
    }
    Console.Write('\n');
}

Console.Write("\n matrice 2 set : \n\n");

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(matrice2[j, i] + "\t");
    }
    Console.Write('\n');
}

PrintMatrice(MatriceTimeVector(matrice1, vector));
PrintMatrice(MatriceTimeMatrice(matrice1, matrice2));
PrintMatrice(MatriceTranspose(matrice1));

void PrintMatrice(double[,] matrice)
{
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            Console.Write(matrice[j, i] + "\t");
        }
        Console.Write('\n');
    }
}

double[,] MatriceTimeVector(double[,] matrice, double[] vector)
{
    double[,] matriceTemp = new double[3,3];
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            matriceTemp[j,i] = matrice[j, i] * vector[j];
        }
        Console.Write('\n');
    }
    return matriceTemp;
}

double[,] MatriceTimeMatrice(double[,] matrice, double[,] matrice2)
{
    double[,] matriceTemp = new double[3, 3];
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            matriceTemp[j, i] = matrice[j, i] * matrice2[i, j];
        }
        Console.Write('\n');
    }
    return matriceTemp;
}

double[,] MatriceTranspose(double[,] matrice)
{
    double[,] matriceTemp = new double[3, 3];
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 3; j++)
        {
            matriceTemp[i, j] = matrice1[j, i];
        }
        Console.Write('\n');
    }
    return matriceTemp;
}
