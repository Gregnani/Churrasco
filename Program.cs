int criaQueBebe;
int criaNutella;
int miniCria;
int crias;
int Rapaziada;
//insumos
double carnes;
double acompanhamentos;
double cerveja;
double refrigerante;
double agua;


Console.WriteLine("---Churrascada com os cria---");
//quem vai 
Console.Write("Crias que bebem :");
criaQueBebe = Convert.ToInt32(Console.ReadLine());

Console.Write("Crias Nutella:");
criaNutella = Convert.ToInt32(Console.ReadLine());

Console.Write("miniCrias:");
miniCria = Convert.ToInt32(Console.ReadLine());

//soma de quem vai 
crias = criaQueBebe + criaNutella;
Rapaziada = crias + miniCria;

carnes = 0.5 * crias + 0.1 * miniCria;
acompanhamentos = 0.2 * Rapaziada;
cerveja = 3 * criaQueBebe;
refrigerante = 0.8 * (criaNutella + miniCria);
agua = 0.5 * Rapaziada;

Console.WriteLine();
//reesultados
Console.WriteLine($"Carnes:{carnes:N1}kg");
Console.WriteLine($"Acompanhamentos:{acompanhamentos:N1}kg");
Console.WriteLine($"Cerveja:{cerveja:N1}L");
Console.WriteLine($"Refrigerante:{refrigerante:N1}L");
Console.WriteLine($"Agua:{agua:N1}L");