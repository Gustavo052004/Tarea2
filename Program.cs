//// See https://aka.ms/new-console-template for more information
////Console.WriteLine("Hello, World!");

////int[] numeros = new int[10];
////for (int i = 0; i < numeros.Length; i++)
////{
////	numeros[i] = (i + 1) * 5;
////	Console.WriteLine(numeros[i]);
////}

//int[] valores = new int[] { 1, 2, 3, 4, 9, 7, 12 };

//for (int i = 0;i < valores.Length;i++)
//{
//	Console.WriteLine(valores[valores.Length - (i + 1)]);
//}

//int suma = 0 ;

//for (int i = 0; i < valores.Length; i++)
//{
//	suma = suma + valores[i];
//}
//Console.WriteLine("Sumatoria: "+ suma);




int n = 5;

int[,] matriz = new int[n, n];
Random random = new Random(); //clase random 

for (int f = 0; f < n; f++)
{
	for (int c = 0; c < n; c++)
	{
		matriz[f, c] = random.Next(1, 101); 
	}
}

Console.WriteLine("Matriz:");
Console.WriteLine("");

//mostrar matriz 
for (int f = 0; f < n; f++)
{
	for (int c = 0; c < n; c++)
	{
		Console.Write(matriz[f, c] + "\t");
	}
	Console.WriteLine();
}




Console.WriteLine("");
//	esquinas superior izquierda matriz[0, 0]

// esquinas superior derecha matriz[0, n - 1]

//esquinas inferior izquierda matriz[n - 1, 0]

//esquinas superior derecha matriz[n - 1, n - 1]

int sumaEsquinas = matriz[0, 0] + matriz[0, n - 1] + matriz[n - 1, 0] + matriz[n - 1, n - 1];
Console.WriteLine("\nSuma de las esquinas: " + sumaEsquinas);


int sumadiagonalizq = 0;
int sumadiagonalder = 0;

for (int i = 0; i < n; i++)
{
	sumadiagonalizq += matriz[i, i];
	sumadiagonalder += matriz[i, ((n-1) - i)];
}

Console.WriteLine("");
Console.WriteLine("Suma diagonal izquierda: "+sumadiagonalizq);

Console.WriteLine("");
Console.WriteLine("Suma diagonal derecha: " + sumadiagonalder);

Console.WriteLine("");
Console.WriteLine("Suma diagonales: " + (sumadiagonalder + sumadiagonalizq));