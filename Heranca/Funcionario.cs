using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca;

internal class Funcionario : Pessoa //Funcionario herda de Pessoa
 {
    public string? Empresa {  get; set; }   
    public decimal Salario { get; set; }
 }

