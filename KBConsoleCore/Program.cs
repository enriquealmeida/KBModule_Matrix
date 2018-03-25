using MathNet.Numerics.LinearAlgebra;
using MathNet.Numerics.LinearAlgebra.Factorization;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace KBConsoleCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            Console.WriteLine("Creo matriz " + stopwatch.Elapsed);
            Matrix<Single> processedData = Matrix<Single>.Build.Random(7500, 7500);

            Console.WriteLine("Resuelvo matriz " +  stopwatch.Elapsed);
            Evd<Single> eigen = processedData.Evd();
            Console.WriteLine("Imprimo resultados  " + stopwatch.Elapsed);
            Vector<Complex> eigenvector = eigen.EigenValues;
            Console.WriteLine(eigenvector.ToVectorString());
            stopwatch.Stop();
            Console.WriteLine("Demoro   " + stopwatch.Elapsed);
            Console.ReadKey();

        }
    }
}
