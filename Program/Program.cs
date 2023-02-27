string[] MakeMeArray(int x){
    string[] arr = new string[x];
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"Введите {i+1} элемент массива: ");
        arr[i] = Console.ReadLine();
    }
    return arr;
};
string[] Sort(string[] col){
    int size = 0;
    string[] arr_sort;
    int[] counter = new int[col.Length];
    for (int i = 0; i < col.Length; i++)
    {
        if(col[i].Length<=3){
            counter[size++] = i;
        }
    }
    arr_sort = new string[size];    
    for (int i = 0; i < arr_sort.Length; i++)
    {
        arr_sort[i] = col[counter[i]];
    }
        return arr_sort;  
}

System.Console.Write("Введите длину массива: ");
int lng = int.Parse(Console.ReadLine());
string[] array_first = MakeMeArray(lng);
string[] array_final = Sort(array_first);
System.Console.WriteLine($"[{string.Join(",", array_first)}] => [{string.Join(",", array_final)}]");