//A classe File está no namespace System.IO e é usada para realizar operações de leitura e gravação de arquivos 
//Fornece métodos estáticos para criar, copiar, excluir, mover e abrir arquivos e também fornece métodos para trabalhar com diretórios, como criar, excluir e mover diretórios

/* Métodos
 * 
 * Criação e manipulação de arquivos:
 * - Create: Cria um novo arquivo vazio ou sobrescreve um arquivo existente
 * - Delete: Exclui um arquivo
 * - Exists: Verifica se um arquivo existe
 * - Copy: Copia um arquivo existente para um novo arquivo. Não sobrescreve arquivo de mesmo nome
 * - Move: Move um arquivo para um novo local permitindo fornecer um novo nome
 * 
 * Leitura e escrita de arquivos:
 * 
 * - ReadAllText: Abre o arquivo, lê todo o conteúdo de um arquivo de texto e retona uma string e fecha
 * - ReadAllBytes: Lê todo o conteúdo de um arquivo binário e retorna um array de bytes
 * - WriteAllText: Cria um novo arquivo e grava uma string em um arquivo de texto e fecha o arquivo
 * - WriteAllBytes: Grava um array de bytes em um arquivo binário
 * - AppendAllText: Abre o arquivo, anexa uma string e fecha o arquivo
 */

//deve-se usar a string verbatim para indicar que as barras não são sequências de escape
string caminhoOrigem = @"C:\dados\arquivo1.txt";

//criar arquivo
//File.Create(caminhoOrigem);

File.WriteAllText(caminhoOrigem, "Vinicius Cruz \r\n");

Console.WriteLine($"Última modificação feita em : {File.GetLastWriteTime(caminhoOrigem)}");

Console.ReadKey();