//Coleções não genéricas estão presentes no namespace System.Collections e armazenam os elementos em arrays de objetos permitem arrays de objetos 
//permitindo que eles contenham qualquer tipo de dados

//São elas: ArrayList, HashTable, SortedList, Stack, Queue
//Realixam boxing ao incluir elementos e unboxing ao remover e são mais sucetíveis a exceções em tempo de exdcução

//Coleções genéricas foram introduzidas na versão 2.0 do C# e estão presentes no namespace System.Collections.Generic sendo coleções fortemente tipadas
//São elas: Dictionary<TKey, TValue>, SortedDictionary<TKey, TValue>, SortedList<TKey, TValue>, LinkedList<T>, HashSet<T>, SortedSet<T>, Stack<T>, Queue<T>,
//List<T>

//Não realizam boxing e unboxing gerando um melhor desempenho, o recomendável é utilizar coleções genéricas
//ArrayList -> Use List<T>
//HashTable -> Use Dictionary<TKey, TValue>
//Queue -> Use Queue<T>
//SortedList -> Use SortedList<T>
//Stack -> Stack<T>