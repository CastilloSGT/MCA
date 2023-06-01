internal class Program
{
    private static void Main(string[] args)
    {
        Teste();
    }
    public static void imprm(string[] arrays){
        for (int i = 0; i < arrays.Length; i++)
        {
            Console.WriteLine(arrays[i]);
        }        
    }
    public static void Teste(){
        string strCollections1 = "testes sobre collections1";
        string strCollections2 = "testes sobre collections2";
        string strCollections3 = "testes sobre collections3";
            
        /*Já tem conhecimento do q vai armazenar
        string [] arraysStr = new String[]{
            strCollections1,
            strCollections2,
            strCollections3

        };*/

        string[] arraysStr = new string [3];

        arraysStr[0] = strCollections1;
        arraysStr[1] = strCollections2;
        arraysStr[2] = strCollections3;
        //Console.WriteLine(arraysStr);

        /*foreach (var temp in arraysStr)
        {
            Console.WriteLine(temp);
        }
        Console.WriteLine(arraysStr[0]);
        Console.WriteLine(arraysStr[arraysStr.Length - 1]);
        Console.WriteLine("testes sobre collections1: " +  Array.IndexOf(arraysStr, strCollections1));
        Console.WriteLine(Array.LastIndexOf(arraysStr, strCollections2));
        
        Array.Reverse(arraysStr); 
        imprm(arraysStr);

        Array.Reverse(arraysStr); 
        imprm(arraysStr);

        Array.Resize(ref arraysStr, 2);
        imprm(arraysStr);

        Array.Resize(ref arraysStr, 3);
        imprm(arraysStr);

        

        arraysStr[arraysStr.Length - 1] = "Conclusão";
        imprm(arraysStr);
        arraysStr[1] = "Conclusão";
        Array.Sort(arraysStr);
        imprm(arraysStr);
        //imprm(arraysStr);
        string[] copia = new string[2];
        Array.Copy(arraysStr, 0, copia, 0, 2);
        imprm(copia);
        decimal[] copia = new decimal[2];
        Array.Copy(saldosPorDiaDoMes, saldosPorDiaDoMes.Length - 2, copia, 0, 2);*/
        string[] clone = (string[])arraysStr.Clone();
        //imprm(clone);

        Array.Clear(clone, 0, 2); // 0 = a partir de qual element, 2 quantos indices vão ser apagados
        imprm(clone);

        /*
        Declarando um array
        A sintaxe de um array em C#
            Declarando e inicializando um array
            Inicializando um array vazio com uma dimensão
        Imprimindo elementos de um array
        Índices
        Procurando índices de um elemento
            Encontrando a primeira ocorrência
            Encontrando a última ocorrência
        Revertendo arrays
        Redimensionando arrays
        Acessando elementos pelo índices
        Ordenando arrays
        Copiando arrays
        Clonando arrays
        Limpando elementos de um array
        */
    }
}