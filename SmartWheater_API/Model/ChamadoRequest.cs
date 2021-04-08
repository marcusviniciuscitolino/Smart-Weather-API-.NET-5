using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartWheater_API.Model
{
    public class ChamadoRequest
	{ 
		//informação do problema(texto)
		public string DescCalled { get; set; }
		// Data de abertura(data)
		public DateTime DateOpen { get; set; }
		// Data de fechamento(data)
		public DateTime DateClosed { get; set; }
		// Nome do agricultor(texto)
		public string NameFarmer { get; set; }
		// Nome do atendente(texto)
		public string NameTec { get; set; }
		// Tamanho da Fazenda(número)
		public double FarmeSize { get; set; }
		// Tipo de problema(lista de opções)
		public int IdProblem { get; set; }
		// Prioridade do chamado(lista de opções)
		public int IdPriority { get; set; }
		// Status do chamado(lista de opções)
		public int StatusCalled { get; set; }
		// SLA do chamado(Farol estilo Salesforce)
		public string Sla { get; set; }
	}
}